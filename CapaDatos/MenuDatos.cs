using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace CapaDatos
{
    public class MenuDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectResult<proc_Menu_1_Result> menuOpcionesUser;
        ObjectResult<proc_Menu_2_Result> menuOpcionesAdmin;
        ObjectResult<proc_SubMenu_1_Result> subMenuOpcionesUser;
        ObjectResult<proc_SubMenu_2_Result> subMenuOpcionesAdmin;

        public ObjectResult<proc_Menu_1_Result> opcionesMenuUserDA()
        {
            var resultado = modelDB.proc_Menu_1();
           
            menuOpcionesUser = resultado;
            
            return menuOpcionesUser;
        }
        public ObjectResult<proc_Menu_2_Result> opcionesMenuAdminDA()
        {
            var resultado = modelDB.proc_Menu_2();

            menuOpcionesAdmin = resultado;

            return menuOpcionesAdmin;
        }

        public ObjectResult<proc_SubMenu_1_Result> opcionesSubMenuUserDA()
        {
            var resultado = modelDB.proc_SubMenu_1();

            subMenuOpcionesUser = resultado;

            return subMenuOpcionesUser;
        }
        public ObjectResult<proc_SubMenu_2_Result> opcionesSubMenuAdminDA()
        {
            var resultado = modelDB.proc_SubMenu_2();

            subMenuOpcionesAdmin = resultado;

            return subMenuOpcionesAdmin;
        }

    }
}
