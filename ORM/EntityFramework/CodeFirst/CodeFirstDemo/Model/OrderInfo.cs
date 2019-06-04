/*
 * CLR Version：4.0.30319.42000
 * NameSpace：CodeFirstDemo.Model
 * FileName：OrderInfo
 * CurrentYear：2019
 * CurrentTime：2019/6/3 16:39:46
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/3 16:39:46 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Model
{
    class OrderInfo
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
    }
}
