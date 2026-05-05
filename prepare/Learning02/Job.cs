using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYr;
    public int _endYr;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle},  {_company}, ({_startYr}-{_endYr})");
    }
}