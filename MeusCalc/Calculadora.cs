using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusCalc;
public class Calculadora
{
    private List<string> _historico;
    private string _data;

    public Calculadora(string data)
    {
        _historico = new List<string>();
        _data = data;
    }

    public decimal Somar(decimal valorUm, decimal valorDois)
    {
        decimal resposta = valorUm + valorDois;

        _historico.Insert(0, "Res: " + resposta + " - data: " + _data);
        return resposta;
    }

    public decimal Subtrair(decimal valorUm, decimal valorDois)
    {
        decimal resposta = valorUm - valorDois;

        _historico.Insert(0, "Res: " + resposta + " - data: " + _data);
        return resposta;
    }

    public decimal Multiplicar(decimal valorUm, decimal valorDois)
    {
        decimal resposta = valorUm * valorDois;

        _historico.Insert(0, "Res: " + resposta + " - data: " + _data);
        return resposta;
    }

    public decimal Dividir(decimal valorUm, decimal valorDois)
    {
        decimal resposta = valorUm / valorDois;

        _historico.Insert(0, "Res: " + resposta + " - data: " + _data);
        return resposta;
    }

    public List<string> Historico()
    {
        _historico.RemoveRange(3, _historico.Count - 3);
        return _historico;
    }
}
