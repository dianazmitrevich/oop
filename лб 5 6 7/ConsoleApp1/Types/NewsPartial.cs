﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Exceptions__lb_7_;

namespace ConsoleApp1.Types
{
    public partial class News : TelevisionProgram, IShowInfo, IProducer
    {
        public void showDuration()
        {
            Console.WriteLine("This news episode goes for {0} minutes", Duration);
        }

        public void editAgeRange(int ageRange = 0)
        {
            if (ageRange > 0)
                this.AgeRange = ageRange;
            else throw new ExceptionF("NewsPartial.cs", "Age range can't be less than 0");
        }

        public void setProducer(string producerName = "")
        {
            this.producerName = producerName;
        }

        public override string ToString()
        {
            return $"This news episode goes for {this.Duration} minutes \nAge limit is {this.AgeRange} and above years \nNews category is {this.category}\nProducer - {this.producerName}";
        }
    }
}
