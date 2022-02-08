using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Member : iMember, IComparable<Member> 
    {
        private string firstName;
        private string lastName;
        private string contactNumber;
        private string pin;
        private int numTools;
        private int borrowLimit = 3;
        private Tool[] borrowedToolsArray;
        private ToolCollection borrowedTools = new ToolCollection();
        private string[] tools = new string[3];
        private int toolsCount = 0;
        private string userName;
        // private ToolCollection toolCollection;
        
        public Member(string first, string last, string number, string pass)
        {
            this.firstName = first;
            this.lastName = last;
            this.contactNumber = number;
            this.pin = pass;
            this.borrowedToolsArray = new Tool[borrowLimit];
            this.userName = firstName + lastName;
            // this.toolCollection = new ToolCollection($"{this.firstName} + " + $"{this.lastName}'s tools");
        }
        public string FirstName { get => firstName; set => firstName = value; } 
        public string LastName { get => lastName; set => lastName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string PIN { get => pin; set => pin = value; }
        public string[] Tools { get => tools; }
        public int ToolsCount { get => toolsCount; set => toolsCount = value; }
        public int NumTools { get => numTools; set => numTools = value; }

        public Tool[] BorrowedToolsArray { get => borrowedToolsArray; }
        public ToolCollection BorrowedTools { get => borrowedTools; }
        public int BorrowLimit { get => borrowLimit; }

        public void addTool(Tool aTool)
        {
            if (numTools < borrowLimit && aTool.Quantity > 0)
            {
                borrowedTools.add(aTool);
                tools[toolsCount] = aTool.Name;
                toolsCount++;
                numTools++;
            }
            else
            {
                Console.WriteLine("Member cannot borrow any more tools");
            } 
        }

        public int CompareTo(Member other)
        {
            if (this.lastName.CompareTo(other.lastName) < 0) { return -1; }
            else if ((this.lastName.CompareTo(other.lastName) == 0) && (this.firstName.CompareTo(other.firstName) < 0)) { return -1; }
            else if ((this.lastName.CompareTo(other.lastName) == 0) && (this.firstName.CompareTo(other.firstName) == 0)) { return 0; }
            else return 1;
        }

        public int CompareToPin(Member other)
        {
            if (this.lastName.CompareTo(other.lastName) < 0) { return -1; }
            else if ((this.lastName.CompareTo(other.lastName) == 0) && (this.firstName.CompareTo(other.firstName) < 0)) { return -1; }
            else if ((this.lastName.CompareTo(other.lastName) == 0) && (this.firstName.CompareTo(other.firstName) == 0) && (this.pin.CompareTo(other.pin) ==0) ) { return 0; }
            else return 1;
        }

        public void deleteTool(Tool aTool)
        {
            if (borrowedTools.search(aTool))
            {
                borrowedTools.delete(aTool);
                numTools--;
            }
            else { Console.WriteLine("Member was not borrowing this tool"); }
        }

        public override string ToString()
        {
            return ($"Name: {this.firstName}" + " " + $"{this.lastName}\nNumber: {this.contactNumber}");
        }
    }
}
