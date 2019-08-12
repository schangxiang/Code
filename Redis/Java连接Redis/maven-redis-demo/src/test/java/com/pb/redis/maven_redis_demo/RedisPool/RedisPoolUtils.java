package com.pb.redis.maven_redis_demo.RedisPool;

import redis.clients.jedis.Jedis;
import redis.clients.jedis.JedisPool;
import redis.clients.jedis.JedisPoolConfig;
import redis.clients.util.Pool;

/**
 * 
 * 
 * 项目名称：maven-redis-demo 类名称：RedisPoolUtils 类描述：Redis连接池帮助类 创建人：Administrator
 * 创建时间：2019年8月12日 上午9:33:33 修改人：Administrator 修改时间：2019年8月12日 上午9:33:33 修改备注：
 * 
 * @version
 *
 */
public class RedisPoolUtils {
	private static JedisPool pool;
	static {
		// 1、连接池RedisPool的配置信息
		JedisPoolConfig poolConfig = new JedisPoolConfig();
		poolConfig.setMaxTotal(5);// 最大连接数
		poolConfig.setMaxIdle(1);// 最大空闲数
		// ....其他配置

		// 2、连接池
		String host = "192.168.186.131";
		int port = 6379;
		pool = new JedisPool(poolConfig, host, port);
	}

	public static Jedis GetJedis() {
		Jedis jedis = pool.getResource();
		jedis.auth("xiangzi");
		return jedis;
	}

	public static void Close(Jedis jedis) {

		jedis.close();
	}
}
