package com.pb.thread.demo;

/*
 * join()方法的特点
 * 1、当前线程会被挂起，让join进来的线程执行
 * 2、join进来的线程在没有执行完毕之前，会一直阻塞当前线程
 * 
 * mian方法启动时，就会创建当前java程序的主线程！！！
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
				Thread jThread= new JoinTest("半路杀出的线程"+i+"--");
				try {
					jThread.start();
					jThread.join();
				} catch (Exception e) {
					// TODO: handle exception
				}
			}
			System.out.println(Thread.currentThread().getName()+i);//输出主线程的名字
		}
	}

}
