CREATE DATABASE IF EXISTS FormLogin;

CREATE TABLE _user(
	email varchar(50) NOT NULL,
	password varchar(20) NOT NULL
)

Select * FROM _user WHERE email = @login AND password = @password;