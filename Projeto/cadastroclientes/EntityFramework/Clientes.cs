//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cadastroclientes.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int id_categoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
    }
}
