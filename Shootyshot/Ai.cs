using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shootyshot.Logic;
namespace Shootyshot
{
    public class Ai
    {
       
        public Ai()
        {
            character = new Character();    
        }
        public Character character;
        public int AIAmmo = 0;
       
        public Actions AiActions() //Mechanical choices the ai commits
        {
            if (AIAmmo == 3)
            {
                return Actions.Shotgun;
            }
            else if (AIAmmo == 0)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 2);
                switch (number)
                {
                    case 1:
                        AIAmmo++;
                        return Actions.Reload;
                    case 2:
                        return Actions.Block;
                }
                return Actions.Block;


            }
            else
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 3);
                switch (number)
                {
                    case 1:
                        AIAmmo++;
                        return Actions.Reload;
                    case 2:
                        return Actions.Block;
                    case 3:
                        AIAmmo--;
                        return Actions.Shoot;
                }

                return Actions.Block;
            }


        }
    }
}
