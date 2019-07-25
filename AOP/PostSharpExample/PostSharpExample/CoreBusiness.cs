using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpExample
{
    class CoreBusiness
    {
        [Logging(BusinessName = "预定房间")]
        [ExceptionAspectDemo]
        public  void Describe(string memberName, string roomNumber, AgvMap myParam)
        {
            System.Windows.Forms.MessageBox.Show(String.Format("尊敬的会员{0}，恭喜您预定房间{1}成功！", memberName, roomNumber), "提示");

            //此处故意报错
            throw new Exception("我就错了，咋地");
        }
    }
}
