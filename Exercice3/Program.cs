using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 6);
            Point p2 = new Point(3, 7);
            Point p3 = new Point(4, 8);

            Console.WriteLine("La distance entre p1 et p2 est :" + p1.distance(p2));


        }

        public class Point
        {
            private double x;
            private double y;
            public Point()                     //Le constructeur par défaut
            {
            }

            public Point(double a, double b)   //Le constructeur d'initialisation
            {
                x = a;
                y = b;
            }


            public double getx()         //Le getter de x
            {
                return x;
            }
            public double gety()      //le getter de y
            {
                return y;
            }

            public void setx(double a)   //Le setter de  x
            {
                x = a;
            }


            public void sety(double o)    //Le setter de y
            {
                y = o;
            }

            // distance 
            public double distance(Point p)
            {
                return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
            }

            //Egalité
            public bool egalité(Point p)
            {
                if ((x == p.x) && (y == p.y))
                    return true;
                else
                    return false;

            }
            //translation 
            public Point translation(float a)
            {
                x = x + a;
                y = y + a;
                return new Point(x, y);
            }

            // public void Linéarité 
            public static void linéarité(Point P1, Point p2, Point p3)
            {
                double a;
                double b;
                if (P1.x != p2.x)
                {
                    a = (P1.y - p2.y) / (P1.x - p2.x);
                    b = P1.y + a * P1.x;
                    if (a * p3.x + b == p3.y)
                    {
                        Console.WriteLine("les trois points sont linéaire");
                    }
                    else
                    {
                        Console.WriteLine("les trois points ne sont pas linéaire");
                    }

                }


            }
        }
    }

}

