﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

'REVISAR LOS LISTAR ENFERMEDAD PORQUE HAY 2 LISTAR Y LISTAR TODO QUE HACEN LO MISMO
'REVISAR LISTAR ENFERMEDADES ACTIVAS E INACTIVAS(POSIBLE ELIMINACION)
'REVISAR ACTIVAR ENFERMEDAD Y REACTIVAR, YA QUE HACEN LO MISMO
<TestClass()> Public Class TestModeloEnfermedad

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Diagnostico As String = "5"

    <TestMethod()> Public Sub TestInsertar()
        Dim resultado As Boolean

        Dim sintomaPrueba As New List(Of String) From {
            "Diarrea",
            "Debilidad",
            "Delirio",
            "Alucinaciones",
            "Desmayo"
        }

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
            .Sintomas = sintomaPrueba,
            .Nombre = "Hartnup",
            .Descripcion = "Mala absorcion de los aminoacidos",
            .Prioridad = "ALTA"
        }

        Try
            e.Insertar()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestEstaInactivo()
        Dim resultado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Alergia"
       }

        Try
            e.EstaInactivo()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestActivarEnfermedad()
        Dim activarEnfermedad
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Alergia"
       }

        Try
            e.ActivarEnfermedad()
            activarEnfermedad = True

        Catch ex As Exception
            activarEnfermedad = False

        End Try

        Assert.IsTrue(activarEnfermedad)

    End Sub

    <TestMethod()> Public Sub TestListar()
        Dim listado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass)

        Try
            e.Listar()
            listado = True

        Catch ex As Exception
            listado = False

        End Try

        Assert.IsTrue(listado)

    End Sub

    <TestMethod()> Public Sub TestListarNombreEnfermedadesActivas()
        Dim listado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass)

        Try
            e.Listar()
            listado = True

        Catch ex As Exception
            listado = False

        End Try

        Assert.IsTrue(listado)
    End Sub

    <TestMethod()> Public Sub TestListarNombreEnfermedadesInactivas()
        Dim listado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass)

        Try
            e.Listar()
            listado = True

        Catch ex As Exception
            listado = False

        End Try

        Assert.IsTrue(listado)
    End Sub

    '<TestMethod()> Public Sub TestListarTodo()

    'End Sub

    <TestMethod()> Public Sub TestModificar()

        Dim modificadoOK As Boolean

        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Bronquitis",
           .Descripcion = "Inflamacion de los conductos bronquiales, las vias respiratorias que llevan oxigeno a sus pulmones.",
           .Prioridad = "ALTA",
           .Id = "5"
       }

        Try
            e.Modificar()
            modificadoOK = True

        Catch ex As Exception
            modificadoOK = False

        End Try

        Assert.IsTrue(modificadoOK)

    End Sub

    <TestMethod()> Public Sub TestCambiarEnfermedadYSintomas()

        Dim modificadoOK As Boolean

        Dim sintomaPrueba As New List(Of String) From {
            "Diarrea",
            "Debilidad",
            "Delirio",
            "Alucinaciones",
            "Desmayo",
            "Temblores"
        }
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Hartnup",
           .Descripcion = "Mala absorcion de los aminoacidos",
           .Prioridad = "ALTA",
           .Id = "9"
       }

        Try
            e.CambiarEnfermedadYSintomas()
            modificadoOK = True

        Catch ex As Exception
            modificadoOK = False

        End Try

        Assert.IsTrue(modificadoOK)

    End Sub
    <TestMethod()> Public Sub TestEliminar()
        Dim resultado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Id = "3"
       }

        Try
            e.Eliminar()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub
    <TestMethod()> Public Sub TestObtenerId()
        Dim resultado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Acne"
       }

        Try
            e.ObtenerId()
            resultado = True

        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerPrioridad()
        Dim resultado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Id = "4"
       }

        Try
            e.ObtenerPrioridad()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerDescripcion()
        Dim resultado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Id = "5"
       }

        Try
            e.ObtenerDescripcion()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerTodo()
        Dim resultado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Id = "5"
       }

        Try
            e.ObtenerTodo()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerExistencia()
        Dim resultado As Boolean
        Dim e As New ModeloEnfermedad(Admin, AdmPass) With {
           .Nombre = "Alergia"
       }

        Try
            e.ObtenerExistencia()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    '<TestMethod()> Public Sub TestReactivarEnfermedad()

    'End Sub

End Class