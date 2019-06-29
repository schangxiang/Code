package com.factorymethod;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：YoghourtFactory   
* 类描述：   酸奶工厂
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午8:42:15   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午8:42:15   
* 修改备注：   
* @version    
*    
*/
public class YoghourtFactory implements ProductFactory {

	@Override
	public Product factory() {
		System.out.println("生产酸奶工厂");
		return new YogHourt();
	}

}
