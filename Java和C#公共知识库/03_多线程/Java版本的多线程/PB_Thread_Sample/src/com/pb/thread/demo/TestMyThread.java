package com.pb.thread.demo;

public class TestMyThread {
	/*
	 * �̳�Thread�ഴ���߳�
	 * 1���̳�Thread��
	 * 2����дrun����
	 * 3��ʵ�����̶߳���
	 * 4������start���������߳�
	 * 
	 * �̳�Thread������ʲô���⣿
	 * �߳��಻�ܼ̳�������
	 */
   public static void main(String[] args)
   {
	   //ʵ�����̶߳���
	   Thread myThread=new MyThread();
	   //�����߳�
	   myThread.start();
	   /*
	    * start���������ã��÷�����ʹ����ϵͳ��ʼ��һ���µ��̣߳�������µ��߳���ִ���̶߳����run����
	    */
   }
}
