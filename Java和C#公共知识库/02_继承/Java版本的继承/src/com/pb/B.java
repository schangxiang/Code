package com.pb;

public class B extends A {
	public B()
	{
		System.out.println("Build B(�޲ι���)");
	}
	public B(String name)
	{
		System.out.println(name+"Build B(�вι���)");
	}
	
	public void Hello()
	{
		System.out.println("�����ageֵ��:"+super.age); //�������ĳ�Ա����
		super.Hello();//��ʽ���ø���ķ���
		System.out.println("Hello,����B�������Hello����");
	}

}
