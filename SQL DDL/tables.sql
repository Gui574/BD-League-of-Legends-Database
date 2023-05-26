
--USE MASTER
--GO
--DROP DATABASE LoLDatabase
--GO
--CREATE DATABASE LoLDatabase;
--GO
--USE LoLDatabase;

--done
CREATE TABLE Region (
name			VARCHAR(50)			NOT NULL	PRIMARY KEY,		
emblem			VARCHAR(350)				NOT NULL
);

--done
CREATE TABLE Champion (
name			VARCHAR(25)			NOT NULL	PRIMARY KEY,
gender			VARCHAR(6)			NOT NULL	CHECK(gender IN	('Male', 'Female', 'Other')),
description		VARCHAR(50),
species			VARCHAR(11)			NOT NULL,
region_name		VARCHAR(50)			FOREIGN KEY REFERENCES Region(name),
splashArt		VARCHAR(350)		NOT NULL,
quote			VARCHAR(MAX),
releaseDate		DATE				NOT NULL
);

--done
CREATE TABLE Abilities (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,

P_name				VARCHAR(50),
P_description		NVARCHAR,

Q_name				VARCHAR(50),
Q_description		NVARCHAR,

W_name				VARCHAR(50),
W_description		NVARCHAR,

E_name				VARCHAR(50),
E_description		NVARCHAR,	

R_name				VARCHAR(50),
R_description		NVARCHAR,	
);

--done
CREATE TABLE Tribes (
name			VARCHAR(15)			NOT NULL	PRIMARY KEY,
art				VARCHAR(350)				NOT NULL,		
description		VARCHAR(250),
region_name		VARCHAR(50)			NOT NULL	FOREIGN KEY REFERENCES Region(name)
);

--done
CREATE TABLE Alternate_Universe (
name			VARCHAR(25)			NOT NULL	PRIMARY KEY,
skinLine		VARCHAR(50)			NOT NULL	UNIQUE,		
yearCreated		INT					NOT NULL
);

--done ?
CREATE TABLE Stories (
title			VARCHAR(20)			NOT NULL	PRIMARY KEY,
author			VARCHAR(20)			NOT NULL,
link			VARCHAR(50)			NOT NULL	UNIQUE,
type 			VARCHAR(50)			NOT NULL,
universe_name	VARCHAR(25)						FOREIGN KEY REFERENCES Alternate_Universe(name)
);

--done
CREATE TABLE Secrets (
title			VARCHAR(25)			NOT NULL	PRIMARY KEY,
image			VARCHAR(350)				NOT NULL,
description		NVARCHAR			NOT NULL	UNIQUE,
region_name		VARCHAR(50)			FOREIGN KEY REFERENCES Region(name)
);

--done
CREATE TABLE Exists_On (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name),
universe_name		VARCHAR(25)		NOT NULL	FOREIGN KEY REFERENCES Alternate_Universe(name),
												PRIMARY KEY (champion_name, universe_name)
);

--done ?
CREATE TABLE Participates (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name),
stories_title		VARCHAR(20)		NOT NULL	FOREIGN KEY REFERENCES Stories(title),
												PRIMARY KEY (champion_name, stories_title)
);
