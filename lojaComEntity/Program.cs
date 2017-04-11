using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();

            Usuario weslley = new Usuario()
            {
                Nome = "Weslley",
                Senha = "123"
            };

            contexto.Usuarios.Add(weslley);
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
