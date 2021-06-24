using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSfDataGrid.Models;
using AppSfDataGrid.Core;
using System.Windows;
using System.Windows.Input;

namespace AppSfDataGrid.ViewModel
{
    public class PersonViewModel:INotify
    {
        private Person personSelect;
        private ICommand buttonNewRow;
        private ICommand buttonDeleteRow;
        private ICommand buttonSaveExcel;
        private ICommand buttonOpenExcel;
        private ICommand buttonDelete;
        private List<String> listDepartamentos;
        private PersonCollection personCollection;

        public PersonViewModel() {
            personCollection = new();
            listDepartamentos = new();
            LoadDepartement();
        }

        public Person PersonSelect {
            get => personSelect;
            set {
                personSelect = value;
                RaisePropertyChange("PersonSelect");
            }
        }

        public List<string> ListDepartamentos {
            get => listDepartamentos;
            set => listDepartamentos = value;
        }

        public PersonCollection _PersonCollecion {
            get => personCollection;
            set {
                personCollection = value;
                RaisePropertyChange("_PersonCollecion");
            }
        }

        public ICommand ButtonSaveExcel {
            get {
                buttonSaveExcel = new RelayCommand(new Action(SaveExcel));
                return buttonSaveExcel;
            }
        }

        public ICommand ButtonOpenExcel {
            get {
                buttonOpenExcel = new RelayCommand(new Action(OpenExcel));
                return buttonOpenExcel;
            }
        }

        public ICommand ButtonNewRow {
            get {
                buttonNewRow = new RelayCommand(new Action(NewRow));
                return buttonNewRow;
            }
        }

        public ICommand ButtonDeleteRow {
            get {
                buttonDeleteRow = new RelayCommand(new Action(DeleteRow));
                return buttonDeleteRow;
            }
        }

        public ICommand ButtonDelete {
            get {
                buttonDelete = new RelayCommand(new Action(Clear));
                return buttonDelete;
            }
        }

        private void NewRow() {
            personCollection.Add(new Person() { Id = (personCollection.Count < 0) ? "1" : "" + (personCollection.Count + 1) });
        }

        public async void SaveExcel() => await FileExcel.Export(personCollection);

        public async void OpenExcel() {
            personCollection.Clear();
            foreach(var a in await FileExcel.Import()) {
                personCollection.Add(a);
            }
        }

        private void DeleteRow() {
            if(personSelect != null) {
                personCollection.Remove(personSelect);
                List<Person> listPerson = new List<Person>();
                int n = 1;
                foreach(var a in personCollection) {
                    listPerson.Add(new Person() {
                        Id = n.ToString(),
                        name = a.name,
                        surName = a.surName,
                        edad = a.edad,
                        telefone = a.telefone,
                        department = a.department
                    });
                    n++;
                }
                n = 0;
                personCollection.Clear();
                foreach(var a in listPerson) {
                    personCollection.Add(a);
                }
                listPerson.Clear();
            }
        }

        private void LoadDepartement() {
            listDepartamentos.Add("Managua");
            listDepartamentos.Add("Masaya");
            listDepartamentos.Add("Matagalpa");
            listDepartamentos.Add("Rivas");
            listDepartamentos.Add("Chinandega");
            listDepartamentos.Add("Leon");
            listDepartamentos.Add("Granada");
            listDepartamentos.Add("Madriz");
            listDepartamentos.Add("Esteli");
            listDepartamentos.Add("Jinotega");
            listDepartamentos.Add("Chontales");
            listDepartamentos.Add("RAAN");
            listDepartamentos.Add("RAAS");
            listDepartamentos.Add("Boaco");
            listDepartamentos.Sort();
        }

        public void Clear() {
            personCollection.Clear();
        }
    }
}
