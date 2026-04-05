using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null,"title tidak boleh kosong");
        Debug.Assert(title.Length <= 100,"panjang title tidak boleh lebih dari 100");

        Random random = new Random();
        this.id = random.Next(00000,100000);
        this.title = title;
        this.playCount = "0";
    } 

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000,"melebihi batas max playcount");

        try
        {
            checked
            {
                int current = int.Parse(playCount);
                current += count;
                playCount = current.ToString();
            }
        }
        catch (OverflowException) 
        {
            Console.WriteLine("play count maksimal!!");
        }
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

        Console.WriteLine("Test Exception");
        SayaMusicTrack overflow = new SayaMusicTrack("Overflow");

        for (int i = 0; i < 1000; i++)
        {
            overflow.IncreasePlayCount(10000000);
        }

        Console.WriteLine("Test Precondition");
        SayaMusicTrack panjangmax = new SayaMusicTrack(new string('L',101));

    }
}