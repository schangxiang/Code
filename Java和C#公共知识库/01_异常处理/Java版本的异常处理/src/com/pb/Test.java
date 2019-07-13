package com.pb;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
			People p=new People();
			try {
				p.setSex("Male");
			} catch (Exception e) {
				System.out.println("设置性别出错了");
				e.printStackTrace();//输出异常信息
			}
	}

}
