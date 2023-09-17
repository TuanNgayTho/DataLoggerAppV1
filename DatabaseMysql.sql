CREATE DATABASE datalogger;
USE datalogger;
SET GLOBAL event_scheduler = ON;

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

CREATE EVENT AutoDeleteOldData
ON SCHEDULE EVERY 1 DAY
STARTS CURRENT_TIMESTAMP
ON COMPLETION PRESERVE ENABLE
DO 
	DELETE LOW_PRIORITY FROM datalogger.samples WHERE ts < DATE_SUB(NOW(), INTERVAL 1 YEAR);