using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SimpleInterest
    {
        double principal=0, rateOfInterest=0, time=0;

        public SimpleInterest(double principal, double rateOfInterest, double time)
        {
            this.principal = principal;
            this.rateOfInterest = rateOfInterest;
            this.time = time;
        }

        public void CalculateInterest()
        {
            try
            {

                if (principal > 0 && rateOfInterest > 0 && time > 0)
                {
                    var interest = (principal * rateOfInterest * time) * 0.01;
                    Console.WriteLine("Interest earned [0]", interest);
                }
                else
                {
                    Console.WriteLine("Invalid Parameters");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
