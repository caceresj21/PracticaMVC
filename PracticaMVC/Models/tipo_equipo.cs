﻿using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class tipo_equipo
    {
        [Key]
        [Display(Name = "ID tipo de equipo")]
        public int id_tipo_equipo { get; set; }

        [Display(Name = "Descripcion")]
        public string? descripcion { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}