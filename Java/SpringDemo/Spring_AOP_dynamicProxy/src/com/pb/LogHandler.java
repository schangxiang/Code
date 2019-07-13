package com.pb;

import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Proxy;


public class LogHandler implements InvocationHandler {
	//Ŀ����� 
	private Object targetObject;
	/**
	 * ������̬������
	 * @param targetObject
	 * @return ������
	 */
	public Object createProxy(Object targetObject) {
		this.targetObject=targetObject;
		return Proxy.newProxyInstance(
				targetObject.getClass().getClassLoader(),
				targetObject.getClass().getInterfaces(),
				this);
	}
	@Override
	public Object invoke(Object proxy,java.lang.reflect.Method method,Object[] args) throws Throwable
	{
		Object obj=null;
		try {
			beforeLog();
			 //����Ŀ������з���  
			obj=method.invoke(targetObject, args);
			afterLog();
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		return obj;
	}
	 //��־������  
    private void beforeLog(){  
        System.out.println("��ʼִ��");  
    }  
      
    private void afterLog(){  
        System.out.println("ִ�����");  
    }  
}
