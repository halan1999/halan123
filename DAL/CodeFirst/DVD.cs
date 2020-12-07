using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CodeFirst
{
   public class DVD
    {
        [Key]
        public int id_DVD { get; set; }
        // 0 : tren ke // 1 : da thue
        public int trangThai { get; set; }

        //foreign key
        public virtual int id_TieuDe { get; set; }

        public virtual ICollection<PhieuDatTruoc> phieudattruocs { get; set; }
        public virtual ICollection<PhieuThueTra> phieuthues { get; set; }
    }
}
