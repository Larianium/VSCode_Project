using System.Collections;

namespace MyConsoleApp;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello!");
        //Console.ReadLine();
        List<int> exList = new List<int>();
        ArrayList myAL = new ArrayList();
        LinkedList<int> myLL = new LinkedList<int>();

        Console.WriteLine("List:");
        for(int i = 0; i <= 10; i++) //1000000
        {
            exList.Add(i);          
            Console.WriteLine(exList[i]);          
        }

        Console.WriteLine("ArrayList:");
        for(int i = 0; i <= 10; i++) //1000000
        {
            myAL.Add(i);            
            Console.WriteLine(myAL[i]);
        }

        Console.WriteLine("LinkedList:");
        LinkedListNode<int> currentNode = myLL.First;
        
        for(int i = 0; i <= 10; i++) //1000000
        {
            myLL.AddLast(i);  
            Console.WriteLine(currentNode.Next);

        }

        // foreach (int item in myLL)
        // {
        //     Console.WriteLine(item);
        // }
    }
}
