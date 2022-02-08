using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MemberCollection : iMemberCollection
    {
        private int numMembers;
        private int maxMembers = 30;
        private BSTree memberCollection;
        private Member[] memberArray;

        public MemberCollection()
        {
            this.memberCollection = new BSTree();
            this.numMembers = 0;
            this.memberArray = new Member[maxMembers];
        }
        public int Number { get; }

        public void add(Member aMember)
        {
            memberCollection.Insert(aMember);
            memberArray[numMembers] = aMember;
            this.numMembers++; 
        }

        public void delete(Member aMember)
        {
            this.memberCollection.Delete(aMember);
            this.numMembers--;
            List<Member> deleteMemberList = memberArray.ToList();
            deleteMemberList.Remove(aMember);
            memberArray = deleteMemberList.ToArray();
        }

        public bool search(Member aMember)
        {
            return memberCollection.Search(aMember);
        }

        public Member[] toArray()
        {
            return memberArray; 
        }

        public bool Empty()
        {
            return memberCollection.IsEmpty();
        }

        //public string FindNumber(string first, string last)
        //{
        //    List<Member> memberList = this.memberArray.ToList();
        //    Member member = memberList.Where(member => member.FirstName == first && member.LastName == last).FirstOrDefault();
        //    Console.WriteLine(member.ContactNumber);
        //    return member.ContactNumber;                      
        //}

        public string FindNumber(string first, string last)
        {
            Member dummy = new Member(first, last, "N/A", "N/A");
            for (int i = 0; i < this.memberArray.Length; i++)
            {
                if (dummy.FirstName == memberArray[i].FirstName)
                {
                    return memberArray[i].ContactNumber; 
                }                
            }
            return "nah"; 
        }

        public Member ConfirmMember(string first, string last, string number)
        {
            Member dummy = new Member(first, last, number, "N/A");
            for (int i = 0; i < this.memberArray.Length; i++)
            {
                if ( (dummy.FirstName == memberArray[i].FirstName) && (dummy.LastName == memberArray[i].LastName) && (dummy.ContactNumber == memberArray[i].ContactNumber) )
                {
                    return memberArray[i];
                }
            }
            return null; 
        }

        public Member ConfirmMemberAlt(string first, string last)
        {
            Member dummy = new Member(first, last, "N/A", "N/A");
            for (int i = 0; i < this.memberArray.Length; i++)
            {
                if ((dummy.FirstName == memberArray[i].FirstName) && (dummy.LastName == memberArray[i].LastName))
                {
                    return memberArray[i];
                }
            }
            return null;
        }

        
    }
}
