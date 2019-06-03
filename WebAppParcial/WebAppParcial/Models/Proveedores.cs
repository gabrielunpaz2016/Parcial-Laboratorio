using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppParcial.Interface;

namespace WebAppParcial.Models
{
    public partial class Proveedores : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

    }


    [MetadataType(typeof(ProveedoresMetadata))]
    public partial class Proveedores
    {
        public class ProveedoresMetadata
        {
            [Key]
            public char Id { get; set; }

            [StringLength(100)]
            public string Nombre { get; set; }
            

        }
    }




}