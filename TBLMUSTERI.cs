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
    
    public partial class TBLMUSTERI
    {
        public TBLMUSTERI()
        {
            this.TBLSATIS = new HashSet<TBLSATIS>();
        }
    
        public int MUSTERIID { get; set; }
        public string MUSTERIAD { get; set; }
        public string MUSTERISOYAD { get; set; }
        public string SEHIR { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        public virtual ICollection<TBLSATIS> TBLSATIS { get; set; }
    }
}
