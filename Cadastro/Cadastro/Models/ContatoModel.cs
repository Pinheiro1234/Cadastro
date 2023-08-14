using System.ComponentModel.DataAnnotations;

namespace Cadastro.Models
{
    public class ContatoModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do cliente")]
        [EmailAddress(ErrorMessage = " O e-mail Informado não é valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do cliente")]
        [Phone(ErrorMessage = " O Celular Informado não é valido!")]
        public string Celular { get; set; }
        
        public int Cpf { get; set; }
        
        public int Rg { get; set; }

        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int N { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }



    }
}
