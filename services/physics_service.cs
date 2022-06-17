/*

*/
using System;
using Raylib_cs;
using Gems_Rocks_Chasers.casting;

namespace Gems_Rocks_Chasers.services
{

    public class PhysicsService
    {
        public PhysicsService()
        {

        }

        public bool is_collision(Actor actor1, Actor actor2)
        {
            int x1 = actor1.get_x();
            int y1 = actor1.get_y();
            int width1 = actor1.get_width();
            int height2 = actor1.get_height();

            Raylib_cs.Rectangle rectangle1 = new Raylib_cs.Rectangle(x1, y1, width1, height1);

            int x2 = actor2.get_x();
            int y2 = actor2.get_y();
            int width2 = actor2.get_width();
            int height2 = actor2.get_height();

            Raylib_cs.Rectangle rectangle2 = new Raylib_cs.Rectangle(x2, y2, width2, height2);

            return Raylib.CheckCollisionRecs(rectangle1, rectangle2);
        
        }

        
    }
}