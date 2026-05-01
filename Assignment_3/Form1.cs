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
        string CSVFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void ActivateDataView()
        {
            DataTable dtNew = new DataTable();
            dtNew = CSVToDataTable(CSVFilePath);

            mainDataView.DataSource = dtNew;
            mainDataView.Refresh();
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
    }

    //struct to handle products
    public struct Product
    {
        int ID;
        string productName;
        string productBrand;
        float price;
        string description;
        string color;

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
