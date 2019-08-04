package com.pb.thread.demo;

public class MyRunnable implements Runnable {
	private int count=0;
	@Override
	public void run() {
		count++;
		System.out.println("count:"+count);
	}
}
