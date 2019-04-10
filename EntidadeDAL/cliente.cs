namespace EntidadeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cliente")]
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            licenca = new HashSet<licenca>();
        }

        [Key]
        public int idCliente { get; set; }

        [Required]
        public string razaoSocial { get; set; }

        [Required]
        public string nomeTitular { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Column(TypeName = "date")]
        public DateTime dtCadastro { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        [StringLength(13)]
        public string cnpj { get; set; }

        public bool ativo { get; set; }

        public string chaveApi { get; set; }

        public string facebook { get; set; }

        [StringLength(50)]
        public string sfacebook { get; set; }

        public string whatsapp { get; set; }

        [StringLength(50)]
        public string swhatsapp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<licenca> licenca { get; set; }
    }
}
