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

        public List<Estados> GetAllEstados()
        {
            //List<Estados> rjkn = new List<Estados>();
            List<Estados> estados = entities.Estados.ToList();
            return estados;
            //try
            //{
            //    return entities.Estados.ToList();
            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return rjkn;
            //}


        }

    }
}
