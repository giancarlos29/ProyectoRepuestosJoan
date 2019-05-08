using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity.Core.Objects;


namespace CapaNegocios
{
    public class UsersNegocio
    {
        UsersDatos userDatos = new UsersDatos();

        public Tuple<bool, proc_ValidarUsuario_Result> ValidarUsuario(User user)
        {           

            return userDatos.ValidarUsuario(user);   
        }

        public ObjectResult<proc_CargarTodosUsers_Result> CargarTodosUsers()
        {
            return userDatos.CargarTodosUsers();
        }

        public Tuple<bool, int> AgregarUser(User user)
        {

            return userDatos.AgregarUser(user);
        }

        public bool EditarUser(User user)
        {
            return userDatos.EditarUser(user);
        }

        public bool BorrarUser(int userID)
        {
            return userDatos.BorrarUser(userID);
        }
    }
}
