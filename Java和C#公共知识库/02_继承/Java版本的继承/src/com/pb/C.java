package com.pb;

public class C extends A{
  public int age=99;
  public C() {
	  System.out.println("Build C(无参构造)");
  }
  public C(String name) {
	  super(name);//显式调用父类的有参构造，如果不写这句的话，默认调用父类无参构造，也就是等同于super();
	  System.out.println(name+"Build C(有参构造)");
  }
  public  void Hello()
  {
	  System.out.println("Hello,我是C方法里的Hello方法");
  }
}
