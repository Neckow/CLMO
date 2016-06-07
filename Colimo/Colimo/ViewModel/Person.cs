using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colimo.ViewModel
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
    }
    public class Rootobject
    {
        public Person[] people { get; set; }
    }
}
