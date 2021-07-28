using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjthirdapplication
{
    //Generic 
    class Sample<T>
    {
        T Name;
        T City;
        internal Sample(T Name,T City)
        {
            this.Name = Name;
            this.City = City;

        }
        //Normal Method
        internal void Add(int x,int y)
        {
            Console.WriteLine("addition is:{0}",(x+y));
        }
        //Generic method
        //<T>
        internal void Swap<T>(T x,T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("x is {0} || Y is {1}",x,y);

        }
    }/*Generic Consrtaint
      * where T: struct  //value type
      * where T:class // reference type
      * where T:new //default parameter constarint
      * where T:<interface name
      * */
    class Student<T> where T: struct
    {

    }
    class Generic_methods
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("Anu","chennai");
            sample.Swap<int>(6, 8);
            sample.Swap<string>("good", "morning");

            //Struct Constarint
            //error because student class will accept only struct value(Value type)
            //Student<string> student =new Student<string>();

            Student<int> student1 = new Student<int>();
        }
    }
}
