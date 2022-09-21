using System;

var instance = new Program {
    MyProp = "first"
};

instance.MyProp = "second";
instance.Show();
partial class Program
{
    public string MyProp { get; init; }

    public void Show()
    {
        Console.WriteLine($"MyProp = {MyProp}");
    }
}