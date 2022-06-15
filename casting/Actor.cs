/*

*/

using System;

namespace Gems_Rocks_Chasers.casting;

public class Actor
{
    protected Point _position;
    protected Pointf _velocity; 

    protected int _width = 0;
    protected int _height = 0; 

    protected string _image = "";

    private bool _using_gravity;

    private bool _is_falling;  

    public Actor()
    {
        _position = new Point(0, 0);
        _velocity = new Pointf(0f, 0f);
        _using_gravity = false; 
    }

    public void set_use_gravity(bool using_gravity)
    {
        _using_gravity = using_gravity
    }

    public void get_use_gravity()
    {
        return _using_gravity; 
    }

    public Pointf get_velocity()
    {
        return _velocity;
    }

    public Pointf set_velocity(Pointf new_velocity)
    {
        _velocity = new_velocity;

    }

    public Point get_position()
    {
        return _position;
    }

    public Point get_x()
    {
        return _position.get_x();
    }

    public Point get_y()
    {
        return _position.get_y();
    }

    public Point set_position(Point new_position)
    {
        _position = new_position;
    }

    public string get_image()
    {
        return _image;
    }

    public void set_image(string new_image)
    {
        _image = new_image; 
    }

    public void change_x_velocity()
    {
        Pointf velocity = get_velocity();
        double x = velocity.get_x();
        double y = velocity.get_y();
        set_velocity(new Pointf(-x, y));
        
    }

    public void change_y_velocity()
    {
        Pointf velocity = get_velocity();
        double x = velocity.get_x();
        double y = velocity.get_y();
        set_velocity(new Pointf(x, -y));
    }

    public void move_next()
    {
        int x = _position.get_x();
        int y = _position.get_y();

        int dx = (int)_velocity.get_x();
        int dy = (int)_velocity.get_y();

        int new_x = (x + dx) % Constants.MAX_X;
        int new_y = (y + dy) % Constants.MAX_Y; 

        if (new_x < 0)
        {
            new_x = Constants.MAX_X;
        }

        if (new_y < 0)
        {
            new_y = Constants.MAX_Y;
        }

        _position = new Point(new_x, new_y);
    }

}