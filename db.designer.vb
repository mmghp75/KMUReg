﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="KMUReg")>  _
Partial Public Class dbDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttblUser(instance As tblUser)
    End Sub
  Partial Private Sub UpdatetblUser(instance As tblUser)
    End Sub
  Partial Private Sub DeletetblUser(instance As tblUser)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("KMURegConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tblShamsiMiladis() As System.Data.Linq.Table(Of tblShamsiMiladi)
		Get
			Return Me.GetTable(Of tblShamsiMiladi)
		End Get
	End Property
	
	Public ReadOnly Property tblUsers() As System.Data.Linq.Table(Of tblUser)
		Get
			Return Me.GetTable(Of tblUser)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblShamsiMiladi")>  _
Partial Public Class tblShamsiMiladi
	
	Private _Miladi As Date
	
	Private _Shamsi As String
	
	Private _Shamsi_YearOf As Integer
	
	Private _Shamsi_MonthOf As Integer
	
	Private _Shamsi_DayOf As Integer
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Miladi", DbType:="DateTime NOT NULL")>  _
	Public Property Miladi() As Date
		Get
			Return Me._Miladi
		End Get
		Set
			If ((Me._Miladi = value)  _
						= false) Then
				Me._Miladi = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Shamsi", DbType:="NVarChar(20) NOT NULL", CanBeNull:=false)>  _
	Public Property Shamsi() As String
		Get
			Return Me._Shamsi
		End Get
		Set
			If (String.Equals(Me._Shamsi, value) = false) Then
				Me._Shamsi = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Shamsi_YearOf", DbType:="Int NOT NULL")>  _
	Public Property Shamsi_YearOf() As Integer
		Get
			Return Me._Shamsi_YearOf
		End Get
		Set
			If ((Me._Shamsi_YearOf = value)  _
						= false) Then
				Me._Shamsi_YearOf = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Shamsi_MonthOf", DbType:="Int NOT NULL")>  _
	Public Property Shamsi_MonthOf() As Integer
		Get
			Return Me._Shamsi_MonthOf
		End Get
		Set
			If ((Me._Shamsi_MonthOf = value)  _
						= false) Then
				Me._Shamsi_MonthOf = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Shamsi_DayOf", DbType:="Int NOT NULL")>  _
	Public Property Shamsi_DayOf() As Integer
		Get
			Return Me._Shamsi_DayOf
		End Get
		Set
			If ((Me._Shamsi_DayOf = value)  _
						= false) Then
				Me._Shamsi_DayOf = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblUser")>  _
Partial Public Class tblUser
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _FirstNameOf As String
	
	Private _LastNameOf As String
	
	Private _StartDateOf As System.Nullable(Of Date)
	
	Private _EndDateOf As System.Nullable(Of Date)
	
	Private _UserName As String
	
	Private _Password As String
	
	Private _isInActive As Boolean
	
	Private _AccessTypeOf As Integer
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnFirstNameOfChanging(value As String)
    End Sub
    Partial Private Sub OnFirstNameOfChanged()
    End Sub
    Partial Private Sub OnLastNameOfChanging(value As String)
    End Sub
    Partial Private Sub OnLastNameOfChanged()
    End Sub
    Partial Private Sub OnStartDateOfChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnStartDateOfChanged()
    End Sub
    Partial Private Sub OnEndDateOfChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnEndDateOfChanged()
    End Sub
    Partial Private Sub OnUserNameChanging(value As String)
    End Sub
    Partial Private Sub OnUserNameChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub OnisInActiveChanging(value As Boolean)
    End Sub
    Partial Private Sub OnisInActiveChanged()
    End Sub
    Partial Private Sub OnAccessTypeOfChanging(value As Integer)
    End Sub
    Partial Private Sub OnAccessTypeOfChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FirstNameOf", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property FirstNameOf() As String
		Get
			Return Me._FirstNameOf
		End Get
		Set
			If (String.Equals(Me._FirstNameOf, value) = false) Then
				Me.OnFirstNameOfChanging(value)
				Me.SendPropertyChanging
				Me._FirstNameOf = value
				Me.SendPropertyChanged("FirstNameOf")
				Me.OnFirstNameOfChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastNameOf", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property LastNameOf() As String
		Get
			Return Me._LastNameOf
		End Get
		Set
			If (String.Equals(Me._LastNameOf, value) = false) Then
				Me.OnLastNameOfChanging(value)
				Me.SendPropertyChanging
				Me._LastNameOf = value
				Me.SendPropertyChanged("LastNameOf")
				Me.OnLastNameOfChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StartDateOf", DbType:="Date")>  _
	Public Property StartDateOf() As System.Nullable(Of Date)
		Get
			Return Me._StartDateOf
		End Get
		Set
			If (Me._StartDateOf.Equals(value) = false) Then
				Me.OnStartDateOfChanging(value)
				Me.SendPropertyChanging
				Me._StartDateOf = value
				Me.SendPropertyChanged("StartDateOf")
				Me.OnStartDateOfChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EndDateOf", DbType:="Date")>  _
	Public Property EndDateOf() As System.Nullable(Of Date)
		Get
			Return Me._EndDateOf
		End Get
		Set
			If (Me._EndDateOf.Equals(value) = false) Then
				Me.OnEndDateOfChanging(value)
				Me.SendPropertyChanging
				Me._EndDateOf = value
				Me.SendPropertyChanged("EndDateOf")
				Me.OnEndDateOfChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property UserName() As String
		Get
			Return Me._UserName
		End Get
		Set
			If (String.Equals(Me._UserName, value) = false) Then
				Me.OnUserNameChanging(value)
				Me.SendPropertyChanging
				Me._UserName = value
				Me.SendPropertyChanged("UserName")
				Me.OnUserNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_isInActive", DbType:="Bit NOT NULL")>  _
	Public Property isInActive() As Boolean
		Get
			Return Me._isInActive
		End Get
		Set
			If ((Me._isInActive = value)  _
						= false) Then
				Me.OnisInActiveChanging(value)
				Me.SendPropertyChanging
				Me._isInActive = value
				Me.SendPropertyChanged("isInActive")
				Me.OnisInActiveChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AccessTypeOf", DbType:="Int NOT NULL")>  _
	Public Property AccessTypeOf() As Integer
		Get
			Return Me._AccessTypeOf
		End Get
		Set
			If ((Me._AccessTypeOf = value)  _
						= false) Then
				Me.OnAccessTypeOfChanging(value)
				Me.SendPropertyChanging
				Me._AccessTypeOf = value
				Me.SendPropertyChanged("AccessTypeOf")
				Me.OnAccessTypeOfChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
