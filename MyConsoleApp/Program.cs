using System.Collections;
using System.Diagnostics;
namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        List<int>       exList          = new List<int>();
        ArrayList       myAL            = new ArrayList();
        LinkedList<int> myLL            = new LinkedList<int>();
        Stopwatch       stopwatch       = new Stopwatch();
        int             elementList,
                        size            = 1000000,
                        searchElement   = 496753,
                        remainderNumber = 777;
        
        //"List:"
        Console.WriteLine("List:");
        stopwatch.Start();
        for(int i = 0; i <= size; i++)         
            exList.Add(i);                          

        stopwatch.Stop();      
        Console.WriteLine("Прошедшее время заполнения в миллисекундах: {0}", stopwatch.ElapsedMilliseconds); 
        
        stopwatch.Restart();
        elementList = exList[searchElement];
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время поиска элемента {0} в миллисекундах: {1}", searchElement, stopwatch.ElapsedMilliseconds);

        stopwatch.Restart();
        foreach (int item in exList)
        {
            if(item % remainderNumber == 0)
                Console.WriteLine(item);          
        }
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время заполнения foreach в миллисекундах: {0}", stopwatch.ElapsedMilliseconds);

        //"ArrayList:"
        Console.WriteLine("ArrayList:");
        stopwatch.Restart();
        for(int i = 0; i <= size; i++)          
            myAL.Add(i);                        
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время заполнения в миллисекундах: {0}", stopwatch.ElapsedMilliseconds);   

        stopwatch.Restart();
        elementList = (int)myAL[searchElement];
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время поиска элемента {0} в миллисекундах: {1}", searchElement, stopwatch.ElapsedMilliseconds);

        stopwatch.Restart();
        foreach (int item in myAL)
        {
            if(item % remainderNumber == 0)
                Console.WriteLine(item);        
        }
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время заполнения foreach в миллисекундах: {0}", stopwatch.ElapsedMilliseconds);

        //"LinkedList:"
        Console.WriteLine("LinkedList:");   
        stopwatch.Restart();     
        for(int i = 0; i <= size; i++)           
            myLL.AddLast(i);             

        foreach (int item in myLL)
        {
            elementList = item;
            if(elementList % remainderNumber == 0)   
                Console.WriteLine(item);    
        }
        stopwatch.Stop();
        Console.WriteLine("Прошедшее время заполнения в миллисекундах: {0}", stopwatch.ElapsedMilliseconds); 

        stopwatch.Restart();
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
