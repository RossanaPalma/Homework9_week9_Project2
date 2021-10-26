/// Chapter No. 11 - Homework9_Project2
/// File Name: Homework9_week9_Project2.java
/// @author: Rossana Palma
/// Date:  October 24, 2021
///
/// Problem Statement: Write a Temperature class that has two instance variables: a 
/// temperature value (a floating-point number) and a character for the scale, either 
/// C for Celsius of F for Fahrenheit.  The class should have 4 constructor methods: 
/// one for each instance variable (assume zero degress if no value is specified and 
/// Celsius if no scale is specified), one with two parameters for the two instance 
/// variables, and a no-argument constructor (set to zero degrees Celsius).   
/// 
/// Overall Plan:
/// 1) Create a Temperature class
/// 2) Declare variables
/// 3) Write 4 constructor methods
/// 4) Write Getter and Setter methods
/// 5) Write toString method
/// 6) Write Equals method
/// 
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9_week9_Project2
{
    class Temperature
    {
        // Declare cariables
        private double temp;
        private char scale;

        // Constructors
        
        public Temperature(double temp)
        {
            this.temp = temp;
            scale = 'C';
        }

        public Temperature(char scale)
        {
            temp = 0;
            this.scale = scale;
        }

        public Temperature(double temp, char scale)
        {
            this.temp = temp;
            this.scale = scale;
        }

        // No-argument constructor (set to zero degrees Celsius)
        public Temperature()
        {
            temp = 0;
            scale = 'C';
        }
        // Getter methods
        public double GetTempC()
        {
             double tempC = temp;
             if (Char.ToUpper(scale) == 'F')
             {
                tempC = (temp - 32) * (Convert.ToDouble(5) / 9);
             }
             return Math.Round(tempC, 1);
        }

        public double GetTempF()
        {
            double tempF = temp;
            if (Char.ToUpper(scale) == 'C')
            {
                tempF = (temp * (Convert.ToDouble(9) / 5)) + 32;
            }
            return Math.Round(tempF, 1);
        }

        // Setter methods
        public void SetTemp(double temp)
        {
            this.temp = temp;
        }

        public void SetScale(char scale)
        {
            scale = Char.ToUpper(scale);
            this.scale = scale;
        }

        public void SetAll(double temp, char scale)
        {
            this.temp = temp;
            scale = Char.ToUpper(scale);
            this.scale = scale;
        }

        // ToString method
        public string ToString()
        {
            return String.Format(" {0}°{1}", temp, Char.ToUpper(scale));
        }

        // Equals method
        public bool Equals(object obj)
        {
            //Check for null 
            if ((obj == null))
            {
                return false;
            }
            else
            {
                Temperature t = (Temperature)obj;
                return GetTempF() == t.GetTempF();
            }
        }
    }
}

