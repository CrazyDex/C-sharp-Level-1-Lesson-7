using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Evdokhin Denis
namespace HwT1
{
    public partial class FGame : Form
    {
        public FGame()
        {
            InitializeComponent();
            //------------------------
            controls = new List<Button>() { ButPlus, ButMulti, ButPrev, ButClear };
            UnActive();
            //------------------------
        }

        //код игры
        Random random = new Random();
        int win;
        int clbut;
        Stack<string> actions = new Stack<string>();
        List<Button> controls;

        void Doing(int clbut)
        {
            switch (clbut)
            {
                case 0:
                    actions.Push(LabCur.Text);
                    LabCur.Text = Convert.ToString(Convert.ToInt32(LabCur.Text) + 1);
                    LabAct.Text = Convert.ToString(Convert.ToInt32(LabAct.Text) + 1);
                    WinTest();
                    return;
                case 1:
                    actions.Push(LabCur.Text);
                    LabCur.Text = Convert.ToString(Convert.ToInt32(LabCur.Text) * 2);
                    LabAct.Text = Convert.ToString(Convert.ToInt32(LabAct.Text) + 1);
                    WinTest();
                    return;
                case 2:
                    if (actions.Count > 0)
                    {
                        LabCur.Text = actions.Pop();
                        LabAct.Text = Convert.ToString(Convert.ToInt32(LabAct.Text) - 1);
                    }
                    return;
            }
        }

        void WinTest()
        {
            if (Convert.ToInt32(LabCur.Text) == win) { MessageBox.Show("You win!");  UnActive(); }
            else if (Convert.ToInt32(LabCur.Text) > win) { MessageBox.Show("You lose!"); UnActive(); }
        }

        void Active()
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Enabled = true;
            }
        }
        void UnActive()
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Enabled = false;
            }
            actions.Clear();
        }
        // конец

        private void ButPlus_Click(object sender, EventArgs e)
        {
            clbut = 0;
            Doing(clbut);
        }

        private void ButMulti_Click(object sender, EventArgs e)
        {
            clbut = 1;
            Doing(clbut);
        }

        private void ButPrev_Click(object sender, EventArgs e)
        {
            clbut = 2;
            Doing(clbut);
        }

        private void MenNG_Click(object sender, EventArgs e)
        {
            Active();
            LabCur.Text = "1";
            LabAct.Text = "0";
            win = random.Next(10, 20);
            this.Text = "Набери: " + win.ToString();
        }

        private void MenExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            Active();
            LabCur.Text = "1";
            LabAct.Text = "0";
            actions.Clear();
        }
    }
}
