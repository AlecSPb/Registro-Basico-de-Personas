using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using AppSfDataGrid.Models;
using System.IO;
using Microsoft.Win32;

namespace AppSfDataGrid.Core
{
    public class FileExcel
    {
        public FileExcel() {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public static async Task Export(PersonCollection person) {
            SaveFileDialog saveFile = new();
            try {
                if(saveFile.ShowDialog() == true) {
                    FileInfo fileInfo = new FileInfo(saveFile.FileName + ".xlsx");
                    using var package = new ExcelPackage(fileInfo);
                    var ws = package.Workbook.Worksheets.Add("Registro-Personas");
                    var rango = ws.Cells["A1"].LoadFromCollection(person,true);
                    rango.AutoFitColumns();
                    await package.SaveAsync();
                }
            } catch {
            }
        }

        public static async Task<List<Person>> Import() {

            OpenFileDialog saveFile = new();
            List<Person> listPerson = new();
            try {
                if(saveFile.ShowDialog() == true) {
                    FileInfo fileInfo = new FileInfo(saveFile.FileName);
                    using var package = new ExcelPackage(fileInfo);
                    await package.LoadAsync(fileInfo);
                    var ws = package.Workbook.Worksheets[PositionID: 0];
                    int fila = 2, columna = 1;

                    while(string.IsNullOrWhiteSpace(ws.Cells[fila,columna].Value?.ToString()) == false) {
                        Person person = new Person();
                        person.Id = ws.Cells[fila,columna].Value.ToString();
                        person.name = ws.Cells[fila,columna + 1].Value.ToString();
                        person.surName = ws.Cells[fila,columna + 2].Value.ToString();
                        person.edad = ws.Cells[fila,columna + 3].Value.ToString();
                        person.telefone = ws.Cells[fila,columna + 4].Value.ToString();
                        person.department = ws.Cells[fila,columna + 5].Value.ToString();
                        listPerson.Add(person);
                        fila++;
                    }
                }
            } catch { }
            return listPerson;
        }
    }
}
