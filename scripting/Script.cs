/*

*/
using System.Collections.Generic;
using HolesAreBad.Casting;
using HolesAreBad.Services;


namespace HolesAreBad.Scripting
{
    public class Script
    {
        private Dictionary <string, List<Action>> script; 
        
        public script()
        {
            _script = script;
        }

        public create_groups()
        {
            _script["inputs"] = new List<Action>();
            _script["updates"] = new List<Action>();
            _script["outputs"] = new List<Action>(); 
        }

        public add_action(string group, Action action)
        {
            _script[group].Add(action);
        }

        public Dictionary <string, List<Action>> get_script()
        {
            return _script;
        }
    }
}