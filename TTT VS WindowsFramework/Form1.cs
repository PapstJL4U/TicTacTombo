using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.controller;
using model;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        CSpiel Spiel = null;
        System.Windows.Forms.Button[,] MyButtons = null;
        Dictionary<Farbe, Color> KVFarbe = new Dictionary<Farbe, Color>
        {
            { Farbe.Weiss, Color.White},
            { Farbe.Schwarz, Color.Black },
            { Farbe.Blau, Color.Blue },
            { Farbe.Rot, Color.Red},
            { Farbe.Lila, Color.Purple },
        };


        Label[] Wins = null;
        public Form1()
        {
            InitializeComponent();
            MyButtons = new System.Windows.Forms.Button[,]
            {
                { bt_00, bt_01, bt_02 },
                { bt_10, bt_11, bt_12 },
                { bt_20, bt_21, bt_22 }
            };

            foreach (Button bt in MyButtons)
            {
                bt.Text = "";
                bt.Enabled = true;
                bt.BackColor = Color.Transparent;
            }

            Wins = new Label[] { lb_spieler1_won, lb_spieler2_won };
        }

        public void setController(CSpiel Controller)
        {
            Spiel = Controller;
        }
        private void lb_Spieler1_Click(object sender, EventArgs e)
        {

        }

        private void bt_00_Click(object sender, EventArgs e)
        {
            button_pressed(0, 0, sender, e);
        }

        private void bt_01_Click(object sender, EventArgs e)
        {
            button_pressed(0, 1, sender, e);
        }

        private void bt_02_Click(object sender, EventArgs e)
        {
            button_pressed(0, 2, sender, e);
        }

        private void bt_10_Click(object sender, EventArgs e)
        {
            button_pressed(1, 0, sender, e);
        }

        private void bt_11_Click(object sender, EventArgs e)
        {
            button_pressed(1, 1, sender, e);
        }

        private void bt_12_Click(object sender, EventArgs e)
        {
            button_pressed(1, 2, sender, e);
        }

        private void bt_20_Click(object sender, EventArgs e)
        {
            button_pressed(2, 0, sender, e);
        }

        private void bt_21_Click(object sender, EventArgs e)
        {
            button_pressed(2, 1, sender, e);
        }

        private void bt_22_Click(object sender, EventArgs e)
        {
            button_pressed(2, 2, sender, e);
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            foreach (Button bt in MyButtons)
            {
                bt.Enabled = true;
                bt.BackColor = Color.Transparent;
            }

            Spiel.neuesSpiel();
        }

        private void button_pressed(int row, int col, object sender, EventArgs e)
        {
            Spiel.pressedButton(row, col);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void gewonnenesSpiel(String Spielername, int SpielerID, int wins)
        {
            tb_output.Text = $"{Spielername} hat gewonnen.";
            Wins[SpielerID].Text = wins.ToString();
            foreach (Button bt in MyButtons)
            {
                bt.Enabled = false;
            }
        }

        public void setSpielernamen(ISpieler sp1, ISpieler sp2)
        {
            lb_Spieler1.Text = sp1.getSpielerName();
            bt_farbe_1.Text = "";
            bt_farbe_1.BackColor = KVFarbe[sp1.getSpielerfarbe()];

            lb_Spieler2.Text = sp2.getSpielerName();
            bt_farbe_2.Text = "";
            bt_farbe_2.BackColor = KVFarbe[sp2.getSpielerfarbe()];

            pb_arrow.Image = MyImages.Images[0];
        }

        public void setButton(int row, int col, Farbe farbe)
        {
            System.Windows.Forms.Button Button = MyButtons[row, col];
            Button.BackColor = KVFarbe[farbe];
            Button.Enabled = false;
        }

        private void lb_spieler1_won_Click(object sender, EventArgs e)
        {

        }

        internal void setArrow(int anDerReihe)
        {
            pb_arrow.Image = MyImages.Images[anDerReihe];
        }

        private void pb_arrow_Click(object sender, EventArgs e)
        {

        }
    }
}
