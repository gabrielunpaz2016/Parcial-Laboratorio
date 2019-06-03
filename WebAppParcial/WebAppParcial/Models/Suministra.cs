using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppParcial.Interface;

namespace WebAppParcial.Models
{
    public partial class Suministra : IEntity
    {
        public int Id { get; set; }
        public int Precio { get; set; }
    }
}