namespace EntidadeDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("licenca")]
    public partial class licenca
    {
        public string chave { get; set; }

        public string chave1 { get; set; }

        public string chave2 { get; set; }

        public int idCliente { get; set; }

        public string chave3 { get; set; }

        [Key]
        public int idLicenca { get; set; }

        public virtual cliente cliente { get; set; }
    }
}
