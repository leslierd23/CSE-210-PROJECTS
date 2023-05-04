//create the class
public class Job 
{
    //create the variables n the class
    public string  _company;
    public string _jobTitle;
    public string  _startYear;
    public string _endYear;
    

    //add a method member function
    public void DisplayJobTittle()
    {
        Console.Write($"  {_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

} 


