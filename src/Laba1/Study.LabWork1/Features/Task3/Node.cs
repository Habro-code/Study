using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Study.LabWork1.Features.Task3
{
    internal class Node
    {
        //Список потомков и значение узла
        public List<Node> ListChil = new List<Node>();
        public string data;

        public Node(string str) => data = str;
       
        //Вывод всего дерева
        public void PrintListChil(int level = 0)
        {
            Console.WriteLine(new string(' ', 3 * level) + $"- {data}");

            if (ListChil.Count == 0)
                return;
            
            foreach (var child in ListChil)
                child.PrintListChil(level + 1);
        }
    }
}
