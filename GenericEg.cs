using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjthirdapplication
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        internal Person(int id,string name,string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }

    }
    class GenericEg
    {
        static void Listeg()
        {           //typesafe
            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");

            fruits.Insert(1,"Pineapple");
            fruits.RemoveAt(3);
            //fruits.Add(10);--error because it is typesafe

            List<string> Vegetables = new List<string>();
            Vegetables.Add("Carrot");
            Vegetables.Add("Beetroot");
            Vegetables.Add("Tamoto");
            Vegetables.AddRange(fruits);//adding one list into another

            foreach (var list in fruits)
            {
                Console.WriteLine("Fruits{0}", list);

            }
            Console.WriteLine("Vegetables");
            foreach (var list in Vegetables)
            {
                Console.WriteLine("Vegetables:{0}", list);

            }

        }
        //Key value pair
        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "JAVA");
            dt.Add(2, "NETWORKS");
            dt.Add(3, "AI");
            foreach(KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key+""+kp.Value);
            }
        }
        static void StackEg()
        {
            //push,pop,peek,contains,clear methods
            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(10);
            st.Push(50);
            foreach(var stack in st)
            {
                Console.WriteLine(stack);//output:50,10,30,40
            }
            st.Pop();
            Console.WriteLine("After 1 pop");
            foreach (var stack in st)
            {
                Console.WriteLine(stack);
            }
            Console.WriteLine("peek:{0}",st.Peek());
        }
        static void QueueEg()
        {
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(10);
            qu.Enqueue(20);
            qu.Enqueue(30);
            qu.Enqueue(30);
            qu.Enqueue(30);
            foreach (var queue in qu)
            {
                Console.WriteLine(queue);
            }
            qu.Dequeue();
            Console.WriteLine("-----");
            foreach (var queue in qu)
            {
                Console.WriteLine(queue);
            }
            Console.WriteLine(qu.Count()); ;
            Console.WriteLine("-----");
            
        }
        static void Sortedlist()
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(3, "Three");
            sl.Add(1, "One");
            sl.Add(2, "Two");
            sl.Add(4, null);
            sl.Add(10, "Ten");
            sl.Add(5, "Five");
            foreach (KeyValuePair<int, string> kp in sl)
                Console.WriteLine("key: {0}, value: {1}", kp.Key, kp.Value);
        }
        static void Main()
        {
            Listeg();
            Console.WriteLine("Person Details");
            Console.WriteLine("------------");
            List<Person> person = new List<Person>();
            person.Add(new Person(1, "Sai", "Pune"));
            person.Add(new Person(2, "Ram", "Mumbai"));
            person.Add(new Person(3, "Geetha", "Hyderabad"));
            foreach(Person p in person)
            {
                Console.WriteLine("ID:{0} || Name:{1} || city:{2})",p.id,p.name,p.city);
            }
            DictionaryEg();
            StackEg();
            QueueEg();
            Sortedlist();
        }
    }
}
