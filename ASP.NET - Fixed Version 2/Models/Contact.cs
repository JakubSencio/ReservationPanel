namespace ASP.NET___Fixed_Version_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

public class Contact
{
    
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać imię!")]
        public string Name { get; set; }

        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required(ErrorMessage = "Proszę podać poprawny email!")]
        public string Email { get; set; }

        public string Subject { get; set; }

        [MinLength(5, ErrorMessage = "Wiadomość musi mieć co najmniej 5 znaków!")]
        [Required(ErrorMessage = "Proszę wpisać wiadomość!")]
        public string Message { get; set; }

        public Priority Priority { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
    } 
