using System;

namespace doublyLinkedList
{
     public class Node
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

    public interface ISentinel
    {
        
    }

    public class baseSentinel:Node,ISentinel
    {
        //Instance constructors couldn't be inherited.
        public baseSentinel(int Invalue):base(Invalue)
        { }
    }

    public class DList
    {
        public DList()
        {

        }
        internal Node Top_Sentinel { get; set; }
        internal Node Buttom_Sentinel { get; set; }
    }

    public static class DListExtension
    {
        //static public void InsertNode(this DList dList,int )
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dlist = new DList();
            var newNode = new Node(1000);
        }
    }
}
