package com.pb;

public class Hello implements IHello  {
    @Override
    public void sayHello(String str) throws Exception {
    	System.out.println("���"+str);
    	//�����׳��쳣
    	throw new Exception("��������쳣��");
    }
    
    @Override
    public void sayHelloChina(String str) {
    	System.out.println("���"+str);
    }
    @Override
    public void sayHelloEnglish(String str) {
    	System.out.println("Hello"+str);
    }
}
