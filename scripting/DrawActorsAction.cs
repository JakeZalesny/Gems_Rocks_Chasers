using System.Collections.Generic;
using HolesAreBad.Casting;
using HolesAreBad.Services;


namespace HolesAreBad.Scripting
{
    public class DrawActorsAction : Action
    {
        private VideoService _video_service;
        
        public DrawActorsAction(VideoService _video_service)
        {
            _video_service = _video_service;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _video_service.start_drawing();

            foreach(List<Actor> group in cast.Values)
            {
                _video_service.draw_all_actors_in_group(group);

            }

            _video_service.end_drawing();
        }
    }
}