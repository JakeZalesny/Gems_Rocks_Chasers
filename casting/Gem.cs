/*

*/

public class Gem : Actor
{
    public Gem()
    {   public string gem = "*";
        Random x_velocity = new Random();
        Point _position = new Point(0, 0);
        Pointf _velocity = new Pointf(0, x_velocity.NextDouble() * 12);
    }

    public string get_gem()
    {
        return gem;
    }

    public void move_down()
    {
        int x = (_position.get_x() + (int)_velocity.get_x()) % Constants.MAX_X; 
        int y = (_position.get_y() - (int)_velocity.get_y()) % Constants.MAX_Y;
        _position = new Point(x, y); 
    }
}