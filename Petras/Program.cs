using Petras.HashTable;
using Petras.Others;
using Petras.StringManipulations;
using System.Collections;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading.Tasks.Dataflow;

Permutations c = new Permutations();

var result=c.CheckPermutation("ab", "eidboaooo");

var test = "";

//question 1
//var ref1 = new Foo { Value = 1 };
//var ref2 = new Foo { Value = 1 };

//var equality = ref1.Equals(ref2);
//var sameRefs = ref1 == ref2;



//question 3

//using(var disposable=new TestDisposable())
//{
//    disposable.Do();
//}

//3a 
//var disposable = new TestDisposable();

//try
//{
//    disposable.Do();
//}
//catch
//{
//    disposable.Dispose();
//}

//3b

//try
//{
//    var disposable = new TestDisposable();
//    disposable.Do();
//}
//finally
//{
//    GC.Collect();
//    GC.WaitForPendingFinalizers();
//}

//3c
//var disposable = new TestDisposable();

//try
//{
//    disposable.Do();
//}
//finally
//{
//    disposable.Dispose();
//    GC.Collect();
//    GC.WaitForPendingFinalizers();
//}

//3d
//TestDisposable disposable = null;

//try
//{
//    disposable= new TestDisposable();
//    disposable.Do();
//}
//finally
//{
//    disposable?.Dispose();

//}

var container = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
{
    "Test",
    "test",
    "Test",
    "test",
    "hash",
    "",
    String.Empty
};


var count= container.Count();
var found= container.Contains("test");



//4

//Foo foo = new Foo();
//Bar bar = new Bar();
//foo.Bar = bar;
//bar.Foo = foo;
//foo = null;
//bar = null;
//class Foo
//{
//    public Bar Bar { get; set; }
//}
//class Bar
//{
//    public Foo Foo { get; set; }
//}

//7



//        Foo foo = null;
//        try
//        {
//            foo = new Foo(value: 23);
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("Failed to create foo");
//        }
//        Console.WriteLine(foo.Value);



//class Foo
//{
//    public int Value { get; }

//    public Foo(int value)
//    {
//        Value = value;
//        throw new InvalidOperationException();
//    }
//}


//8


//Task t1 = new Task(() => Foo.Bar(1));
//Task t2 = new Task(() => Foo.Bar(2));

//t1.Start();
//t2.Start();

//t1.Wait();
//t2.Wait();


//static class Foo
//{
//    private static readonly object s_lockobject = new object();
//    public static void Bar(Int32 taskNumber)
//    {
//        lock (s_lockobject) 
//        { 
//            for (int i=0; i < 3; i++)
//            {
//                Console.Write(taskNumber);
//            }
//        }
//    }
//}

//9
//#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

//ConcurrentQueue<int> queue = new();
//Task.Run(() => 
//{
//    lock (queue)
//    {
//        while (queue.TryDequeue(out int value))
//        {
//            Console.WriteLine(value);
//        }
//    }
//});

//for (int i = 0; i < 10000; i++)
//{
//    queue.Enqueue(i);
//}

//13
var numberOfIterations = 10;
var alg = new Algorithm();

Task oddtask = Task.Factory.StartNew(() => 
{ 
    for (int i = 0; i < numberOfIterations; i++)
    {
        alg.PrintOdd();
    }
});

Task eventask = Task.Factory.StartNew(() =>
{
    for (int i = 0; i < numberOfIterations; i++)
    {
        alg.PrintEven();
    }
});

class Algorithm
{
    public Algorithm() { }
    public void PrintEven()
    {

    }
    public void PrintOdd()
    {

    }

}


//11
public sealed class DisposableScope: IDisposable
{
    public DisposableScope()
    {
            
    }
    public void Dispose() 
    {
    // your code here
    }
    public void Add(DisposableScope disposable) 
    {
    // your code here
    }
}
//test
//using (DisposableScope scope = new())
//{
//    scope.Add(item1);
//    scope.Add(item2);
//    scope.Add(item3);
//    scope.Add(item2);

//}



public class TestDisposable : IDisposable
{
    public void Do()
    {
        //doing stuff
    }

    public void Dispose()
    {
        //disposing stuff
    }
}






//static void SetZeroes(int[][] matrix)
//{
//    HashSet<int> rows = new HashSet<int>();
//    HashSet<int> cols = new HashSet<int>();

//    // First pass: Identify rows and columns containing zeros
//    for (int i = 0; i < matrix.Length; i++)
//    {
//        for (int j = 0; j < matrix[0].Length; j++)
//        {
//            if (matrix[i][j] == 0)
//            {
//                rows.Add(i);
//                cols.Add(j);
//            }
//        }
//    }

//    // Second pass: Set entire row and column to zero if any element in it is zero
//    for (int i = 0; i < matrix.Length; i++)
//    {
//        for (int j = 0; j < matrix[0].Length; j++)
//        {
//            if (rows.Contains(i) || cols.Contains(j))
//            {
//                matrix[i][j] = 0;
//            }
//        }
//    }
//}
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Hello, World!");
//}


//int[][] matrix = new int[][]
//       {
//            new int[] {1, 2, 3},
//            new int[] {4, 0, 6},
//            new int[] {7, 8, 9}
//       };

//SetZeroes(matrix);

//// Print the modified matrix
//foreach (var row in matrix)
//{
//    Console.WriteLine(string.Join(" ", row));
//}

