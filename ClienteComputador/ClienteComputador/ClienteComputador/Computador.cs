using System.Collections.Generic;

namespace ClienteComputador
{
    public class Computador
    {
        public int codigo { get; set; }
        public string marca { get; set; } = "";
        public string fechaFabricacion { get; set; } = "";
        public string estado { get; set; } = "";
        public bool portatil { get; set; }
        public double costoMantenimiento { get; set; }
        public bool activo { get; set; }
        public List<string>? perifericos { get; set; }

        // Para mostrar en la grilla
        public string PortatilStr => portatil ? "Si" : "No";
        public string ActivoStr => activo ? "Activo" : "Inactivo";
        public string PericosStr => perifericos != null ? string.Join(", ", perifericos) : "";
    }
}
