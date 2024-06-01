using Microsoft.Win32;
using OfficeOpenXml;
using System.Dynamic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Data_Analyst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
		public void ReadExcFile(object sender, RoutedEventArgs e)
		{
			string filePath = "";
			OpenFileDialog openFileDialog = new()
			{
				InitialDirectory = "c:\\",
				Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
				FilterIndex = 1,
				RestoreDirectory = true
			};
			if (openFileDialog.ShowDialog() == true)
			{
				filePath = openFileDialog.FileName;
			}
			if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
			{
				MessageBox.Show("Please select a valid Excel file.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			FileInfo fileInfo = new(filePath);
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			var data = new List<ExpandoObject>();

			using (ExcelPackage package = new(fileInfo))
			{
				ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

				// Generate DataGrid columns based on the header row
				for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
				{
					dataGrid.Columns.Add(new DataGridTextColumn
					{
						Header = worksheet.Cells[1, col].Text,
						Binding = new Binding($"Column{col}")
					});
					System.Diagnostics.Trace.WriteLine(dataGrid.Columns[col - 1].Header); // виводить назву стовбця в консоль дебагу
				}
				

				// Iterate through rows and add to the list
				for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
				{
					dynamic expandoRow = new ExpandoObject();
					var expandoDict = (IDictionary<string, object>)expandoRow;

					for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
					{
						expandoDict[$"Column{col}"] = worksheet.Cells[row, col].Text;
					}

					data.Add(expandoRow);
				}
			}

			dataGrid.ItemsSource = data;
		}
	}
}