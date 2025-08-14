using System.ComponentModel.DataAnnotations;
using AppBlazor.Entities;
using Xunit;
namespace AppBlazor.Test
{
    public class RepresentanteFormCLSTest
    {
        private List<ValidationResult> ValidaModelo(object modelo) 
        {
            var resultado = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo, null, null);
            Validator.TryValidateObject(modelo, contexto, resultado, true);
            return resultado;
        }
        [Fact]
        public void ValidacionCamposVacios()
        {
            var representante = new RepresentanteFormCLS();
            var errores = ValidaModelo(representante);
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El numero de empleado es requerido") || e.ErrorMessage !.Contains("El numero de empleado debe ser positivo"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El nombre es requerido"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La edad es requerido"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El cargo es requerido"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La fecha de contrato es requerida"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La cuota es requerida"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La venta es requerido"));
        }
    }
}