/*

*/

using System;

namespace Gems_Rocks_Chasers.casting 
{
    public class Pointf
    {
        private double _x;
        private double _y;


        public Pointf(int x, int y)
        {
            _x = x; 
            _y = y; 
        }

        public double get_x()
        {
            return _x;
        }

        public double get_y()
        {
            return _y; 
        }

        public Pointf add(Pointf other)
        {
            double new_x = _x + other._x;
            double new_y = _y + other._y;
            return new Pointf(new_x, new_y); 
        }

        public Pointf scale(int factor)
        {
            double new_x = _x * factor;
            double new_y = _y * factor; 

            return new Pointf(new_x, new_y);
        }

        public reverse()
        {
            return scale(-1);
        }


    }
}