package com.factory;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：SimpleStaticFactory   
* 类描述：  简单静态工厂类
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午6:48:50   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午6:48:50   
* 修改备注：   
* @version    
*    
*/
public class SimpleStaticFactory {

	 public static Product factory(String str) throws BadException {
		 if(str.equalsIgnoreCase("Creamery"))
		 {
			 System.out.println("生产鲜奶");
			 return new Creamery();
		 }else if(str.equalsIgnoreCase("Yoghourt")) {
			 System.out.println("生产酸奶");
			 return new YogHourt();
		 }else
		 {
			 throw new BadException("没有该类型产品!");
		 }
	 }
}
