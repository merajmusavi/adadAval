using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");

            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int second = int.Parse(Console.ReadLine());

            
            for(int i=first+1; i<second;i++){
      
                bool isPrime = true;
               for(int x = 2; x<=i/2; x++){
                if(i%x==0){
                  isPrime = false;
                  break;
                }
               }
               if (isPrime)
                Console.WriteLine(i);

            
            }


          
        }
    }
}