package com.pb.redis.maven_redis_demo.RedisPool;

import java.util.HashMap;
import java.util.Map;

import org.junit.Test;

import redis.clients.jedis.Jedis;
import redis.clients.jedis.JedisPoolConfig;

public class RedisPoolDemo {

	public static void main(String[] args) {

		Jedis jedis = RedisPoolUtils.GetJedis();

		String key = "applicationName";
		if (jedis.exists(key)) {
			System.out.println("Redis中的" + key + "数据:" + jedis.get(key));
		} else {
			String result = "微信达人";
			jedis.set(key, result);
			System.out.println("数据库查询中的" + key + "数据:" + result);

		}

		RedisPoolUtils.Close(jedis);
	}

	/**
	 * Redis操作Hash
	 */
	@Test
	public void T1() {
		Jedis jedis = RedisPoolUtils.GetJedis();

		String key = "users";

		if (jedis.exists(key)) {
			Map<String, String> map = jedis.hgetAll(key);
			System.out.println("---Redis查询结果是:");
			System.out.println(map.get("id") + "\t" + map.get("name"));
		} else {
			String id = "1";
			String name = "宋凯";
			jedis.hset(key, "id", id);
			jedis.hset(key, "name", name);
			System.out.println("---数据库查询结果是:");
			System.out.println(id + "\t" + name);
		}

		jedis.close();
	}

	/**
	 * 对上面的方法进行优化
	 */
	@Test
	public void T2() {
		Jedis jedis = RedisPoolUtils.GetJedis();

		int id = 2;
		String key = User.getKeyName() + id; // user:1
		if (jedis.exists(key)) {
			Map<String, String> hash = jedis.hgetAll(key);
			User u = new User();
		    u.setId(Integer.parseInt(hash.get("id")));
		    u.setName(hash.get("name"));
		    System.out.println("Redis查询的对象是：" + u);
		} else {
			User u = new User();
			u.setId(id);
			u.setName("刘大人");

			Map<String, String> map = new HashMap<String, String>();
			map.put("id", u.getId().toString());
			map.put("name", u.getName());

			jedis.hmset(key, map);

			System.out.println("数据库查询的对象是：" + u);
		}

		jedis.close();
	}

}
