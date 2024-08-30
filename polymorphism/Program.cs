using polymorphism;

BaseGeometricShape square1 = new Square();
Console.WriteLine("Area of square1 :" + square1.CalculateArea(3,3));

BaseGeometricShape rectangle1 = new Rectangle();
Console.WriteLine("Area of rectangle1 :" + rectangle1.CalculateArea(3, 4));

BaseGeometricShape right_triangle1 = new RightTriangle();
Console.WriteLine("Area of right_triangle1 :" + right_triangle1.CalculateArea(6, 4));
