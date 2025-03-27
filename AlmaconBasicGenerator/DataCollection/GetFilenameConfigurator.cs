using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmaconBasicGenerator.DataCollection
{
    internal class GetFilenameConfigurator
    {
        public string ReturnFilename ()
        {
            string filePath = @"W:\Almacon Tools\Design spreadsheets\Almacon Basic Systeem\";

            var excelFiles = Directory.GetFiles(filePath, "*xlsx")
                .Concat(Directory.GetFiles(filePath, "*xls"))
                .Where(f => Path.GetFileName(f)
            .StartsWith("Berekening template Basic systeem"))
                .Select(f => new FileInfo(f));
            var mostRecentFile = excelFiles.OrderByDescending(f => f.LastWriteTime).FirstOrDefault().Name;
            string excelConfigurator = mostRecentFile.ToString();
            return excelConfigurator;
        }
    }
}
