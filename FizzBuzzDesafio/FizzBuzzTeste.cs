using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzDesafio
{
    
    public class FizzBuzzTeste
    {
        [Test]
        public void AoVerificarNumero1Retornar1()
        {
            string resultado = new FizzBuzz().Verificar(1);
            Assert.AreEqual("1", resultado);
        }

        [Test]
        public void AoVerificarNumero2Retornar2()
        {
            string resultado = new FizzBuzz().Verificar(2);
            Assert.AreEqual("2", resultado);
        }
        [Test]
        public void AoVerificarNumero3DeveRetornarFizz()
        {
            string resultado = new FizzBuzz().Verificar(3);
            Assert.AreEqual("Fizz", resultado);
        }
        [Test]
        public void AoVerificarNumero4DeveRetornar4()
        {
            string resultado = new FizzBuzz().Verificar(4);
            Assert.AreEqual("4", resultado);
        }

        [Test]
        public void AoVerificarNumero5DeveRetornarBuzz()
        {
            string resultado = new FizzBuzz().Verificar(5);
            Assert.AreEqual("Buzz", resultado);
        }
        [Test]
        public void AoVerificarNumero6DeveRetornarFizz()
        {
            string resultado = new FizzBuzz().Verificar(6);
            Assert.AreEqual("Fizz", resultado);
        }

        [Test]
        public void AoVerificarNumero10DeveRetornarBuzz()
        {
            string resultado = new FizzBuzz().Verificar(10);
            Assert.AreEqual("Buzz", resultado);
        }

        [Test]
        public void AoVerificarNumero15DeveRetornarFizzBuzz()
        {
            string resultado = new FizzBuzz().Verificar(15);
            Assert.AreEqual("Fizz Buzz", resultado);
        }

        [Test]
        public void AoVerificarNumero30DeveRetornarFizzBuzz()
        {
            string resultado = new FizzBuzz().Verificar(30);
            Assert.AreEqual("Fizz Buzz", resultado);
        }

        [Test]
        public void AoVerificarNumero90DeveRetornarFizzBuzz()
        {
            string resultado = new FizzBuzz().Verificar(90);
            Assert.AreEqual("Fizz Buzz", resultado);
        }
    }
}
