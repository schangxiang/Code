package com.pb;

import org.aspectj.lang.annotation.After;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;

//引入Aspect注解，声明切面
@Aspect
public class aspectBean {
	//定义为切入点
	@Pointcut("execution(* hello.*(..))")
	public void log() {
		
	}
	@Before(value="log()") //在切入点之前执行
	public void startLog()
	{
		System.out.println("开始记录");
	}
	@After(value="log()") //在切入点之后执行
	public void endLog()
	{
		System.out.println("结束记录");
	}
}
