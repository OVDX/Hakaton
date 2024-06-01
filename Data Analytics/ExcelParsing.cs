using Data_Analyst;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Analytics
{
    public class ExcelParsing
    {
        public static List<Product> ReadExcFile()
        {
            List<Product> products = new List<Product>();

            string filePath = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            FileInfo fileInfo = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                for (int row = 2; row <= rowCount-1; row++) // Починаємо з другого рядка, якщо в першому заголовки
                {
                    products.Add(new Product(worksheet.Cells[row, 3].Value?.ToString(), worksheet.Cells[row, 2].Value?.ToString(), DateTime.Parse(worksheet.Cells[row, 4].Text), double.Parse(worksheet.Cells[row, 6].Value?.ToString()), int.Parse(worksheet.Cells[row, 5].Value?.ToString()), worksheet.Cells[row, 1].Value?.ToString()));
                }
            }

            return products;
        }
    }
}
