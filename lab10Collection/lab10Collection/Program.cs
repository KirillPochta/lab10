using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            forniture obj4 = new forniture("Hello","Modern",2001);
            ArrayList second = new ArrayList();
            second.Add(1);
            second.Add(1.2124);
            second.Add("string");
            second.Add("s");
            second.Add(obj4.ToString());
            for(int i = 0; i < second.Count; i++)
            {
                Console.WriteLine(second[i]);
            }

            second.Remove(0);
            second.Remove(1);
       
            HashSet<object> boss = new HashSet<object>(3);

            for(int i=0;i< second.Count; i++)
            {
                boss.Add(second[i]);
            }
            if (boss.Contains("string") || boss.Contains("s") || boss.Contains(1.2124)) Console.WriteLine($"boss include elemets of ArralyList second");

            foreach (var item in boss)
            {
                Console.WriteLine(item);

            }

            ObservableCollection<forniture> LastTask = new ObservableCollection<forniture>();

            static void SomeThingDidWrong(object convert, NotifyCollectionChangedEventArgs e)
            {
                Console.WriteLine("I hope it's works");
            }

            LastTask.CollectionChanged += SomeThingDidWrong;


            forniture obj5 = new forniture("Iam","Petr",2000);
            forniture obj6 = new forniture("So","Vasya",2001);
            forniture obj7 = new forniture("Tired","Vitya",2002);
            LastTask.Add(obj5);
            LastTask.Add(obj6);
            LastTask.Add(obj7);
            LastTask.Remove(obj5);

            foreach(forniture item in LastTask)
            {
                Console.WriteLine(item);
            }

        }
    }
}
