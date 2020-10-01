using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string stri = "false";
                bool b = Convert.ToBoolean(stri);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("The string could not be converted to boolean");
            }

        }
    }
}
