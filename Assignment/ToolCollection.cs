using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ToolCollection : iToolCollection
    {
        Tool[] collection; 
        private int number = 0;
        private int capacity = 30;

        public ToolCollection()
        {
            this.collection = new Tool[capacity];
            number = 0;             
        }

        public int Number { get; }
        public int Capacity { get; }

        public void add(Tool aTool)
        {
            if (number < capacity)
            {
                collection[number] = aTool;
                number++;
            }
            else
            {
                Console.WriteLine("Cannot add tool into collection");
            }
        }
        

        public void delete(Tool aTool)
        {
            List<Tool> collectionList = collection.ToList(); 
            for (int i = 0; i < collectionList.Count; i++)
            {
                if (collection[i] == aTool) { collectionList.Remove(aTool); }
            }
            collection = collectionList.ToArray();             
        }
    

        public bool search(Tool aTool)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == aTool) { Console.WriteLine($"Found tool {aTool}"); return true; }               

            }
            Console.WriteLine($"Did not find tool {aTool}");
            return false; 
        }

        public Tool[] toArray()
        {
            return collection; 
        }

        public Tool ConfirmTool(String name)
        {
            Tool dummy = new Tool(name);
            for (int i = 0; i < this.collection.Length; i++)
            {
                if (dummy.Name == collection[i].Name)
                {
                    return collection[i];
                }
            }
            return null;
        }
    }
    
}
