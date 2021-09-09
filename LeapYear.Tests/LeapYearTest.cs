using System;
using System.IO;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearTest
    {
        [Fact]
        public void TestIfLeapYear1600()
        {
          
            Assert.Equal(true,Program.IsLeapYear(1600));
            
        }
         [Fact]
        public void TestIfLeapYear1700()
        {
          
            Assert.Equal(false,Program.IsLeapYear(1700));
            
        }
          [Fact]
        public void TestIfLeapYear2021()
        {
          
            Assert.Equal(false,Program.IsLeapYear(2021));
            
        }


        [Fact]
        public void TestIfLeapYearnay1600(){
        
         Assert.Equal("yay",Program.IsLeapYear(1600)? "yay" : "nay");

    
        }
         [Fact]
        public void TestIfLeapYearnay1700(){
        
         Assert.Equal("nay",Program.IsLeapYear(1700)? "yay" : "nay");

    
        }
         [Fact]
        public void TestIfLeapYearnay2021(){
        
         Assert.Equal("nay",Program.IsLeapYear(1700)? "yay" : "nay");
    
        }

        [Fact]
        public void TestIfLeapYearbelow1582(){
        int year = 1500;
         if(year<1582){
                     Console.WriteLine("You can only apply years from 1582.");
                 } else{
                     Console.WriteLine(Program.IsLeapYear(year)? "yay" : "nay");
       Assert.Equal("You can only apply years from 1582.","You can only apply years from 1582");
    
    
        }

        
    

}
    }
}
