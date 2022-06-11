using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Prueba.Models;
using WebApi.Prueba.ViewModels;

namespace WebApi.Prueba.Services
{
    public interface IClienteService
    {
        List<Cliente> GetClientesList();

        Cliente GetClienteDetailsById(string CodCliente);

        ResponseModel SaveCliente(Cliente clienteModel);

        ResponseModel UpdateCliente(Cliente clienteModel);

        ResponseModel DeleteCliente(string CodCliente);

    }
}
