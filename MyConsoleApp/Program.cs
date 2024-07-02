using System.Collections;
using System.Diagnostics;

namespace MyConsoleApp;





class Program
{
    static void Main(string[] args)
    {
        List<int>       exList = new List<int>();
        ArrayList       myAL = new ArrayList();
        LinkedList<int> myLL = new LinkedList<int>();
        Stopwatch       stopwatch = new Stopwatch(),
                        stopwatchElementList = new Stopwatch(),
                        stopwatchElementArrayList = new Stopwatch(),
                        stopwatchElementLinkedList = new Stopwatch();
        int             elementList, 
                        searchElement = 496753;

        Console.WriteLine("List:");
        stopwatch.Start();
        for(int i = 0; i <= 1000000; i++) //1000000
        {           
            exList.Add(i);           
            //Console.WriteLine(exList[i]);          
        }  
        stopwatch.Stop();      
        Console.WriteLine("Прошедшее время заполнения в миллисекундах: {0}", stopwatch.ElapsedMilliseconds); 
        
        //stopwatchElementList.Start();
        stopwatchElementList.Start();
        elementList = exList[searchElement];
        stopwatchElementList.Stop();
        //stopwatchElementList.Stop();
        Console.WriteLine("Прошедшее время поиска элемента в миллисекундах: {0}", stopwatchElementList.ElapsedMilliseconds);

        Console.WriteLine("ArrayList:");
        stopwatch.Start();
        for(int i = 0; i <= 1000000; i++) //1000000
        {            
            myAL.Add(i);                        
            //Console.WriteLine(myAL[i]);
        }
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время заполнения в миллисекундах: {0}", stopwatch.ElapsedMilliseconds);    

        //stopwatchElementArrayList.Start();
        stopwatchElementList.Start();
        elementList = (int)myAL[searchElement];
        //stopwatchElementArrayList.Stop();
        stopwatchElementList.Stop();
        Console.WriteLine("Прошедшее время поиска элемента в миллисекундах: {0}", stopwatchElementList.ElapsedMilliseconds);

        Console.WriteLine("LinkedList:");
        //LinkedListNode<int> currentNode = myLL.First;   
        stopwatch.Start();     
        for(int i = 0; i <= 1000000; i++) //1000000
        {            
            myLL.AddLast(i);             
            //Console.WriteLine(currentNode.Next);
        }
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время заполнения в миллисекундах: {0}", stopwatch.ElapsedMilliseconds); 

        //stopwatchElementLinkedList.Start();
        stopwatchElementList.Start();
        //elementList = myLL.Select(searchElement);
        elementList = myLL.ElementAt(searchElement);
        //stopwatchElementLinkedList.Stop();
        stopwatchElementList.Stop();
        Console.WriteLine("Прошедшее время поиска элемента в миллисекундах: {0}", stopwatchElementList.ElapsedMilliseconds);

        // foreach (int item in myLL)
        // {
        //     Console.WriteLine(item);
        // }

        //Test 02.07.2024
    }
}
