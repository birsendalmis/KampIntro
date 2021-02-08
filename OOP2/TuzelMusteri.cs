using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    //Miras - inheritance
    //TuzelMusteri:Musteri --> bu şekilde yapılan işlem , müşterinin içinde olan tüm özellikler tuzelmusteride de var.yani burda müsteri ebeveyn.
    class TuzelMusteri:Musteri
    {
        
        public string SirkerAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
