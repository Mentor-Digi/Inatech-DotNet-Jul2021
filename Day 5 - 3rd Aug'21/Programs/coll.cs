using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class coll
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add("Mango");
            al.Add(45);
            al.Add("Banana");
            al.Add(new object());
            foreach (var i in al)
                Console.WriteLine(i);
            Console.WriteLine("*************************");
            ArrayList list = new ArrayList();
            list.Add("Apple");
            list.Add("Orange");
            list.Add("Grapes");
            al.AddRange(list);
            al.Insert(1, "Strawberry");
            Console.WriteLine(al.Contains(45));
            al.Remove(45);
            al.Add("Mango");
            foreach (var i in al)
                Console.WriteLine(i);
            Console.WriteLine("******************");
            Hashtable ht = new Hashtable();
            ht.Add("k1", "Kiran");
            ht.Add("k2", "Gayathri");
            ht.Add("k3", "Rinku");
            ht.Add("k4", "Sowmya");
            ht.Add("k5", "Hema");
            ht.Add("k6", "Sakthi");
            foreach(var v in ht.Keys)
            Console.WriteLine(v.ToString());

            //for (int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht.Keys + " " + ht.Values);
            //}

            SortedList slist = new SortedList();
            slist.Add(1, "ONe");
            slist.Add(2, "Two");
            slist.Add(3, "Three");
            slist.Add(4, "Four");
            foreach (var v in slist.GetValueList())
                Console.WriteLine(v);

            Queue q = new Queue();
            q.Enqueue("Jamun");
            q.Enqueue("Rasgulla");
            q.Enqueue("Rasmalai");
            q.Enqueue("Mysorepaa");
            Console.WriteLine(q.Dequeue());
            Console.ReadLine();
        }
    }
}
