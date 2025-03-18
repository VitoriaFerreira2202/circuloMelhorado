using circuloMelhorado.Models;
using circuloMelhorado.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuloMelhorado.Controle
{
    //classe controladora para calcular relacionamento a circulo
    internal class circuloControle
    {
        // metodo publico  estatico para calcular o circulo
        public static (string Messagem, MessageBoxIcon icone )CalculaCirculo(string input) 
        {

            if (Double.TryParse(input, out double valorConvertido))
            {
                try
                {
                    //cria uma instancia da classe circulo 
                    Circulo circulo = new Circulo(valorConvertido);

                    //stringcom resultado do calcule

                    string resultado = $"area: {circulo.CalcArea():f}\nperimetro: {circulo.CalcPer():f}";
                    //return da funcao

                    return (resultado, funcUtils.ObterIcone(resultado));
                }
                
                catch(ArgumentException ex)
                {
                    //capturando o erro da classe
                    string msg = $" Error :{ex.Message}";
                    return (msg, funcUtils.ObterIcone(msg));


                }
            }
            else 
            {
                string msgerro = "Erro:o valor digitado nao é um numero valido";
                return (msgerro, funcUtils.ObterIcone(msgerro));

            }

        }
    }
}
