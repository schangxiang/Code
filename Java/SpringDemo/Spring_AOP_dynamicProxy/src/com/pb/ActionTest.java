package com.pb;

public class ActionTest {
	 public static void main(String[] args) {  
	        //�����������iuserServ  
	        LogHandler handler = new LogHandler();  
	        IUserServ iuserServ = (IUserServ)handler.createProxy(new UserServImpl());  
	        iuserServ.deleteUserById(new User());  
	    }  
}
