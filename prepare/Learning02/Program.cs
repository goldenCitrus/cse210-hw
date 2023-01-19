using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Intel";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Walmart";
        job2._jobTitle = "CEO";
        job2._startYear = 2010;
        job2._endYear = 2015;
        
        Resume myResume = new Resume();
        myResume._name = "Curtis Schmidtlein";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}