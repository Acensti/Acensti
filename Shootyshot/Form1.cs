﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Shootyshot
{
    public partial class Form1 : Form
    {
        public enum Action
        {
            Reload,
            Shoot,
            Block,
            Shotgun,
        }

        private int AIAmmo = 0;
        private int UserAmmo = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            UserAmmo--;
            if (UserAmmo < 1)
            {
                btnShot.Enabled = false;
            }

            if (UserAmmo < 3)
            {
                btnShotgun.Enabled = false;
            }
            Action UserAction = Action.Shoot;
            Action AIAction = AiActions();
            OngoingActions(AIAction, UserAction);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disables shoot and shotgun

        }

        

        private void btnBlock_Click(object sender, EventArgs e)
        {
            Action UserAction = Action.Block;
            Action AIAction = AiActions();
            OngoingActions(AIAction, UserAction);
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            MessageBox.Box("You have dumpstered shitter");
            Action UserAction = Action.Shotgun;
            Action AIAction = AiActions();
            OngoingActions(AIAction, UserAction);
        }

       

        private void textBoxPlayerAction_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void GameView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UserAmmo++;
            if (UserAmmo >= 1)
            {
                btnShot.Enabled = true;
            }

            if (UserAmmo >= 3)
            {
                btnShotgun.Enabled = true;
            }
            Action UserAction = Action.Reload;
            Action AIAction = AiActions();
            OngoingActions(AIAction, UserAction);
        }

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
