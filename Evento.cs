using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_1
{
    public class Evento
    {
        public string? Nome { get; set; }
        public string? Local { get; set; }
        public float? Valor { get; set; }
        private List<Pessoa>? pessoas;
        public List<Pessoa>? Pessoas
        {
            get
            {
                return Pessoas;
            }
            set
            {
                List<Pessoa> newPessoas = value;
                if (newPessoas.Count <= 20)
                {
                    Console.WriteLine("numero de pessoas menor ou igual a 20");
                    this.pessoas = newPessoas;
                }
                else
                {
                    throw new ArgumentException("Quantidade de pessoas superior a 20");
                }
            }
        }

        public bool validarQtdPessoas(List<Pessoa> newPessoas)
        {
            if (newPessoas.Count <= 20)
            {
                return true;
            }
            return false;

        }


    }
}