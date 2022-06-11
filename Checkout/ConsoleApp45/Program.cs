namespace CheckOut
{
    class Program
    {

        static void Main(string[] args)
        {
            var checkout = new CheckoutV1();
            var result = checkout.Calc("ABCABCABCABC");
        }


    }
}
