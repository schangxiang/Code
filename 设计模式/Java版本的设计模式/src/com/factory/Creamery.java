package com.factory;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：Creamery   
* 类描述：   鲜奶类
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午6:44:11   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午6:44:11   
* 修改备注：   
* @version    
*    
*/
public class Creamery implements Product {

	@Override
	public void craftwork() {
		System.out.println("牛奶+除菌=鲜奶");
	}

	@Override
	public void type() {
	 System.out.println("原味浓香");
	}

}
