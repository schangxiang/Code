package com.factorymethod;

public class Test {

	public static void main(String[] args) {
		
		ProductFactory y=new YoghourtFactory();
		Product y_p=y.factory();
		y_p.craftwork();
		y_p.type();
		
		System.out.println("------·Ö¸îÏß------");
		
		ProductFactory c=new CreameryFactory();
		Product c_p=c.factory();
		c_p.craftwork();
		c_p.type();

	}

}
