using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Tool : iTool, IComparable<Tool>
    {
        private string name;
        private int quantity = 0;
        private int availableQuantity;
        private int noBorrowings = 0;
        private MemberCollection borrowingMembers = new MemberCollection();
        public Tool(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int AvailableQuantity { get => availableQuantity; set => availableQuantity = value; }
        public int NoBorrowings { get => noBorrowings; set => noBorrowings = value; }

        public MemberCollection GetBorrowers => throw new NotImplementedException();

        public void addBorrower(Member aMember)
        { 
            if (quantity > 0 && aMember.NumTools < 3)
            {
                borrowingMembers.add(aMember);
                noBorrowings++;
                quantity--;
            }
            
        }

        public int CompareTo(Tool other)
        {
            if (this.name.CompareTo(other.name) < 0) { return -1; }
            else if (this.name.CompareTo(other.name) == 0) { return 0; }
            else return 1;
        }

        public int CompareBorrows(Tool other)
        {
            if (this.noBorrowings.CompareTo(other.noBorrowings) < 0) { return -1; }
            else if (this.noBorrowings.CompareTo(other.noBorrowings) == 0) { return 0; }
            else return 1;
        }


        public void deleteBorrower(Member aMember)
        {
            if (borrowingMembers.search(aMember))
            {
                borrowingMembers.delete(aMember);
                quantity++;                
            }
            
        }

        public override string ToString()
        {
            return ($"Tool Name: {this.name}\n" + $"Available Quantity: {this.quantity}");
        }

    }
    
}
    