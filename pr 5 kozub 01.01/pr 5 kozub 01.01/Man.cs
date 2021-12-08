using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5_kozub_01._01
{
    internal class Man
    {
        private string _name;
        private char _sex;
        private int _age;
        private float _weight;
        public string Name { get { return _name; } set { _name = value; } }

        public char Sex
        {
            get { return _sex; }
            set
            {
                if (value == 'М' || value == 'м' || value == 'Ж' || value == 'ж')
                    _sex = value;
                else throw new ArgumentException();
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                else _age = value;
            }
        }


        public float Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                else _weight = value;
            }
        }

        public Man()
        {
            _name = "Unnamed";
            _sex = Sex;
            _age = 1;
            _weight = 1;
        }

        public void SetParams(string name)
        {
            Name = name;
        }

        public void SetParams(string name, char sex, int age, float weight)
        {
            Name = name;
            Sex = sex;
            Age = age;
            Weight = weight;
        }

    }
}
