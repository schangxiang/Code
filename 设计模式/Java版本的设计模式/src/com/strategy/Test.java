package com.strategy;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String name = "CD��Ƭ";
		int amount = 10;
		int price = 99;
		float sum = 0;

		// ��ͨ�˿�
		Context cont = new Context(new CommonAccount());
		sum = cont.doAccount(amount, price);
		System.out.println("������ͨ�˿ͣ���Ʒ�����ǣ�" + name + "�������ǣ�" + amount + "�������ǣ�" + price + "��Ӧ������ǣ�" + sum);

		// ��Ա�˿�
		cont = new Context(new InsiderAccount());
		sum = cont.doAccount(amount, price);
		System.out.println("���ǻ�Ա����Ʒ�����ǣ�" + name + "�������ǣ�" + amount + "�������ǣ�" + price + "��Ӧ������ǣ�" + sum);
		// VIP�˿�
		cont = new Context(new VipAccount());
		sum = cont.doAccount(amount, price);
		System.out.println("����VIP����Ʒ�����ǣ�" + name + "�������ǣ�" + amount + "�������ǣ�" + price + "��Ӧ������ǣ�" + sum);
	}
}
