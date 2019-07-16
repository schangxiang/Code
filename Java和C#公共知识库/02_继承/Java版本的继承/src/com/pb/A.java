package com.pb;

public class A {

	public int age=11;
	public A()
	{
		System.out.println("Build A(无参构造)");
	}
	  public A(String name)
      {
		  System.out.println(name + "Build A(有参构造)");
      }
      public  void Hello()
      {
    	  System.out.println("Hello,我是A方法里的Hello方法");
      }
}
