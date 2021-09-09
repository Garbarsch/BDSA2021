using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true){
            
            Console.Write("Enter an Year: ");
            try
            {
             
                 int year = Convert.ToInt32(Console.ReadLine());
                 if(year<1582){
                     Console.WriteLine("You can only apply years from 1582.");
                 } else{
                     Console.WriteLine(IsLeapYear(year)? "yay" : "nay");
                     break;
                 }
                    
            }
            catch (System.Exception e)
            {
            
               Console.WriteLine("You need to only enter a number! ");
            
            }
             
      
            }

            
        }
      public static  bool IsLeapYear(int year){
            if((year%400)==0 && (year%100)==0 || (year%4)==0 && (year%100)!=0)  
            return true;
            else 
            return false;            
        

        }
    }
}
