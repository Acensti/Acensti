using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shootyshot.Logic;
namespace Shootyshot
{
    public class Character
    {
        public static Actions CurrentAction { get; set; }

            public int ammo = 0;

         public Actions Reload()
         {
             ammo++;
             return Actions.Reload;
         }
         public Actions Shoot()
         {
             if (ammo < 1)
             {
                 throw new Exception("User did not have enough ammo!");
             }
             ammo--;
             return Actions.Shoot;
         }
         public Actions Block()
         {
             return Actions.Block;
         }
         public Actions Shotgun()
         {
             if (ammo < 3)
             {
                 throw new Exception("User did not have enough ammo!");
             }
             return Actions.Shotgun;
         }

    }
}
