package com.pb;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

/**   
*    
* ��Ŀ���ƣ�PB_SpringDemo   
* �����ƣ�HellpSpring   
* ��������   ��һ��Spring��Ŀ
* �����ˣ�Administrator   
* ����ʱ�䣺2019��7��6�� ����7:23:43   
* �޸��ˣ�Administrator   
* �޸�ʱ�䣺2019��7��6�� ����7:23:43   
* �޸ı�ע��   
* @version    
*    
*/
public class HelloSpring {

	//��Ҫע�������,������ָ�Bean���û���κι�ϵ
	private String input_str=null;
	
	/*
	 * ע���1������ע����ǿ� get��set������������ȷ�ϵģ����籾��������getMyStr��setMyStr����ôBean����������־ͱ�������ΪmyStr,�������
	 * ע���2��Bean���������ֱ���������ĸСд���籾������ myStr,����д��MyStr������[Invalid property 'MyStr' of bean class [com.pb.HelloSpring]: No property 'MyStr' found]
	 * ע���3��get��set���������Ӧ���������������� getMYStr��setMyStr����Сд��һ��Ҳ�����
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
		// ����Spring������
		ApplicationContext context=new ClassPathXmlApplicationContext("applicationContext.xml");
		
		//��ȡbean��ʵ��
		HelloSpring helloSpring=(HelloSpring)context.getBean("myFirstSpringDemo");
		helloSpring.Print();
  
	}

}
