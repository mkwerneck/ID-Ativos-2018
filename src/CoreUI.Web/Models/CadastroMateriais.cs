using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Cadastro_MateriaisTables")]
    public class CadastroMateriais
    {

        [Required]
        public int Id { get; set; }

        public String NumSerie { get; set; }

        public String Patrimonio { get; set; }

        [Required]
        public float Quantidade { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataFabricacao { get; set; }

        public DateTime DataValidade { get; set; }

        public String TAGID { get; set; }

        public decimal ValorUnitario { get; set; }

        public float SaldoItem { get; set; }

        public String SaldoItemInventario { get; set; }

        public String UsuarioExecucao { get; set; }

        public Byte[] Imagem { get; set; }

        public String HiperLink { get; set; }

        public Boolean FlagEntrada { get; set; }

        public Boolean FlagDiscrepancia { get; set; }
        
        public float Peso { get; set; }

        public String UltimaPosicao { get; set; }

        public String UltimaLocalizacao { get; set; }

        public DateTime DataHoraLocalizacao { get; set; }

        public String DadosTecnicos { get; set; }

        public String IdOmni { get; set; }

        public String UltimoCautela { get; set; }

        public String UltimoMecanico { get; set; }

        public String UltimoDBOS { get; set; }

        public DateTime UltimoDataEmprestimo { get; set; }

        public String UltimoProcesso { get; set; }

        public int NotaFiscal { get; set; }

        public DateTime DataEntradaNotaFiscal { get; set; }

        public Boolean FlagContentor { get; set; }

    }
}
