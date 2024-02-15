using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car:IComparable, ICloneable
    {
        int id;
        string model;
        int speed;

        public int Id
        {
            get {return id; }
            set {  id = value; } 
        }
        public string Model 
        {
            get { return model; }
            set {  model = value; }
        }
        public int Speed 
        {
            get { return speed; }
            set { speed = value; }
        }

        public Car(int _id , string _model , int _speed) 
        {
            id = _id;
            model = _model;
            speed = _speed;
        }


        // Constructor Chaining
        public Car(int _id) 
            :this(_id , "BMW" , 120)
        {
            /*id = _id;
            model = "BMW";
            speed = 120;*/
        }


        // Copy Constructor
        public Car(Car c)
        {
            id = c.id;
            model = c.model;
            speed = c.speed;
        }

        public override string ToString()
        {
            return $"{id}:{model}:{speed}";
        }

        public int CompareTo(object? obj)
        {
            Car r = (Car) obj;
            return speed.CompareTo(r.speed);
        }

        public object Clone()
        {
            // return new Car(id , model , speed); 
            return new Car(this);  // Copy Ctor
        }
    }
}
