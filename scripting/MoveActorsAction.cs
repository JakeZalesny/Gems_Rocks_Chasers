/*

*/

public class MoveActorsAction : Action 
{
    public MoveActorsAction()
    {

    }

    public override void Execute(Dictionary<string, List<Actor>> cast)
    {
        foreach (List<Actor> group in cast.Values)
        {
            foreach (Actor actor in group)
            {
                MoveActor(actor);
            }
        }
    }

    public void move_actor(Actor actor)
    {
        int x = actor.get_x();
        int y = actor.get_y();

        double dx = actor.get_velocity().get_x();
        double dy = actor.get_velocity().get_y(); 

        double new_x = (x + dx) % Constants.MAX_X;
        double new_y = (y + dy) % Constants.MAX_Y;

        if (new_x < 0)
        {
            new_x = Constants.MAX_X;
        }

        if (new_y < 0)
        {
            new_y = Constants.MAX_Y;
        }

        actor.set_position(new Point((int)new_x, (int)new_y));
    }
}