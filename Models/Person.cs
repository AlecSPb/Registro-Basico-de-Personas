using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSfDataGrid.Models
{
    public class PersonCollection:ObservableCollection<Person>
    {
    }

    public class Person
    {
        public string Id {
            get; set;
        }

        public string name {
            get; set;
        }

        public string surName {
            get; set;
        }

        public string edad {
            get; set;
        }

        public string telefone {
            get; set;
        }

        public string department {
            get; set;
        }

        public Person() {
        }

        public Person(string Id) {
            this.Id = Id;
        }

        public Person(string Id,string name) {
            this.Id = Id;
            this.name = name;
        }

        public Person(string Id,string name,string surName) {
            this.Id = Id;
            this.name = name;
            this.surName = surName;
        }

        public Person(string Id,string name,string surName,string edad) {
            this.Id = Id;
            this.name = name;
            this.surName = surName;
            this.edad = edad;
        }

        public Person(string Id,string name,string surName,string edad,string telefone) {
            this.Id = Id;
            this.name = name;
            this.surName = surName;
            this.edad = edad;
            this.telefone = telefone;
        }

        public Person(string Id,string name,string surName,string edad,string telefone,string department) {
            this.Id = Id;
            this.name = name;
            this.surName = surName;
            this.edad = edad;
            this.telefone = telefone;
            this.department = department;
        }
    }
}
