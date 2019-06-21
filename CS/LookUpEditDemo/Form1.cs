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

        DataTable table;
        private void Form1_Load(object sender, EventArgs e) {
            table = CreateTable();
            FillComboBox();
            SetupLookup();
        }

        DataTable CreateTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));

            dataRow = table.NewRow();
            dataRow["ID"] = 840;
            dataRow["Name"] = "US";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ID"] = 124;
            dataRow["Name"] = "Canada";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ID"] = 36;
            dataRow["Name"] = "Australia";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ID"] = 826;
            dataRow["Name"] = "UK";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["ID"] = 554;
            dataRow["Name"] = "New Zealand";
            table.Rows.Add(dataRow);

            return table;
        }

        public void FillComboBox() {
            foreach(DataRow Row in table.Rows) {
                comboBoxEdit1.Properties.Items.Add(Row["Name"]);
            }
            comboBoxEdit1.Properties.Sorted = true;
        }

        public void SetupLookup() {
            lookUpEdit1.Properties.DataSource = table;
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.ValueMember = "ID";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Country", 100);
            col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            lookUpEdit1.Properties.Columns.Add(col);
        }

    }
}