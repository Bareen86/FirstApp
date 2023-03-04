using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    //  internal - виден внутри сборки
    //  private - виден только внутри класса
    internal class Person
    {
        private string _name;

        public Person()
        {

        }

        // Свойство с именем Get
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                // value - передаваемый параметр
                _name = value;
            }
        }

        public Person(string name)
        {
            _name = name;
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}
