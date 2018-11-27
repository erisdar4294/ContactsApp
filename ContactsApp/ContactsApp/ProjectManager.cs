using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Класс, реализующий сохранение данных в файл и загрузки из него
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        /// <param name="_partToFile">Путь к файлу</param>
        /// <param name="contact">Сериализуемый класс</param>
        private static string _partToFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                                      "/ContactsApp" + "/ContactsApp.notes";

        /// <summary>
        /// Метод, выполняющий запись в файл
        /// </summary>
        /// <param name="notes">Экземпляр проекта для сериализации</param>
        public static void Serialization(Project contact)
        {
            // Экземпляр сериалиатора
            JsonSerializer serializer = new JsonSerializer();

            // Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(_partToFile))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                // Вызов сериализатора и передача объекта сериализации
                serializer.Serialize(writer, contact);
            }
        }

        /// <summary>
        /// Метод, выполняющий чтение из файла (десериализация)
        /// </summary>
        /// <returns>Экземпляр проекта, считанный из файла</returns>
        public static Project Deserialization(string _partToFile)
        {
            //Переменная, в которую будет помещен результат десериализации
            Project project = null;

            //Экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(_partToFile))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                project = (Project)serializer.Deserialize(reader);
            }

            return project;
        }
    }
}