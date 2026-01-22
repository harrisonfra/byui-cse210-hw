using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Crowdstrike";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Electrical Engineer";
        job2._company = "General Electric";
        job2._startYear = 2024;
        job2._endYear = 2026;
        
        Resume resume1 = new Resume();
        resume1._name = "John";

        //job1.Display();
        //job2.Display();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

    }
}