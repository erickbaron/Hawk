using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hawk.Domain.Entities
{
    [Table("imagens")]
    public class imagem 
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("registro_ativo", TypeName = "BIT")]
        public bool RegistroAtivo { get; set; }

        [Column("data_criacao", TypeName = "DATETIME")]
        public DateTime DataCriacao { get; set; }

        public Produto produto { get; set; }

        public int IdProduto { get; set; }

        [Column("url_imagem", TypeName = "VARCHAR(100)")]
        public string UrlImagem { get; set; }

        [Column("url_imagem_hash", TypeName = "VARCHAR(100)")]
        public string UrlImagemHash { get; set; }
    }
}
