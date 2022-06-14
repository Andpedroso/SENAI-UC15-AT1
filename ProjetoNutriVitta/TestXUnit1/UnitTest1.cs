using ProjetoNutriVitta;

namespace TestXUnit1
{
    public class UnitTest1
    {
        //Teste Unitário 1
        [Fact]
        public void CalcularImcTest()
        {
            //Arrange

            double pNum = 50;

            double aNum = 1.70;

            double rNum = 26.666666666666668;

            //Act

            var resultado = Operacoes.CalcularImc(pNum, aNum);

            //Assert

            Assert.Equal(rNum, resultado);
        }

        //Arrange
        [Theory]
        [InlineData(50, 1.70, 17.301038062283737)]
        [InlineData(60, 1.70, 20.761245674740486)]
        [InlineData(60, 1.50, 26.666666666666668)]
        [InlineData(110, 1.80, 33.95061728395061)]
        [InlineData(120, 1.80, 37.03703703703704)]
        [InlineData(130, 1.70, 44.98269896193772)]
        public void CalcularImcTestLista(double pNum, double aNum, double rNum)
        {
            //Act

            var resultado = Operacoes.CalcularImc(pNum, aNum);

            //Assert

            Assert.Equal(rNum, resultado);
        }

        //Teste Unitário 2
        [Fact]
        public void CompararImcTest()
        {
            //Arrange

            double iPeso = 26.666666666666668;

            double rPeso = 4;

            //Act

            var resultado = Operacoes.CompararImc(iPeso);

            //Assert

            Assert.Equal(rPeso, resultado);
        }

        //Arrange
        [Theory]
        [InlineData(17.301038062283737, 1)]
        [InlineData(20.761245674740486, 2)]
        [InlineData(26.666666666666668, 3)]
        [InlineData(33.95061728395061, 4)]
        [InlineData(37.03703703703704, 5)]
        [InlineData(44.98269896193772, 6)]
        public void CompararImcTestLista(double iPeso, double rNum)
        {
            //Act

            var resultado = Operacoes.CompararImc(iPeso);

            //Assert

            Assert.Equal(rNum, resultado);
        }
    }
}