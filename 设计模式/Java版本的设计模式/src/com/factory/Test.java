package com.factory;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�Test   
* ��������   ������
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����6:58:36   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����6:58:36   
* �޸ı�ע��   
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
