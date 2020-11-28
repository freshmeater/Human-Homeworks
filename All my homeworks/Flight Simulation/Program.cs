using System;
using System.Collections.Generic;
using System.Text;
using static Input.Program;
using VectorStructure;

namespace FlightSimulation
{
    class MainClass
    {
        const double deltaTime = 1d / 60d;
        static double time = 0d;
        static double resistance = 0.95;
        static Vector g = new Vector(0, -9.81, 0);
        static double maxY = 0;
        static void Main(string[] args)
        {
            PhysicalPoint ball = new PhysicalPoint(DoubleInput(),VectorInput());
            do
            {
                maxY = ball.coords.y >= maxY ? ball.coords.y : maxY;
                time += deltaTime;
                ball.speed = (ball.speed+g)*resistance;
                ball.coords += ball.speed*deltaTime;
                Console.WriteLine(ball.coords);
            } while (ball.coords.y>0);
            Console.WriteLine($"Час: {time}");
            Console.WriteLine($"Дистанция: {ball.Distance()}");
            Console.WriteLine($"Максимальна висота: {maxY}");
        }
    }
}
