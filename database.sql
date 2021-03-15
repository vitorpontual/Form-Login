CREATE DATABASE IF EXISTS FormLogin;

CREATE TABLE _user(
	email varchar(50) NOT NULL,
	password varchar(20) NOT NULL
)

INSTER INTO _user values( email, password);

Select * FROM _user WHERE email = @login AND password = @password;