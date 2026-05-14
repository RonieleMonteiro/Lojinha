using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.DAL;
using Lojinha.Modelos;
namespace Lojinha.BLL
{
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            // o nome do cliente é obrigtório
            if (cliente.Nome.Trim().Length == 0) 
            {
                throw new Exception("O nome do cliente é obrigatorio");  
                     
                                  
            }
            //Email é sempre em letras minúsculas 
            cliente.Email = cliente.Email.ToLower();
            // Se está tudo Ok, chama a rotina de inserção
            ClientesDAL obj = new ClientesDAL();
            obj.Incluir(cliente);

        }
        public void Alterar(ClienteInformation cliente) 
        {

            // o nome do cliente é obrigtório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");

            }
            //Email é sempre em letras minúsculas 
            cliente.Email = cliente.Email.ToLower();
            // Se está tudo Ok, chama a rotina de alteração
            ClientesDAL obj = new ClientesDAL();
            obj.Alterar(cliente);

        }
        public void Excluir(int codigo)
        {

           
            if (codigo < 0)
            {
                throw new Exception("Selecione um clinete antes de excluir");

            }
            
            ClientesDAL obj = new ClientesDAL();
            obj.Excluir(codigo);

        }
        public DataTable Listagem(string filtro) 
        {

            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro);     
        
        }


    }
}
