namespace MyConsoleApp;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello!");
        //Console.ReadLine();
        List<int> exList = new List<int>();
        var exList_1 = new List<int>{1,2,3};

        for(int i = 0; i <= 10; i++) //1000000
        {
            exList.Add(i);
            i++;
            //Console.WriteLine(exList);
            PrintList(exList);
        }
    }
}
