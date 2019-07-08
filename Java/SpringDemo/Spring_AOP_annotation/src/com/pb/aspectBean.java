package com.pb;

import org.aspectj.lang.annotation.After;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;

//����Aspectע�⣬��������
@Aspect
public class aspectBean {
	//����Ϊ�����
	@Pointcut("execution(* hello.*(..))")
	public void log() {
		
	}
	@Before(value="log()") //�������֮ǰִ��
	public void startLog()
	{
		System.out.println("��ʼ��¼");
	}
	@After(value="log()") //�������֮��ִ��
	public void endLog()
	{
		System.out.println("������¼");
	}
}
