using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;
using Newtonsoft.Json;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        private Contact _contact;
        private Project _project;

        [SetUp]
        public void InitComponent()
        {
            _project = new Project();

            //Контакт на проверку
            _contact = new Contact();
            _contact.Name = "alex";
            _contact.Surname = "smirnov";
            _contact.DateOfBirth = new DateTime(1955, 01, 18);
            _contact.Email = "alex.smirnov@mail.com";
            _contact.IdVk = "smit18";
            _contact.phoneNumber.Number = 79994444444;
        }

        /// <summary>
        /// Позитивный тест сериализации
        /// </summary>
        [Test(Description = "Тест сериализации")]
        public void TestSerialization()
        {


        }

        /// <summary>
        /// Позитивный тест десериализации
        /// </summary>
        [Test(Description = "Тест десериализации")]
        public void TestDeserilization_CorrectValue()
        {


        }
    }
}
