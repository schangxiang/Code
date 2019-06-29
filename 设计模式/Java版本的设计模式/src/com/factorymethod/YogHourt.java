package com.factorymethod;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：YogHourt   
* 类描述：   酸奶类
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午6:46:56   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午6:46:56   
* 修改备注：   
* @version    
*    
*/
public class YogHourt implements Product {

	@Override
	public void craftwork() {
		
		System.out.println("牛奶+酵母菌=酸奶");

	}

	@Override
	public void type() {
		System.out.println("酸甜可口");

	}

}
