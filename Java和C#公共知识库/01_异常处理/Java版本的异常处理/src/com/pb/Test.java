package com.pb;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
			People p=new People();
			try {
				p.setSex("Male");
			} catch (Exception e) {
				System.out.println("�����Ա������");
				e.printStackTrace();//����쳣��Ϣ
			}
	}

}
