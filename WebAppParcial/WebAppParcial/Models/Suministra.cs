using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppParcial.Interface;

namespace WebAppParcial.Models
{
    public partial class Suministra : IEntity
    {
        public int Id { get; set; }
        public int CodigoPieza { get; set;}
        public char IdProveedor { get; set; }
        public int Precio { get; set; }
        
        
    }

    [MetadataType(typeof(SuministraMetadata))]
    public partial class Suministra
    {
        public class SuministraMetadata
        {
            [Key]
            public char Id { get; set; }

            [ForeignKey]
            public int CodigoPieza { get; set; }
            
            public char IdProveedor { get; set; }

            public int Precio { get; set; }


        }
    }



}