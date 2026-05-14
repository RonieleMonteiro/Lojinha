using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.DAL
{
    public class Dados
    {
        public static string StringConexao
        {
            get 
            {
                return  @"Data Source=DESKTOP-PHMQ9A5\MSSQLSERVER02;Initial Catalog=dblojinha;Integrated Security=True;Encrypt=False";
            }
            
        }
    }
}