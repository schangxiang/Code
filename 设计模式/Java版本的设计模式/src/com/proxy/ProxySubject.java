package com.proxy;

/**
 * 
 * 项目名称：PB_OOPDesignMode 类名称：ProxySubject 类描述： 代理主题 创建人：Administrator
 * 创建时间：2019年6月29日 上午10:40:16 修改人：Administrator 修改时间：2019年6月29日 上午10:40:16 修改备注：
 * 
 * @version
 * 
 */
public class ProxySubject extends Subject {

	private RealSubject realSubject;

	@Override
	public void request() {

		preRequest();

		if (realSubject == null) {
			realSubject = new RealSubject();
		}
		realSubject.request();

		postRequest();
	}

	private void preRequest() {
		System.out.println("请求前的操作！");
	}

	private void postRequest() {
		System.out.println("请求后的操作！");
	}
}
