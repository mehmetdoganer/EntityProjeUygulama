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
    
    public partial class TBLURUN
    {
        public TBLURUN()
        {
            this.TBLSATIS = new HashSet<TBLSATIS>();
        }
    
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public string MARKA { get; set; }
        public Nullable<short> STOK { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> KATEGORI { get; set; }
    
        public virtual TBLKATERGORI TBLKATERGORI { get; set; }
        public virtual ICollection<TBLSATIS> TBLSATIS { get; set; }
    }
}
