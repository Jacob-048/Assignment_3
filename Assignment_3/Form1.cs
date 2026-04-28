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
        public Form1()
        {
            InitializeComponent();

            mainDataView.Columns.Add("ID", "ID");
            mainDataView.Columns.Add("ProductName", "Name");
            mainDataView.Columns.Add("ProductBrand", "Brand");
            mainDataView.Columns.Add("ProductPrice", "Price");
            mainDataView.Columns.Add("ProductDescription", "Description");
            mainDataView.Columns.Add("ProductColor", "Colour");

            DataTable dtNew = new DataTable();
            dtNew = CSVToDataTable("H:/Programming/Product_Catalogue.csv");
        }

        public DataTable CSVToDataTable(string path)
        {
            DataTable csvData = new DataTable();


            return csvData;
        }

        private void mainDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
