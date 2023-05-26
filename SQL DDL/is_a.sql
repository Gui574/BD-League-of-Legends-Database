USE LoLDatabase;


CREATE TABLE Human (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);

CREATE TABLE Yordle (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);

CREATE TABLE Vastayan (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);

CREATE TABLE Undead (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);

CREATE TABLE Spirits (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);

CREATE TABLE Celestials (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);

CREATE TABLE VoidBorn (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);

CREATE TABLE Ascended (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);

CREATE TABLE Darkin (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,
description			NVARCHAR,
origin				VARCHAR(25)					FOREIGN KEY REFERENCES Region(name)
);