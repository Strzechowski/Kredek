using System.Linq;
using System.Diagnostics;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ZadanieDomoweLab4
{
    /// <summary>
    /// Klasa do tworzenia naszych dokumentów
    /// </summary>
    public class Export
    {
        /// <summary>
        /// Funkcja pozwala zapisać tabelę DataGridView do pliku .csv
        /// </summary>
        /// <param name="table"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        public void PrintToCsv(DataGridView table, string name, string path)
        {
            string csvFile = "";
            foreach (DataGridViewColumn temporaryColumn in table.Columns)
            {
                csvFile += temporaryColumn.HeaderText + ",";
            }

            // chcemy usunąć ostatni przecinek
            // jeśli tabela byłaby pusta to dostalibyśmy błąd (dlatego jest if)
            if (csvFile.Length > 1)
                csvFile = csvFile.Remove(csvFile.Length - 1);
            csvFile += "\r\n";

            foreach (DataGridViewRow temporaryRow in table.Rows)
            {
                foreach (DataGridViewCell temporaryCell in temporaryRow.Cells)
                {
                    csvFile += temporaryCell.Value.ToString() + ",";
                }
                csvFile = csvFile.Remove(csvFile.Length - 1); 
                csvFile += "\r\n";
            }
            
            File.WriteAllText(path + name + ".csv", csvFile);
        }

        /// <summary>
        /// Funkcja tworzy plik pdf z informacją o wypłacie pracownika przy pomocy biblioteki PDFSharp
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        public void MakePdf(DataClassesZooDataBaseDataContext dataContext, int whichEmployee)
        {
            Employee employee = (from element in dataContext.Employees
                                 where element.Id == whichEmployee
                                 select element).FirstOrDefault();

            //Musimy zadeklarować parę zmiennych z biblioteki PDFSharp
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Wypłata";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);

            XFont fontBig = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont fontSmall = new XFont("Verdana", 14);

            if (employee != null)
            {
                //Teraz skorzystamy z graph.DrawString, który pozwala nam skomponować nasz plik PDF
                graph.DrawString("Wypłata", fontBig, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("Imię i nazwisko pracownika: " + employee.Name + " " + employee.Surname, fontSmall, XBrushes.Black, 0, 60);
                graph.DrawString("Pesel: " + employee.PESEL, fontSmall, XBrushes.Black, 0, 90);
                graph.DrawString("Wykonywana praca: " + employee.WorkType.Job, fontSmall, XBrushes.Black, 0, 120);
                graph.DrawString("Pensja: " + employee.WorkType.Salary, fontSmall, XBrushes.Black, 0, 150);

                string pdfFilename =  "Wyplata.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            else
            {
                MessageBox.Show("Podaj poprawne Id pracownika!");
            }
        }
    }
}
