package com.pb;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class FactoryTest {
	public static void main(String[] args)
	{
		// δ��Springʹ�õĹ���ģʽ����
		/*

		InkFactory factory=new InkFactory();
		Ink k=null;
		
		k=factory.getInk("color");
		System.out.println(k.getColor());
		
		k=factory.getInk("grey");
		System.out.println(k.getColor());
		
		//*/
		
		//ʹ��Spring�ķ�ʽ
		//����Spring������
		ApplicationContext context=new ClassPathXmlApplicationContext("applicationContext.xml");
		
		//����Spring����ģʽ
		Ink k1=null;
		k1=(Ink)context.getBean("color");
		System.out.println(k1.getColor());
		
		Ink k2=(Ink)context.getBean("grey");
		System.out.println(k2.getColor());
		
		Ink k11=(Ink)context.getBean("color");//��֤�Ƿ��ǵ���ģʽ
		System.out.println(k1==k11);//��� True����ʾ������ɵ��ǵ���ģʽ��ͬһ��ʵ������
	}
	
}
