using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassforReflection
{
    public class Car
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public int MaxSpeed { get; set; }
        public bool Broken { get; set; }
        public Car(string model, string type, int maxSpeed, bool broken)
        {
            Model = model;
            Type = type;
            MaxSpeed = maxSpeed;
            Broken = broken;
        }
    }
}
