package com.pb.thread.demo.Sleep����;

public class NewThread extends Thread {
   public void run()
   {
	   for (int i = 0; i < 20; i++) {
		System.out.println("���̵߳�iֵ��"+i);
	}
   }
}
