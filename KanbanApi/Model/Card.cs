using System;
using System.ComponentModel.DataAnnotations;

namespace KanbanApi.Model
{
    public class Card
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        [Required]
        public string Lista { get; set; }
    }
}
