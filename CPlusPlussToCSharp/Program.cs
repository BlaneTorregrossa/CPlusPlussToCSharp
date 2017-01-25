using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPlusPlussToCSharp
{

    //Arrays

    //Arrays 3
    /*
           static void Main(string[] args)
            {

                double[] nums = new double[10];
                for (int i = 10; i > 0; i--)
                {
                    nums[i - 1] = i;
                }

            }

    
        //Arrays7 
        
        static void Main(string[] args)
        {


            int[,] days = new int[29, 5];
            //int tempa[1];
            //int tempb[1];
            int rowCount = 0;
            int colCount = 0;
            int rowSum = 0;
            int colSum = 0;
            //int tempa;
            //int tempb;

            for (int i = 0; i < 29; i++)    // for loop to determine row of array
            {
                for (int j = 0; j < 5; j++) // for loop to determine column of array
                {
                    days[i, j] = rowCount; // places intergers in the array
                    rowSum = days[i, j] + rowSum;
                    rowCount++; // increases numbers by one

                }
            }

            for (int i = 0; i < 5; i++) // for loop to determine row of array
            {
                for (int j = 0; j < 29; j++) // for loop to determine column of array
                {
                    days[i, j] = colCount; // places intergers in the array // Error says Index is out of bounds of the array
                    colSum = days[i, j] + colSum;
                    colCount++; // increases numbers by one

                }
            }



        }



    }

        //Arrays 8
        
        static void Main(string[] args)
        {



            int [] health = { 100, 100, 100, 100, 100 };
            string input;
            int attackCounter = 0;

            //std::cout << "Please select a player to take damage using keys 0 to 4." << std::endl;
            //std::cin >> input;

            for (int i = 0; i < 5;)
            {
                Console.WriteLine("Please select a player to take damage using keys 0 to 4.");
                i++;

                if (input > 4 || input < 0)
                {
                    Console.WriteLine("No Valid Input")
                    i--;
                }

                else if (health[input] <= 0)
                {

                    Console.WriteLine("Input No longer Valid");
                    i--;
                }

                else
                {
                    health[input] = health[input] - 40;
                    attackCounter++;
                    if (health[input] == -20)
                    {
                        health[input] == 0;
                        Console.WriteLine("20 damage was dealt to your target ");
                    }
                    else
                    {
                        Console.WriteLine("40 damage was dealt to your target ");
                    }
                }

                if (attackCounter == 5)
                {
                    Console.WriteLine("Player HP is: ")(health[0])(" HP");
                    Console.WriteLine("Player HP is: ")(health[2])(" HP");
                    Console.WriteLine("Player HP is: ")(health[3])(" HP");
                    Console.WriteLine("Player HP is: ")(health[4])(" HP");
                    Console.WriteLine("Player HP is: ")(health[5])(" HP");
                }

            }


            return 0;
        }



    */



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




    class Program
    {

        static void Main(string[] args)
        {

        }


    }
}

