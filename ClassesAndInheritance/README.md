# Classes and Inheritence

## Starting a Solution and Project(s)

1. Open Visual Studio, create new project option on the right hand side
2. Fill in details however you want. It doesn't matter too much for this kind of task but we are using NET 3.1
3. You now have a solution with a new project.

## Establishing Fundamental C#/Coding

- Using the keyword 'var' can only be used if you initialise the variable AND declare it in a method like so:
```
public void Method() {
	var newVariable = ""; // same as string newVariable
	var newVariable2 = 5; // same as int newVariable2
}
```
- Something I did not go over in the lesson is the 'void' keyword used on methods. This keyword indicates that the method does not return anything.
```
public void VoidMethod() {
	var sum = 1 + 2;
	// end of method
}
```
- If you do want to return something you can instead replace keyword 'void' with a datatype. Note that methods with a datatype MUST return something:
```
public String GetName() {
	var name = "Name here";
	return name; // HAS TO RETURN SOMETHING
}
```
```
// somewhere in Program.cs main(){}
	string newName = object.GetName(); // will now be 'Name here'
```

## Classes and Objects

- Classes are 'templates' for objects
- Objects are instances of classes
- You can instantiate an object of a class usingthe following line:
```
ClassName objectName = new ClassName();
```

## Inheritance

- Passing down almost everything of a parent class down to another child class
- Children classes can use inherited variables and methods.
- Can replace methods or variables using the keywords 'virtual' on the parent method and 'override' on the child method:
```
public virtual void ParentMethod() {}
public override void ChildMethod() {}
```