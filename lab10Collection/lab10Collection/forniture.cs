using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab10Collection
{
    class forniture:IList<object>
    {
        public string name;
        public string style;
        public int YearOfSales;

        public forniture(string name,string style, int YearOfSales)
        {
            this.name = name;
            this.style = style;
            this.YearOfSales = YearOfSales;

        }
        void Sent()
        {
            Console.WriteLine("Fornitures was sent");
        }
        void Accept()
        {
            Console.WriteLine("Fornitrue was accepted");
        }

        public void Repair()
        {
            Console.WriteLine("Forniture was repaired");
        }

        public void Build()
        {
            Console.WriteLine("Fornitrue was builded");
        }

        public void Execute()
        {
            Console.WriteLine("Fornitrue was executed");
        }

       

        static forniture obj1 = new forniture("Monty", "Modern", 2002);
        static forniture obj2 = new forniture("Carlo", "Post-Modern", 2004);
        static forniture obj3 = new forniture("MonteBooba", "abstract", 2006);

        public List<forniture> ForWork = new List<forniture> { obj1, obj2, obj3 };
        //public ArrayList ForWork = new ArrayList();

        public override string ToString()
        {
            return $"Naame {this.name=name} Style {this.style=style} YearOfSales {this.YearOfSales=YearOfSales}";
        }
        public void CountOfList(int i)
        {
            Console.WriteLine(ForWork[i]);
        }

        public void Add(forniture[] item)
        {
            foreach (var i in item)
            {
                if (!ForWork.Contains(i))
                {
                    ForWork.Add(i);
                }
            }
        }

        public void Check()
        {
            foreach (object i in this.ForWork)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void Remove(forniture item)
        {
            ForWork.Remove(item);
        }
        public void IndexDel(int index)
        {
            ForWork.RemoveAt(index);
        }
        public string SearchElement(forniture obj)
        {
            return obj.ToString();
        }
        public string SearchIdElement(int id)
        {
            return ForWork[id].ToString();
        }
    }
}
