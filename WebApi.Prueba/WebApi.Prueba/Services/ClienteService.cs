using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Prueba.Models;
using WebApi.Prueba.ViewModels;

namespace WebApi.Prueba.Services
{
    public class ClienteService : IClienteService
    {
        private EmpContext _Context;

        public ClienteService(EmpContext Context)
        {
            _Context = Context;
        }

        public ResponseModel DeleteCliente(string CodCliente)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Cliente _temp = GetClienteDetailsById(CodCliente);
                if (_temp != null)
                {
                    _Context.Remove<Cliente>(_temp);
                    _Context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Employee Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Employee Not Found";
                }

            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public Cliente GetClienteDetailsById(string CodCliente)
        {
            Cliente _Cliente;
            try
            {
                _Cliente = _Context.Find<Cliente>(CodCliente);
            }
            catch (Exception)
            {
                throw;
            }
            return _Cliente;
        }

        public List<Cliente> GetClientesList()
        {
            List<Cliente> _List;
            try
            {
                _List = _Context.Set<Cliente>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return _List;
        }

        public ResponseModel SaveCliente(Cliente clienteModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                _Context.Add<Cliente>(clienteModel);
                model.Messsage = "Cliente Inserted Successfully";
                _Context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel UpdateCliente(Cliente clienteModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Cliente _temp = GetClienteDetailsById(clienteModel.CodCliente);
                if (_temp != null)
                {
                    _temp.NombreCompleto = clienteModel.NombreCorto;
                    _temp.NombreCorto = clienteModel.NombreCorto;
                    _temp.Abreviatura = clienteModel.Abreviatura;
                    _temp.RUC = clienteModel.RUC;
                    _temp.Estado = clienteModel.Estado;
                    _temp.GrupoFacturacion = clienteModel.GrupoFacturacion;
                    _temp.InactivoDesde = clienteModel.InactivoDesde;
                    _temp.CodigoSAP = clienteModel.CodigoSAP;
                    _Context.Update<Cliente>(_temp);
                    model.Messsage = "Cliente Update Successfully";
                    _Context.SaveChanges();
                    model.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
    }
}
