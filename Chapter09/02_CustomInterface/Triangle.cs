using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CustomInterface
{
    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        { Console.WriteLine("Drawing {0} the Triangle.", PetName); }

        // Реализация интерфейса IPointy
        public byte Points
        {
            get { return 3; }
        }
    }
}
