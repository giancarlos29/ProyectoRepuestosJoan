using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using CapaDatos;

namespace CapaNegocios
{
    public class MenuNegocio
    {        
        MenuDatos menuDatos = new MenuDatos();
        public ObjectResult<proc_Menu_1_Result> opcionesMenuUserNE()
        {
            return menuDatos.opcionesMenuUserDA();
        }

        public ObjectResult<proc_Menu_2_Result> opcionesMenuAdminNE()
        {
            return menuDatos.opcionesMenuAdminDA();
        }
        public ObjectResult<proc_SubMenu_1_Result> opcionesSubMenuUserNE()
        {
            return menuDatos.opcionesSubMenuUserDA();
        }

        public ObjectResult<proc_SubMenu_2_Result> opcionesSubMenuAdminNE()
        {
            return menuDatos.opcionesSubMenuAdminDA();
        }
    }
}
