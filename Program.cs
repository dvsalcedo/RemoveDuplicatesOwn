using System.Collections;

namespace RemoveDuplicatesOwn1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linklist = new LinkedLists();
            linklist.append(1);
            linklist.append(3);
            linklist.append(5);
            linklist.append(8);
            linklist.append(1);
            linklist.append(2);
            linklist.append(1);
            linklist.append(4);

            linklist.print();
            linklist = RemoveDuplicates(linklist);
            System.Console.WriteLine("Result");
            linklist.print();
        }


        static LinkedLists RemoveDuplicates(LinkedLists linklist)
        {
            Node node;
            Hashtable buffer = new Hashtable();

            if (linklist == null)
                return null;

            node = linklist.First();
            buffer.Add(node.value, true);
            while (node.next != null)
            {
                if (!buffer.ContainsKey(node.next.value))
                    buffer.Add(node.next.value, true);
                else
                    node.next = node.next.next;

                node = node.next;
            }

            return linklist;
        }
    }
}
