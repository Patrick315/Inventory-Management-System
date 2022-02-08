using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class HSTest
    {
        public static Tool[] CombinedToolsArray(ToolCollection[][] tools)
        {
            Tool[] combinedTools = new Tool[500];
            int count = 0;
            for (int i = 0; i < tools.Length; i++)
            {
                for (int j = 0; j < tools[i].Length; j++)
                {
                    for (int t = 0; t < tools[i][j].toArray().Length; t++)
                    {
                        if (tools[i][j].toArray()[t] != null && tools[i][j].toArray()[t].NoBorrowings > 0)
                        {
                            combinedTools[count] = tools[i][j].toArray()[t];
                            count++;
                        }
                    }
                }
            }

            return combinedTools;
        }

        public static void SortToolArray(Tool[] tools)
        {
            List<Tool> toolList = new List<Tool>();
            for (int i = 0; i < tools.Length; i++)
            {
                if (tools[i] != null)
                {
                    toolList.Add(tools[i]);
                }
            }            
            List<Tool> sortedToolList = toolList.OrderByDescending(o => o.NoBorrowings).ToList();
            Tool[] sortedToolArray = sortedToolList.ToArray();
            for (int i = 0; i < 3; i++)
            {
                if (sortedToolArray[i].NoBorrowings > 0)
                {
                    Console.WriteLine($"#{i+1} {sortedToolArray[i].Name}:" + $" borrowed {sortedToolArray[i].NoBorrowings} times\n===");
                }
                
            }
                
        }

        
    }
}
