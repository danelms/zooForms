using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> _animals = new List<Animal>();

        public List<Animal> getAllAnimals()
        {
            return _animals;
        }

        public Animal getAnimal(int pos)
        {
            return _animals[pos];
        }

        public void addAnimal(Animal a)
        {
            _animals.Add(a);
        }

        public void removeAnimal(Animal a)
        {
            _animals.Remove(a);
        }
    }

    public abstract class Animal
    {
        private String _name;
        private int _legs;

        public Animal(String name, int legs)
        {
            _name = name;
            _legs = legs;
        }

        public override string ToString()
        {
            return "Name: " + _name + " Legs: " + _legs;
        }

        public String getName()
        {
            return _name;
        }

        public void setLegs(int legs)
        {
            _legs = legs;
        }

        public int getLegs()
        {
            return _legs;
        }

    }

    public class Bear : Animal
    {
        private String _hatStyle;

        public Bear(String name, int legs, String hatStyle) : base(name, legs)
        {
            _hatStyle = hatStyle;
        }

        public String getHat()
        {
            return _hatStyle;
        }
    }

    public class Lion : Animal
    {
        private String _cntryOfOrigin;

        public Lion(String name, int legs, String countryOfOrigin) : base(name, legs)
        {
            _cntryOfOrigin = countryOfOrigin;
        }

        public String getCountry()
        {
            return _cntryOfOrigin;
        }
    }

    public class Fox : Animal
    {
        private String _furColour;

        public Fox(String name, int legs, String furColour) :base(name, legs)
        {
            _furColour = furColour;
        }

        public String getFurColour()
        {
            return _furColour;
        }
    }
}
