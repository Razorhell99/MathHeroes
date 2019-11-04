using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public int Level {
            get
            {
                return (Experience / 100) + 1;
            }
        }
        public int Experience { get; set; }

        public Player()
            :base()
        {
           
        }

    }

    
    
}
