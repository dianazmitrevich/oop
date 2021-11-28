﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class TelevisionProgram
    {
        // Вариант 8

        // Телевизионная программа, Фильм, Новости, Худ. фильм,
        // Мультфильм, Реклама, Режиссер

        // constructors
        public int duration;
        public int ageRange;
        private string producer;

        public int Duration
        {
            get => duration;
            set
            {
                if (duration > 0)
                    this.Duration = duration;
                else throw new Exception("Duration can't be less than 0");
            }
        }

        public int AgeRange
        {
            get => ageRange;
            set
            {
                if (ageRange > 0)
                    this.AgeRange = ageRange;
                else throw new Exception("Age range can't be less than 0");
            }
        }

        public string Producer
        {
            get => producer;
            set
            {
                this.Producer = producer;
            }
        }

        public TelevisionProgram(int duration = 0, int ageRange = 0, string producer = "")
        {
            this.Duration = duration;
            this.AgeRange = ageRange;
            this.Producer = producer;
        }
    }
}