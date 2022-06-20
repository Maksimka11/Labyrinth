using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Обработка нажатия на кнопку btnLevel1
        private void btnLevel1_Click(object sender, EventArgs e)
        {
            //Открываем форму с первым уровнем лабиринта
            Level1Form level1 = new Level1Form();
            level1.ShowDialog();
            
        }
        //Обработка нажатия на кнопку btnLevel2
        private void btnLevel2_Click(object sender, EventArgs e)
        {
            //Открываем форму со вторым уровнем лабиринта
            Level2Form level2 = new Level2Form();
            level2.ShowDialog();
        }

        //Обработка нажатия на кнопку btnLevel2
        private void btnLevel3_Click(object sender, EventArgs e)
        {
            //Открываем форму с третьим уровнем лабиринта
            Level3Form level3 = new Level3Form();
            level3.ShowDialog();
            
        }

        //Обработка нажатия на кнопку btnLevel2
        private void btnLevel4_Click(object sender, EventArgs e)
        {
            //Открываем форму с четвертым уровнем лабиринта
            Level4Form level4 = new Level4Form();
            level4.ShowDialog();
        }

        //Обработка нажатия на кнопку btnLevel2
        private void btnLevel5_Click(object sender, EventArgs e)
        {
            //Открываем форму с пятым уровнем лабиринта
            Level5Form level5 = new Level5Form();
            level5.ShowDialog();
        }

        //Обработка нажатия на кнопку btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Закрываем приложение
            Application.Exit();
        }
    }
}
