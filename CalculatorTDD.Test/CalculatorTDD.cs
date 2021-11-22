using NUnit.Framework;

namespace CalculatorTDD.Test
{
    //Se n�o passar valor, retornar zero
    public class Tests
    {
        [Test]
        public void Se_ParamVazio_RetornarZero()
        {
            Assert.AreEqual(0, CalculatorTDDProj.Add(string.Empty));
        }

        //Se passado apenas 1 numero para o calculo, retornar o proprio numero
        [Test]
        public void Se_Apenas1Param_RetornarOMesmo()
        {
            Assert.AreEqual(5, CalculatorTDDProj.Add("5"));
        }

        //Teste em 2 numeros como parametro
        [Test]
        public void Se_2Param_EfetuarSoma()
        {
            var num = "7,8";
            var resultatoEsperado  = 15;
            Assert.AreEqual(resultatoEsperado, CalculatorTDDProj.Add(num));
        }

        //Teste em 3 numeros como parametro
        [Test]
        public void Se_3Parm_EfetuarSoma()
        {
            var num = "1, 2, 3";
            var esperado = 6;
            Assert.AreEqual(esperado, CalculatorTDDProj.Add(num));
        }

        //Teste em 4 ou mais numeros como parametro, nao considerando valores acima de '1000'
        [TestCase("1,2,3,4", 10)]
        [TestCase("8,7,20", 35)]
        [TestCase("5,0,4,1001", 9)]
        [TestCase("5,0,4,1000", 1009)]
        [TestCase("26,6,90", 122)]
        public void Se_MaisQue4Param_ExecutaSoma(string input, int result)
        {
            Assert.AreEqual(result, CalculatorTDDProj.Add(input));
        }

        //Teste nao permitindo numeros negativos
        [TestCase("1,2,3,4,5,-5")]
        [TestCase("-1,1,2,9")]
        [TestCase("5,6,8,-5")]
        public void Se_ParamContemNumNegativo_NaoPermitir(string num)
        {
            Assert.Throws<AssertionException>(() => CalculatorTDDProj.Add(num));
        }
    }
}