using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Login
    {
        public static ML.Result LoginUsuario(ML.Login login)
        {
            ML.Result result = new ML.Result();
            using (DL.PruebaTecnicaEntities context =new DL.PruebaTecnicaEntities())
            {
                var query = context.UsuarioLogin(login.Usuario, login.Contraseña);
                if (query != null)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.Message = "No se pudo iniciar sesion";
                }
            }
                return result;
        }
    }
}
