package com.pb.thread.demo.Sleep方法;


/*
 * sleep方法的作用是
 * 1、将当前线程挂起（就是暂停当前线程的执行），并阻塞指定的时间
 * 2、当前线程挂起后，就会释放系统资源，让别的线程执行
 */
public class TestWait {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Thread nThread=new NewThread();
		nThread.start();
		
	    System.out.println("开始等待");
	    
	    
	    Wait.bySec(5);
	    System.out.println("恢复运行");
	} 

}
