using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
		
			{
                #region Task1
                //Task_1   print Valuaes from 1 to 50 included
                Console.WriteLine("Task_1   print Valuaes from 1 to 50 included");
                int i;
                for (i = 1; i <= 50; i++)
                {
                    Console.WriteLine("Value of i is {0}",i);
                }
                Console.WriteLine("2nd_version print Valuaes from 1 to 50 included");
                for (i = 1; i <= 50; i++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
                Console.WriteLine("************************************************");
                #endregion

                #region Task2
                //Task_2 print Valuaes from 50 to 1 included
                Console.WriteLine("Task_2 print Valuaes from 50 to 1 included");
                for (i = 50; i >= 1; i--)
                {
                    Console.WriteLine("Value of i is {0}", i);
                }
                Console.WriteLine("2nd_version print Valuaes from 50 to 1 included");
                for (i = 50; i >= 1; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("**************************************************");
                #endregion

                #region Task3
                //Task_3 Print all even values from 1-50
                Console.WriteLine("Task_3 Print all even values from 1-50");
                for (i = 2; i <= 50; i += 2)
                {
                    Console.WriteLine("Value of i is {0}", i);
                }
                Console.WriteLine("2nd version _Print all even values from 1-50");
                for (i = 1; i <= 50; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Value of all even i is {0}",i);
                    }
                }
                Console.WriteLine("*************************************");
                #endregion

                #region Task_4
                // Task_4 Print all valueus from 50 to 1 devided to 3
                Console.WriteLine("Task_4 Print all valueus from 50 to 1 devided to 3");
                for (i = 48; i >= 1; i -= 3)
                {
                    Console.WriteLine("Value of i divisible to 3 is {0}", i);
                }
                Console.WriteLine("2nd_version Print all valueus from 50 to 1 devided to 3");
                for(i=50; i >=1; i--)
                {
                    if(i%3 == 0)
                    {
                        Console.WriteLine("Value of i divisible to 3 is {0}", i);
                    }
                }
                Console.WriteLine("****************************************");

                #endregion


                #region Task_5
                //Print all values from 50 to 1 devided both to 3 and to 7
                Console.WriteLine("Print all values from 50 to 1 devided both to 3 and to 7");
                for (i = 50; i >= 1; i--)
                {

                    if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.WriteLine("Value of i devided both to 3 and 7 {0}", i);
                    }
                    
                   
                }
                Console.WriteLine("***********************");
                #endregion
               

            }

        }
	}
}
