﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreSeriesAWSBeanstalk.Models
{

    [Table("SERIES")]
    public class Serie
    {
        [Key]
        [Column("IDSERIE")]
        public int IdSerie { get; set; }
        [Column("SERIE")]
        public string Nombre { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
        [Column("ANYO")]
        public int Anyo { get; set; }


    }
}
