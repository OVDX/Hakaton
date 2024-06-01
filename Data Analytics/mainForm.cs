using Data_Analyst;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Media;
using LiveCharts.WinForms;

namespace Data_Analytics
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        List<Product> listOfProducts = new List<Product>();
        List<List<Product>> groupedByType = new List<List<Product>>();
        private void mainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            listOfProducts = ExcelParsing.ReadExcFile();
            groupedByType = Product.groupByType(listOfProducts);
            typeCmb.Items.Clear();
            var uniqueTypes = listOfProducts.Select(p => p.Type).Distinct().ToList();

            // Додавання унікальних типів до комбобоксу
            typeCmb.Items.Clear(); // Очистити комбобокс перед додаванням нових елементів
            typeCmb.Items.AddRange(uniqueTypes.ToArray());


            typeCmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            typeCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            typeCmb.AutoCompleteMode = AutoCompleteMode.Suggest;
            typeCmb.IntegralHeight = false;
            typeCmb.MaxDropDownItems = 5;

            nameCmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            nameCmb.AutoCompleteSource = AutoCompleteSource.ListItems;
            nameCmb.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameCmb.IntegralHeight = false;
            nameCmb.MaxDropDownItems = 5;
        }



        private void typeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameCmb.SelectedIndex = -1;
            nameCmb.Items.Clear();

            var productsWithType = groupedByType.FirstOrDefault(group => group.Any(product => product.Type == typeCmb.Text));

            if (productsWithType != null)
            {

                foreach (var product in productsWithType)
                {
                    if (!nameCmb.Items.Contains(product.Name))
                    {
                        nameCmb.Items.Add(product.Name);
                    }
                }
            }
        }
        private void nameCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameCmb.SelectedIndex != -1)
            {
                cartesianChart1.Visible = true;
                SeriesCollection seriesCollection1 = new SeriesCollection();
                var uniqueMonths = listOfProducts.Select(p => p.Date.Month).Distinct().ToList();
                var uniqueNames = listOfProducts.Select(p => p.Name).Distinct().ToList();
                CultureInfo ukrainianCulture = new CultureInfo("uk-UA");
                var monthLabels = new List<string>();

                foreach (var name in uniqueNames)
                {
                    if (name == nameCmb.Text)
                    {
                        var columnSeries = new ColumnSeries
                        {
                            Title = name,
                            Values = new ChartValues<int>()
                        };

                        foreach (var month in uniqueMonths)
                        {
                            var productsInMonthAndName = listOfProducts
                                .Where(p => p.Name == name && ukrainianCulture.DateTimeFormat.GetMonthName(p.Date.Month) == ukrainianCulture.DateTimeFormat.GetMonthName(month))
                                .ToList();

                            columnSeries.Values.Add(productsInMonthAndName.Count);
                            monthLabels.Add(ukrainianCulture.DateTimeFormat.GetMonthName(month));

                        }
                        seriesCollection1.Add(columnSeries);
                        cartesianChart1.AxisX.Clear();
                        cartesianChart1.AxisX.Add(new Axis
                        {
                            Labels = monthLabels
                        });
                    }
                }
                cartesianChart1.Series = seriesCollection1;
                cartesianChart1.Update();
                factors();
            }

            SeriesCollection seriesCollection = new SeriesCollection();
            SeriesCollection secondSeriesCollection = new SeriesCollection();

            List<string> place = new List<string>();
            List<int> count = new List<int>();
            List<double> price = new List<double>();

            for (int i = 0; i < listOfProducts.Count; i++)
            {
                if (listOfProducts[i].Name == nameCmb.Text)
                {
                    if (!place.Contains(listOfProducts[i].Street))
                    {
                        place.Add(listOfProducts[i].Street);
                        count.Add(listOfProducts[i].Count);
                        price.Add(listOfProducts[i].Price);
                    }
                    else
                    {
                        int index = place.IndexOf(listOfProducts[i].Street);
                        count[index] += listOfProducts[i].Count;
                        price[index] += listOfProducts[i].Price;
                    }
                }
            }
            for (int i = 1; i < count.Count; i++)
            {
                for (int j = 1; j < count.Count - (i - 1); j++)
                {
                    if (count[j] > count[j - 1])
                    {
                        SwapValues<int>(count, j, j - 1);
                        SwapValues<double>(price, j, j - 1);
                        SwapValues<string>(place, j, j - 1);
                    }
                }
            }

            seriesCollection.Add(new ColumnSeries
            {
                Title = "Count",
                Values = new ChartValues<int>(count),
                DataLabels = true
            });

            secondSeriesCollection.Add(new ColumnSeries
            {
                Title = "Price",
                Values = new ChartValues<double>(price),
                DataLabels = true
            });

            countPlace.Series = seriesCollection;
            countPlace.AxisX.Clear();
            countPlace.AxisY.Clear();
            countPlace.AxisX.Add(new Axis
            {
                Title = "Place",
                Labels = place
            });
            countPlace.AxisY.Add(new Axis
            {
                Title = "Count"
            });

            pricePlace.Series = secondSeriesCollection;
            pricePlace.AxisX.Clear();
            pricePlace.AxisY.Clear();
            pricePlace.AxisX.Add(new Axis
            {
                Title = "Place",
                Labels = place
            });
            pricePlace.AxisY.Add(new Axis
            {
                Title = "Price"
            });
        }
        public static void SwapValues<T>(List<T> source, int index1, int index2)
        {
            T temp = source[index1];
            source[index1] = source[index2];
            source[index2] = temp;
        }

        private void factors()
        {
            string type = typeCmb.Text;
            string name = nameCmb.Text;
            var monthLabels = new List<string>();
            CultureInfo ukrainianCulture = new CultureInfo("uk-UA");
            // Знайдемо групу продуктів за типом
            var productsWithType = groupedByType.FirstOrDefault(group => group.Any(product => product.Type == type));

            if (productsWithType == null)
            {
                MessageBox.Show("Продуктів з обраним типом не знайдено.");
                return;
            }

            // Загальна кількість продуктів за всі місяці
            int countAll = productsWithType.Sum(product => product.Count);

            // Розрахунок середньої кількості за місяць
            double averageAllMonth = countAll / 6.0;

            // Унікальні місяці
            var uniqueMonths = productsWithType.Select(p => p.Date.Month).Distinct().ToList();

            List<double> ratios = new List<double>();
            cartesianChart1.Visible = true;
            SeriesCollection seriesCollection1 = new SeriesCollection();

            // Колонка для діаграми
            var columnSeries = new ColumnSeries
            {
                Title = name,
                Values = new ChartValues<double>()
            };

            foreach (var uniqueMonth in uniqueMonths)
            {
                // Загальна кількість продуктів за конкретний місяць
                int countForMonth = productsWithType.Where(p => ukrainianCulture.DateTimeFormat.GetMonthName(p.Date.Month) == ukrainianCulture.DateTimeFormat.GetMonthName(uniqueMonth)).Sum(p => p.Count);

                // Відношення до середньої кількості, перетворене у відсотки
                monthLabels.Add(ukrainianCulture.DateTimeFormat.GetMonthName(uniqueMonth));
                double ratio = Math.Round((countForMonth / averageAllMonth) * 100, 2);
                ratios.Add(ratio);
            }

            foreach (var ratio in ratios)
            {
                columnSeries.Values.Add(ratio);
            }

            seriesCollection1.Add(columnSeries);

            cartesianChart2.Series = seriesCollection1;

            // Налаштування осі Y для відображення у відсотках
            cartesianChart2.AxisY.Clear();
            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Відсотки",
                LabelFormatter = value => value + "%"
     
            }) ;

            // Оновлення діаграми
            cartesianChart2.Update();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
