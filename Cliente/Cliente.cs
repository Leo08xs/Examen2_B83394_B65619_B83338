using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Cliente
    {
        private int clienteID;
        private String nombre;
        private String Apellidos;

        public void ClienteP(int ID, String nom, String ape)
        {

            clienteID = ID;
            nombre = nom;
            Apellidos = ape;

        }

        public void ClienteV() { 
        
        }


        public void setClienteID(int ID)
        {
            this.clienteID = ID;
        }

        public int getclienteID()
        {
            return this.clienteID;
        }

        public void setNombre(String nombre){
            this.nombre = nombre;
}

        public String getNombre()
        {
            return this.nombre;
        }

        public void setApellidos(String apellidos)
        {
            this.Apellidos = apellidos;
        }

        public String getApellidos()
        {
            return this.Apellidos;
        }


    }
}
