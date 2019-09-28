﻿namespace Andrea.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Fairy
    {
        public enum List
        {
            Jarra,
            Jabon,
            Jengibre
        }
        [Key]
        public int FairyID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        public string NickName { get; set; }
        [Required]
        public List Wishes { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Cumpleaños")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }
}