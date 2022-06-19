/*

*/
using System; 

namespace Gems_Rocks_Chasers.casting
{
    public class Gem : Actor
    {
        public Gem()
        {  
            public string gem = "*";
            public int width = 16;
            public int height = 29;

            set_image(string gem);
            set_width(int width);
            set_image(int height);
        }
    }
}