# Using
Can use with anything that implements IDisposable.  

Designed so can say hey before your get rid of me I need to clean up this system resources using outside of c#  
Main use cases:
- Databases
- Files
- Network connections

```csharp
public class MyClass : IDisposable{}
```

# Files

## Locating/ Working with
'\' is an escape character. But @"" means ignored
```csharp
Console.WriteLine("Hello World!\nCreates a new line\tTab");
```

```csharp
var files = Directory.GetFiles("C:\\Dev\\temp");
files = Directory.GetFiles(@"C:\Dev\temp");


Directory.GetFiles(path); // Returns a list of FileInfo

Path.Combine(dir, filename);

var file = new FileInfo(path);
if(file.Exists)
{
	file.Delete()
}

// or can use this
File.Exists(path)
```

## Reading
Initially stream reader  
```csharp
StringBuilder sb = new StringBuilder();
using (StreamReader sr = new StreamReader("lastupdate.txt")) 
{
    while (sr.Peek() >= 0) 
    {
        sb.Append(sr.ReadLine());
    }
}
textbox.Text = sb.Tostring();
```

Streams is a pattern. 


Then new File api: simpler. No need to remember to close stream
```csharp
var lines = File.ReadAllLines(_path);
foreach (var line in lines)
{
	// Here I convert into my own class
	yield return MyClass.Parse(line);   // Using  a Parse method as C# way of converting text to object. Could have just done through constructor but constructors throwing exceptions is a bit contraverious. I'm for it (You should not be allowed to create a class in a bad state) but some ppl are against it.
}

```

```
            string[] lines = File.ReadAllLines(path);
            var contacts = new List<Contact>();
            foreach (var line in lines)
            {
                var spilt = line.Split(",");
                var contact = new Contact() {Name = spilt[0], Number = long.Parse(spilt[1])};
                contacts.Add(contact);
            }
```
```contact.cs
    public class Contact
    {
        public string Name { get; set; }
        public long Number { get; set; }
    }
```


## Writing
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file

```csharp

// Example #3: Write only some strings in an array to a file.
// The using statement automatically flushes AND CLOSES the stream and calls
// IDisposable.Dispose on the stream object.
// NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
// encodes the output as text.
using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
{
	foreach (string line in lines)
	{
		// If the line doesn't contain the word 'Second', write the line to the file.
		if (!line.Contains("Second"))
		{
			file.WriteLine(line);
		}
	}
}



// WriteAllLines creates a file, writes a collection of strings to the file,
// and then closes the file.  You do NOT need to call Flush() or Close().
System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);

// use write all text if just one string with line breaks in it


File.AppendAllText(path, text + Environment.NewLine)


```
