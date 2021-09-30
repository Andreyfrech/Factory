using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factories
{
    public partial class Form1 : Form
    {
        ValidationData validation = new ValidationData();
        Text text = new Text();
        factory fact = new factory(); 
        char number;
        public Form1()
        {
            InitializeComponent();
        }
        #region Установка цвета текста
        public void richTextBox_Error_Color()
        {
            richTextBox_Result.ForeColor = Color.Red;
        }

        public void richTextBox_Default_Color()
        {
            richTextBox_Result.ForeColor = Color.Black;
        }
        #endregion
        #region Проверяем, что comboBox не пустой

        private void comboBox_Factory_TextChanged(object sender, EventArgs e)
        {
           validation.comboBox_TextChaged(comboBox_Factory.Text, button_add_Factory);
        }

        private void comboBox_Weight_TextChanged(object sender, EventArgs e)
        {
            validation.comboBox_TextChaged(comboBox_Weight.Text, button_Add_Weight);
        }

        private void comboBox_Product_TextChanged(object sender, EventArgs e)
        {
            validation.comboBox_TextChaged(comboBox_Product.Text, button_Add_Product);
        }

        private void comboBox_Truck_TextChanged(object sender, EventArgs e)
        {
            validation.comboBox_TextChaged(comboBox_Truck.Text, button_Add_Truck);
        }

        #endregion

        #region Добавляем названия элементов в comboBox
        public void comboBox_Items_Add(ComboBox comboBox)
        {
            if (!comboBox.Items.Contains(comboBox.Text))
            {
                comboBox.Items.Add(comboBox.Text);
                comboBox.Text = null;
            }
        }
        
        private void button_add_Factory_Click(object sender, EventArgs e)
        {
            comboBox_Items_Add(comboBox_Factory);
        }

        private void button_Add_Weight_Click(object sender, EventArgs e)
        {
            comboBox_Items_Add(comboBox_Weight);
        }

        private void button_Add_Product_Click(object sender, EventArgs e)
        {
            comboBox_Items_Add(comboBox_Product);
        }

        private void button_Add_Truck_Click(object sender, EventArgs e)
        {
            comboBox_Items_Add(comboBox_Truck);
        }
        #endregion
        #region Проверяем ввод определенных знаков
        private void textBox_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            number = e.KeyChar;
            validation.Enter_Number(number, e);
        }

        private void comboBox_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            number = e.KeyChar;
            validation.Enter_Number_And_Dot(number, e);
        }

        private void textBox_N_KeyPress(object sender, KeyPressEventArgs e)
        {
            number = e.KeyChar;
            validation.Enter_Number(number, e);
        }

        private void comboBox_Truck_KeyPress(object sender, KeyPressEventArgs e)
        {
            number = e.KeyChar;
            validation.Enter_Number(number, e);
        }
        #endregion

        private void button_Result_Click(object sender, EventArgs e)
        {
            if (comboBox_Factory.Items.Count != 4 || comboBox_Product.Items.Count != 4 || comboBox_Weight.Items.Count != 4 || comboBox_Truck.Items.Count != 2) 
            {
                richTextBox_Error_Color();
                richTextBox_Result.Text = text.ComboBox_Count;
                return;
            }

            if (!String.IsNullOrWhiteSpace(textBox_M.Text) && !String.IsNullOrWhiteSpace(textBox_N.Text) && comboBox_Factory.Items.Count > 0 && comboBox_Product.Items.Count > 0 && comboBox_Truck.Items.Count > 0 && comboBox_Weight.Items.Count > 0)
            {
                if (Convert.ToInt32(textBox_M.Text) < 100)
                {
                    richTextBox_Error_Color();
                    richTextBox_Result.Text = text.M;
                    return;
                }

                if (Convert.ToInt32(textBox_N.Text) < 50)
                {
                    richTextBox_Error_Color();
                    richTextBox_Result.Text = text.Product_Per_Hour;
                    return;
                }
              
                // Расчет параметров 
                fact.Parameters(Convert.ToInt32(textBox_M.Text), Convert.ToInt32(textBox_N.Text), comboBox_Factory, comboBox_Weight, comboBox_Product, comboBox_Truck);
          
                new Thread(delegate () { ReleaseProduct_a(comboBox_Product.Items[0], fact.Capacity[0]); }).Start();
                new Thread(delegate () { ReleaseProduct_a(comboBox_Product.Items[1], fact.Capacity[1]); }).Start();
                new Thread(delegate () { ReleaseProduct_a(comboBox_Product.Items[2], fact.Capacity[2]); }).Start();
                new Thread(delegate () { ReleaseProduct_a(comboBox_Product.Items[3], fact.Capacity[3]); }).Start();

                richTextBox_Default_Color();
                richTextBox_Result.Text = null;
                richTextBox_Result1.Text = null;
                richTextBox_Result.Text += "Общая вместимость склада: " + fact.Storage + "\n\nПри заполнении склада на 95% (" + fact.Delivery + ") производится отправка в торговые сети " + fact.TruckSize.Count + " грузовиками.";
                richTextBox_Result.Text += "\n\nПервый грузовик вместимостью " + fact.TruckSize[0] + " сделает " + fact.VoyageTruck[0] + " поездки и перевезет " + fact.TruckL[0] + " ед. в том числе " + fact.Capacity[0] + " ед. товара " + comboBox_Product.Items[0] + " и " + fact.Capacity[1] + " ед. товара " + comboBox_Product.Items[1];
                richTextBox_Result.Text += "\n\nВторой грузовик вместимостью " + fact.TruckSize[1] + " сделает " + fact.VoyageTruck[1] + " поездки и перевезет " + fact.TruckL[1] + " ед. в том числе " + fact.Capacity[2] + " ед. товара " + comboBox_Product.Items[2] + " и " + fact.Capacity[3] + " ед. товара " + comboBox_Product.Items[3];
                richTextBox_Result.Text += "\n\nЗавод " + comboBox_Factory.Items[0] + ": Объем выпуска - " + fact.Capacity[0] + " ед./час, общий вес партии - " + fact.TotalWeight[0] + " кг";
                richTextBox_Result.Text += "\nЗавод " + comboBox_Factory.Items[1] + ": Объем выпуска - " + fact.Capacity[1] + " ед./час, общий вес партии - " + fact.TotalWeight[1] + " кг";
                richTextBox_Result.Text += "\nЗавод " + comboBox_Factory.Items[2] + ": Объем выпуска - " + fact.Capacity[2] + " ед./час, общий вес партии - " + fact.TotalWeight[2] + " кг";
                richTextBox_Result.Text += "\nЗавод " + comboBox_Factory.Items[3] + ": Объем выпуска - " + fact.Capacity[3] + " ед./час, общий вес партии - " + fact.TotalWeight[3] + " кг";

            }
            else
            {
                richTextBox_Error_Color();
                richTextBox_Result.Text = text.No_Data;
            }
        }
        public void ReleaseProduct_a(object prod, object count)
        {
            {
                
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    for (int i = 1; i <= (double)count; i++)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.04));
                        richTextBox_Result1.Text += "  " + prod + "-" + i;
                        richTextBox_Result1.SelectionStart = richTextBox_Result1.TextLength;
                        richTextBox_Result1.ScrollToCaret();
                        this.Update();
                    }
                });
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            comboBox_Factory.Items.Clear();
            comboBox_Product.Items.Clear();
            comboBox_Truck.Items.Clear();
            comboBox_Weight.Items.Clear();
        }
    }
}
