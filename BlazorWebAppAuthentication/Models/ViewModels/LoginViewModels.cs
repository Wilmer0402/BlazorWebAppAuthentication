﻿using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppAuthentication.Models.ViewModels
{
    public class LoginViewModels
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por Favor Ingrese el Nombre de Usuario")]

        public string? Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por Favor Ingrese su Password")]

        public string? Password { get; set; }

    }
}
