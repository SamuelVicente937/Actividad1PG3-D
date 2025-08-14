using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Entities
{
    public class RepresentanteFormCLS
    {
        [Required(ErrorMessage = "El numero de empleado es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El numero de empleado debe ser positivo")]
        public int Num_Empl { get; set; }   
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(60, ErrorMessage = "La longitud maxima es 60 caracteres")]
        [MinLength(5, ErrorMessage = "La longitud minima es de 5 caracteres")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "La edad es requerida")]
        [Range(18, 80, ErrorMessage ="La edad debe ser mayor o igual a 18 o no debe ser mayor a 80") ]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El cargo es requerido")]
        [MaxLength(15, ErrorMessage = "La longitud maxima es 15 caracteres")]
        public string Cargo { get; set; } = string.Empty ;
        [Required(ErrorMessage = "La fecha de contrato es requerida")]
        [DataType(DataType.Date, ErrorMessage = "Por favor ingresa una fecha válida")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1960-01-01", "9999-12-31", ErrorMessage = "La fecha de contrato debe ser después de 1980")]
        public DateTime FechaContrato { get; set; }
        [Required(ErrorMessage = "La cuota es requerida")]
        [Range(1, double.MaxValue, ErrorMessage = "La cuota de empleado debe ser positivo")]
        public double Cuota { get; set; }
        [Required(ErrorMessage = "La venta es requerida")]
        [Range(1, double.MaxValue, ErrorMessage = "La venta del empleado debe ser positivo")]
        public double Venta { get; set; }

    }
}
