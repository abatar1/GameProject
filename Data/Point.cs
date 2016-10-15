namespace GameProject
{
    public class Point
    {
        double x;
        double y;

        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public static bool IsPointInsideCircle(Point p1, Point p2, double r)
        {
            //тут алгоритм, который находит расстояние между p1 и p2
            //и если _r >= r, то возвращаем true
            return true;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

    }
}
