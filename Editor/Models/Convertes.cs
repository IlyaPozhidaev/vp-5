using Avalonia;
using Avalonia.Media;
using System.Collections.Generic;

namespace Editor.Models
{
    public static class Converters
    {
        public static string BrushToString(SolidColorBrush brush) => brush.ToString();

        public static SolidColorBrush StringToBrush(string str) => new SolidColorBrush(Color.Parse(str));

        public static string PointToString(Point p) => p.ToString();

        public static Point StringToPoint(string str)
        {
            var s = str.Split(',');
            return new Point(double.Parse(s[0]), double.Parse(s[1]));
        }

        public static List <Point> StringToPoints(string str)
        {
            var list = new List <Point>();
            var s = str.Split(',');
            for (int i = 0; i < s.Length; i += 2)
            {
                list.Add(new Point(double.Parse(s[i]), double.Parse(s[i + 1])));
            }
            return list;
        }

        public static Thickness StringToMargin(string str)
        {
            var s = str.Split(',');
            return new Thickness(double.Parse(s[0]), double.Parse(s[1]));
        }
    }
}
