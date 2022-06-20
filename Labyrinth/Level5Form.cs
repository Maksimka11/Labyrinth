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
    public partial class Level5Form : Form
    {
        public Level5Form()
        {
            InitializeComponent();
        }
        //Создаем экземпляр класса Lab
        Lab lab = new Lab();
        //Переменная для отслеживания поднятия ключа
        bool KeyTacked = false;
        //Отслеживание направления движения стен
        bool Label23Down = true;
        bool Label24Down = false;
        bool Label31Left = true;
        //Переменная для отслеживания количества поднятых монет
        int TackedGold = 0;

        //Обрабатываем задевание стен лабиринта
        private void label23_MouseEnter(object sender, EventArgs e)
        {
            //Вызываем диалоговое окно с предложением начать игру снова
            int result = lab.FinishGame();
            // Если пользователь решил продолжить
            if (result == 1)
            {
                //Перемещаем курсор в начало
                Cursor.Position = PointToScreen(lab.StartGame(lblStart));
                //Восстанавливаем элементы управления
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                pictureBox1.Visible = true;
                label21.Visible = true;
                //Обнуляем прогресс взаимодействия с элементами 
                TackedGold = 0;
                KeyTacked = false;
            }
            else DialogResult = DialogResult.Cancel;
        }


        //Обрабатываем поднятие ключа
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //Записываем в переменную, что ключ был поднят
            KeyTacked = true;
            //Делаем ключ невидимым
            pictureBox1.Visible = false;
        }

        //Каждую секунду некоторые стены лабиринта меняют свою видимость
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Visible = !label9.Visible;
            label22.Visible = !label22.Visible;
            label4.Visible = !label4.Visible;
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //Обрабатываем задевание двери
        private void label20_MouseEnter(object sender, EventArgs e)
        {
            //Если ключ не был поднят то обрабатываем задевание двери, как задевание стены
            if (KeyTacked == false)
            {
                int result = lab.FinishGame();
                if (result == 1)
                {
                    Cursor.Position = PointToScreen(lab.StartGame(lblStart));
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    label19.Visible = true;
                    label30.Visible = true;
                    pictureBox1.Visible = true;
                    label21.Visible = true;
                    TackedGold = 0;
                    

                }
                else DialogResult = DialogResult.Cancel;
            }
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label29.Visible = false;
            if (TackedGold == 6) { label21.Visible = false; }
        }

        private void label28_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label28.Visible = false;
            if (TackedGold == 6) { label21.Visible = false; }
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label27.Visible = false;
            if (TackedGold == 6) { label21.Visible = false; }
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label26.Visible = false;
            if (TackedGold == 6) { label21.Visible = false; }
        }

        private void label30_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label30.Visible = false;
            if (TackedGold == 6) { label21.Visible = false; }
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label25.Visible = false;
            if (TackedGold == 6) { label21.Visible = false; }
        }

        //Устанавливаем курсор в начало лабиринта при загрузке формы
        private void Level5Form_Load(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(lab.StartGame(lblStart));
        }
        
        //Каждые 50мс некоторые стены лабиринта передвигаются в заданном направлении
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Label23Down == true)
            {
                label23.Location = new Point(label23.Location.X, label23.Location.Y + 1);
                if (label23.Location == new Point(132, 322)) Label23Down = false;
            }
            else
            {
                label23.Location = new Point(label23.Location.X, label23.Location.Y - 1);
                if (label23.Location == new Point(132, 85)) Label23Down = true;
            }

            if (Label24Down == true)
            {
                label24.Location = new Point(label24.Location.X, label24.Location.Y + 1);
                if (label24.Location == new Point(132, 322)) Label24Down = false;
            }
            else
            {
                label24.Location = new Point(label24.Location.X, label24.Location.Y - 1);
                if (label24.Location == new Point(132, 85)) Label24Down = true;
            }

            if(Label31Left == true)
            {
                label31.Location = new Point(label31.Location.X-1, label31.Location.Y);
                if (label31.Location == new Point(243, 170)) Label31Left = false;
            }
            else
            {
                label31.Location = new Point(label31.Location.X + 1, label31.Location.Y);
                if (label31.Location == new Point(367, 170)) Label31Left = true;
            }

        }
    }
}
