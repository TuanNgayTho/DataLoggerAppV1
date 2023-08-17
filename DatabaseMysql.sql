CREATE DATABASE datalogger;
USE datalogger;
CREATE TABLE samples(
	id int primary key not null auto_increment,
    ainame varchar(255),
    aivalue0 float default 0,
    aivalue1 float default 0,
    aivalue2 float default 0,
    aivalue3 float default 0,
    aivalue4 float default 0,
    aivalue5 float default 0,
    aivalue6 float default 0,
    aivalue7 float default 0,
    ts TIMESTAMP  DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    dt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);