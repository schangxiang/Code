package com.pb.thread.demo.Sleep·½·¨;

public class Wait {
    public static void bySec(long s)
    {
    	for (int i = 0; i < s; i++) {
			System.out.println(i+1+"Ãë");
			try {
				Thread.sleep(1000);//ÐÝÃßÒ»Ãë
				
			} catch (Exception e) {
				// TODO: handle exception
			}
		}
    }
}
