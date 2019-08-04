package com.pb.thread.demo;

/*
 * join()�������ص�
 * 1����ǰ�̻߳ᱻ������join�������߳�ִ��
 * 2��join�������߳���û��ִ�����֮ǰ����һֱ������ǰ�߳�
 * 
 * mian��������ʱ���ͻᴴ����ǰjava��������̣߳�����
 */
public class JoinTest extends Thread {
	public JoinTest(String name)
	{
		super(name);
	}
	
	public void run() {
		for (int i = 0; i < 5; i++) {
			System.out.println(getName()+i);
		}
	}
	
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		for (int i = 0; i < 10; i++) {
			if(i==5) {
				Thread jThread= new JoinTest("��·ɱ�����߳�"+i+"--");
				try {
					jThread.start();
					jThread.join();
				} catch (Exception e) {
					// TODO: handle exception
				}
			}
			System.out.println(Thread.currentThread().getName()+i);//������̵߳�����
		}
	}

}
