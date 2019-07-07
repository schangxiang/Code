package com.pb;

public class InkFactory {
	public Ink getInk(String e)
	{
		if(e.equalsIgnoreCase("color")) {
			return new ColorInk();
		}else {
			return new GreyInk();
		}
	}
}
