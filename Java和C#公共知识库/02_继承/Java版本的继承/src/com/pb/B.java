package com.pb;

public class B extends A {
	public B()
	{
		System.out.println("Build B(无参构造)");
	}
	public B(String name)
	{
		System.out.println(name+"Build B(有参构造)");
	}
	
	public void Hello()
	{
		System.out.println("父类的age值是:"+super.age); //输出父类的成员变量
		super.Hello();//显式调用父类的方法
		System.out.println("Hello,我是B方法里的Hello方法");
	}

}
