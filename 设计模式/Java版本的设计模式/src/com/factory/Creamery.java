package com.factory;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�Creamery   
* ��������   ������
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����6:44:11   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����6:44:11   
* �޸ı�ע��   
* @version    
*    
*/
public class Creamery implements Product {

	@Override
	public void craftwork() {
		System.out.println("ţ��+����=����");
	}

	@Override
	public void type() {
	 System.out.println("ԭζŨ��");
	}

}
