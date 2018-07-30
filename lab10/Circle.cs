using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Circle
    {


        public double radius;
        public double area;
        public double circumference;
        public double pi;

        private double Radius { get; set; }



        public Circle(double radius)
        {

            Radius  = radius;
            //pi = 3.14  ;
           // area = pi * radius * radius;
            //circumference = 2 * pi * radius;

        }


       
        

        public double CalculateCircumference()
        {
             var  circumference  = 2* Math.PI * Radius;

            return circumference;
        }


        public string CalculateFormattedCircumference()
        {
            
        }


        public double CalculateArea()
        {
            var area = pi * radius * radius;

            return area;
        }


        public string CalculateFormattedArea()
        {
            
        }


        private string FormatNumber(double )
        {

        }


        /*  public string CalculateFormattedArea()
          {

          }


          private string FormatNumber(double)
          {

          }
           */






    }

}
