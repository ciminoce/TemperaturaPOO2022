using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TemperaturaPOO2022.Entidades;

namespace TemperaturaPOO2022.Testing
{
    [TestClass]
    public class TemperaturaTest
    {
        [TestMethod]
        public void TemperaturaValidarValidaCelsius()
        {
            Escala escala = Escala.Celsius;
            double grados = 20;

            Temperatura temp = new Temperatura(escala, grados);

            Assert.IsTrue(temp.Validar());
        }
        public void TemperaturaValidarValidaFahrenheit()
        {
            Escala escala = Escala.Fahrenheit;
            double grados = 68;

            Temperatura temp = new Temperatura(escala, grados);

            Assert.IsTrue(temp.Validar());
        }
        public void TemperaturaValidarNoValidaCelsiusMenor()
        {
            Escala escala = Escala.Celsius;
            double grados = -81;

            Temperatura temp = new Temperatura(escala, grados);

            Assert.IsFalse(temp.Validar());
        }
        public void TemperaturaValidarNoValidaCelsiusMayor()
        {
            Escala escala = Escala.Celsius;
            double grados = 81;

            Temperatura temp = new Temperatura(escala, grados);

            Assert.IsFalse(temp.Validar());
        }

        public void TemperaturaValidarNoValidaFahrenheitMenor()
        {
            Escala escala = Escala.Fahrenheit;
            double grados = -113;

            Temperatura temp = new Temperatura(escala, grados);

            Assert.IsTrue(temp.Validar());
        }
        public void TemperaturaValidarNoValidaFahrenheitMayor()
        {
            Escala escala = Escala.Fahrenheit;
            double grados = 177;

            Temperatura temp = new Temperatura(escala, grados);

            Assert.IsTrue(temp.Validar());
        }

        public void TemperaturaGetConversionFahrenheit()
        {
            Escala escala = Escala.Celsius;
            double grados = 20;

            Temperatura temp = new Temperatura(escala, grados);

            Assert.AreEqual(68,temp.GetConversion());
        }
        public void TemperaturaGetConversionCelsius()
        {
            Escala escala = Escala.Fahrenheit;
            double grados = 68;

            Temperatura temp = new Temperatura(escala, grados);

            Assert.AreEqual(20, temp.GetConversion());
        }


    }
}
