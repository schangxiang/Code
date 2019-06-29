package com.strategy;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：CommonAccount   
* 类描述：   普通顾客的商品价格计算类
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午10:15:58   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午10:15:58   
* 修改备注：   
* @version    
*    
*/
public class CommonAccount extends Account {

	@Override
	public float getFactPrice(int amout, int price) {
		return amout * price; // 普通顾客不打折
	}

}
