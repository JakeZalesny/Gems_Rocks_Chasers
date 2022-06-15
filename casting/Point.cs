/*

*/

using System; 

namespace Gems_Rocks_Chasers.casting; 

public class Point()
{
    private int _x 
    private int _y

    public Point(int x, int y)
    {
        _x = x;
        _y = y;

    }

    public int get_x()
    {
        return _x;
    }

    public int get_y()
    {
        return _y;
    }

    public Point add(Point other)
    {
        int new_x = _x + other._x;
        int new_y = _y + other._y;
        return new Point(new_x, new_y);
    }

    public Point scale(int factor)
    {
        int new_x = _x * factor;
        int new_y = _y * factor; 
        return new Point(new_x, new_y);
    }

    public Point reverse()
    {
        return scale(-1);
    }

} 