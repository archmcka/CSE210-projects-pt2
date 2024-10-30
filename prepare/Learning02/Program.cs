using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job();
        job1._company="microsoft";
        job1._jobTitle="software engineer";
        job1._startDate="2019";
        job1._endDate="2024";

        Job job2= new Job();
        job2._company="apple";
        job2._jobTitle="manager";
        job2._startDate="2011";
        job2._endDate="2019";

        Resume myResume =d new Resume();
        myResume._name="mckayla archibald";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



    }
}

