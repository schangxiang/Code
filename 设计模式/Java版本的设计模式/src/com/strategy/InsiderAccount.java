package com.strategy;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�InsiderAccount   
* ��������   ��Ա��Ʒ�۸������
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����10:17:04   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����10:17:04   
* �޸ı�ע��   
* @version    
*    
*/
public class InsiderAccount extends Account {

	@Override
	public float getFactPrice(int amout, int price) {
		return amout*price*9/10; //��Ա��9��
	}

}
