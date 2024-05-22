using System;

namespace PayrollSoftware
{
    class Staff 
    {
        //contains info bout each staff
        //contains CalculatePay() 
    }

    class Manager : Staff 
    {
        //inherit staffclass and ovverride CalculatePay()
    }
    class Admin : Staff 
    {
        //inherit staffclass and ovverride CalculatePay()
    }
    class FileReader 
    {
        //The FileReader class contains a simple method that reads from a .txt file and creates a list of Staff objects based on the contents in the.txt file.
    }
    class PaySlip 
    {
        /*The PaySlip class generates the pay slip of each employee in the company. In
        addition, it also generates a summary of the details of staff who worked less than 10
        hours in a month.*/

    }
    class Program 
    {
        public static void Main(String[] args)
        {

        }
    }
}