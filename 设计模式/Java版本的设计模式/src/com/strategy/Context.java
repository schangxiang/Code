package com.strategy;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�Context   
* ��������   ��������ά�����Ե�����
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����10:19:38   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����10:19:38   
* �޸ı�ע��   
* @version    
*    
*/
public class Context {
   // ���в����������
   private Account account;
   //���췽����ʵ���������������
   public Context(Account account)
   {
	   this.account=account;
   }
   //���ò��Է���
   public float doAccount(int amount,int price)
   {
	   return  account.getFactPrice(amount, price);
   }
}
