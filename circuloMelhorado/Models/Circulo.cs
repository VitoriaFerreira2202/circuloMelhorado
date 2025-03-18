using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuloMelhorado.Models
{
      internal class Circulo
      { 
        //atributo privado,que naopode ser acessado diretamente fora da clase
       private double Raio {  get; set; }

        //metodo contrutor que receber raio como paramento
        public Circulo(double Raio) 
        {
            //usuando metedo set para verficar a integridade dos mues dados
            //muda this.raio para setraio
            //this.Raio = Raio;
            SetRaio(Raio);
        }

        private void SetRaio(double Raio)
        {
            if (Raio > 0)
            {
                this.Raio = Raio;
            }
            else
            {
                // lanca uma execao caso o raio seja menor que 0
                throw new ArgumentException("O raio deve ser numero possitivo");
            }
        }

        //metodo publico que calcula area
        public double CalcArea() 
        {
            double ValorCalcArea = Math.PI * (this.Raio * this.Raio);
            return  ValorCalcArea;
        }

        //metodo que calculça perimertro
        public double CalcPer() 
        {
         double ValorCalcPeri=2*Math.PI*this.Raio;
         return ValorCalcPeri;
        
        }
      }
}
