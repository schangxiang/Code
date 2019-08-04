package com.pb.thread.demo;

public class MyThread extends Thread {

	private int count=0;
	
	@Override
	public void run()
	{
		System.out.println("线程已启动");
		while(count<10000) {
			count++;
		}
		System.out.println("count:"+count);
	}
}
