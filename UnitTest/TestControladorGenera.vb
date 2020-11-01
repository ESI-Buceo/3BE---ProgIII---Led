﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorGenera
    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly Diagnostico As String = "3"


    <TestMethod()> Public Sub TestObtenerIdEnfermedadGenerada()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Dim resultado As Boolean
        Try
            ControladorGenera.ObtenerIdEnfermedadGenerada()
            resultado = True
        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreEnfermedad()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Dim resultado As Boolean
        Try
            ControladorGenera.ObtenerNombreEnfermedad(Diagnostico)
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreSintomas()
        Dim resultado As Boolean
        Try
            ControladorGenera.ObtenerNombreSintomas(5)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub


End Class