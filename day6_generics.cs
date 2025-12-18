using System;

class Program
{
    static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4};
        double[] doubleArray = { 1, 2, 3, 4};
        string[] stringArray = { "1", "2", "3", "4"};
        

        Program p = new Program();

        p.displayElements(intArray);
        p.displayElements(doubleArray);
        p.displayElements(stringArray);

        // displayElements(intArray);
        // displayElements(doubleArray);
        // displayElements(stringArray);
    }

    public  void displayElements<T>(T[] array)
    {
        foreach( T item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
    // public static void displayElements<T>(T[] array)
    // {
    //     foreach( T item in array)
    //     {
    //         Console.Write(item + " ");
    //     }

    //     Console.WriteLine();
    // }
}