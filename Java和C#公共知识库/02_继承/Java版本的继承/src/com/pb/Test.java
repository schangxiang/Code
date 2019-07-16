package com.pb;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
	   
		//子类实例化无参
		//子类无参实例化，首先会默认调用父类的无参构造，再调用子类的无参构造
		//B b1=new B(); //输出：【Build A(无参构造)   Build B(无参构造)】
		
		//子类实例化有参，子类有参构造显式调用父类的无参构造(如果不显式，默认还是调父类的无参构造)
		//B b2=new B("猪");//输出： 【Build A(无参构造) 猪Build B(有参构造)】
		
		//子类实例化有参，子类显式的调用父类的有参构造
		//C c1=new C("驴");//输出:【驴Build A(有参构造) 驴Build C(有参构造)】
		
		//子类实例化，调用父类的方法
	    /*
		B b3=new B();
		b3.Hello(); 
		//*/
		/* 输出：
		 * Build A(无参构造)
Build B(无参构造)
父类的age值是:11
Hello,我是A方法里的Hello方法
Hello,我是B方法里的Hello方法
		 */
		
		//子类和父类有公共的成员变量
		/*
		C c2=new C("虎");
		System.out.println("年龄： "+c2.age);//输出 99
		A a1=new C("虎");
		System.out.println("年龄： "+a1.age);//输出 11
		//*/
		
		//实例化子类，转为父类对象，输出的成员变量是父类的值,调用的方法是字类重写的方法
		A a2=new C();
		System.out.println("年龄： "+a2.age);//输出 11
		a2.Hello();//如果C有重写方法，就显示C内的方法，如果没重写，就显示A的方法
		
	}

}
