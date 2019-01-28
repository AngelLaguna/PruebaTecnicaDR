using frmTecnico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTecnico.Controller
{
    class PersonaController
    {
        PruebaTecnicaEntities entities = new PruebaTecnicaEntities();
        public bool AddPersona(Persona persona, Estados es, Estados es2)
        {
            try
            {
                var con = new PruebaTecnicaEntities();
                con.InsertaPersona(
                    persona.Nombre,
                    persona.ApPaterno,
                    persona.ApMaterno,
                    persona.FNacimiento,
                    persona.Sexo,
                    persona.Telefono,
                    es.Estado,
                    es2.Estado,
                    persona.Delegacion,
                    persona.Colonia,
                    persona.Calle,
                    persona.Numero
                    );
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<SelectAllPersonas_Result> GetAllPersonas()
        {
            List<SelectAllPersonas_Result> allP = new List<SelectAllPersonas_Result>();
            try
            {
                allP = entities.SelectAllPersonas().ToList();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return allP;
        }

    }
}
