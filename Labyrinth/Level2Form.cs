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
    public partial class Level2Form : Form
    {
        public Level2Form()
        {
            InitializeComponent();
        }

        //Переменная для отслеживания поднятия ключа
        bool KeyTacked = false;

        //Создаем экземпляр класса Lab
        Lab lab = new Lab();

        //Обрабатываем задевание стен лабиринта
        private void Level2Form_MouseEnter(object sender, EventArgs e)
        {
            //Вызываем диалоговое окно с предложением начать игру снова
            int result = lab.FinishGame();
            //Если пользователь решил продолжить
            if (result == 1)
            {
                //Перемещаем курсор в начало
                Cursor.Position = PointToScreen(lab.StartGame(lblStart));
                //Восстанавливаем элементы управления
                pictureBox1.Visible = true;
                KeyTacked = false;

            }
            //Иначе закрываем форму
            else DialogResult = DialogResult.Cancel;
        }

        //Обрабатываем завершение лабиринта
        private void lblFinish_MouseEnter_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        //Устанавливаем курсор в начало лабиринта при загрузке формы
        private void Level2Form_Load_1(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(lab.StartGame(lblStart));

        }

        //Обрабатываем поднятие ключа
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //Делаем ключ невидимым
            pictureBox1.Visible = false;
            //Записываем в переменную, что ключ был поднят
            KeyTacked = true;

        }

        //Обрабатываем задевание двери
        private void label16_MouseEnter(object sender, EventArgs e)
        {
            //Если ключ не был поднят то обрабатываем задевание двери, как задевание стены
            if (KeyTacked == false)
            {
                int result = lab.FinishGame();
                if (result == 1)
                {
                    Cursor.Position = PointToScreen(lab.StartGame(lblStart));
                    pictureBox1.Visible = true;
                }
                else DialogResult = DialogResult.Cancel;
            }
        }
    }
}
