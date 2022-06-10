using AluguelVeiculo.Respository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelVeiculo.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Marcar { get; set; }

        public string Nome { get; set; }
        public int Cpf { get; set; }

        public Item()
        {
            Id = Guid.NewGuid();
        }
    }
}
