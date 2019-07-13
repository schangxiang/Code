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
	    if("男".equals(sex) || "女".equals(sex))
	    {
	    	this.sex=sex;
	    }
	    else {
	    	throw new GendorException("性别必须是男或者女");
	    }
	}
}
