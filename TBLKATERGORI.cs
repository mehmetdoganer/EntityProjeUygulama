//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjeUygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLKATERGORI
    {
        public TBLKATERGORI()
        {
            this.TBLURUN = new HashSet<TBLURUN>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
    
        public virtual ICollection<TBLURUN> TBLURUN { get; set; }
    }
}
