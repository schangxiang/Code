package com.strategy;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：InsiderAccount   
* 类描述：   会员商品价格计算类
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午10:17:04   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午10:17:04   
* 修改备注：   
* @version    
*    
*/
public class InsiderAccount extends Account {

	@Override
	public float getFactPrice(int amout, int price) {
		return amout*price*9/10; //会员打9折
	}

}
