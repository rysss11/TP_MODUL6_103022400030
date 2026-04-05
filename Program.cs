using System;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Random random = new Random();
        this.id = random.Next(00000,100000);
        this.title = title;
        this.playCount = "0";
    } 

    public void IncreasePlayCount(int count)
    {
        int current = int.Parse(playCount);
        current = count++;
        playCount = current.ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("Track Id: " + id);
        Console.WriteLine("Track Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
        Console.WriteLine("");
    }
}

public class program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu = new SayaMusicTrack("Lagu 1");
        SayaMusicTrack lagu2 = new SayaMusicTrack("Lagu 2");
        lagu.IncreasePlayCount(100);
        lagu.PrintTrackDetails(); 
        lagu2.IncreasePlayCount(200);
        lagu2.PrintTrackDetails();
    }
}