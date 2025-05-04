using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            _renderer.Render("Circle");
        }
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            _renderer.Render("Square");
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            _renderer.Render("Triangle");
        }
    }
}
