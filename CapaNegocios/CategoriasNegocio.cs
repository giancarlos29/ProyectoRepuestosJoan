using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity.Core.Objects;

namespace CapaNegocios
{
    public class CategoriasNegocio
    {
        CategoriasDatos categoriasDatos = new CategoriasDatos();

        public Tuple<bool, int> AgregarCategoriaProd(CategoriasProd categoriaProd)
        {

            return categoriasDatos.AgregarCategoriaProd(categoriaProd);
        }

        public ObjectResult<proc_CargarTodasCategoriasProd_Result> CargarCategoriasProd()
        {
            return categoriasDatos.CargarTodasCategoriasProd();
        }
        public bool EditarCategoriaProd(CategoriasProd categoriaProd)
        {
            return categoriasDatos.EditarCategoriaProd(categoriaProd);
        }

        public bool BorrarCategoriaProd(int categoriaProdID)
        {
            return categoriasDatos.BorrarCategoriaProd(categoriaProdID);
        }

    }
}
