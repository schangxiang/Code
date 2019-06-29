package com.proxy;

/**
 * 
 * ��Ŀ���ƣ�PB_OOPDesignMode �����ƣ�ProxySubject �������� �������� �����ˣ�Administrator
 * ����ʱ�䣺2019��6��29�� ����10:40:16 �޸��ˣ�Administrator �޸�ʱ�䣺2019��6��29�� ����10:40:16 �޸ı�ע��
 * 
 * @version
 * 
 */
public class ProxySubject extends Subject {

	private RealSubject realSubject;

	@Override
	public void request() {

		preRequest();

		if (realSubject == null) {
			realSubject = new RealSubject();
		}
		realSubject.request();

		postRequest();
	}

	private void preRequest() {
		System.out.println("����ǰ�Ĳ�����");
	}

	private void postRequest() {
		System.out.println("�����Ĳ�����");
	}
}
