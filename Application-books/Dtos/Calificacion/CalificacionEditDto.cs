<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace Application_books.Dtos.Calificacion
{
    public class CalificacionEditDto
    {
        [Display(Name = "Calificacion")]
        [Required(ErrorMessage = "El valor de estrellas es requerido.")]
        public int Calificacion { get; set; }
        [Display(Name = "Comentario")]
        [Required(ErrorMessage = "El comentario es requrido.")]
        public string Comentario { get; set; }
=======
﻿namespace Application_books.Dtos.Calificacion
{
    public class CalificacionEditDto : CalificacionCreateDto
    {
>>>>>>> 05a8ee66c43c0e33b97da97cfe17dc4345c9bd9c
    }
}
