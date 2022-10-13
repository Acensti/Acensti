using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shootyshot
{
    public class Character
    {
         public enum Action
        {
            Reload,
            Shoot,
            Block,
            Shotgun,
        }
         public int ammo = 0;

         public Action Reload()
         {
             ammo++;
             return Action.Reload;
         }
         public Action Shoot()
         {
             if (ammo < 1)
             {
                 throw new Exception("User did not have enough ammo!");
             }
             ammo--;
             return Action.Shoot;
         }
         public Action Block()
         {
             return Action.Block;
         }
         public Action Shotgun()
         {
             if (ammo < 3)
             {
                 throw new Exception("User did not have enough ammo!");
             }
             return Action.Shotgun;
         }

    }
}
