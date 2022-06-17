/*

*/
using System;
using System.Collections.Generic;
using Gems_Rocks_Chasers.casting;

namespace Gems_Rocks_Chasers.scripting 
{
    public abstract class Action 
    {
        public abstract void Execute(Dictionary<string, List<Actor>> cast);
    }
}