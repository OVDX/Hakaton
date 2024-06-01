using Microsoft.Win32;
using OfficeOpenXml;
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
			using (ExcelPackage package = new(fileInfo))
			{
				ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
			}
		}
	}
}