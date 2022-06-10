using AluguelVeiculo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelVeiculo.Models
{
    public class Cliente
    {

        public Cliente(ClienteViewModel clienteBase)
        {

            Nome = clienteBase.Nome;
            Cpf = clienteBase.Cpf;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        

    }
}
