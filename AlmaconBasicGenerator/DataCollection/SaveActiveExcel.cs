using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace AlmaconBasicGenerator.DataCollection
{
    public class SaveActiveExcel
    {
        public string saveActiveExcel(string modelPath, string fileName)
        {
            try
            {
                string filePath = @"W:\Almacon Tools\Design spreadsheets\Almacon Basic Systeem\";
                string excelConfigurator = "";
                bool workbookFound = false;

                var excelFiles = Directory.GetFiles(filePath, "*xlsx")
                    .Concat(Directory.GetFiles(filePath, "*xls"))
                    .Where(f => Path.GetFileName(f)
                .StartsWith("Berekening template Basic systeem"))
                    .Select(f => new FileInfo(f));
                var mostRecentFile = excelFiles.OrderByDescending(f => f.LastWriteTime).FirstOrDefault().Name;
                excelConfigurator = mostRecentFile.ToString();

                Excel.Application excelApp = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
                Excel.Workbooks workbooks = excelApp.Workbooks;

                foreach (Excel.Workbook workbook in workbooks)
                {
                    if (workbook.Name == excelConfigurator)
                    {
                        workbookFound = true;
                        workbook.SaveAs(modelPath + @"\ALM_Static_calculations\" + fileName + excelConfigurator);
                        return "Succes";
                    }
                }

                if (workbookFound == false)
                {
                    MessageBox.Show("Werkmap" + excelConfigurator + " is niet gevonden.");
                }
                return "Succes";
            }

            catch (Exception)
            {
                MessageBox.Show("De configurator is niet opgeslagen!");
                return "Failed";
            }
        }
    }
}
