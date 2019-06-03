using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppParcial.Interface;

namespace WebAppParcial.Models
{
    public partial class Piezas : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }


    [MetadataType(typeof(PiezasMetadata))]
    public partial class Piezas
    {
        public class PiezasMetadata
        {
            [Key]
            public int Id { get; set; }

            [StringLength(100)]
            public string Nombre { get; set; }


        }
    }




}