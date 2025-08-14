using System.ComponentModel.DataAnnotations;
using AppBlazor.Entities;
using Xunit;
namespace AppBlazor.Test
{
    public class RepresentanteFormCLSTest
    {
        private List<ValidationResult> ValidaModelo(object modelo)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo, null, null);
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            return resultados;
        }
        [Fact]
        public void ValidacionCamposVacios()
        {
            
            var representante = new RepresentanteFormCLS();
            var errores = ValidaModelo(representante);
       
            
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El numero de empleado es requerido") 
            || e.ErrorMessage!.Contains("El numero de empleado debe ser positivo"));

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El nombre es requerido"));

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La edad es requerida") 
            || e.ErrorMessage!.Contains("La edad debe ser mayor o igual a 18 o no debe ser mayor a 80"));

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El cargo es requerido"));

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La fecha de contrato es requerida") 
            || e.ErrorMessage!.Contains("La fecha de contrato debe ser despu�s de 1980"));

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La cuota es requerida") 
            || e.ErrorMessage!.Contains("La cuota de empleado debe ser positivo"));

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La venta es requerida") 
            || e.ErrorMessage!.Contains("La venta del empleado debe ser positivo"));
        }
        [Fact]
        public void ValidacionCamposCorrectos()
        {
            var representante = new RepresentanteFormCLS()
            {
                Num_Empl = 1, 
                Nombre = "Juanito Perez",
                Edad = 35,
                Cargo = "Representante",
                FechaContrato = new DateTime(2006, 1,1),
                Cuota = 15.0,
                Venta = 20.0
            };
            var errores = ValidaModelo(representante);
            Assert.Empty(errores);
        }
    }
}