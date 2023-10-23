namespace ControlASP.Entidades
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;




        [Table("FacturasVtosPendientes")]
        public class FacturasVtosPendientesModel
        {
            [Key]
            [Column("henfID")]
            public int Id { get; set; }

            [Column("henfNumFra")]
            public int NumFra { get; set; }

            [Column("henfFNombre")]
            [MaxLength(100)]
            public string FNombre { get; set; }

            [Column("henfFCIF")]
            [MaxLength(20)]
            public string FCIF { get; set; }

            [Column("henfFDireccion")]
            [MaxLength(50)]
            public string FDireccion { get; set; }

            [Column("henfFPoblacion")]
            [MaxLength(50)]
            public string FPoblacion { get; set; }

            [Column("henfFCodPostal")]
            [MaxLength(6)]
            public string FCodPostal { get; set; }

            [Column("henfFProvincia")]
            [MaxLength(50)]
            public string FProvincia { get; set; }

            [Column("henfFPais")]
            [MaxLength(5)]
            public string FPais { get; set; }

            [Column("henfProforma")]
            public int? Proforma { get; set; }

            [Column("henfEstanciaReal")]
            public bool? EstanciaReal { get; set; }

            [Column("henfBono")]
            [MaxLength(30)]
            public string Bono { get; set; }

            [Column("henfFechaCierre")]
            public DateTime? FechaCierre { get; set; }

            [Column("henfAsientoAsignado")]
            public int AsientoAsignado { get; set; }

            [Column("henfCerradaEl")]
            public DateTime? CerradaEl { get; set; }

            [Column("NumeroAbono")]
            public int? NumeroAbono { get; set; }

            [Column("fabFecha")]
            public DateTime? Fecha { get; set; }

            [Column("fabEsTotal")]
            public bool? EsTotal { get; set; }

            [Column("fabAsiento")]
            public int? Asiento { get; set; }

            [Column("hefcImporte", TypeName = "money")]
            public decimal Importe { get; set; }

            [Column("hefcTipoCierre")]
            public byte TipoCierre { get; set; }

            [Column("hefcCuenta")]
            [MaxLength(12)]
            public string Cuenta { get; set; }

            [Column("hefcFoPago")]
            public int? FoPago { get; set; }

            [Column("hefcContraCuenta")]
            [MaxLength(12)]
            public string ContraCuenta { get; set; }

            [Column("hvtVto")]
            public DateTime Vto { get; set; }

            [Column("ImporteFactura", TypeName = "money")]
            public decimal ImporteFactura { get; set; }

            [Column("ImportePagado", TypeName = "money")]
            public decimal ImportePagado { get; set; }

            [Column("ImportePdte", TypeName = "money")]
            public decimal ImportePdte { get; set; }
        }



        [Table("Clientes")]
        public class ClientesModel
        {
            [Key]
            [Column("cliCodigo")]
            [StringLength(20)]
            public string Codigo { get; set; }

            [Column("cliTipo")]
            public byte? Tipo { get; set; }

            [Column("cliDescriptor")]
            [StringLength(50)]
            public string Descriptor { get; set; }

            [Column("cliNombre")]
            [StringLength(50)]
            public string Nombre { get; set; }

            [Column("cliCIF")]
            [StringLength(20)]
            public string CIF { get; set; }

            [Column("cliCDireccion")]
            [StringLength(50)]
            public string Direccion { get; set; }

            [Column("cliCPoblacion")]
            [StringLength(50)]
            public string CPoblacion { get; set; }

            [Column("cliCCodPostal")]
            [StringLength(6)]
            public string CCodPostal { get; set; }

            [Column("cliCProvincia")]
            [StringLength(50)]
            public string CProvincia { get; set; }

            [Column("cliCPais")]
            [StringLength(5)]
            public string CPais { get; set; }

            [Column("cliFDireccion")]
            [StringLength(50)]
            public string FDireccion { get; set; }

            [Column("cliFPoblacion")]
            [StringLength(50)]
            public string FPoblacion { get; set; }

            [Column("cliFCodPostal")]
            [StringLength(6)]
            public string FCodPostal { get; set; }

            [Column("cliFProvincia")]
            [StringLength(50)]
            public string FProvincia { get; set; }

            [Column("cliFPais")]
            [StringLength(5)]
            public string FPais { get; set; }

            [Column("cliTel0")]
            [StringLength(256)]
            public string Tel0 { get; set; }

            [Column("cliTel1")]
            [StringLength(256)]
            public string Tel1 { get; set; }

            [Column("cliTel2")]
            [StringLength(256)]
            public string Tel2 { get; set; }

            [Column("cliFax0")]
            [StringLength(256)]
            public string Fax0 { get; set; }

            [Column("cliFax1")]
            [StringLength(256)]
            public string Fax1 { get; set; }

            [Column("cliFax2")]
            [StringLength(256)]
            public string Fax2 { get; set; }

            [Column("cliEMail")]
            [StringLength(256)]
            public string EMail { get; set; }

            [Column("cliHTTP")]
            [StringLength(256)]
            public string HTTP { get; set; }

            [Column("cliDirector")]
            [StringLength(256)]
            public string Director { get; set; }

            [Column("cliPersBook")]
            [StringLength(256)]
            public string PersBook { get; set; }

            [Column("cliMorosa")]
            public byte? Morosa { get; set; }

            [Column("cliTPrepago")]
            public bool? TPrepago { get; set; }

            [Column("cliCredito")]
            public bool? Credito { get; set; }

            [Column("cliNacionalidad")]
            public int? Nacionalidad { get; set; }

            [Column("cliIdioma")]
            public int? Idioma { get; set; }

            [Column("cliTipoDef")]
            public int? TipoDef { get; set; }

            [Column("cliObs")]
            [StringLength(255)]
            public string Observaciones { get; set; }

            [Column("cliCreacion")]
            public DateTime? Creacion { get; set; }

            [Column("NombreComp")]
            [StringLength(102)]
            public string NombreCompleto { get; set; }
        }

        [Table("PagosACuenta")]
        public class PagosACuentaModel
        {
            [Key]
            [Required]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Column("pacNumero")]
            public int Numero { get; set; }
            [Required]
            [MaxLength(20)]
            [Column("pacCliente")]
            public string Cliente { get; set; }
            [Required]
            [MaxLength(50)]
            [Column("pacDescripcion")]
            public string Descripcion { get; set; }
            [Required]
            [Column("pacFecha")]
            public DateTime Fecha { get; set; }
            [Required]
            [Column("pacImporte")]
            public decimal Importe { get; set; }
            [Required]
            [Column("pacOrigenDoc")]
            public byte OrigenDoc { get; set; }
            [Required]
            [Column("pacNumDoc")]
            public int NumDoc { get; set; }
            [Required]
            [MaxLength(12)]
            [Column("pacCtaBanco")]
            public string CtaBanco { get; set; }
            [Required]
            [MaxLength(12)]
            [Column("pacCtaGtos")]
            public string CtaGtos { get; set; }
            [Required]
            [Column("pacGastos")]
            public decimal Gastos { get; set; }
            [Required]
            [Column("pacAsiento")]
            public int Asiento { get; set; }
            [Column("pacRetro")]
            public int? Retro { get; set; }

            //[NotMapped]
            //public string cliCtaConta { get; set; }
        }


        [Table("PagosACuentaAbo")]
        public class PagosACuentaAboModel
        {
            [Key]
            [Required]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Column("pcaID")]
            public int ID { get; set; }
            [Column("pcaNumero")]
            public int? Numero { get; set; }
            [Column("pcaFecha")]
            public DateTime? Fecha { get; set; }
            [Column("pcaImporte")]
            public decimal? Importe { get; set; }
            [Required]
            [Column("pcaOrigen")]
            public byte Origen { get; set; }
            [Column("pcaNumDoc")]
            public int? NumDoc { get; set; }
            [Column("pcaAsiento")]
            public int? Asiento { get; set; }
            [MaxLength(12)]
            [Column("pcaCtaCliente")]
            public string CtaCliente { get; set; }
        }

    
}


