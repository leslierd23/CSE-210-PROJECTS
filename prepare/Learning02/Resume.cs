using System;

public class Resume
{

    public string _namePerson;


    public List<Job>_jobs= new List<Job>();

    public void DisplayJobTittle()
    {
       Console.WriteLine($"The Name: {_namePerson}");
       Console.WriteLine($"Jobs: ");


    //list or the jobs
       foreach (Job job in _jobs)
       {
       //call the displayjobtittle
       job.DisplayJobTittle();

       }
    }
}


