using DungeonWorld.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonWorld.DAO
{
    public class DataAccesObject
    {
        public static DWModel context = new DWModel();

        public static Race GetRaceById(int id)
        {
            
            return context.Races.Where(r => r.IDRace == id).FirstOrDefault();
            

        }
        public static Race GetRaceIdByName(string name)
        {

            return context.Races.Where(r => r.Race_Name == name).FirstOrDefault();


        }

        public  static Class GetClassById(int id)
        {
            
            return  context.Classes
                               .Where(r => r.IDClass == id)
                               .SingleOrDefault();

        }
        public static Class GetClassIdByName(string name)
        {
            var query = context.Classes
                               .Where(r => r.Class_Name == name).FirstOrDefault();
                            
            
            return query;

        }
        public static List<string> GetClassNames()
        {
            return context.Classes.Select(c => c.Class_Name).ToList();
        }
        public static List<String> GetRaceNames()
        {

            return context.Races.Select(c => c.Race_Name).ToList();

        }

        public static List<Character> GetAllCharacters() 
        {
            return  context.Characters.ToList();
        }
    }
}