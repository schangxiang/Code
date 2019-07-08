package com.pb;

import java.lang.reflect.Method;

import org.springframework.aop.ThrowsAdvice;


public class SayThrowAdvice implements ThrowsAdvice {

	public void afterThrowing(Method method,Object[] objs,Object target,Throwable ta)
	{
		System.out.println("我捕获的异常是-> "+ta+" =====， 在方法 "+method+"抛出了异常");
	}
}
