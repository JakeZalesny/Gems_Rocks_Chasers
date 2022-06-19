/*

*/
using System;
using System.Collections.Generic;
using Gems_Rocks_Chasers.casting;
using Gems_Rocks_Chasers.scripting;
using Gems_Rocks_Chasers.services;

namespace Gems_Rocks_Chasers
{
    public class Director
    {       
            public Cast cast = new Cast();
            public Script script = new Script();
            public static bool _keepPlaying = true;

        public Director()
        {
            _script = script;
            _cast = cast; 

        }

        public initialize_objects()
        {
            VideoService _video_service = new VideoService(); 
            PhysicsService _physics_service = new PhysicsService(); 
            KeyboardService _keyboard_service = new KeyboardService();  


            _cast.create_groups();
            _script.create_groups();
            
            Character character = new Character();
            _cast.add_actor("character", character);
            
            for (int i = 0; i <= Constants.GEM_AMMOUNT; i++)
            {
                Gem.Actor gem = new Gem.Actor(); 
                _cast.add_actor("gems", gem);
                
            }

            for (int i = 0; i <= Constants.ROCK_AMMOUNT; i++)
            {
                Rock.Actor rock = new Rock.Actor();
                _cast.add_actor("rocks", rock);
            }

            DrawActorsAction _draw_actors_action = new DrawActorsAction(_video_service);
            MoveActorsAction _move_actors_action = new MoveActorsAction();
            ControlActorsAction _control_actors_action = new ControlActorsAction(_keyboard_service);

            _script.add_action("outputs",_draw_actors_action);
            _script.add_action("updates",_move_actors_action);
            _script.add_action("updates", _control_actors_action);

            _video_service.open_window(Constants.MAX_X, Constants.MAX_Y, "Gems Rocks & Chasers", Constants.FRAME_RATE);

        }

        public void cue_action(string phase)
        {
            Dictionary <string, List<Action>> script_dict = _script.get_script();
            Dictionary <string, List<Actor>> cast_dict = _cast.get_cast(); 

            List<Action> actions = script_dict[phase];

            foreach(Action action in actions)
            {
                action.Execute(cast_dict);
            }

        }

        public void Direct()
        {
            while(_keepPlaying)
            {
                cue_action("inputs");
                cue_action("updates");
                cue_action("outputs");

                if (Raylib_cs.Raylib.WindowShouldClose())
                {
                    _keepPlaying = false;
                }
            }

            Console.WriteLine("Game Over!");
        }

    }
}