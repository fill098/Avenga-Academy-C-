using System;
using System.Collections.Generic;
using System.Text;

namespace Class05.Race_Day_Homework.Models
{
    public class Car
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public Driver Driver { get; set; }



        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }


        public static void RaceCars(Car car1, Car car2)
        {
            int car1Speed = car1.CalculateSpeed();
            int car2Speed = car2.CalculateSpeed();

            if (car1Speed > car2Speed)
            {
                PrintWinner(car1, car1Speed);
            }
            else if (car1Speed < car2Speed)
            {
                PrintWinner(car2, car2Speed);

            }
            else
            {
                Console.WriteLine("It is a tie!!");
            }

        }


        static void PrintWinner(Car car, int speed)
        {
            Console.WriteLine($"Winner: {car.Model} driven by {car.Driver.Name} with speed {speed}");

        }
    }
}
