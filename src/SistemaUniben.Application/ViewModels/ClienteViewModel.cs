﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace SistemaUniben.Application.ViewModels
{
	public class ClienteViewModel
	{
		[Key]
		public int ClienteId { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Sobrenome { get; set; }

		[ScaffoldColumn(false)]
		public DateTime DataCadastro { get; set; }
	}
}