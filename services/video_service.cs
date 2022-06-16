/*

*/

using System;
using System.Collections.Generic;
using Raylib_cs;
using Gems_Rocks_Chasers.casting;

public class VideoService
{
    private Raylib_cs.Color _background_color = Raylib_cs.Color.BLACK; 
    private Dictionary<string, Raylib_cs.Texture2D> _textures = new Dictionary<string, Raylib_cs.Texture2D>();

    public VideoService()
    {

    }

    public void open_window(int width, int height, string title, int frame_rate)
    {
        Raylib.InitWindow(width, height, title);
        Raylib.SetTargetFPS(frame_rate);
    }

    public void close_window()
    {
        Raylib.CloseWindow();
    }

    public void start_drawing()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(_background_color);

    }

    public void end_drawing()
    {
        Raylib.EndDrawing();

    }

    public void draw_box(int x, int y, int width, int height, Raylib_cs.Color BLUE)
    {
        Raylib.DrawRectangle(x, y, width, height, Raylib_cs.Color.BLUE)
    }

    public void draw_image(int x, int y, string image)
    {
        if(!_textures.ContainsKey(image))
        {
            Raylib_cs.Texture2D loaded = Raylib.LoadTexture(image);
            _textures[image] = loaded;
        }

        Raylib_cs.Texture2D texture = _textures[image];
        Raylib.DrawTexture(texture, x, y, Raylib_cs.Color.WHITE);

    }

    public void draw_actor(Actor actor)
    {
        int x = actor.get_x();
        int y = actor.get_y();
        int width = actor.get_width();
        int height = actor.get_height();

        if(actor.has_image())
        {
            string image = actor.get_image();
            draw_image(x, y, image);
        }

        else
        {
            draw_box(x, y, width, height);
        }
    }

    // Potential Problem with datatypes be aware
    public void draw_all_actors_in_group(List<Actor> actors)
    {
        foreach (Actor actor in actors)
        {
            draw_actor(actor);
        }
    }

}