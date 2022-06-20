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
    public partial class Level3Form : Form
    {
        public Level3Form()
        {
            InitializeComponent();
        }
        //Создаем экземпляр класса Lab
        Lab lab = new Lab();

        //Переменная для отслеживания количества поднятых монет
        int TackedGold = 0;

        //Обрабатываем задевание стен лабиринта
        private void Level3Form_MouseEnter(object sender, EventArgs e)
        {
            //Вызываем диалоговое окно с предложением начать игру снова
            int result = lab.FinishGame();
            // Если пользователь решил продолжить
            if (result == 1)
            {
                //Перемещаем курсор в начало
                Cursor.Position = PointToScreen(lab.StartGame(lblStart));
                //Восстанавливаем элементы управления
                label31.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                //Обнуляем количество поднятых монет
                TackedGold = 0;
            }
            //Иначе закрываем форму
            else DialogResult = DialogResult.Cancel;
        }

        //Обрабатываем завершение лабиринта
        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //Устанавливаем курсор в начало лабиринта при загрузке формы
        private void Level3Form_Load(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(lab.StartGame(lblStart));
        }

        //Обрабатываем поднятие монетки
        private void label26_MouseEnter(object sender, EventArgs e)
        {
            //Инкрементируем количество монет
            TackedGold++;
            //Делаем монету невидимой
            label26.Visible = false;
            //Проверяем количество поднях монет и если подняты все, то делаем дверь невидимой
            if (TackedGold == 5) label31.Visible = false; 
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {

            TackedGold++;
            label27.Visible = false;
            if (TackedGold == 5) label31.Visible = false; 
        }

        private void label28_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
           label28.Visible = false;
            if (TackedGold == 5) label31.Visible = false;
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label29.Visible = false;
            if (TackedGold == 5)label31.Visible = false;
        }

        private void label30_MouseEnter(object sender, EventArgs e)
        {
            TackedGold++;
            label30.Visible = false;
            if (TackedGold == 5) label31.Visible = false; 
        }
    }
}
