Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
Imports CapaDeDatos

<TestClass()> Public Class TestModeloUsuario

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "53590226"
    Private ReadOnly MedPass As String = "49249605"
    Private ReadOnly AdmPass As String = "54083680"
    Private ReadOnly Diagnostico As String = "1"
    Private ReadOnly Enfermedades As New List(Of String)
    Private ReadOnly Medicaciones As New List(Of String)
    Private ReadOnly Roles(3) As Boolean
    Private ReadOnly Contra As String = "Pas1234_"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestNuevoPaciente()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Medico,
            .Nombre = "Nuevo",
            .Apellido = "Paciente",
            .Mail = "Correo",
            .FechaNacimiento = "2020-05-10",
            .Sexo = 0,
            .EnfermedadCronica = Enfermedades,
            .Medicacion = Medicaciones,
            .Password = Contra
        }
        Try
            Resultado = True
            u.NuevoPaciente()
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoPaciente()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Paciente,
            .Sexo = 0,
            .FechaNacimiento = "2020-02-12",
            .EnfermedadCronica = Enfermedades,
            .Medicacion = Medicaciones
        }
        Try
            u.AgregarNuevoPaciente()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoMedico()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Medico,
            .Nombre = "Nuevo",
            .Apellido = "Medico",
            .Mail = "Correo",
            .Password = Contra
        }
        Try
            u.NuevoMedico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoMedico()

        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Medico
        }
        Try
            u.AgregarNuevoMedico()
            Resultado = True
        Catch ex As Exception


        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoAdministrativo()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Admin,
            .Nombre = "Nuevo",
            .Apellido = "Admin",
            .Mail = "Corero",
            .Password = Contra
        }
        Try
            u.NuevoAdministrativo()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoAdministrativo()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Paciente
        }
        Try
            u.AgregarNuevoAdministrativo()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoPacienteMedico()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Paciente,
            .Nombre = "Nuevo",
            .Apellido = "PacMed",
            .Mail = "Correo",
            .FechaNacimiento = "2002-20-12",
            .Sexo = "1",
            .EnfermedadCronica = Enfermedades,
            .Medicacion = Medicaciones,
            .Password = Contra
        }
        Try
            u.NuevoPacienteMedico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoPacienteAdmin()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Paciente,
            .Nombre = "Nuevo",
            .Apellido = "PacAdm",
            .Mail = "Correo",
            .FechaNacimiento = "1998-01-12",
            .EnfermedadCronica = Enfermedades,
            .Medicacion = Medicaciones,
            .Password = Contra
        }
        Try
            u.NuevoPacienteAdmin()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoMedicoAdmin()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Medico,
            .Nombre = "Nuevo",
            .Apellido = "MedAdm",
            .Mail = "Correo",
            .Password = Contra
        }
        Try
            u.NuevoMedicoAdmin()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoPacienteMedicoAdmin()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .Nombre = "Nuevo",
            .Apellido = "Todo",
            .CI = Paciente,
            .Mail = "Correo",
            .FechaNacimiento = "1999-10-20",
            .Sexo = "1",
            .Medicacion = Medicaciones,
            .EnfermedadCronica = Enfermedades,
            .Password = Contra
        }
        Try
            u.NuevoPacienteMedicoAdmin()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerCorreo()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Paciente
        }
        Try
            Assert.AreEqual(u.ObtenerCorreo(), "atoderol@gmail.com")
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreApellidoCedula()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Admin
        }
        Try
            u.ObtenerNombreApellidoCedula()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerCedulaMedico()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass)
        Try
            u.ObtenerCiMedico()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerCedulaAdministrativo()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass)
        Try
            u.ObtenerCiAdministrador()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombre()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Admin
        }
        Try
            u.ObtenerNombre()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreCi()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass)
        Try
            u.ObtenerNombre(Paciente)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreApellidoMail()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Medico
        }
        Try
            u.ObtenerNombreApellidoMail()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerTodasLasCedulas()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass)

        Try
            u.ObtenerTodasLasCedulas()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestExisteRol()
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Paciente,
            .Rol = 1
        }
        Try
            Assert.AreEqual(u.ExisteRol(), 1)
        Catch ex As Exception
        End Try

    End Sub

    <TestMethod()> Public Sub TestModificarPersona()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .Nombre = "Nuevo",
            .Apellido = "Nombre",
            .Mail = "Correo",
            .CI = Admin
            }
        Try
            u.ModificarPersona()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarPersona()
        Resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Paciente,
            .Roles = Roles,
            .EliminarPersona = False
        }
        Try
            u.Eliminar()
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)
    End Sub

End Class