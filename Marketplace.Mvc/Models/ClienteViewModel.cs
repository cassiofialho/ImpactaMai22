using System.ComponentModel.DataAnnotations;

namespace Marketplace.Mvc.Models
{
    public class ClienteViewModel
    {
     
        public int Id { get; set; }
        [Required]
        [RegularExpression("^\\d{3}.\\d{3}.\\d{3}-\\d{2}$",ErrorMessage ="Digite o CPF no formato: 999.999.999-99")]
        public string Documento { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required]
        //[Phone()]
        public string Telefone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}