package com.factorymethod;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�YoghourtFactory   
* ��������   ���̹���
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����8:42:15   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����8:42:15   
* �޸ı�ע��   
* @version    
*    
*/
public class YoghourtFactory implements ProductFactory {

	@Override
	public Product factory() {
		System.out.println("�������̹���");
		return new YogHourt();
	}

}
