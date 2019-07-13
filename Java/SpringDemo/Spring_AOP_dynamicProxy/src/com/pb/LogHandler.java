package com.pb;

import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Proxy;


public class LogHandler implements InvocationHandler {
	//目标对象 
	private Object targetObject;
	/**
	 * 创建动态代理类
	 * @param targetObject
	 * @return 代理类
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
			 //调用目标对象中方法  
			obj=method.invoke(targetObject, args);
			afterLog();
		} catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		return obj;
	}
	 //日志管理方法  
    private void beforeLog(){  
        System.out.println("开始执行");  
    }  
      
    private void afterLog(){  
        System.out.println("执行完毕");  
    }  
}
