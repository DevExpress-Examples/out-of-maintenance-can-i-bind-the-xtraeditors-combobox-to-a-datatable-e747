Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace LookUpEditDemo
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			FillDataSet()
			FillComboBox()
			SetupLookup()
		End Sub
		Private Sub FillDataSet()
			dsStorage1.Countries.AddCountriesRow(840, "US")
			dsStorage1.Countries.AddCountriesRow(124, "Canada")
			dsStorage1.Countries.AddCountriesRow(36, "Australia")
			dsStorage1.Countries.AddCountriesRow(826, "UK")
			dsStorage1.Countries.AddCountriesRow(554, "New Zealand")
		End Sub

		Public Sub FillComboBox()
			For Each Row As DataRow In dsStorage1.Countries.Rows
				comboBoxEdit1.Properties.Items.Add(Row("Name"))
			Next Row
			comboBoxEdit1.Properties.Sorted = True
		End Sub

		Public Sub SetupLookup()
			lookUpEdit1.Properties.DataSource = dsStorage1.Countries
			lookUpEdit1.Properties.DisplayMember = "Name"
			lookUpEdit1.Properties.ValueMember = "ID"
			Dim col As DevExpress.XtraEditors.Controls.LookUpColumnInfo
			col = New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Country", 100)
			col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
			lookUpEdit1.Properties.Columns.Add(col)
		End Sub

	End Class
End Namespace