using System;
using System.Collections.Generic;
using System.Text;

namespace GraphDemo
{
    class Graph
    {
        private bool[] connections;
        private int size;

        public Graph(int size)
        {
            this.size = size;
            Console.WriteLine(size * (size - 1) / 2);
            connections = new bool[size * (size - 1) / 2];
        }

        public void AddConnection(int A, int B)
        {
            connections[Math.Max(A, B) * (Math.Max(A, B) - 1) / 2 + Math.Min(A, B)] = true;
        }

        public bool GetConnection(int A, int B) => connections[Math.Max(A, B) * (Math.Max(A, B) - 1) / 2 + Math.Min(A, B)];

        public int[] GetAll(int index)
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if (i != index && GetConnection(index, i))
                {
                    ret.Add(i);
                }
            }
            return ret.ToArray();
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", connections));
        }
    }
}
