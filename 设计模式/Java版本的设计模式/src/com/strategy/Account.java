package com.strategy;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：Account   
* 类描述：   计算商品价格的抽象类（是个策略类）
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午10:13:11   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午10:13:11   
* 修改备注：   
* @version    
*    
*/
public abstract class Account {
	public abstract float getFactPrice(int amout,int price); // 获取实际的商品销售价格
}
