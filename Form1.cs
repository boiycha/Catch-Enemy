using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brick_Game
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
            lOver.Hide();
            
        }

        bool left, right;
        int x;
        int score;
        Random rnd = new Random();
        int life;

        void LifeIndex()
        {
            if (life == 1)
            {
                pLife1.Image = Properties.Resources.icons8_spade_suit_48;
            }
            if (life == 2)
            {
                pLife2.Image = Properties.Resources.icons8_spade_suit_48;
            }
            if (life == 3)
            {
                pLife3.Image = Properties.Resources.icons8_spade_suit_48;
                lOver.Show();
                timer1.Stop();

                
            }
        }

        void GameUpdate()
        {
            if (player.Bounds.IntersectsWith(enemy.Bounds))
            {
                enemy.Location = new Point(x, 0);
                enemy.Top -= 200;
                life += 1;
                LifeIndex();
            }
        }

        void EnemyMove()
        {
            enemy.Top += 6;
            if (enemy.Top > 400)
            {
                score++;
                lScore.Text = "Score : " + score;
                x = rnd.Next(0, 300);
                enemy.Location = new Point(x, 0);
            }
        }
        void PlayerMove()
        {
            if (right)
            {
                player.Left += 5;
            }
            if (left)
            {
                player.Left -= 5;
            }
        }
        private void Form1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            PlayerMove();
            EnemyMove();
            GameUpdate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }
    }
}
