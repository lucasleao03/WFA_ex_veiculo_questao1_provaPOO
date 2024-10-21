using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_ex_veiculo
{
    internal class Onibus : Veiculo
    {
        //atributos
        private int assentos;

        //getter e setter
        public int Assentos { get => assentos; set => assentos = value; }

        //Construtores
        public Onibus() : base()
        {
            assentos = 0;
        }

        public Onibus(string _placa, int _ano, int _assentos) : base(_placa, _ano)
        {
            assentos = _assentos;
        }

        //métodos
        public override double Alugar()
        {
            double diaria;
            diaria = (30 * assentos) - (DateTime.Now.Year - ano) * 70;
            return diaria;
        }
    }
}
