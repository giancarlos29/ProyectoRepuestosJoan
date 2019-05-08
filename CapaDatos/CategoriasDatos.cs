using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace CapaDatos
{
    public class CategoriasDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter categoriaProdID = new ObjectParameter("CategoriaProdID", typeof(int));

        public ObjectResult<proc_CargarTodasCategoriasProd_Result> CargarTodasCategoriasProd()
        {
            var result = modelDB.proc_CargarTodasCategoriasProd();

            return result;
        }
        public Tuple<bool, int> AgregarCategoriaProd(CategoriasProd categoriaProd)
        {
            modelDB.proc_InsertarCategoriaProd(categoriaProdID, categoriaProd.Categoria, resultado);

            return Tuple.Create((bool)resultado.Value, (int)categoriaProdID.Value);
        }

        public bool EditarCategoriaProd(CategoriasProd categoriaProd)
        {
            modelDB.proc_ActualizarCategoriaProd(categoriaProd.CategoriaProdID, categoriaProd.Categoria, resultado);
            return (bool)resultado.Value;
        }

        public bool BorrarCategoriaProd(int categoriaProdID)
        {
            modelDB.proc_BorrarCategoriaProd(categoriaProdID, resultado);
            return (bool)resultado.Value;
        }

    }
}
