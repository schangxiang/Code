package com.pb.thread.demo.Sleep����;


/*
 * sleep������������
 * 1������ǰ�̹߳��𣨾�����ͣ��ǰ�̵߳�ִ�У���������ָ����ʱ��
 * 2����ǰ�̹߳���󣬾ͻ��ͷ�ϵͳ��Դ���ñ���߳�ִ��
 */
public class TestWait {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Thread nThread=new NewThread();
		nThread.start();
		
	    System.out.println("��ʼ�ȴ�");
	    
	    
	    Wait.bySec(5);
	    System.out.println("�ָ�����");
	} 

}
