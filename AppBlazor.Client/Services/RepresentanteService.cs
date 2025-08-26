using AppBlazor.Entities;

namespace AppBlazor.Client.Services
{
    public class RepresentanteService
    {
        private List<RepresentanteListCLS> lista;
        public RepresentanteService()
        {
            lista = new List<RepresentanteListCLS>();
            lista.Add(new RepresentanteListCLS { Num_empl = 1, Nombre = "Juanito Perez", Edad = 25, Cargo = "Vendedor", FechaContrato = new DateTime(2006, 3, 1), Cuota = 10, Venta = 15 });
            lista.Add(new RepresentanteListCLS { Num_empl = 2, Nombre = "Juanito Perez", Edad = 25, Cargo = "Vendedor", FechaContrato = new DateTime(2006, 3, 1), Cuota = 10, Venta = 15 });
            lista.Add(new RepresentanteListCLS { Num_empl = 3, Nombre = "Juanito Perez", Edad = 25, Cargo = "Vendedor", FechaContrato = new DateTime(2006, 3, 1), Cuota = 10, Venta = 15 });
            lista.Add(new RepresentanteListCLS { Num_empl = 4, Nombre = "Juanito Perez", Edad = 25, Cargo = "Vendedor", FechaContrato = new DateTime(2006, 3, 1), Cuota = 10, Venta = 15 });
            lista.Add(new RepresentanteListCLS { Num_empl = 5, Nombre = "Juanito Perez", Edad = 25, Cargo = "Vendedor", FechaContrato = new DateTime(2006, 3, 1), Cuota = 10, Venta = 15 });
        }
        public List<RepresentanteListCLS> listarRepresentante() 
        {
            return lista;
        }
        public void eliminarRepresentante(int num_empl)
        {
            var listaQueda = lista.Where(p => p.Num_empl != num_empl).ToList();
            lista = listaQueda;
        }
    }
}
