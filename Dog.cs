﻿using System;
namespace MoeQuiz
{
    public class Dog : Animal
    {
        public string Sound { get; set; }

        public string getInfo()
        {
            return $"Name: {Name}, Color: {Color}, Legs: {LegCount}, Sound: {Sound}";
        }
    }
}