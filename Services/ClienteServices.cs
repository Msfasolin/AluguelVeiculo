using AluguelVeiculo.Respository;
using AluguelVeiculo.Models;
using AluguelVeiculo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AluguelVeiculo.Services
{
    public class ClienteServices
    {
        public Cliente CadastrarCliente(ClienteViewModel clienteRecebeido)
        {
            Cliente cliente = new Cliente(clienteRecebeido);
            Armazenamento.Clientes.Add(cliente);

            return cliente;
        }

        public List<Cliente> ListarClientes()
        {
            return Armazenamento.Clientes
                .OrderBy(cliente => cliente.Nome)
                .ThenBy(cliente => cliente.Cpf)
                .ToList();
        }

        public Cliente ObterCliente(string idRecebido)
        {
            List<Cliente> lista = ListarClientes();
            if (lista.Any(u => u.Id.ToString() == idRecebido))
            {
                Cliente cliente = lista
                   .Where(u => u.Id.ToString() == idRecebido)
                   .First();
                return cliente;
            }

            return null;
        }
    }
}
