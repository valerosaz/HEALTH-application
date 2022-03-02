-- create database healthBOT
DROP DATABASE IF EXISTS healthBOT;
CREATE DATABASE healthBOT;
-- database healthBOT used for mordifing
USE healthBOT;

CREATE TABLE user_information
(
	user_firstname VARCHAR(30) NOT NULL,
    user_lastname VARCHAR(30) NOT NULL,
    user_email VARCHAR (30),
    user_id INT(1) NOT NULL, -- 1 = doctor, 2 = nurse, 3 = patient
    user_birthday DATE NOT NULL,
    user_address VARCHAR(50) NOT NULL,
    user_phonenumber INT NOT NULL,
    user_user VARCHAR(15) NOT NULL,
    user_pass VARCHAR(16) NOT NULL,
    PRIMARY KEY (user_user)
);

CREATE TABLE heartbeat_data
( 
	username VARCHAR(15) NOT NULL,
    timePeriod TIMESTAMP NOT NULL,
	BPM INT,
    FOREIGN KEY (username) REFERENCES user_information(user_user)
);
