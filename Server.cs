using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cyberpunk2020Library;

namespace Cyberpunk2020CC
{
    public static class Server
    {
        //Needs implementation
        public static Character[] GetCharactersFromDatabase()
        {
            Character[] res = { Character.GenerateRandomNPC() };
            return res;
        }
    }
}
