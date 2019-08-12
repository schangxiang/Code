package com.pb.redis.maven_redis_demo;

import org.junit.Test;

import redis.clients.jedis.Jedis;

public class RedisDemo {

	/**
	 * Java端通过Jedis操作Redis服务器
	 * @param args
	 */
	public static void main(String[] args) {
		
		String host="192.168.186.131";
		int port=6379;
		Jedis jedis=new Jedis(host, port);
		jedis.auth("xiangzi");
		
		System.out.println("连接Redis:"+jedis.ping());

	}
	
	@Test
	public void t1()
	{
		String host="192.168.186.131";
		int port=6379;
		Jedis jedis=new Jedis(host, port);
		jedis.auth("xiangzi");
		
		String strName="myStr";
		jedis.set(strName,"Java端设置的名字");
		System.out.println("Redis中的数据:"+jedis.get(strName));

		
		jedis.close();
	}
	
	/*
	 * Redis作用：为了减轻数据库的访问压力
	 * 需求：如果redis有，就从redis取，如果没有，查询数据库的值放进redis
	 */
	
	@Test
	public void T2()
	{
		String host="192.168.186.131";
		int port=6379;
		Jedis jedis=new Jedis(host, port);
		jedis.auth("xiangzi");
		
		String key="applicationName";
		if(jedis.exists(key)) {
			System.out.println("Redis中的"+key+"数据:"+jedis.get(key));
		}else {
			String result="微信达人";
			jedis.set(key, result);
			System.out.println("数据库查询中的"+key+"数据:"+result);
			
		}
	}

}
