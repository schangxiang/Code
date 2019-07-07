package com.pb;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class FactoryTest {
	public static void main(String[] args)
	{
		// 未用Spring使用的工厂模式方法
		/*

		InkFactory factory=new InkFactory();
		Ink k=null;
		
		k=factory.getInk("color");
		System.out.println(k.getColor());
		
		k=factory.getInk("grey");
		System.out.println(k.getColor());
		
		//*/
		
		//使用Spring的方式
		//创建Spring上下文
		ApplicationContext context=new ClassPathXmlApplicationContext("applicationContext.xml");
		
		//测试Spring工厂模式
		Ink k1=null;
		k1=(Ink)context.getBean("color");
		System.out.println(k1.getColor());
		
		Ink k2=(Ink)context.getBean("grey");
		System.out.println(k2.getColor());
		
		Ink k11=(Ink)context.getBean("color");//验证是否是单例模式
		System.out.println(k1==k11);//输出 True，表示这个生成的是单例模式，同一个实例对象
	}
	
}
