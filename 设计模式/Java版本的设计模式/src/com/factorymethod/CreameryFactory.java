package com.factorymethod;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：CreameryFactory   
* 类描述：   鲜奶工厂
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午8:40:23   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午8:40:23   
* 修改备注：   
* @version    
*    
*/
public class CreameryFactory implements ProductFactory {

	@Override
	public Product factory() {
		System.out.println("生产鲜奶工厂");
		return new Creamery();
	}

}
