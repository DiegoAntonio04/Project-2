using System;

class Program
{
    static void Main(string [] args)
        { for (int i= 1; i <= 100; i++)
           {
            if(i%3==0 && i%5==0)
            {
                System.Console.WriteLine("Hello Goodbye");
            }
            else if(i%5==0)
            {
                System.Console.WriteLine("Goodbye");
            }
            else if (i%3==0)
            {
                System.Console.WriteLine("Hello");
            }
            else
            {
                System.Console.WriteLine(i);
            }
           }
        }
    
    

}

