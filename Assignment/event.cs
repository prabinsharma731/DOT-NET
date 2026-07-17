using System;

delegate void Notify();

class Alarm
{
    public event Notify Ring;

    public void Start()
    {
        Console.WriteLine("Alarm Started");

        if (Ring != null)
            Ring();
    }
}

class Program
{
    static void ShowMessage()
    {
        Console.WriteLine("Wake Up!");
    }

    static void Main()
    {
        Alarm alarm = new Alarm();

        alarm.Ring += ShowMessage;

        alarm.Start();
    }
}