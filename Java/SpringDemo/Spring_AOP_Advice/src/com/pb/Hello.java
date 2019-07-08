package com.pb;

public class Hello implements IHello  {
    @Override
    public void sayHello(String str) throws Exception {
    	System.out.println("你好"+str);
    	//测试抛出异常
    	throw new Exception("故意造成异常！");
    }
}
