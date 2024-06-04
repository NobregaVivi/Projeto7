
using System.ComponentModel;
using System.Diagnostics;


namespace CalculadoraTest;
public class Calculadora
{
   public Calculadora construirClasse()
   {
     string data = "02/06/2024";
     Calculadora calc = new Calculadora(02/06/2024);

     return calc;

   }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]              
        public void TestSomar(int val1, int val2, int resultado)
        {
           Calculadora calc = construirClasse();

           int resultadoCalculadora = calc.somar(val1, val2);

           Assert.Equal(resultado, resultadoCalculadora);
        }

    private int somar(int val1, int val2)
    {
       int resultado = val1 + val2;
        return resultado;
    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(5, 5, 0)]              
        public void TestSubtrair(int val1, int val2, int resultado)
        {
           Calculadora calc = construirClasse();

           int resultadoCalculadora = calc.subtrair(val1, val2);

           Assert.Equal(resultado, resultadoCalculadora);
        }

    private int subtrair(int val1, int val2)
    {
        int resultado = val1 - val2;
        return resultado;
    }
    

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]              
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
           Calculadora calc = construirClasse();

           int resultadoCalculadora = calc.multiplicar(val1, val2);

           Assert.Equal(resultado, resultadoCalculadora);
        }

         private int multiplicar(int val1, int val2)
    {
        int resultado = val1 * val2;
        return resultado;
    }

        [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]              
        public void TestDividir(int val1, int val2, int resultado)
        {
           Calculadora calc = construirClasse();

           int resultadoCalculadora = calc.dividir(val1, val2);

           Assert.Equal(resultado, resultadoCalculadora);
        }

         private int dividir(int val1, int val2)
    {
        int resultado = val1 / val2;
        return resultado;
    }

        [Fact]
        public void TestarDividisoaPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        
        {
            Calculadora calc = new Calculadora();
                                         

            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);
           
            var lista = calc.historico();

            Assert.NotEmpty(lista());
           Assert.Equal(3,  lista.Count());
        }

  
}
      