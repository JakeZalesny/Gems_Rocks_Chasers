/*

*/

public class ControlActorsAction : Action
{
    KeyboardService _keyboard;

    public ControlActorsAction(KeyboardService keyboard_service)
    {
        _keyboard = keyboard_service;
    }

    public override void Execute(Dictionary<string, List<actors>> cast)
    {
        Point direction = _keyboard.get_direction();

        Actor player = cast["character"][0];

        Pointf velocity = new Pointf(direction.get_x() * Constants.CHARACTER_SPEED, player.get_velocity().get_y() );
        player.set_velocity(velocity);
    }

}