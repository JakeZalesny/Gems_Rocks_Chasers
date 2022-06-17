/*

*/
using System; 

namespace Gems_Rocks_Chasers.casting
{
    public class Rock : Actor 
    {
        public Rock()
        {   
            public string rock = "0";
            public string width = 16;
            public string height = 29;

            set_image(rock);
            set_width(width);
            set_image(height);
        }

        //public string get_rock()
        //{
        //    return rock;
        //}

        //public void move_down()
        //{
        //  int x = (_position.get_x() + (int)_velocity.get_x()) % Constants.MAX_X; 
            //int y = (_position.get_y() - (int)_velocity.get_y()) % Constants.MAX_Y;
            //_position = new Point(x, y); 
        //}


    }
}