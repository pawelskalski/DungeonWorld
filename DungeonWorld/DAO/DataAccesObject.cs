using DungeonWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonWorld.DAO
{
    public class DataAccesObject
    {
        public static DWModel context = new DWModel();

        public static Race GetRaceById(int id) => context.Races.FirstOrDefault(r => r.RaceId == id);

        public static Race GetRaceIdByName(string name) => context.Races.FirstOrDefault(r => r.RaceName == name);

        public  static Class GetClassById(int id) =>  context.Classes.SingleOrDefault(r => r.IDClass == id);
        
        public static Class GetClassIdByName(string name) => context.Classes.FirstOrDefault(r => r.Class_Name == name);

        public static List<string> GetClassNames() => context.Classes.Select(c => c.Class_Name).ToList();
        
        public static List<String> GetRaceNames() => context.Races.Select(c => c.RaceName).ToList();

        public static List<Character> GetAllCharacters() =>  context.Characters.ToList();
    }
}