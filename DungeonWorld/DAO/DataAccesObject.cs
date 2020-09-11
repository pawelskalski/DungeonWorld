using DungeonWorld.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace DungeonWorld.DAO
{
    public class DataAccesObject
    {
        public static DWModel context = new DWModel();

        //Race
        public static Race GetRaceById(int id) => context.Races.Single(r => r.IDRace == id);
        public static Race GetRaceByName(string name) => context.Races.Single(r => r.Race_Name == name);
        public static List<String> GetRaceNames() => context.Races.Select(c => c.Race_Name).ToList();


        //Class
        public static Class GetClassById(int id) => context.Classes.Single(r => r.IDClass == id);
        public static Class GetClassByName(string name) => context.Classes.Single(r => r.Class_Name == name);
        public static List<string> GetClassNames() => context.Classes.Select(c => c.Class_Name).ToList();


        //Character
        public static List<Character> GetAllCharacters() => context.Characters.ToList();
        public static Character GetCharacterById(int id) => context.Characters.Single(c => c.IDCharacter == id);
        public static void DeleteCharacterById(int id)
        {
            context.Characters.Remove(GetCharacterById(id));
            context.SaveChanges();
        }
       
    }
}


