package com.strategy;

/**   
*    
* ��Ŀ���ƣ�PB_OOPDesignMode   
* �����ƣ�CommonAccount   
* ��������   ��ͨ�˿͵���Ʒ�۸������
* �����ˣ�Administrator   
* ����ʱ�䣺2019��6��29�� ����10:15:58   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��6��29�� ����10:15:58   
* �޸ı�ע��   
* @version    
*    
*/
public class CommonAccount extends Account {

	@Override
	public float getFactPrice(int amout, int price) {
		return amout * price; // ��ͨ�˿Ͳ�����
	}

}
