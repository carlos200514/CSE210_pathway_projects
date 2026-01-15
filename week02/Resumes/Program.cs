using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new Job();
        job1._jobTitle= "Software engineer";
        job1._company= "Microsoft";
        job1._startYear= 2020;
        job1._endYear= 2023;
        Job job2= new Job();
        job2._jobTitle= "Manager";
        job2._company= "apple";
        job2._startYear= 2022;
        job2._endYear= 2024;

        Resume ownResume= new Resume();
        ownResume._name= "Felipe Rojas";
        ownResume._jobs.Add(job1);
        ownResume._jobs.Add(job2);
        ownResume.Display();
    }
}