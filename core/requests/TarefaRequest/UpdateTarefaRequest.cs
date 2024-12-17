using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API_RESTful_para_Gestao_de_Estoque.core.enums;

namespace API_RESTful_para_Gestao_de_Estoque.core.requests.TarefaRequest
{
    public class UpdateTarefaRequest : Request
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(128, ErrorMessage = "O titulo deve conter até 128 caracteres")]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1028, ErrorMessage = "A descrição deve conter até 1028 caracteres")]
        public string Description { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateOnly? DataVencimento { get; set; } = null;

        public TarefaStatus Status { get; set; } = TarefaStatus.andamento;

        public int UsuarioId { get; set; }
    }
}