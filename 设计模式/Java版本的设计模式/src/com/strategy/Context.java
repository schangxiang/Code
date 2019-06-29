package com.strategy;

/**   
*    
* 项目名称：PB_OOPDesignMode   
* 类名称：Context   
* 类描述：   此类用于维护策略的引用
* 创建人：Administrator   
* 创建时间：2019年6月29日 上午10:19:38   
* 修改人：Administrator   
* 修改时间：2019年6月29日 上午10:19:38   
* 修改备注：   
* @version    
*    
*/
public class Context {
   // 持有策略类的引用
   private Account account;
   //构造方法，实例化策略类的引用
   public Context(Account account)
   {
	   this.account=account;
   }
   //调用策略方法
   public float doAccount(int amount,int price)
   {
	   return  account.getFactPrice(amount, price);
   }
}
