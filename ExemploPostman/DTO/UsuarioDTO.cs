using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ExemploPostman.DTO
{
    public class UsuarioDTO
    {
        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        /// <value>
        /// The login.
        /// </value>
        [Required]
        public string Login { get; set; }

        [Required]
        public string Senha { get; set; }

        [JsonIgnore]
        public string LoginConvertido => Login.FromBase64();

        [JsonIgnore]
        public string SenhaConvertida => Senha.FromBase64();
    }
}
