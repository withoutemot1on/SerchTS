﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2
{
    public class Hero
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public Hero(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;

        }
    }
}
