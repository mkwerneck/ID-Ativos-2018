using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "CadastroLocalTable")]
    public class Localizacao
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Código")]
        [Column(name:"Codigo_Local")]
        public String Codigo { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Descrição")]
        [Column(name: "Descricao_Local")]
        public String Descricao { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Endereço")]
        [Column(name: "Endereco_Local")]
        public String Endereco { get; set; }

        [Column(name: "Latitude_Local")]
        public float Latitude { get; set; }

        [Column(name: "Longitude_Local")]
        public float Longitude { get; set; }

        [StringLength(255)]
        [Column(name: "Raio_LocalizacaoGPS")]
        [DisplayName("Raio Localização GPS(m)")]
        public String RaioLocalizacao { get; set; }

        [StringLength(255)]
        [Column(name: "MapData")]
        [DisplayName("Latitude / Longitude")]
        public String MapData { get; set; }

        [Column(name: "Planta_Local")]
        public Byte[] Planta { get; set; }

        [Column(name: "Imagem_Local")]
        public Byte[] Imagem { get; set; }

        [StringLength(255)]
        [Column(name: "Bairro_Local")]
        public String Bairro { get; set; }

        [StringLength(255)]
        [Column(name: "CEP_Local")]
        public String CEP { get; set; }

        [Required]
        [ForeignKey("Cidade")]
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }

        [Required]
        [ForeignKey("Estado")]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        [Required]
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }

        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
