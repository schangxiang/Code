package com.strategy;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String name = "CD唱片";
		int amount = 10;
		int price = 99;
		float sum = 0;

		// 普通顾客
		Context cont = new Context(new CommonAccount());
		sum = cont.doAccount(amount, price);
		System.out.println("您是普通顾客，商品名称是：" + name + "，数量是：" + amount + "，单价是：" + price + "，应付金额是：" + sum);

		// 会员顾客
		cont = new Context(new InsiderAccount());
		sum = cont.doAccount(amount, price);
		System.out.println("您是会员，商品名称是：" + name + "，数量是：" + amount + "，单价是：" + price + "，应付金额是：" + sum);
		// VIP顾客
		cont = new Context(new VipAccount());
		sum = cont.doAccount(amount, price);
		System.out.println("您是VIP，商品名称是：" + name + "，数量是：" + amount + "，单价是：" + price + "，应付金额是：" + sum);
	}
}
