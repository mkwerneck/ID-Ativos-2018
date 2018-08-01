using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "IDs_Sistemas")]
    public class IdentificacaoSistema
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(name: "ID_Sistema")]
        [StringLength(255)]
        [DisplayName("ID Sistema")]
        public String IDSistema { get; set; }

        [Required]
        [Column(name: "Dominio_Principal")]
        [StringLength(255)]
        [DisplayName("Domínio Principal")]
        public String DominioPrincipal { get; set; }

        [Column(name: "Dominio_Mobile")]
        [StringLength(255)]
        [DisplayName("Domínio Mobile")]
        public String DominioMobile { get; set; }

        [Column(name: "Endereço_Integracoes")]
        [StringLength(255)]
        [DisplayName("Endereço Integrações")]
        public String EnderecoIntegracoes { get; set; }

        [Column(name: "Versao_App")]
        [StringLength(255)]
        [DisplayName("Versão")]
        public String Versao { get; set; }

        [Column(name: "Logo_WEB")]
        [DisplayName("Logo Web")]
        public Byte[] LogoWeb { get; set; }

        [Column(name: "Logo_MOBILE")]
        [DisplayName("Logo Mobile")]
        public Byte[] LogoMobile { get; set; }

        [Column(name: "Imagem_Padrao")]
        [DisplayName("Imagem")]
        public Byte[] ImagemPadrao { get; set; }

        [Column(name: "login_AD")]
        [StringLength(255)]
        [DisplayName("Login AD")]
        public String loginAD { get; set; }

        [Column(name: "senha_AD")]
        [StringLength(255)]
        [DisplayName("Senha AD")]
        public String senhaAD { get; set; }

        [ForeignKey("Localizacao")]
        public int? LocalizacaoId { get; set; }
        public virtual Localizacao Localizacao { get; set; }

    }
}
