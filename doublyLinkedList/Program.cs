using System;

namespace doublyLinkedList
{
     public class Node:INode
    {
        internal Node Prev { get; set; }
        internal int Nvalue { get; set; }
        internal Node Next { get; set; }

        public Node(int inValue)
        {
            Nvalue = inValue;
            Prev = null;
            Next = null;
        }
    }

    public interface INode
    {

    }

    public interface ISentinel
    {
        
    }

    public class baseSentinel:Node,ISentinel,INode
    {
        //Instance constructors couldn't be inherited.
        public baseSentinel(int Invalue):base(Invalue)
        { }
    }

    public class SentinelFactory
    {
        public INode CreateSentinel()
        {
            return new baseSentinel(-1);
        }
    }

    public class DList
    {
        public DList()
        {
            var fac = new SentinelFactory();
            Top_Sentinel = (Node)fac.CreateSentinel();
            Buttom_Sentinel = (Node)fac.CreateSentinel();

            Top_Sentinel.Next = Buttom_Sentinel;
            Buttom_Sentinel.Prev = Top_Sentinel;
        }
        internal Node Top_Sentinel { get; set; }
        internal Node Buttom_Sentinel { get; set; }
    }

    public static class DListExtension
    {
        static public void InsertNode(this DList dList,int newValue)
        {
            var curr=dList.Top_Sentinel;
            while(curr.Next!=dList.Buttom_Sentinel)
            {
                curr=curr.Next;
            }
            var newNode=new Node(newValue);
            newNode.Next=dList.Buttom_Sentinel;
            dList.Buttom_Sentinel.Prev=newNode;
            curr.Next=newNode;
            newNode.Prev=curr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dlist = new DList();
            dlist.InsertNode(1000);
            dlist.InsertNode(2000);
        }
    }
}
