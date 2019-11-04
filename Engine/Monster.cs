using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ExperienceIfKilled { get; set; }
        public int GoldIfKilled { get; set; }


        // at which level can the hero see this monster
        public int LevelAvailableAt { get; set; }

    }
}
