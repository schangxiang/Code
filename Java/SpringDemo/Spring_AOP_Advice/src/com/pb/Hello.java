package com.pb;

public class Hello implements IHello  {
    @Override
    public void sayHello(String str) throws Exception {
    	System.out.println("���"+str);
    	//�����׳��쳣
    	throw new Exception("��������쳣��");
    }
}
