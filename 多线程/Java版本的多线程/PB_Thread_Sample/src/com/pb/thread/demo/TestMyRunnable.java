package com.pb.thread.demo;

public class TestMyRunnable {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
       Runnable my=new MyRunnable();
       
       System.out.println("thread������");
       Thread thread=new Thread(my);
       
       System.out.println("thread2������");
       Thread thread_2=new Thread(my);
       thread.start();
       thread_2.start();
	}

}
