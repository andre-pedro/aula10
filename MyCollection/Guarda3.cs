using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    public class Guarda3<T>
    {
        private T v1, v2, v3;
    }
    public Guarda3()
    {
        v1 = default(T);
        v2 = default(T);
        v3 = default(T);
    }
    public T GetItem(int i)
    {
        switch (i)
        {
            case 1: return v1;
            case 2: return v2;
            case 3: return v3;
                default; return default(T); 
        }
    }

}
