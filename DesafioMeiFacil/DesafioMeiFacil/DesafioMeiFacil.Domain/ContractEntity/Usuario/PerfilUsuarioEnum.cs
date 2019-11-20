using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMeiFacil.Domain.ContractEntity.Usuario
{
    public enum PerfilUsuarioEnum : int
    {
        [Description("Usuario")]
        Usuario = -1,
        [Description("Administrador")]
        Administrador = -2
    }
}
