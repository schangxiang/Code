package com.factory;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：Test   
* 类描述：   测试类
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午6:58:36   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午6:58:36   
* 修改备注：   
* @version    
*    
*/
public class Test {

	public static void main(String[] args) {
		
		
		try {
			
			Product y=SimpleStaticFactory.factory("Creamery");
			y.craftwork();
			y.type();
			
			Product c=SimpleStaticFactory.factory("Yoghourt");
			c.craftwork();
			c.type();
			
		} catch (BadException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}

}
