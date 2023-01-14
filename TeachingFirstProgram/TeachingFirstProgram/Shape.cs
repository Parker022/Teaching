using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingFirstProgram
{
    public abstract class Shape
    {
        public float area;

        public abstract void SaySomething(); //THIS HAS TO BE IMPLEMENTED IN SUB CLASSES

        public virtual void SomethingElse()
        {
            Console.WriteLine("something else");
        }

        public virtual float GetArea()
        {
            return 0;
        }
    }

    public class Triangle : Shape
    {
        public float sideA;
        public float sideB;

        public Triangle(float pSideA, float pSideB) 
        {
            sideA = pSideA;
            sideB = pSideB;
            area = GetArea();
        }

        public override void SaySomething()
        {
            throw new NotImplementedException();
        }

        public override void SomethingElse()
        {
            base.SomethingElse();
            Console.WriteLine("and even more else");
        }

        public override float GetArea()
        {
            return (sideA * sideB) / 2;
        }
    }

    public class Sqaure : Shape
    {
        public float sideA;
        public float sideB;

        public Sqaure(float pSideA, float pSideB)
        {
            sideA = pSideA;
            sideB = pSideB;
            area = GetArea();
        }

        public override void SomethingElse()
        {
            Console.WriteLine("just something");
        }

        public override void SaySomething()
        {
            throw new NotImplementedException();
        }

        public override float GetArea()
        {
            return sideA * sideB;
        }
    }
}
