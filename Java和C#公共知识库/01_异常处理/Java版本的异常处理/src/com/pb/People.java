package com.pb;

public class People {
	String name="";
	int age=0;
	String sex;
	public String getSex()
	{
		return sex;
	}
	public void setSex(String sex) throws Exception{
	    if("��".equals(sex) || "Ů".equals(sex))
	    {
	    	this.sex=sex;
	    }
	    else {
	    	throw new GendorException("�Ա�������л���Ů");
	    }
	}
}
