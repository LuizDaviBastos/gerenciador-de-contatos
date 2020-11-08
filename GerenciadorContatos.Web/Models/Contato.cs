using GerenciadorContatos.Resources;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "MSG_E_REQUIRED", ErrorMessageResourceType = typeof(Mensagens))]
        public string Nome { get; set; }

        [Display(Name = "Sobre Nome")]
        [Required(ErrorMessageResourceName = "MSG_E_REQUIRED", ErrorMessageResourceType = typeof(Mensagens))]
        public string SobreNome { get; set; }

        [Phone(ErrorMessageResourceName = "MSG_E_REQUIRED", ErrorMessageResourceType = typeof(Mensagens))]
        [Required(ErrorMessageResourceName = "MSG_E_REQUIRED", ErrorMessageResourceType = typeof(Mensagens))]
        public string Celular { get; set; }

        [Required(ErrorMessageResourceName = "MSG_E_REQUIRED", ErrorMessageResourceType = typeof(Mensagens))]
        [EmailAddress(ErrorMessageResourceName = "MSG_E_EMAIL", ErrorMessageResourceType = typeof(Mensagens))]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
