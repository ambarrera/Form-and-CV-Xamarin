using System;
using System.Collections.Generic;

namespace TuApp
{
    public class CVModel
    {
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }
        public string Contacto { get; set; }
        public string Nacionalidad { get; set; }
        public string NivelIngles { get; set; }
        public List<string> LenguajesProgramacion { get; set; }
        public List<string> Aptitudes { get; set; }
        public List<string> Habilidades { get; set; }
        public string Perfil { get; set; }
    }
}