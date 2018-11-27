using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, номер телефона
    /// </summary>
    public class PhoneNumber
    {
        private long _number;

        /// <summary>
        /// Метод, устанавливающий ограничение на номер телефона контакта
        /// </summary>
        public long Number
        {
            get { return _number; }
            set
            {
                //Первая цифра номера должна быть 7
                if (value < 70000000000 || value > 79999999999)
                {
                    throw new ArgumentException("Введите номер телефона, начинающийся с 7");
                }

                //Колличество цифр не должно привышать 11
                if (value > 99999999999)
                {
                    throw new ArgumentException("Вы ввели больше 11 цифр, введите номер из 11 цифр");
                }

                //Колличество цифр не должно быть меньше 11
                if (value < 10000000000)
                {
                    throw new ArgumentException("Вы ввели меньше 11 цифр, введите номер, состоящий из 11 цифр");
                }
                else
                    _number = value;
            }
        }
    }
}
