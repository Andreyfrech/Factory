using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    class Text
    {
        public string ComboBox_Count
        {
            get
            {
                return "Один завод выпускает одну продукцию, у каждой продукции свой вес\n\nКоличество заводов = количество продуктов = количество вес продукта = 4\n\nКоличество грузовиков = 3";
            }
        }

        public string No_Data
        {
            get
            {
                return "Не все поля заполнены";
            }
        }

        public string M
        {
            get
            {
                return "M должно быть больше или равно 100";
            }
        }

        public string Product_Per_Hour
        {
            get
            {
                return "Объем продукции в час должен быть больше или равен 50";
            }
        }
    }
}
