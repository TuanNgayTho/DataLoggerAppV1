CREATE DATABASE datalogger;
USE datalogger;
CREATE TABLE samples(
	id int primary key not null auto_increment,
    aivalue0 float default 0,
    aivalue1 float default 0,
    aivalue2 float default 0,
    aivalue3 float default 0,
    aivalue4 float default 0,
    aivalue5 float default 0,
    aivalue6 float default 0,
    aivalue7 float default 0,
    ts TIMESTAMP  DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);
CREATE TABLE alarmlist(
	id int primary key not null auto_increment,
    ainame varchar(50) default "undefined",
    aichannel int default 0,
    aivalue0 float default 0,
    aivalue1 float default 0,
    aivalue2 float default 0,
    aivalue3 float default 0,
    aivalue4 float default 0,
    aivalue5 float default 0,
    aivalue6 float default 0,
    aivalue7 float default 0,
    alarmstatuscolor bool default false, -- false => low alarm, true => high alarm
    alarmstatus bool default false, -- false => mới xảy ra lỗi, true => lỗi đã kết thúc
    ts TIMESTAMP  DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);