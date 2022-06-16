/*

*/

using System;
using Raylib_cs;
using Raylib; 

namespace Gems_Rocks_Chasers.services;

public class KeyboardService
{
    public KeyboardService()
    {

    }

    public bool is_left_key_pressed()
    {
        return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_A);
    }

    public bool is_right_key_pressed()
    {
        return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_D);
    }

    public bool is_up_key_pressed()
    {
        return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_W);
    }

    public bool is_down_key_pressed()
    {
        return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_S);
    }

    public Point get_direction()
    {
        int x = 0;
        int y = 0; 

        if(is_left_key_pressed())
        {
            x += -1;
        }

        if(is_right_key_pressed())
        {
            x += 1;
        }

        if(is_up_key_pressed())
        {
            y += 1;
        }

        if(is_down_key_pressed())
        {
            y += -1; 
        }

        return new Point(x, y)
    }
}