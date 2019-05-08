using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace CapaDatos
{
    public class UsersDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("Resultado", typeof(bool));
        ObjectParameter userID = new ObjectParameter("UserID", typeof(int));
        proc_ValidarUsuario_Result proc_ValidarUsuario;

        public Tuple<bool, proc_ValidarUsuario_Result> ValidarUsuario(User user)
        {

            var result = modelDB.proc_ValidarUsuario(user.UserName, user.UserPassword, resultado).FirstOrDefault();
            proc_ValidarUsuario = result;
            return Tuple.Create((bool)resultado.Value,proc_ValidarUsuario);
            
        }               

        public ObjectResult<proc_CargarTodosUsers_Result> CargarTodosUsers()
        {
            var result = modelDB.proc_CargarTodosUsers();

            return result;
        }
        public Tuple<bool, int> AgregarUser(User user)
        {
            modelDB.proc_InsertarUser(userID, user.UserName, user.UserPassword, user.UserLevel, resultado);

            return Tuple.Create((bool)resultado.Value, (int)userID.Value);
        }

        public bool EditarUser(User user)
        {
            modelDB.proc_ActualizarUsers(user.UserID, user.UserName, user.UserPassword, user.UserLevel, resultado);
            return (bool)resultado.Value;
        }

        public bool BorrarUser(int userID)
        {
            modelDB.proc_BorrarUser(userID, resultado);
            return (bool)resultado.Value;
        }

    }
}
