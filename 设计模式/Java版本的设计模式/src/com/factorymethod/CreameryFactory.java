package com.factorymethod;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�CreameryFactory   
* ��������   ���̹���
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����8:40:23   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����8:40:23   
* �޸ı�ע��   
* @version    
*    
*/
public class CreameryFactory implements ProductFactory {

	@Override
	public Product factory() {
		System.out.println("�������̹���");
		return new Creamery();
	}

}
