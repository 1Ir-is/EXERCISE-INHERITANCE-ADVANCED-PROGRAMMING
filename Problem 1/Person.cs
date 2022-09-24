﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    public class Person
    {
        private int age;
        private string name;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
           protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
            }

        }

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (value.Length < 3 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();

        }
    }
}
