using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Zoo
    {
        private List<Animal> _animals;

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

    public class Animal
    {
        private String _name;
        private int _legs;

        public void setName(String name)
        {
            _name = name;
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

        public class Bear : Animal
        {

        }

    }
}
