﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3082
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1591


Imports Microsoft.VisualBasic
Imports System
Namespace LookUpEditDemo


	''' <summary>
	'''Represents a strongly typed in-memory cache of data.
	'''</summary>
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Global.System.Serializable(), Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"), Global.System.Xml.Serialization.XmlRootAttribute("DsStorage"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")> _
	Partial Public Class DsStorage
		Inherits System.Data.DataSet

		Private tableCountries As CountriesDataTable

		Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Sub New()
			Me.BeginInit()
			Me.InitClass()
			Dim schemaChangedHandler As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
			Me.EndInit()
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
			MyBase.New(info, context, False)
			If (Me.IsBinarySerialized(info, context) = True) Then
				Me.InitVars(False)
				Dim schemaChangedHandler1 As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
				AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
				AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
				Return
			End If
			Dim strSchema As String = (CStr(info.GetValue("XmlSchema", GetType(String))))
			If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
				Dim ds As New Global.System.Data.DataSet()
				ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
				If (ds.Tables("Countries") IsNot Nothing) Then
					MyBase.Tables.Add(New CountriesDataTable(ds.Tables("Countries")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
			End If
			Me.GetSerializationData(info, context)
			Dim schemaChangedHandler As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Countries() As CountriesDataTable
			Get
				Return Me.tableCountries
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.BrowsableAttribute(True), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)> _
		Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(ByVal value As System.Data.SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Overrides Function Clone() As Global.System.Data.DataSet
			Dim cln As DsStorage = (CType(MyBase.Clone(), DsStorage))
			cln.InitVars()
			cln.SchemaSerializationMode = Me.SchemaSerializationMode
			Return cln
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
			If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
				Me.Reset()
				Dim ds As New Global.System.Data.DataSet()
				ds.ReadXml(reader)
				If (ds.Tables("Countries") IsNot Nothing) Then
					MyBase.Tables.Add(New CountriesDataTable(ds.Tables("Countries")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
			Dim stream As New Global.System.IO.MemoryStream()
			Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
			stream.Position = 0
			Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Sub InitVars(ByVal initTable As Boolean)
			Me.tableCountries = (CType(MyBase.Tables("Countries"), CountriesDataTable))
			If (initTable = True) Then
				If (Me.tableCountries IsNot Nothing) Then
					Me.tableCountries.InitVars()
				End If
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitClass()
			Me.DataSetName = "DsStorage"
			Me.Prefix = ""
			Me.Namespace = "http://tempuri.org/DsStorage.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
			Me.tableCountries = New CountriesDataTable()
			MyBase.Tables.Add(Me.tableCountries)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Function ShouldSerializeCountries() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
			If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
				Me.InitVars()
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
			Dim ds As New DsStorage()
			Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
			Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
			Dim any As New Global.System.Xml.Schema.XmlSchemaAny()
			any.Namespace = ds.Namespace
			sequence.Items.Add(any)
			type.Particle = sequence
			Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
			If xs.Contains(dsSchema.TargetNamespace) Then
				Dim s1 As New Global.System.IO.MemoryStream()
				Dim s2 As New Global.System.IO.MemoryStream()
				Try
					Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
					dsSchema.Write(s1)
					Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
					Do While schemas.MoveNext()
						schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
						s2.SetLength(0)
						schema.Write(s2)
						If (s1.Length = s2.Length) Then
							s1.Position = 0
							s2.Position = 0
							Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

							Loop
							If (s1.Position = s1.Length) Then
								Return type
							End If
						End If
					Loop
				Finally
					If (s1 IsNot Nothing) Then
						s1.Close()
					End If
					If (s2 IsNot Nothing) Then
						s2.Close()
					End If
				End Try
			End If
			xs.Add(dsSchema)
			Return type
		End Function

		Public Delegate Sub CountriesRowChangeEventHandler(ByVal sender As Object, ByVal e As CountriesRowChangeEvent)

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class CountriesDataTable
			Inherits System.Data.DataTable
			Implements System.Collections.IEnumerable

			Private columnID As Global.System.Data.DataColumn

			Private columnName As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub New()
				Me.TableName = "Countries"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property IDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property NameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As CountriesRow
				Get
					Return (CType(Me.Rows(index), CountriesRow))
				End Get
			End Property

			Public Event CountriesRowChanging As CountriesRowChangeEventHandler

			Public Event CountriesRowChanged As CountriesRowChangeEventHandler

			Public Event CountriesRowDeleting As CountriesRowChangeEventHandler

			Public Event CountriesRowDeleted As CountriesRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub AddCountriesRow(ByVal row As CountriesRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function AddCountriesRow(ByVal ID As Integer, ByVal Name As String) As CountriesRow
				Dim rowCountriesRow As CountriesRow = (CType(Me.NewRow(), CountriesRow))
				Dim columnValuesArray() As Object = { ID, Name}
				rowCountriesRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowCountriesRow)
				Return rowCountriesRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function FindByID(ByVal ID As Integer) As CountriesRow
				Return (CType(Me.Rows.Find(New Object() { ID}), CountriesRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
				Return Me.Rows.GetEnumerator()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As CountriesDataTable = (CType(MyBase.Clone(), CountriesDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New CountriesDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub InitVars()
				Me.columnID = MyBase.Columns("ID")
				Me.columnName = MyBase.Columns("Name")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Private Sub InitClass()
				Me.columnID = New Global.System.Data.DataColumn("ID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnID)
				Me.columnName = New Global.System.Data.DataColumn("Name", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnName)
				Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() { Me.columnID}, True))
				Me.columnID.AllowDBNull = False
				Me.columnID.Unique = True
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function NewCountriesRow() As CountriesRow
				Return (CType(Me.NewRow(), CountriesRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New CountriesRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(CountriesRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.CountriesRowChangedEvent IsNot Nothing) Then
					RaiseEvent CountriesRowChanged(Me, New CountriesRowChangeEvent((CType(e.Row, CountriesRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.CountriesRowChangingEvent IsNot Nothing) Then
					RaiseEvent CountriesRowChanging(Me, New CountriesRowChangeEvent((CType(e.Row, CountriesRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.CountriesRowDeletedEvent IsNot Nothing) Then
					RaiseEvent CountriesRowDeleted(Me, New CountriesRowChangeEvent((CType(e.Row, CountriesRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.CountriesRowDeletingEvent IsNot Nothing) Then
					RaiseEvent CountriesRowDeleting(Me, New CountriesRowChangeEvent((CType(e.Row, CountriesRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub RemoveCountriesRow(ByVal row As CountriesRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New DsStorage()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "CountriesDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
		Partial Public Class CountriesRow
			Inherits System.Data.DataRow

			Private tableCountries As CountriesDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableCountries = (CType(Me.Table, CountriesDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property ID() As Integer
				Get
					Return (CInt(Fix(Me(Me.tableCountries.IDColumn))))
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableCountries.IDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property Name() As String
				Get
					Try
						Return (CStr(Me(Me.tableCountries.NameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Name' in table 'Countries' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCountries.NameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsNameNull() As Boolean
				Return Me.IsNull(Me.tableCountries.NameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetNameNull()
				Me(Me.tableCountries.NameColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
		Public Class CountriesRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As CountriesRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub New(ByVal row As CountriesRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Row() As CountriesRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class
	End Class
End Namespace

'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1591