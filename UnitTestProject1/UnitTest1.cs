using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppTaller;
using LibreriaTaller;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        //Debe ser un rut valido, usa el metodo validarRut del cliente.
        public void Cliente_Prueba_Validar_Rut()
        {
            //Arrange
            NegocioTaller nt = new NegocioTaller();

            Cliente cl1 = new Cliente();
            cl1.Rut = "15.445.494-2";
            cl1.Nombre = "Gabriel";
            cl1.Email = "prueba@prueba.cl";

            int esperado = nt.RegistrarCliente(cl1);

            //Act
            int resultado = 1;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Cliente_Prueba_Registrar_cliente_sin_nombre()
        {
            //Arrange
            NegocioTaller nt = new NegocioTaller();

            Cliente cl1 = new Cliente();
            cl1.Rut = "154454942";
            cl1.Nombre = "";
            cl1.Email = "prueba@prueba.cl";

            int esperado = nt.RegistrarCliente(cl1);

            //Act
            int resultado = 1;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        //cliente con telefono, error en SET de cliente.
        public void Cliente_Prueba_Ingresar_CLiente_con_Telefono()
        {
            //Arrange
            NegocioTaller nt = new NegocioTaller();

            Cliente cl1 = new Cliente();
            cl1.Rut = "15.445.494-2";
            cl1.Nombre = "Gabriel";
            cl1.Telefono = "123456789";
            cl1.Email = "prueba@prueba.cl";

            int esperado = nt.RegistrarCliente(cl1);

            //Act
            int resultado = 1;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        

        [TestMethod]
        //Debe ser un mail valido, usa el metodo validarMail del cliente.
        public void Cliente_Prueba_Registrar_mail_sin_arroba()
        {
            //Arrange
            NegocioTaller nt = new NegocioTaller();

            Cliente cl1 = new Cliente();
            cl1.Rut = "15.445.494-2";
            cl1.Nombre = "Gabriel";
            cl1.Email = "prueba.cl";

            int esperado = nt.RegistrarCliente(cl1);

            //Act
            int resultado = 1;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void NegocioTaller_Prueba_Registrar_Nuevo_Cliente()
        {
            //Arrange
            NegocioTaller nt = new NegocioTaller();

            Cliente cl1 = new Cliente();
            cl1.Rut = "154454942";
            cl1.Nombre = "Gabriel";
            cl1.Email = "prueba@prueba.cl";

            Cliente cl2 = new Cliente();
            cl2.Rut = "154454942";
            cl2.Nombre = "Gabriel";
            cl2.Email = "prueba@prueba.cl";

            nt.RegistrarCliente(cl1);
            int esperado = nt.RegistrarCliente(cl2);

            //Act
            int resultado = 0;

            //Assert
            Assert.AreEqual(esperado, resultado);
        }


    }
}
