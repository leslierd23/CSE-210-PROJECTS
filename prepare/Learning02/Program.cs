using System;

class Program
{
    static void Main(string[] args)
    {
        //crrate a new job instance 
        Job job1 = new Job();
        job1._jobTitle= "Driver";
        job1._company="Pemex";
        job1._endYear="2024";
        job1._startYear="1998";
        

        Job job2= new Job();
        job2._jobTitle="cutter";
        job2._company="RGV Truss";
        job2._endYear="2024";
        job2._startYear="2021";

         //calls to the new method os display
        job1.DisplayJobTittle();
        
        Resume theResume = new Resume();
        theResume._namePerson = "Leslie Labastida";
        
        theResume._jobs.Add(job1);
        theResume._jobs.Add(job2);

        theResume.DisplayJobTittle();
    }
    
    
} 

