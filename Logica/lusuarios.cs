using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oke.Logica
{
    class lusuarios
    {
        private int idusuario;
        private string usuario;
        private string pass;
        private byte[] icono;
        private string estado;

        public int Idusuario {
            get { return Idusuario; }
            set { Idusuario = value; }
        }

        public string Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        public string Pass
        {
            get { return Pass; }
            set { Pass = value; }
        }

        public byte[] Icono
        {
            get { return Icono; }
            set { Icono = value; }
        }

        public string Estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public lusuarios(int idusuario, string usuario, string pass, byte[] icono, string estado)
        {
            Idusuario = idusuario;
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            Pass = pass ?? throw new ArgumentNullException(nameof(pass));
            Icono = icono ?? throw new ArgumentNullException(nameof(icono));
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            Idusuario = idusuario;
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            Pass = pass ?? throw new ArgumentNullException(nameof(pass));
            Icono = icono ?? throw new ArgumentNullException(nameof(icono));
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
        }
    }
}
