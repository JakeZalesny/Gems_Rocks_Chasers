/*

*/

public class Character : Actor 
{
    private string _charimg = "#";
    private string _char_width = 16; 
    private string _char_height = 29; 

    public Character()
    {
        set_image(_charimg);
        set_height(_char_height);
        set_width(_char_width);

        int x = Constants.MAX_X / 2;
        int y = Constants.MAX_Y / 2;
        Point position = new Point(x, y);

        set_position(position);

        set_velocity(new Pointf(0, 0));

    }
}