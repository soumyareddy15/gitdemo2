using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjthirdapplication
{
    //custom or user defined Exception
    public class AgeNotvalid : ApplicationException
    {
        public AgeNotvalid(string Message):base(Message)
        {

        }
    }

    class Exceptional_Handling
    {
        static void Main()
        {
            try {
                /*int num = 10, div = 0;
                if(div==0)
                {
                    throw new DivideByZeroException();
                    //or
                    //throw new Exception();
                }
                else
                {
                    num = num / div;
                }
                num = num / div;
                Console.WriteLine(num);
                int[] arr = new int[] { 20, 30, 40, 50 };
                //Console.WriteLine((arr[6]));
                */

                Console.WriteLine("enter the age");
                int age = Convert.ToInt32(Console.ReadLine());
                if(age<18)
                {
                    throw new AgeNotvalid("TO VOTE AGE SHOULD BE ABOVE 18");
                }
                else
                {
                    Console.WriteLine("eligible to vote");
                }
            }
            /*catch (Exception e)//handles all the exception
            {
                Console.WriteLine("eroorrrr");
                Console.WriteLine(e);
            }--error because first child then parent
            */
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e);--it gives error in whichline number
                //Console.WriteLine(e.Message);--OperatingSystem:Attempted to divide by zero.
                //Console.WriteLine(e.Source);--Prjthirdapplication
                Console.WriteLine("please enter the valid number");
            }
            
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)//handles all the exception
            {
                Console.WriteLine("eroorrrr");
                Console.WriteLine(e);
            }

            //finallly is excecuted only when the exception is handled ,without catch finally is not executed
            finally
            {
                Console.WriteLine("hope you are doing good");
            }
        }
    }
}
