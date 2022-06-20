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
    public partial class Level1Form : Form
    {
        public Level1Form()
        {
            InitializeComponent();
        }
        //Создаем экземпляр класса Lab
        Lab lab = new Lab();

        //Устанавливаем курсор в начало лабиринта при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(lab.StartGame(lblStart));
        }

        //Обрабатываем завершение лабиринта
        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //Обрабатываем задевание стен лабиринта
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            //Вызываем диалоговое окно с предложением начать игру снова
            int result = lab.FinishGame();
            //Если пользователь решил продолжить перемещаем курсор в начало уровня
            if (result == 1) Cursor.Position = PointToScreen(lab.StartGame(lblStart));
            //Иначе закрываем форму
            else DialogResult = DialogResult.Cancel;
        }
    }
}
