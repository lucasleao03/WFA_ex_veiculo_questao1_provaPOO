using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_ex_veiculo
{
    internal abstract class Veiculo
    {
        //atributos
        protected string placa;
        protected int ano;

        //getters e setters
        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        //construtores
        protected Veiculo()
        {
            placa = string.Empty;
            ano = 0;
        }

        protected Veiculo(string _placa, int _ano)
        {
            placa = _placa;
            ano = _ano;
        }

        //método
        public abstract double Alugar(); 

    }
}
