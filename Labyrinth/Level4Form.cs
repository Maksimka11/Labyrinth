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
    public partial class Level4Form : Form
    {
        public Level4Form()
        {
            InitializeComponent();
        }

        //Создаем экземпляр класса Lab
        Lab lab = new Lab();
        //Переменная для отслеживания поднятия ключа
        bool KeyTacked = false;
        //Переменная для отслеживания количества поднятых монет
        int TackedGold = 0;

        //Обрабатываем задевание стен лабиринта
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            //Вызываем диалоговое окно с предложением начать игру снова
            int result = lab.FinishGame();
            // Если пользователь решил продолжить
            if (result == 1)
            {
                //Перемещаем курсор в начало
                Cursor.Position = PointToScreen(lab.StartGame(lblStart));
                //Восстанавливаем элементы управления
                label18.Visible = true;
                label20.Visible = true;
                label27.Visible = true;
               label28.Visible = true;
                label17.Visible = true;
               label31.Visible = true;
                pictureBox1.Visible = true;
                label15.Visible = true;
                //Обнуляем прогресс взаимодействия с элементами 
                TackedGold = 0;
                KeyTacked = false;
            }
            //Иначе закрываем форму
            else DialogResult = DialogResult.Cancel;
        }

        //Обрабатываем завершение лабиринта
        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //Обрабатываем поднятие ключа
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //Записываем в переменную, что ключ был поднят
            KeyTacked = true;
            //Делаем ключ невидимым
            pictureBox1.Visible = false;
        }

        //Устанавливаем курсор в начало лабиринта при загрузке формы
        private void Level4Form_Load(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(lab.StartGame(lblStart));
        }

        //Обрабатываем поднятие монетки
        private void label18_MouseEnter(object sender, EventArgs e)
        {
            //Инкрементируем количество монет
            TackedGold++;
            //Делаем монету невидимой
            label18.Visible = false;
            //Проверяем количество поднях монет и если подняты все, то делаем дверь невидимой
            if (TackedGold == 6) { label15.Visible = false; }
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label31.Visible = false;
            if (TackedGold == 6) { label15.Visible = false; }
        }

        private void label28_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label28.Visible = false;
            if (TackedGold == 6) { label15.Visible = false; }
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label20.Visible = false;
            if (TackedGold == 6) {label15.Visible = false; }
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label27.Visible = false;
            if (TackedGold == 6) { label15.Visible = false; }
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label17.Visible = false;
            if (TackedGold == 6) { label15.Visible = false; }
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
                    label18.Visible = true;
                    label20.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    label17.Visible = true;
                    label31.Visible = true;
                    pictureBox1.Visible = true;
                    label15.Visible = true;
                    TackedGold = 0;
                }
                else DialogResult = DialogResult.Cancel;
            }
        }
    }
}
