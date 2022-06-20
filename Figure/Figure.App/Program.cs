using System;

namespace Figure.App
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Cli.ShowInfo("1. Circle");
            Cli.ShowInfo("2. Rectangle");
            var select = Cli.Input("enter type figure");
            Figure? figure = select switch
            {
                "1" => new Circle(),
                "2" => new Rectangel(),
                _ => null,
            };
            if (figure is not null)
            {
                ConsolFigure.InputFigure(figure);
                ConsolFigure.ShowSquare(figure);
                ConsolFigure.ShowPerimeter(figure);
            }

        }

    }
}
