using System;

namespace GraphDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(5);

            graph.AddConnection(0, 1);
            graph.AddConnection(0, 2);
            graph.AddConnection(0, 3);
            graph.AddConnection(1, 3);
            graph.AddConnection(1, 4);
            graph.AddConnection(2, 3);
            graph.AddConnection(3, 4);

            graph.Print();

            string str;
            while ((str = Console.ReadLine()).ToLower() != "exit")
            {
                string[] strs = str.Split(' ');
                switch (strs[0].ToLower())
                {
                    case "set":
                        graph.AddConnection(int.Parse(strs[1]), int.Parse(strs[2]));
                        break;
                    case "get":
                        Console.WriteLine(graph.GetConnection(int.Parse(strs[1]), int.Parse(strs[2])));
                        break;
                    case "getall":
                        Console.WriteLine(string.Join(", ", graph.GetAll(int.Parse(strs[1]))));
                        break;
                }
            }
        }
    }
}
