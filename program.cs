/*


*/

using System;
using Gems_Rocks_Chasers.scripting;
using Gems_Rocks_Chasers.casting;
using Gems_Rocks_Chasers.scripting; 
using System.Collections.Generic;

namespace Gems_Rocks_Chasers
{
    class Program 
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            director.initialize_objects(); 
            director.direct();
        }   
    }
}