using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dziedziczenie
{
    public class Animal
    {
        public PictureBox Picture;
        public string Food;
        public int Hunger;
        //public Boundaries boundaries;
        //public Location location;

        public void MakeNoise()
        {

        }
        public void Eat()
        {

        }
        public void Sleep()
        {

        }
        public void Roam()
        {

        }
    }
    public class Feline : Animal
    {

    }
    public class Canine : Animal
    {

    }
    public class Hippo : Animal
    {
        public void Swim()
        {

        }
    }
    public class Lion : Feline 
    {
            
    }
    public class Tiger : Feline
    {

    }
    public class Dog : Canine
    {
        Dog spot = new Dog();
        //spot.MakeNoise();
        //spot.Roam();
        //spot.Eat();
        //spot.Sleep();
        //spot.Fetch();
    }
    public class Cat : Feline
    {
           
    }
    public class Wolf : Canine
    {





    }
    public class  Bird
    {
        public virtual void Fly()
        {

        }
    }
    public class Penguin : Bird
    {
        public override void Fly()
        {
            MessageBox.Show("Pingwiny nie potrafią latać!");

        }
    }
        

    
}
