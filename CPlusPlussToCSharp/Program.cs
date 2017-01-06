using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPlusPlussToCSharp
{

    //Loops
    /*
     Loops 1
              for (int i = 100; i >= 0; i--)
              {
                  Console.WriteLine(i);
              } 

              for (int i = 99; i >= 0; i--)
              {
                  Console.WriteLine(i);
              }

              for (int i = 100; i >= 1; i--)
              {
                  Console.WriteLine(i);
              }

             for (int i = 101; i >= 0; i--)
             {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
             }

        Loops 2
        
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                int temp = i;
                if (i % 5 == 0 && i % 3 == 0)
                {
                    i = temp;
                    Console.WriteLine(i);
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    i = temp;
                    Console.WriteLine(i);
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    i = temp;
                    Console.WriteLine(i);
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        

     Loops 2 (Except it is in a list)

         class Program
    {
        static void Main(string[] args)
        {

            List<string> FizzBuzz = new List<string>();
            for (int i = 0; i < 100; i++)
            {               
                if (i % 5 == 0 && i % 3 == 0)   // FizzBuzz
                {            
                    FizzBuzz.Add("FizzBuzz");
                }
                else if (i % 3 == 0)                 // Buzz
                {               
                    FizzBuzz.Add("Fizz");
                }
                else if (i % 5 == 0)                 // Fizz
                {
                    FizzBuzz.Add("Buzz");
                }
                else                            // Just numbers
                {
                    FizzBuzz.Add(i.ToString());
                }
            }

            foreach(string i in FizzBuzz)
            {
                Console.WriteLine(i);
            }
        }


    }


        Loops 3

            static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                    
                }
            }
            Console.WriteLine(sum);
        }

        Loops 4

        static void Main(string[] args)
        {
            int i = 100

            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }


        static void Main(string[] args)
        {

            int i = 99;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }


          static void Main(string[] args)
        {

            int i = 100;
            while (i >= 1)
            {
                Console.WriteLine(i);
            }

        }


          static void Main(string[] args)
        {
            int i = 101;
            while (i >= 0)
            {
                i--;
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }


           static void Main(string[] args)
        {
            int i = 0;
            while (i <= 100 )
            {
                i++;
                if (i % 5 == 0 && i % 3 == 0)
                {                   
                    Console.WriteLine(i);
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {                
                    Console.WriteLine(i);
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


        }


               static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            while (i < 1000)
            {
                i++;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;

                }
            }
            Console.WriteLine(sum);
        }

    */

    //Functions
    /*
     Functions 1

            {
                int the_variablea = 1;
                Console.WriteLine(the_variablea);
                {
                    Console.WriteLine(the_variablea);
                    int the_variableb = 2;
                    Console.WriteLine(the_variableb);
                    {
                        Console.WriteLine(the_variableb);
                        int the_variablec = 3;
                        Console.WriteLine(the_variablec);
                    }
                    Console.WriteLine(the_variableb);
                }
                Console.WriteLine(the_variablea);
            }

         */

    class Player
    {
        public Player() { }

        private int m_health = 50;
        private string m_name;
        private int m_attack;

        public int Health
        {

            get { return m_health; }
            set { value = m_health; }

        }

        public string Name
        {

            get { return m_name; }
            set { value = m_name; }

        }

        public int Attack
        {

            get { return m_attack; }
            set { value = m_attack; }

        }
    }



    class Program
    {

        static void Main(string[] args)
        {



        }



    }
}

