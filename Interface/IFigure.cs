using System;

namespace IFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IFigure
    {
        void CalculateArea();
        void CalculatePerimeter();

    }
    class Rectangle : IFigure
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Circle : IFigure
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
    class Triangle : IFigure
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
    class Square : IFigure
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }

}