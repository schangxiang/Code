package com.factory;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�SimpleStaticFactory   
* ��������  �򵥾�̬������
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����6:48:50   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����6:48:50   
* �޸ı�ע��   
* @version    
*    
*/
public class SimpleStaticFactory {

	 public static Product factory(String str) throws BadException {
		 if(str.equalsIgnoreCase("Creamery"))
		 {
			 System.out.println("��������");
			 return new Creamery();
		 }else if(str.equalsIgnoreCase("Yoghourt")) {
			 System.out.println("��������");
			 return new YogHourt();
		 }else
		 {
			 throw new BadException("û�и����Ͳ�Ʒ!");
		 }
	 }
}
