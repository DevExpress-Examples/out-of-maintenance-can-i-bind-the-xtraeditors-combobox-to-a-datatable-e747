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

		Private table As DataTable
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			table = CreateTable()
			FillComboBox()
			SetupLookup()
		End Sub

		Private Function CreateTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow

			table.Columns.Add("ID", GetType(Integer))
			table.Columns.Add("Name", GetType(String))

			dataRow = table.NewRow()
			dataRow("ID") = 840
			dataRow("Name") = "US"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("ID") = 124
			dataRow("Name") = "Canada"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("ID") = 36
			dataRow("Name") = "Australia"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("ID") = 826
			dataRow("Name") = "UK"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("ID") = 554
			dataRow("Name") = "New Zealand"
			table.Rows.Add(dataRow)

			Return table
		End Function

		Public Sub FillComboBox()
			For Each Row As DataRow In table.Rows
				comboBoxEdit1.Properties.Items.Add(Row("Name"))
			Next Row
			comboBoxEdit1.Properties.Sorted = True
		End Sub

		Public Sub SetupLookup()
			lookUpEdit1.Properties.DataSource = table
			lookUpEdit1.Properties.DisplayMember = "Name"
			lookUpEdit1.Properties.ValueMember = "ID"
			Dim col As DevExpress.XtraEditors.Controls.LookUpColumnInfo
			col = New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Country", 100)
			col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
			lookUpEdit1.Properties.Columns.Add(col)
		End Sub

	End Class
End Namespace