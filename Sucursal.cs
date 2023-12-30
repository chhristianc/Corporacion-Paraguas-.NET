using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2._0_Corporacion_Paraguas
{
    class Sucursal
    {
        string codigoSucursal;
        private List<Vacuna> listaDeVacunas;
        private List<Virus> listaDeVirus;

        public Sucursal(string codigoSucursal) 
        { 
            this.codigoSucursal = codigoSucursal;
            listaDeVacunas = new List<Vacuna>();
            listaDeVirus = new List<Virus>();
        }

        public void CrearVacuna()
        {

        }

        public void SintetizarVirus()
        {

        }

        public void DestruirMedicamento()
        {

        }
        public void DestruirSegunTipo()
        {

        }
    }
}
