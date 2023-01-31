namespace Calculadora.tester
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(20, Calculadora.Somar(10, 10));
        }
        [Fact]
        public void Subtrair()
        {
            Assert.Equal(20, Calculadora.Subtrair(40, 20));
        }
        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, Calculadora.Multiplicat(10, 10));
        }
        [Fact]
        public void Divide()
        {
            Assert.Equal(1, Calculadora.Divide(10, 10));
        }
    }
}