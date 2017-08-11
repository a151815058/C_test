using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//類別，繼承的範例
namespace test_41
{
    class Shape {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public virtual void Draw() {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }
    class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
    class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Shape> shape = new System.Collections.Generic.List<Shape>();
            shape.Add(new Rectangle());
            shape.Add(new Triangle());
            shape.Add(new Circle());

            foreach (var shape1 in shape) {
                Console.WriteLine(shape1);
            }
            Console.ReadKey();
        }
    }
}
