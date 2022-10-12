using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shootyshot
{
    public class Logic
    {
        public enum Action
        {
            Reload,
            Shoot,
            Block,
            Shotgun,
        }

        private void OngoingActions(Action AiChoices, Action PlayerAction)
        {

            if (AiChoices == Action.Shotgun)
            {
                //Game over
            }

            if (PlayerAction == Action.Shoot && AiChoices != Action.Block)
            {
                // Player win
            }

            if (PlayerAction != Action.Block && AiChoices == Action.Shoot)
            {
                //
            }


        }
    }
}
