package com.pb;

import org.aopalliance.intercept.MethodInterceptor;
import org.aopalliance.intercept.MethodInvocation;

public class SayAroundAdvice implements MethodInterceptor {

	@Override
	public Object invoke(MethodInvocation arg0) throws Throwable {
		// TODO Auto-generated method stub
		Object result=null;
		
		System.out.println("Around�ڷ���ִ��ǰ�����飡");
		
		result=arg0.proceed();
		
		System.out.println("Around�ڷ���ִ�к������飡");
		
		return result;
	}

}
