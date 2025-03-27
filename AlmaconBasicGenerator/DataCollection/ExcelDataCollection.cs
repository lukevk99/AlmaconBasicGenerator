using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace AlmaconBasicGenerator.DataCollection
{
    public class ExcelDataCollection
    {
        public string CollectData(int rowNumber, int columnNumber, string excelConfigurator)
        {
            Excel.Application excelApp = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            Excel.Workbooks workbooks = excelApp.Workbooks;

            foreach (Excel.Workbook workbook in workbooks)
            {
                if (workbook.Name ==  excelConfigurator)
                {
                    Excel.Workbook excelWB = excelApp.Workbooks[excelConfigurator];
                    Excel.Worksheet excelWS = (Excel.Worksheet)excelWB.Worksheets[2];
                    Excel.Range excelRange = excelWS.Cells[rowNumber, columnNumber];

                    string cellValue = excelRange.Value?.ToString() ?? "Geen waarde in cel";

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWB);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWS);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                    return cellValue;
                }
            }
            return "Failed";
        }
    }
}