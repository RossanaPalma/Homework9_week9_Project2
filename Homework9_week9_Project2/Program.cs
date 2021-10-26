using System;

namespace Homework9_week9_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing temp variable and methods
            Temperature temp1 = new Temperature(30.1);
            Console.WriteLine("Temp1 in degrees Celsius : " + temp1.ToString());
            Console.WriteLine("Testing get method to TempC: " + temp1.GetTempC());  
            Console.WriteLine("Testing get method to TempF: " + temp1.GetTempF());  
            
            //Set new Temperature to temp1
            temp1.SetTemp(35.0);                                                       
            Console.WriteLine("New Temp1 : " + temp1.ToString());
            
            // Set scale to 'c'
            temp1.SetScale('c');                                                       
            Console.WriteLine("Scale 'c': " + temp1.ToString());
            
            //Set All temp and scale
            temp1.SetAll(76.3, 'f');                                                   
            Console.WriteLine("Temp1 : " + temp1.ToString());
            Console.WriteLine("TempC: " + temp1.GetTempC()); 

            // Testing scale variable and methods
            Temperature temp2 = new Temperature(75.2, 'f');
            Console.WriteLine("Temp2: " + temp2.ToString());
            temp2.SetAll(75.2, 'f');

            // Testing full constructor (temp, scale)
            Temperature temp3 = new Temperature(75.2, 'f');
            Console.WriteLine("Temp3: " + temp3.ToString());

            // Testing Equals method 
            Console.WriteLine("Is temp2 equal to temp3? " + temp2.Equals(temp3)); // true
            Console.WriteLine("Is temp1 equal to temp2? " + temp1.Equals(temp2)); // false

            // Testing no-argument constructor
            Temperature temp4 = new Temperature();
            Console.WriteLine("Temp4: " + temp4.ToString());

            Console.ReadLine(); 
        }
    }
}
    

