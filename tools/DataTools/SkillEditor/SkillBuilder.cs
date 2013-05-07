using System;
using System.Collections.Generic;
using System.IO;
using Data.Structures.SkillEngine;
using ProtoBuf;

namespace DataTools.SkillEditor
{
    class SkillBuilder
    {
        public static string BinPath = Path.GetFullPath("../../../../Tera/bin/Debug/data/skills.bin");
        public static List<Skill> skills;
        public static List<Skill> Getskills()
        {
          
          
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");

            if (File.Exists(BinPath))
            {
                if (File.Exists("data/skills.bin"))
                    File.Delete("data/skills.bin");

                File.Copy(BinPath, "data/skills.bin");
            }
            else
                File.Create("data/skills.bin").Dispose();
           // skills = Liste<Skill>(Data.Data.Skills.Values);
            using (FileStream fileStream = File.OpenRead(Directory.GetCurrentDirectory() + "/data/skills.bin"))
            {

                skills = new List<Skill>(Serializer.Deserialize<Dictionary<int, Skill>>(fileStream).Values);
            }

          return skills;
        }

       
       
          

        public static void SaveData(IEnumerable<Skill> quests)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "data/skills.bin"))
                File.Delete(Directory.GetCurrentDirectory() + "data/skills.bin");

            using (FileStream fileStream = File.Create(Directory.GetCurrentDirectory() + "data/skills.bin"))
            {
                foreach (Skill quest in quests)
                Serializer.SerializeWithLengthPrefix(fileStream, quest, PrefixStyle.Fixed32);
            }
        }
    }
}
       

