package com.pb;

import java.util.List;

public interface IUserServ {
	List<User> findAllUser();
	int deleteUserById(User user);
	int saveUser(User user);
}
