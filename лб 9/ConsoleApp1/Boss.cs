﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Boss
    {
        // Вариант 8

        // Создать класс Boss с событиями Upgrade и TurnOn(под
        // определенным напряжением, учтите что техника или человек могут
        // сломаться). В main создать некоторое количество объектов(техники
        // или полу-техники). Подпишите объекты на события произвольным
        // образом. Реакция на события у разных объектов будет разная.
        // Проверить результаты изменения состояния объектов после
        // наступления событий, возможно не однократном.

        public string Name { get; }
        public string Type { get; }
        public int Level { get; set; }
        public double Strain { get; set; }
        public bool Status { get; set; }

        public Boss(string name = "", string type = "", int level = 0, double strain = 0.0, bool status = true)
        {
            this.Name = name;
            this.Type = type;
            this.Level = level;
            this.Strain = strain;
            this.Status = status;
        }

        public delegate void UpgradeLevel(Boss machine, int upgradeTo);
        public delegate void TurnOnMachine(Boss machine, double currentStrain);
        public event UpgradeLevel UpgradeEvent;
        public event TurnOnMachine TurnOnEvent;

        public void Upgrade(int upgradeTo)
        {
            this.Level = this.Level + upgradeTo;
            this.UpgradeEvent?.Invoke(this, upgradeTo);
        }

        public void TurnOn(double currentStrain)
        {
            this.Strain = currentStrain;
            this.TurnOnEvent?.Invoke(this, currentStrain);
        }

        public void showCurrentLevel() => Console.WriteLine($"Current level is {this.Level}");
        public void showCurrentStrain() => Console.WriteLine($"Current strain is {this.Strain}");

        public static string DeletePunctuation(string str) => Regex.Replace(str, @"[.|,|;|:]", "");
        public static string AddSymbol(string str) => str.Insert(0, " ").ToString();
        public static string ToUpperCase(string str) => str.ToUpper();
        public static string DeleteSpaces(string str) => Regex.Replace(str.Trim(), @"\s+", " ");
        public static string DeleteWordNot(string str) => Regex.Replace(str, @"NOT\w*", "");
    }
}
