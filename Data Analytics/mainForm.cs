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
                            // Фільтруємо продукти за поточну назву та місяць
                            var productsInMonthAndName = listOfProducts
                                .Where(p => p.Name == name && p.Date.Month == month)
                                .ToList();

                            // Додаємо кількість продуктів у місяць для поточної назви продукту
                            columnSeries.Values.Add(productsInMonthAndName.Count);
                        }

                        // Додаємо створений рядок даних до колекції
                        seriesCollection1.Add(columnSeries);
                    }
                }

                cartesianChart1.Series = seriesCollection1;
                cartesianChart1.Update();
            }

            SeriesCollection seriesCollection = new SeriesCollection();
			SeriesCollection secondSeriesCollection = new SeriesCollection();

			List<string> place = new List<string>();
			List<int> count = new List<int>();
            List<double> price = new List<double>();

			for (int i = 0; i < listOfProducts.Count; i++)
			{
				if (!place.Contains(listOfProducts[i].Street))
				{
					place.Add(listOfProducts[i].Street);
					count.Add(listOfProducts[i].Count);
                    price.Add(listOfProducts[i].Price);
				}
				else
				{
					count[place.IndexOf(listOfProducts[i].Street)] += listOfProducts[i].Count;
                    price[place.IndexOf(listOfProducts[i].Street)] += listOfProducts[i].Price;
				}
			}

			for (int i = 0; i < place.Count; i++)
			{
				seriesCollection.Add(new PieSeries
				{
					Title = place[i],
					Values = new ChartValues<int> { count[i] },
					DataLabels = true
				});
                secondSeriesCollection.Add(new PieSeries
				{
					Title = place[i],
					Values = new ChartValues<double> { price[i] },
					DataLabels = true
				});
			}

			countPlace.Series = seriesCollection;
            pricePlace.Series = secondSeriesCollection;
		}
    }
}
