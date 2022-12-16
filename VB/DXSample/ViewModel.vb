Imports System
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace DXSample

    Public Class ViewModel
        Inherits ViewModelBase

        Public Property Items As ObservableCollection(Of RowObject)
            Get
                Return GetProperty(Function() Me.Items)
            End Get

            Set(ByVal value As ObservableCollection(Of RowObject))
                SetProperty(Function() Items, value)
            End Set
        End Property

        Public Sub New()
            Dim random As Random = New Random()
            Items = New ObservableCollection(Of RowObject)()
            For i As Integer = 0 To 10 - 1
                Items.Add(New RowObject() With {.Id = i, .Name = String.Format("Name {0}", i), .Age = random.Next(18, 50), .RegistrationDate = Date.Now.AddDays(random.Next(-100, 100))})
            Next
        End Sub
    End Class

    Public Class RowObject
        Inherits BindableBase

        Public Property Id As Integer
            Get
                Return GetProperty(Function() Me.Id)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() Id, value)
            End Set
        End Property

        Public Property Name As String
            Get
                Return GetProperty(Function() Me.Name)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() Name, value)
            End Set
        End Property

        Public Property Age As Integer
            Get
                Return GetProperty(Function() Me.Age)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() Age, value)
            End Set
        End Property

        Public Property RegistrationDate As Date
            Get
                Return GetProperty(Function() Me.RegistrationDate)
            End Get

            Set(ByVal value As Date)
                SetProperty(Function() RegistrationDate, value)
            End Set
        End Property
    End Class
End Namespace
