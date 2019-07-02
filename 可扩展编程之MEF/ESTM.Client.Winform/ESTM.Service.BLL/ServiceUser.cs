using ESTM.Common.Model;
using ESTM.Service.DAL;
using ESTM.Service.IBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Service.BLL
{
    [Export("Users",typeof(IServiceUser))]
    public class ServiceUser : IServiceUser
    {


        //需要注意：1.添加服务引用在Client.Bll里面，所以，WCF连接的配置要拷贝到Winform项目下面的App.Config里面
        //2.DAL里面的连接字符串也要拷贝到WCF里面，原因同上

        public List<DTO_USERS> GetAllUser()
        {
            var lstRes = new List<DTO_USERS>();
            var oService = new DAL.ServiceUser();
            var lstEFModel = oService.GetAllUsers();

            //一般用AutoMapper将EF的Model转换成DTO的Model.z这里为了测试，我们暂且手动转换。使用反射转换
            var lstEFModelProp = typeof(TB_USERS).GetProperties();
            var lstDTOModelProp = typeof(DTO_USERS).GetProperties();
            foreach (var oEFModel in lstEFModel)
            {
                var oResUser = new DTO_USERS();
                foreach (var oProp in lstEFModelProp)
                {
                    var oDTOMOdelProp = lstDTOModelProp.FirstOrDefault(x => x.Name == oProp.Name);
                    if (oDTOMOdelProp == null)
                    {
                        continue;
                    }

                    oDTOMOdelProp.SetValue(oResUser, oProp.GetValue(oEFModel));
                }
                lstRes.Add(oResUser);
            }


            return lstRes;
        }

        public void AddUser(DTO_USERS oUser)
        {
            
        }
    }
}
