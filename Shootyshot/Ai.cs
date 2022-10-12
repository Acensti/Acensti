using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shootyshot
{
    public class Ai
    {
        public enum Action
        {
            Reload,
            Shoot,
            Block,
            Shotgun,
        }
        public AI()
        {
            character = new Character();
        }
        public Character character;
        public int AIAmmo = 0;
       
        public Action AiActions() //Mechanical choices the ai commits
        {
            if (AIAmmo == 3)
            {
                return Action.Shotgun;
            }
            else if (AIAmmo == 0)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 2);
                switch (number)
                {
                    case 1:
                        AIAmmo++;
                        return Action.Reload;
                    case 2:
                        return Action.Block;
                }
                return Action.Block;


            }
            else
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 3);
                switch (number)
                {
                    case 1:
                        AIAmmo++;
                        return Action.Reload;
                    case 2:
                        return Action.Block;
                    case 3:
                        AIAmmo--;
                        return Action.Shoot;
                }

                return Action.Block;
            }


        }
    }
}
