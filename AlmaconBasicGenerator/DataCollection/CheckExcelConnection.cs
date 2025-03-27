using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

namespace AlmaconBasicGenerator.DataCollection
{
    public class CheckExcelConnection
    {
        public string checkExcelConnection()
        {
            string filePath = @"W:\Almacon Tools\Design spreadsheets\Almacon Basic Systeem\";
            bool workbookFound = false;
            bool excelIsRunning=false;
            Excel.Application excelApp = new Excel.Application();

            if (Process.GetProcessesByName("EXCEL") != null)
            {
                excelIsRunning = true;
            }

            else
            {
                excelApp.Visible = true;
                excelIsRunning = true;
            }

            if (excelIsRunning == false)
            {
                Environment.Exit(0);
            }

            var excelFiles = Directory.GetFiles(filePath, "*xlsx")
               .Concat(Directory.GetFiles(filePath, "*xls"))
               .Where(f => Path.GetFileName(f)
           .StartsWith("Berekening template Basic systeem"))
               .Select(f => new FileInfo(f));
            var mostRecentFile = excelFiles.OrderByDescending(f => f.LastWriteTime).FirstOrDefault().Name;
            string excelConfigurator = mostRecentFile.ToString();

            try
            {
                excelApp = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
                Excel.Workbooks workbooks = excelApp.Workbooks;

                foreach (Excel.Workbook workbook in workbooks)
                {
                    if (workbook.Name == excelConfigurator)
                    {
                        workbookFound = true;
                        return "Succes";
                    }
                }

                if (workbookFound == false)
                {
                    MessageBox.Show("Werkmap '" + excelConfigurator + "' is niet gevonden.", "Config niet gevonden");

                    if (MessageBox.Show("Wilt u de configurator openen?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        workbookFound = true;
                        excelApp.Visible = true;
                        excelApp.Workbooks.Open(filePath + excelConfigurator);

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                        return "Succes";
                    }

                    else
                    {
                        return "Failed";
                    }
                }
                return "Succes";
            }

            catch (Exception)
            {
                MessageBox.Show("Er is een fout opgetreden, proces wordt gestopt");
                return "Failed";
            }
        }
    }
}
