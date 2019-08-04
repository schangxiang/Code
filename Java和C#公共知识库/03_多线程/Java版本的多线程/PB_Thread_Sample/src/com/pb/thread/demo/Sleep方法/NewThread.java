package com.pb.thread.demo.Sleep方法;

public class NewThread extends Thread {
   public void run()
   {
	   for (int i = 0; i < 20; i++) {
		System.out.println("新线程的i值是"+i);
	}
   }
}
