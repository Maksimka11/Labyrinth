using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public class Lab
    {
        //Перемещает курсор в начало  уровня
        public Point StartGame(Label lblStart)
        {
            Point point;
            point = lblStart.Location;
            point.Offset(lblStart.Width / 2, lblStart.Height / 2);
            return point;
            
        }

        //Метод оповещает о проигрыше и предлагает перезапустить уровение
        public int FinishGame()
        {
            DialogResult dr = MessageBox.Show("Вы проиграли! Хотите попробовать снова?", "Поражение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) return 1;
            else return 0;
        }


    }
}
