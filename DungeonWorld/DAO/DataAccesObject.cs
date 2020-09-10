﻿using DungeonWorld.Model;
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
            
            return context.Races.Where(r => r.IDRace == id).SingleOrDefault();
            

        }
        public static Race GetRaceIdByName(string name)
        {

            return context.Races.Where(r => r.Race_Name == name).SingleOrDefault();


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
                               .Where(r => r.Class_Name == name).SingleOrDefault();
                            
            
            return query;

        }
        public async static Task<List<string>> GetClassNames()
        {
            return await context.Classes.Select(c => c.Class_Name).ToListAsync();
        }
        public async static Task<List<String>> GetRaceNames()
        {

            return await context.Races.Select(c => c.Race_Name).ToListAsync();

        }

        public async static Task<List<Character>> GetAllCharacters() 
        {
            return await context.Characters.ToListAsync();
        }
    }
}