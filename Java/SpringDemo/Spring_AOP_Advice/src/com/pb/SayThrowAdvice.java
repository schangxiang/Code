package com.pb;

import java.lang.reflect.Method;

import org.springframework.aop.ThrowsAdvice;


public class SayThrowAdvice implements ThrowsAdvice {

	public void afterThrowing(Method method,Object[] objs,Object target,Throwable ta)
	{
		System.out.println("�Ҳ�����쳣��-> "+ta+" =====�� �ڷ��� "+method+"�׳����쳣");
	}
}
