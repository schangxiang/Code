package com.pb;

public class C extends A{
  public int age=99;
  public C() {
	  System.out.println("Build C(�޲ι���)");
  }
  public C(String name) {
	  super(name);//��ʽ���ø�����вι��죬�����д���Ļ���Ĭ�ϵ��ø����޲ι��죬Ҳ���ǵ�ͬ��super();
	  System.out.println(name+"Build C(�вι���)");
  }
  public  void Hello()
  {
	  System.out.println("Hello,����C�������Hello����");
  }
}
