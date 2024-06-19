﻿using System.ComponentModel.DataAnnotations;

namespace ApiUsuarioCurso.Dto.Usuario
{
    public class UsuarioCriacaoDto
    {
        [Required(ErrorMessage = "Digite o Usuário")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o Nome")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o Sobrenome")]
        public string Sobrenome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o Email")]
        public string Email { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Digite a Senha")]
        public string Senha { get; set; } = string.Empty;


        [Required(ErrorMessage = "Digite a confirmação de senha"),
         Compare("Senha", ErrorMessage = "As senhas não são iguais")]
        public string ConfimaSenha { get; set; } = string.Empty;
    }
}
