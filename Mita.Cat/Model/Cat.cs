using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        private readonly string _age;
        private int _health;

        public Cat(string name, string age, int health, CatColor color)
        {
            _name = name;
            _age = age;
            _health = health;
            Color = color;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Имя задается однократно!");
                }               
            }
        }

        public string Age => _age;

        public CatColor Color { get; set; }

        public void ChangeColor(CatColor color)
        {
            Color = color;
        }


        public bool IsCatHealthy()
        {
            bool isHealthy = !(_health < 5);
            return isHealthy;
        }

        public void Feed()
        {
            _health++;
        }

        public void Punish()
        {
            _health--;
        }
    }

    public class CatColor
    {
        public string HealtyColor { get; set; }

        public string SickColor { get; set; }
    }
}
