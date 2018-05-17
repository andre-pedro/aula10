using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<IStuff> g3i = new Guarda3<IStuff>();
            Guarda3<String> g3s = new Guarda3<string>();
            Guarda3<float> g3f = new Guarda3<float>();

            g3i.SetItem(3, new Food(FoodType.Bread, 2, 0.500f));
            g3s.SetItem(2, "hello");
            g3f.SetItem(1, 1.3f);

            /* Console.WriteLine(g3i.GetItem());
             Console.WriteLine(g3s.GetItem(2, "hello"));
             Console.WriteLine(g3f.GetItem(1, 1.3f)); 
            */

            foreach (String s in g3s)
                Console.WriteLine(s);
            foreach (IStuff i in g3i)
                Console.WriteLine(i);
            foreach (float f in g3f)
                Console.WriteLine(f);
        }
    }
}
