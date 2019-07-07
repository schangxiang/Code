package com.pb;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

/**   
*    
* 项目名称：PB_SpringDemo   
* 类名称：HellpSpring   
* 类描述：   第一个Spring项目
* 创建人：Administrator   
* 创建时间：2019年7月6日 上午7:23:43   
* 修改人：Administrator   
* 修改时间：2019年7月6日 上午7:23:43   
* 修改备注：   
* @version    
*    
*/
public class HelloSpring {

	//需要注入的属性,这个名字跟Bean里的没有任何关系
	private String input_str=null;
	
	/*
	 * 注意点1：依赖注入的是靠 get和set方法的名字来确认的，比如本例子中是getMyStr和setMyStr，那么Bean里的属性名字就必须配置为myStr,否则出错
	 * 注意点2：Bean的属性名字必须是首字母小写，如本例中是 myStr,不能写成MyStr，否则报[Invalid property 'MyStr' of bean class [com.pb.HelloSpring]: No property 'MyStr' found]
	 * 注意点3：get和set方法必须对应起来，不能是这样 getMYStr和setMyStr，大小写不一致也会出错
	 */
	public String getMyStr() {
		return this.input_str;
	}
	public void setMyStr(String strParam) {
		this.input_str=strParam;
	}
	
	public void Print()
	{
		System.out.println("Hello,"+this.getMyStr());
	}
	public static void main(String[] args) {
		// 创建Spring上下文
		ApplicationContext context=new ClassPathXmlApplicationContext("applicationContext.xml");
		
		//获取bean的实例
		HelloSpring helloSpring=(HelloSpring)context.getBean("myFirstSpringDemo");
		helloSpring.Print();
  
	}

}
