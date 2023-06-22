using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.DemoDelegates
{
    public delegate void MyDel(int a, int b);

    public delegate bool MyPredicate(int a, int b);

    public class test
    {
        public MyDel myDel;

        public void TrucMuche(int a,int b)
        {
            myDel.Invoke(a, b);
        }
    }
}
