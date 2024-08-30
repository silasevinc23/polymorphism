using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace polymorphism
{


    public class BaseGeometricShape
    {
        public double height {get; set;}
        public double width { get; set; }

        public virtual double CalculateArea(double height, double width)
        {
            double area = height * width;
            return area;
        }
    }


        public class Square: BaseGeometricShape
        {
          
        }

        public class Rectangle : BaseGeometricShape
        {

        }

        public class RightTriangle : BaseGeometricShape
        {

        public override double CalculateArea(double height, double width)
        {
            double area = (height * width) / 2;
            return area;
        }


    }


}












