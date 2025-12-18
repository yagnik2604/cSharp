
class Box<T>
{
    public T value;
      public Box(T value)
    {
        this.value = value;
    }

}

class Data<T, U>
{
    public T Id;
    public U Value;

    public Data(T id, U value)
    {
        Id = id;
        Value = value;
    }
}


class Pair<T>
{
      public T first;
      public T second;

      public Pair(T first, T second)
    {
        first = first;
        second = second;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Box<int> b1 = new Box<int>(10);
        b1.value = 10;

        Box<string> b2 = new Box<string>("yag");
        b2.value= "yagnik";

        //----------pair class---------------
        Pair<int> p = new Pair<int>(10, 20);
        Pair<string> s = new Pair<string>("A", "B");

        // --------------dta class---------
        Data<int, string> d = new Data<int, string>(1, "Yagnik");


    }
}