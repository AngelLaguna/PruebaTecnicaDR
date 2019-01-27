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
        public bool AddPersona(Persona persona)
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
                    persona.IdEstadoN,
                    persona.IdEstado,
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
    }
}
