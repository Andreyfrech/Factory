using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Factories
{
    public class factory
    {
        // Form1 form = new Form1();
        public string result = "";
        //Объем производства в час для каждого завода
        public List<double> Capacity = new List<double>();
        //Объем производства для всех заводов
        public double SumCapacity = 0;
        //Вместимость склада
        public double Storage = 0;
        //Вместимость каждого грузовика
        public List<int> TruckSize = new List<int>();
        //Количество перевезенных едениц товара
        public int Truck = 0;
        public List<int> TruckL = new List<int>();
        //Вместимость всех грузовиков
        public int SumTruck = 0;
        //Заполнение склада на 95%
        public double Delivery = 0;
        //Процентное соотнешени вместимости грузовик от общего объема грузовиков
        public double percent = 0;
        //Количество рейсов
        public double voyage = 0;
        //Вес
        public double weight = 0;
        //Общий вес продукции завода
        public List<double> TotalWeight = new List<double>();
         //Количество рейсов
        public List<double> VoyageTruck = new List<double>();

        public void Parameters(int M, int N, ComboBox comboBox_Factory, ComboBox comboBox_Weight, ComboBox comboBox_Product, ComboBox comboBox_Truck)
        {
            double j = 1;
            for (int i = 0; i < comboBox_Factory.Items.Count; i++)
            {
                    Capacity.Insert(i, Math.Round(j*N, 2));
                j += 0.1;
                SumCapacity += Capacity[i];
                weight = Convert.ToDouble(comboBox_Weight.Items[i]);
                TotalWeight.Insert(i, Math.Round(weight * Capacity[i], 2));
            }

            Storage = M * SumCapacity;
            Delivery = Storage * 95 / 100;

            for(int i = 0; i < comboBox_Truck.Items.Count; i++)
            {
                int p = Convert.ToInt32(comboBox_Truck.Items[i].ToString());
                TruckSize.Insert(i, p );
                SumTruck += Convert.ToInt32(comboBox_Truck.Items[i]);
            }
            for(int i = 0; i < TruckSize.Count; i++)
            {
                percent = TruckSize[i] * 100 / SumTruck;
                voyage = Math.Ceiling(Delivery * percent / 100 / TruckSize[i]);
                Truck = Convert.ToInt32(Delivery * percent / 100);

                TruckL.Insert(i, Truck);
                VoyageTruck.Insert(i, voyage);
            }
        }

        public string ReleaseProduct_a(object fact, object count)
        {
                for (int i = 0; i < (double)count; i++)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(0.1));
                    return result = "" + fact + i;
                }
            return result;
        }
    }
}
