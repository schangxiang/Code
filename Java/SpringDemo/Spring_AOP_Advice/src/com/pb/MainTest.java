package com.pb;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class MainTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
	    ApplicationContext context=new ClassPathXmlApplicationContext("applicationContext.xml");
	    
	    IHello hello=(IHello)context.getBean("helloProxy");
	    
	    try {
	    	hello.sayHello("·Ã¿Í");
		} catch (Exception e) {
			// TODO: handle exception
		}
	    
	}

}
