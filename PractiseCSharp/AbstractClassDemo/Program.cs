using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus b = new Bus("naka", 3456, "red");
            b.ShowFeatures();
            b.Speed();

            Train t = new Train("shatabdi express", 1234, "blue");
            t.ShowFeatures();
            t.Speed();

            Vehicle v;
            v = new Bus("chowk", 456, "green");
            v.ShowFeatures();
            v.Speed();

            Vehicle.Display();
        }
    }

     abstract class Vehicle
    {
        protected string name;
        protected int modelNo;
        protected string color;

        public Vehicle(string name, int modelNo, string color)
        {
            this.name = name;
            this.modelNo = modelNo;
            this.color = color;
        }

        public void ShowFeatures()
        {
            Console.WriteLine("This is a " +name + " with model no " +modelNo+ " of color " +color);
        }

        public static void Display()
        {
            Console.WriteLine("Its a static method");
        }
        public abstract void Speed();



    }

    class Bus:Vehicle
    {
        public Bus(string name, int modelNo, string color):base(name,modelNo,color)
        {

        }

        public override void Speed()
        {

            Console.WriteLine("Slow Speed");
        }

    }

    class Train : Vehicle
    {
        public Train(string name, int modelNo, string color) : base(name, modelNo, color)
        {

        }

        public override void Speed()
        {

            Console.WriteLine("Fast Speed");
        }

    }


}
