using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class fMain : Form
    {
        CEmblem[] emblems;
        int EmblemCount = 0;
        int CurrentEmblemIndex;
        public fMain()
        {
            InitializeComponent();
            emblems = new CEmblem[100];
        }

        private void BtnCreateNew_Click(object sender, EventArgs e)
        {
            if (EmblemCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }
            Graphics graphics = pnMain.CreateGraphics();
            CurrentEmblemIndex = EmblemCount;

            // Створення нового об'єкта - екземпляра класу CEmblem     
            emblems[CurrentEmblemIndex] = new CEmblem(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            emblems[CurrentEmblemIndex].Show();
            EmblemCount++;

            cbEmblems.Items.Add("Емблема №" + (EmblemCount - 1).ToString());
            cbEmblems.SelectedIndex = EmblemCount - 1;
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Приховування поточного об'єкта - екземпляра класу CEmblem  
            emblems[CurrentEmblemIndex].Hide();
            // --------------------------------------------------------------- 
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Відображення поточного об'єкта     
            emblems[CurrentEmblemIndex].Show();
            // --------------------------------------------------------------- 
        }

        private void BtnExpand_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Розширення поточного об'єкта - екземпляра класу CEmblem  
            emblems[CurrentEmblemIndex].Expand(5);
            // --------------------------------------------------------------- 
        }

        private void BtnCollapse_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------     
            // Стискання поточного об'єкта - екземпляра класу CEmblem     
            emblems[CurrentEmblemIndex].Collapse(5);
            // --------------------------------------------------------------- 
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Переміщення вверх поточного об'єкта     
            emblems[CurrentEmblemIndex].Move(0, -10);
            // ---------------------------------------------------------------
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Переміщення вниз поточного об'єкта     
            emblems[CurrentEmblemIndex].Move(0, 10);
            // ---------------------------------------------------------------
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Переміщення вправо поточного об'єкта     
            emblems[CurrentEmblemIndex].Move(10, 0);
            // ---------------------------------------------------------------
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Переміщення вліво поточного об'єкта 
            emblems[CurrentEmblemIndex].Move(-10, 0);
            // --------------------------------------------------------------- 
        }

        private void BtnRightFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Переміщення поточного об'єкта вправо на більшу відстань     
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
            // ---------------------------------------------------------------  
        }

        private void BtnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Переміщення поточного об'єкта вліво на більшу відстань     
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
            // --------------------------------------------------------------- 
        }

        private void BtnUpFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Переміщення поточного об'єкта вверх на більшу відстань     
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, -
        1); System.Threading.Thread.Sleep(5);
            }
            // ---------------------------------------------------------------
        }

        private void BtnDownFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbEmblems.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;

            // ---------------------------------------------------------------  
            // Переміщення поточного об'єкта вниз на більшу відстань     
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
            // --------------------------------------------------------------- 
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
