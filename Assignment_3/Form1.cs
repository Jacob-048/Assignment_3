using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        string CSVFilePath;

        public Form1()
        {
            InitializeComponent();
            string temp = FindSavedCSV();
            if(temp != "")
            {
                CSVFilePath = temp;
                ActivateDataView();
            }
        }

        private void ActivateDataView()
        {
            DataTable dtNew = new DataTable();
            dtNew = CSVToDataTable(CSVFilePath);

            mainDataView.DataSource = dtNew;
            mainDataView.Refresh();
        }

        public List<Product> CSVToProductList(string path)
        {
            List<Product> prod = new List<Product>();

            try
            {
                if(path.EndsWith(".csv"))
                {
                    using(StreamReader sr = new StreamReader(path))
                    {
                        //read the first line to skip the headers
                        sr.ReadLine();

                        Product newProduct = new Product();

                        while(!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split(',');

                            for(int i = 0; i < line.Length; i++)
                            {
                                
                                switch(i)
                                {
                                    //ID
                                    case 0:
                                        newProduct.ID = int.Parse(line[i]);
                                        break;
                                    //Name
                                    case 1:
                                        newProduct.productName = line[i];
                                        break;
                                    //Brand
                                    case 2:
                                        newProduct.productBrand = line[i];
                                        break;
                                    //Price
                                    case 3:
                                        newProduct.price = double.Parse(line[i]);
                                        break;
                                    //Description
                                    case 4:
                                        newProduct.description = line[i];
                                        break;
                                    //Color
                                    case 5:
                                        newProduct.color = line[i];
                                        break;
                                    default:
                                        break;

                                }
                            }

                            prod.Add(newProduct);
                        }
                    }
                }
            }
            catch
            {

            }

            return prod;
        }

        public DataTable CSVToDataTable(string path)
        {
            DataTable csvData = new DataTable();

            try
            {
                //checks if it is a .csv file
                if(path.EndsWith(".csv"))
                {
                    //reads the file with stream reader
                    using (StreamReader sr = new StreamReader(path))
                    {
                        //Comma seperated values - gets the headers on the first line
                        string[] headers = sr.ReadLine().Split(',');
                        for (int i = 0; i < headers.Length; i++)
                        {
                            csvData.Columns.Add(headers[i]);
                        }

                        //reads the other rows of the .csv
                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(',');
                            DataRow dr = csvData.NewRow();
                            for (int i = 0; i < rows.Length; i++)
                            {
                                dr[i] = rows[i];
                            }

                            csvData.Rows.Add(dr);
                        }
                    }                    
                }
            }
            catch (Exception e)
            {
                csvData.Columns.Add(e.Message);
            }

            return csvData;
        }

        private void mainDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CSVFindButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CSVFilePath = openFileDialog1.FileName;
            }

            ActivateDataView();
        }

        private string FindSavedCSV()
        {
            string foundPath = "";

            string temp = Application.StartupPath + @"\\saved.csv";
            if(File.Exists(temp))
            {
                foundPath = temp;
            }

            return foundPath;  
        }
    }

    //struct to handle products
    public struct Product
    {
        public int ID;
        public string productName;
        public string productBrand;
        public double price;
        public string description;
        public string color;

        public Product(int newID, string newName, string newBrand, float newPrice, string newDescription, string newColor)
        {
            ID = newID;
            productName = newName;
            productBrand = newBrand;
            price = newPrice;
            description = newDescription;
            color = newColor;
        }
    }
}
