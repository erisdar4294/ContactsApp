using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс, содержащий контакт
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Фамилия контакта
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя контакта
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        public PhoneNumber _phoneNumber = new PhoneNumber();

        /// <summary>
        /// Дата рождения контакта
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// E-mail контакта
        /// </summary>
        private string _email;

        /// <summary>
        /// ID Vkontakte контакта
        /// </summary>
        private string _idVk;

        /// <summary>
        /// Метод, устанавливающий ограничения на фамилию контакта
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                //Фамилия не может быть длиннее 50 символов
                if (value.Length > 50)
                {
                    throw new ArgumentException("Введите фамилию, длиной менее 50 символов");
                }

                //Проверка на пустую строку
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку. Повторите ввод");
                }
                else
                    _surname = value;
            }
        }

        /// <summary>
        /// Метод, устанавливающий ограничения на имя контакта
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                //Имя не может быть длиннее 50 символов
                if (value.Length > 50)
                {
                    throw new ArgumentException("Введите имя, длиной менее 50 символов");
                }

                //Проверка на пустую строку
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку. Повторите ввод");
                }
                else
                    _name = value;
            }
        }

        /// <summary>
        /// Метод, устанавливающий ограничения на номер телефона контакта
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        /// <summary>
        /// Ограничение на устанавливаемую дату рождения (минимум 1 января 1900)
        /// </summary>
        private DateTime _dateMinimum = new DateTime(1900, 01, 01);

        /// <summary>
        /// Метод, устанавливающий ограничения на дату рождения контакта.
        /// </summary>
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                //Дата рождения не может быть раньше 1 января 1900 года
                if (value < _dateMinimum)
                {
                    throw new ArgumentException( "Введенная дата не может быть раньше 1900 года");
                }

                //Дата рождения не может быть больше нынешней даты
                if (value > DateTime.Today)
                {
                    throw new ArgumentException(" Дата рождения не может быть позже нынешней");
                }
                else
                    _birthday = value;
            }
        }

        /// <summary>
        /// Метод, устанавливающий ограничения на E-mail контакта
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                //E-mail не может быть длиннее 50 символов
                if (value.Length > 50)
                {
                    throw new ArgumentException("Введите e-mail, длиной менее 50 символов");
                }

                //Проверка на пустую строку
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку. Повторите ввод");
                }
                else
                    _email = value;
            }
        }

        /// <summary>
        /// Метод, устанавливающий ограничения на ID Vkontakte контакта
        /// </summary>
        public string IdVk
        {
            get { return _idVk; }
            set
            {
                //ID не может быть длиннее 15 символов
                if (value.Length > 15)
                {
                    throw new ArgumentException("Введите ID, длиной менее 15 символов");
                }

                //Проверка на пустую строку
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку. Повторите ввод");
                }
                else
                    _idVk = value;
            }
        }


        public Contact()
        { }

        public Contact(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }

        /// <summary>
        /// Реализация интерфейса ICloneable (клонирование) для имен и фамилий
        /// </summary>
        public object Clone()
        {
            return new Contact(Name, Surname);
        }

    }
}