using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteres()
    {
        var texto = "Higor";
        var resultadoEsperado = 5;

        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        Assert.Equal(resultadoEsperado, resultado);
    }
    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        var texto = "ABCDEFDHIJ";
        var textoProcurado = "CD";

         var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        Assert.True(resultado);
    }
    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        var texto = "ABCDEFDHIJ";
        var textoProcurado = "KLMN";

        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        Assert.False(resultado);
    }
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        var texto = "ABC DEF GHI";
        var textoProcurado = "GHI";

        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        Assert.True(resultado);
    }
}
