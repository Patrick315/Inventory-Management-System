using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ToolLibrarySystem : iToolLibrarySystem
    {
        private ToolCollection toolCollection;
        private MemberCollection memberCollection;
        private ToolCollection borrowedTools;
        private ToolCollection[][] allTools;

        public ToolLibrarySystem(ToolCollection toolCollection, MemberCollection memberCollection)
        {
            this.toolCollection = toolCollection;
            this.memberCollection = memberCollection;              
        }

        public ToolLibrarySystem()
        {

        }

        public ToolCollection BorrowedTools { get => borrowedTools; }
        public ToolCollection ToolCollection { get => toolCollection;  }
        public ToolCollection[][] AllTools { get => allTools; set => allTools = value; }
        public void add(Tool aTool)
        {
            toolCollection.add(aTool);
        }

        public void add(Tool aTool, int quantity)
        {
            toolCollection.add(aTool);            
        }

        public void add(Member aMember)
        {
            memberCollection.add(aMember);           
        }

        public void borrowTool(Member aMember, Tool aTool)
        {
            if ( (toolCollection.search(aTool) == true) && (memberCollection.search(aMember) == true))
            {
                aMember.addTool(aTool);
                aTool.addBorrower(aMember);
                //borrowedTools.add(copyTool);
            }
        }

        public void delete(Tool aTool)
        {
            toolCollection.delete(aTool);
        }

        public void delete(Tool aTool, int quantity)
        {
            toolCollection.delete(aTool);
        }

        public void delete(Member aMember)
        {
            memberCollection.delete(aMember);
        }

        public void displayBorrowingTools(Member aMember)
        {
            for (int i = 0; i < aMember.BorrowedTools.toArray().Length; i++)
            {
                if (aMember.BorrowedTools.toArray()[i] != null)
                {
                    Console.WriteLine(aMember.BorrowedTools.toArray()[i]);
                    Console.WriteLine("===");
                }
            }
        }

        public void displayTools(string aToolType)
        {
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            Tool[] combinedTools = HSTest.CombinedToolsArray(allTools);
            HeapSortAlgorithm.HeapSort(combinedTools);
        }

        public string[] listTools(Member aMember)
        {
            return aMember.Tools;
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            if ((toolCollection.search(aTool) == true) && (memberCollection.search(aMember) == true))
            {
                aTool.deleteBorrower(aMember);
                aMember.deleteTool(aTool);
            }
        }
    }
}
