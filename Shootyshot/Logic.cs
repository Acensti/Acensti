using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shootyshot
{
    public class Logic
    {
        public enum Actions
        {
            Reload,
            Shoot,
            Block,
            Shotgun,
        }

        public enum Winner
        {
            Player,
            Ai,
            None,
        }


        public static Winner OngoingActions(Actions AiChoices, Actions PlayerAction)
        {


            if (PlayerAction == Actions.Shotgun)
            {
                return Winner.Player;
            }
          
            if (AiChoices == Actions.Shotgun)
            {
                return Winner.Ai;

            }
            if (PlayerAction == Actions.Shotgun && AiChoices == Actions.Shoot)
            {
                return Winner.Player;
            }

            if (PlayerAction == Actions.Shoot && AiChoices != Actions.Block)
            {
                return Winner.Player;
            }

            if (PlayerAction != Actions.Block && AiChoices == Actions.Shoot)
            {
                return Winner.Ai;
            }
           
            
         
            return Winner.None;


        }

        public static void Endgame(Winner winner)
        {

             if (winner == Winner.Player)
            {
                MessageBox.Show("You won");
            }
           else if (winner == Winner.Ai)
            {
                MessageBox.Show("You lost :c");
            }
           else
            {
                MessageBox.Show("none won :c");

            }




        }
    }
}
