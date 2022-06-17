/*


*/ 

using System;

namespace Gems_Rocks_Chasers.casting
{

    class Cast
    {
        private Dictionary <string, List<Actor>> cast = new Dictionary <string, List<Actor>>();
        
        public Cast()
        {
            _cast = cast;
        }

        public void create_groups()
        {
            _cast["rocks"] = new List<Actor>();
            _cast["gems"] = new List<Actor>(); 
            _cast["chasers"] = new List<Actor>(); 
            _cast["character"] = new List<Actor>();  

        }

        public Dictionary <string, List<Actor>> get_cast()
        {
            return _cast;
        }

        public void add_actor(string group, Actor actor) 
        {
            _cast[group].Add(actor);

        }

        public List<Actor> get_all_actors()
        {
            return _cast.Values;
        }

        
        
    }
}