using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_ex_veiculo
{
    internal class Caminhao : Veiculo
    {
        //atributo
        private int eixos;

        //getter e setter
        public int Eixos { get => eixos; set => eixos = value; }


        //construtores
        public Caminhao() : base()
        {
            eixos = 0;
        }

        public Caminhao(string _placa, int _ano, int _eixos) : base(_placa, _ano)
        {
            eixos = _eixos;
        }

        //método
        public override double Alugar()
        {
            double diaria = (300 * eixos) - (DateTime.Now.Year - ano) * 50;
            return diaria;
        }

    }
}
