package com.pb;

public class ActionTest {
	 public static void main(String[] args) {  
	        //创建代理对象iuserServ  
	        LogHandler handler = new LogHandler();  
	        IUserServ iuserServ = (IUserServ)handler.createProxy(new UserServImpl());  
	        iuserServ.deleteUserById(new User());  
	    }  
}
