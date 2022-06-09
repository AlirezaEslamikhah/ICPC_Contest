using System;
using System.Collections.Generic;

namespace icpc
{
    class Program
    {
        public class vertex
        {
            public bool is_cat;
            public int[] conncected = new int[100];
            int i = 0;
            public void add(int number)
            {
                conncected[i]=number;
                i++;
            }
            
            public vertex(int b)
            {
                conncected[i] = b;
                i++;
            }
            public vertex()
            {
}
            public void dfs()
            {
                
            }
        }
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string[] b = first.Split(" ");
            int[] b1 = new int[2];
            for (int i = 0; i < b.Length; i++)
            {
                b1[i]=int.Parse(b[i]);
            }
            int vertices = b1[0];
            int maximum = b1[1]+1;
            string second = Console.ReadLine();
            string [] c = second.Split(" ");
            vertex[] vertix  = new vertex[c.Length];
            
            for (int i = 0; i < c.Length; i++)
            {
                vertex w = new vertex();
                if (c[i] == "1")
                {
                    w.is_cat = true;
                }
                if (c[i] == "0")
                {
                    w.is_cat = false;
                }
                vertix[i] = w;
            }
            for (int i = 0; i < vertices; i++)
            {
                string r = Console.ReadLine();
                string[] v = r.Split(" ");
                int[] vnew = new int[2];
                for (int h = 0; h < v.Length; h++)
                {
                    vnew [h] = int.Parse(v[h]);
                }
                for (int j = 0; j < v.Length; j++)
                {
                    int n = vnew[j];
                    vertix[n].add(vnew[j+1]);
                }
            }
            for (int i = 0; i < vertices; i++)
            {
                vertix[i].dfs();
            }


        }
    }
}
