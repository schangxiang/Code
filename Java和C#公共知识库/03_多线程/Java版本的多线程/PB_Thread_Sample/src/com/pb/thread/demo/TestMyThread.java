package com.pb.thread.demo;

public class TestMyThread {
	/*
	 * 继承Thread类创建线程
	 * 1、继承Thread类
	 * 2、重写run方法
	 * 3、实例化线程对象
	 * 4、调用start方法启动线程
	 * 
	 * 继承Thread类会存在什么问题？
	 * 线程类不能继承其他类
	 */
   public static void main(String[] args)
   {
	   //实例化线程对象
	   Thread myThread=new MyThread();
	   //启动线程
	   myThread.start();
	   /*
	    * start方法的作用：该方法会使操作系统初始化一个新的线程，由这个新的线程来执行线程对象的run方法
	    */
   }
}
