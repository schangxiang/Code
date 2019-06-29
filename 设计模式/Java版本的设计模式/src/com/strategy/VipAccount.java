package com.strategy;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：VipAccount   
* 类描述：   VIP客户的价格计算类
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午10:18:21   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午10:18:21   
* 修改备注：   
* @version    
*    
*/
public class VipAccount extends Account {

	@Override
	public float getFactPrice(int amout, int price) {
		return amout*price*8/10; //VIP打8折
	}

}
