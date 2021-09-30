using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Factories
{
   public class ValidationData
    {
        #region Проверяем, что comboBox не пустой
        public void comboBox_TextChaged(string text, Button button_add)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                button_add.Enabled = false;
            }
            else
            {
                button_add.Enabled = true;
            }
        }
        #endregion
        #region ввод определенных знаков
        public void Enter_Number(char number, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        public void Enter_Number_And_Dot(char number, KeyPressEventArgs e)
        {
            
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
