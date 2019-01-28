using frmTecnico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTecnico.Controller
{
    class EstadoController
    {
        PruebaTecnicaEntities entities = new PruebaTecnicaEntities();

        /// <summary>
        /// Metodo para registrar un estado en la base de datos
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool AddEstado(Estados estado)
        {
            try
            {
                entities.Estados.Add(estado);
                entities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Metodo para obtenr todos los Estados registrados de frmEstados
        /// </summary>
        /// <returns></returns>
        public List<Estados> GetAllEstados()
        {
            List<Estados> estados = entities.Estados.ToList();
            return estados;
        }

    }
}
