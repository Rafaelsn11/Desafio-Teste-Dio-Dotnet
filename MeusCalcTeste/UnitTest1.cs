using MeusCalc;

namespace MeusCalcTeste;

public class UnitTest1
{
    public Calculadora ConstruirClasse()
    {
        string data = "03/06/2024";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

    [Theory]
    [InlineData (1.5, 1.5, 3.0)]
    [InlineData(4.5, 5.5, 10.0)]
    public void TesteSomar(decimal valorUm, decimal valorDois, decimal resultado)
    {
        Calculadora calc = ConstruirClasse();

        decimal resultadoCalculadora = calc.Somar(valorUm, valorDois);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 3.5, 2.5)]
    [InlineData(5.5, 5, 0.5)]
    public void TesteSubtrair(decimal valorUm, decimal valorDois, decimal resultado)
    {
        Calculadora calc = ConstruirClasse();

        decimal resultadoCalculadora = calc.Subtrair(valorUm, valorDois);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 4.4, 26.4)]
    [InlineData(5, 5, 25)]
    public void TesteMultiplicar(decimal valorUm, decimal valorDois, decimal resultado)
    {
        Calculadora calc = ConstruirClasse();

        decimal resultadoCalculadora = calc.Multiplicar(valorUm, valorDois);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(36, 15, 2.4)]
    [InlineData(5, 20, 0.25)]
    public void TesteDividir(decimal valorUm, decimal valorDois, decimal resultado)
    {
        Calculadora calc = ConstruirClasse();

        decimal resultadoCalculadora = calc.Dividir(valorUm, valorDois);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = ConstruirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0)
       );
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = ConstruirClasse();

        calc.Somar(1, 2);
        calc.Somar(2, 8);
        calc.Somar(3, 7);
        calc.Somar(4, 1);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }


}