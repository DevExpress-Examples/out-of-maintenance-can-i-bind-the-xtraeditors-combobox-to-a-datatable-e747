using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LookUpEditDemo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FillDataSet();
            FillComboBox();
            SetupLookup();
        }
        private void FillDataSet() {
            dsStorage1.Countries.AddCountriesRow(840, "US");
            dsStorage1.Countries.AddCountriesRow(124, "Canada");
            dsStorage1.Countries.AddCountriesRow(36, "Australia");
            dsStorage1.Countries.AddCountriesRow(826, "UK");
            dsStorage1.Countries.AddCountriesRow(554, "New Zealand");
        }

        public void FillComboBox() {
            foreach(DataRow Row in dsStorage1.Countries.Rows) {
                comboBoxEdit1.Properties.Items.Add(Row["Name"]);
            }
            comboBoxEdit1.Properties.Sorted = true;
        }

        public void SetupLookup() {
            lookUpEdit1.Properties.DataSource = dsStorage1.Countries;
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.ValueMember = "ID";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Country", 100);
            col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            lookUpEdit1.Properties.Columns.Add(col);
        }

    }
}