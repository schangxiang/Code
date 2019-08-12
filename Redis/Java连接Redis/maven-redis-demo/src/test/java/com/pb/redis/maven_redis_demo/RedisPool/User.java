package com.pb.redis.maven_redis_demo.RedisPool;
import lombok.Data;

@Data
public class User {
    private Integer id;
    private String name;
    
    public static String getKeyName()
    {
    	return "user:";
    }
}
