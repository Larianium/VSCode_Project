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
                        stopwatchElement = new Stopwatch();
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
        
        stopwatchElement.Start();
        elementList = exList[searchElement];
        stopwatchElement.Stop();
        Console.WriteLine("Прошедшее время поиска элемента в миллисекундах: {0}", stopwatchElement.ElapsedMilliseconds);

        Console.WriteLine("ArrayList:");
        stopwatch.Start();
        for(int i = 0; i <= 1000000; i++) //1000000
        {            
            myAL.Add(i);                        
            //Console.WriteLine(myAL[i]);
        }
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время заполнения в миллисекундах: {0}", stopwatch.ElapsedMilliseconds);    

        stopwatchElement.Start();
        elementList = (int)myAL[searchElement];
        stopwatchElement.Stop();
        Console.WriteLine("Прошедшее время поиска элемента в миллисекундах: {0}", stopwatchElement.ElapsedMilliseconds);

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

        stopwatchElement.Start();
        //elementList = myLL.Select(searchElement);
        elementList = myLL.ElementAt(searchElement);
        stopwatchElement.Stop();
        Console.WriteLine("Прошедшее время поиска элемента в миллисекундах: {0}", stopwatchElement.ElapsedMilliseconds);

        // foreach (int item in myLL)
        // {
        //     Console.WriteLine(item);
        // }
    }
}
