package com.strategy;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�VipAccount   
* ��������   VIP�ͻ��ļ۸������
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����10:18:21   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����10:18:21   
* �޸ı�ע��   
* @version    
*    
*/
public class VipAccount extends Account {

	@Override
	public float getFactPrice(int amout, int price) {
		return amout*price*8/10; //VIP��8��
	}

}
