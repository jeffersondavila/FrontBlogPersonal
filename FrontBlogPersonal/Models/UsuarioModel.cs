﻿using System.ComponentModel.DataAnnotations;

namespace FrontBlogPersonal.Models
{
    public class UsuarioModel
    {
        public int CodigoUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public int CodigoEstadoUsuario { get; set; }
        public DateTime? FechaUltimoAcceso { get; set; }
        public List<BlogModel> Blogs { get; set; } = new List<BlogModel>();
    }

    // Clase para obtener el token y la informacion de un usuario logeado
    public class UsuarioLoginResponseModel
    {
        public string? Token { get; set; }
        public UsuarioModel? Usuario { get; set; }
    }

    // Clase que obtiene la informacion necesaria para registrar a un usuario
    public class UsuarioCreateModel
    {
        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(200, ErrorMessage = "El nombre no debe exceder los 200 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El correo es requerido.")]
        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contraseña debe tener entre 6 y 100 caracteres.")]
        public string? Password { get; set; }
    }

    // Clase que obtiene la informacion necesaria para hacer un login
    public class UsuarioLoginModel
    {
        [Required(ErrorMessage = "El correo es requerido.")]
        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        public string? Password { get; set; }
    }

    // Clase para obtener la informacion para recuperar la contraseña
    public class UsuarioRecuperarPasswordModel
    {
        [Required(ErrorMessage = "El correo es requerido.")]
        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
        public string? Correo { get; set; }
    }

    // Clase para obtener la informacion para restablecer la contraseña
    public class UsuarioRestablecerPasswordModel
    {
        [Required(ErrorMessage = "El token de recuperación es requerido.")]
        public string? TokenRecuperacion { get; set; }

        [Required(ErrorMessage = "La nueva contraseña es requerida.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contraseña debe tener entre 6 y 100 caracteres.")]
        public string? NuevaPassword { get; set; }
    }
}
