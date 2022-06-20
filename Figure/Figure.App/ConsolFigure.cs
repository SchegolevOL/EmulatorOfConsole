using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.App
{
    public static class ConsolFigure
    {
        public static void ShowSquare(Figure figure)
        {
            Cli.ShowInfo(figure.GetSquare().ToString());
        }
        public static void ShowPerimeter(Figure figure)
        {
            Cli.ShowInfo(figure.GetPerimeter().ToString());
        }

        public static void InputCircle(Circle circle)
        {
            bool isConvertToDouble;
            double radius = 0;
            do
            {
                var input = Cli.Input("Enter Radius");
                isConvertToDouble = double.TryParse(input, out radius);

            } while ((!isConvertToDouble) || radius <= 0);
            circle.Radius = radius;
        }
        private static double ValidInput(string message)
        { 
            bool isConvertToDouble;
            double value;
            do
            {
                var input = Cli.Input(message);
                isConvertToDouble = double.TryParse(input, out value);

            } while ((!isConvertToDouble) || value <= 0);
            return value;
        }

        public static void InputRectangle(Rectangel rectangel)
        {
            rectangel.SideA = ValidInput("Enter side A");
            rectangel.SideB = ValidInput("Enter side B");
        }
        public static void InputFigure(Figure figure)
        {
            //var type = figure.GetType();
            //if (type == typeof(Circle))
            //{
            //    InputCircle(figure as Circle);
            //    return;
            //}
            //if (type == typeof(Rectangel))
            //{
            //    InputRectangle(figure as Rectangel);
            //    return;
            //}
            switch (figure)
            {
                case Circle circle:
                    InputCircle(figure as Circle);
                    break;
                case Rectangel rectangel:
                    InputRectangle(figure as Rectangel);
                    break;
              
            }
        }
    }
}
