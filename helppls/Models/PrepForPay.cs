//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace helppls.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PrepForPay
    {
        public int Id { get; set; }
        public int PayTypeId { get; set; }
        public decimal Total { get; set; }
    
        public virtual PayType PayType { get; set; }
    }
}
