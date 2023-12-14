using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a2
{
    class Program
    {
        public static int result(int[] nodes,int len)
        {
            var t = maketree(nodes,len); 
            var tree = t.Item1;
            var root = t.Item2; 
            int[] depth = new int[len]; 
            for(int i = 0; i < len; i++)
                depth[i] = -1; 
            return bfs(len,depth,tree,root); 
        }
        public static int bfs(int n,int[] depth,List<List<int>> tree ,int root)
        {
            int[] stp = new int[n]; 
            if(tree[(int)root].Count == 0)
                return 1;
            Queue<int> q = new Queue<int>(); 
            q.Enqueue(root); 
            depth[root] = 0; 
            stp[root] = 1;
            var current = tree[(int)root]; 
            int node = root; 

            while(q.Count != 0)
            {
                node = q.Dequeue(); 
                int inode = (int) node; 
                current = tree[inode]; 
                foreach(var k in current)
                {
                    if(depth[k] != 0)
                    {
                        q.Enqueue(k); 
                        depth[k] = 0; 
                        stp[k] = stp[node] + 1;
                    }
                }

            }
            return stp[node]; 
        }
        private static Tuple<List<List<int>>,int> maketree (int[] nodes,int n)
        {
            List<List<int>> tree = new List<List<int>>(); 
            int root =0; 
            int i = 0; 
            for(int j = 0; j<n; j++)
                tree.Add(new List<int>()); 

            foreach(var next in nodes)
            {
                if(next == -1)
                    root = i; 
                else
                    tree[(int)next].Add(i);
               i++;
            }
            return new Tuple<List<List<int>>,int>(tree , root);
        }
        static void Main(string[] args)
        {   
            int len=Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] snums= s.Split(' ');
            int[] num = new int[snums.Length-1];
            for(int i=0;i<snums.Length-1;i++)
            {
               num[i]=Convert.ToInt32(snums[i]);
            }
            Console.Write(result(num,len));
        }
    }
}
