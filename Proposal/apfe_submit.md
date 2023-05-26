# BD: Trabalho Prático APFE - LeagueLore

**Grupo**: P7G8

- Ana Loureiro, MEC: 104063
- Guilherme Lopes, MEC: 93393

## Introduction
 
The project will focus on creating a database for the Universe of League of Legends, connecting Champions to Alternate Universes, Regions to their Secrets and Stories containing them all.

## ​Requirements

Requirements can also be found on the pdf document [Requirements_Analysis.pdf](Requirements_Analysis.pdf)

### 1. User Requirements

The database and thus, its website, will include all League of Legends Champions, along with what Region they belong to, what Alternate Universes they exist on and in what Stories they appear. Each Region also has Secrets that describe facts or events that took place there.

____

### 2.1 Contents

#### 2.1.1 Each Champion has their own:

-	Name
-	Gender
-	Species
-	Splash Art
-	Release date
-	<ins>Region</ins> they belong to
-	<ins>Stories</ins> they participate on
-	<ins>Alternate Universe</ins> they exist on

<br>

#### 2.1.2 Each Region has their own:

-	Name
-	Tribes 
-	Emblem
-	<ins>Secrets</ins>

<br>

#### 2.1.3 Each Alternate Universe has their own:

-	Name
-	Skin Line
-	Year Created
-	<ins>Champions</ins>

<br>

#### 2.1.4 Each Story has their own:

-	Title
-	Author
-	Link
-	Participating <ins>Champion</ins>

<br>

#### 2.1.5 Each Secret has their own:

-	Title
-	Description
-	Image
-	<ins>Region</ins> happen on



 <br>
___
### 2.2 Target Audience

#### 2.1 League of Legends players

Players of the game may want to use the database to learn more about the champions they play, their lore, and their backstory. They may also want to learn more about the different stories and narratives in the League of Legends universe.

<br>

#### 2.2 Lore enthusiasts

Fans of the League of Legends lore may want to use the database to explore the rich world-building and storytelling that the game offers. They may be interested in reading the various stories and narratives, and learning more about the different factions, locations, and events.

<br>

#### 2.3 Content creators

Content creators, such as fan fiction writers or artists , may want to use the  database to gather information and inspiration for their work. They may be interested in exploring the different champions and their backstories, and using that information to create their own original content.


 <br>

___

### 3 Functional requirements

The database will store all the data that already exist on the League of Legends Universe, provided by Riot Games and update it accordingly to new releases on their website.

<br>

**3.1**  The wiki should recognize the day a new story, champion or universe is released.
-	A python script will be used to check League’s “newest stories” and “champions” page each 24 hours, storing the sites DOM and comparing to the previous iteration. If the output comes different, a new story has been released, storing temporarily the link of the new page.

<br>

**3.2**  The database should update automatically when new content is released.
-	To get the contents of the new story a new python script will be made to extract the needed information and insert them into the SQL database.

<br>


**3.3**  Pages should automatically update according to the new information.
-	Champion, Region and Universe pages retrieve their information using SQL Queries.

<br>

**3.4** The wiki should have a Search function in order to search Champions, Regions, Universes and Stories.
	- The output will be the result of an SQL Query in the database

<br>

____

### 4 Non-functional requirements:

#### 4.1 Usability
-	The wiki must be user-friendly and easy to navigate, with a clear layout and intuitive interface.

<br>

#### 4.2 Performance
-	The wiki must load pages quickly and respond to user actions in a timely manner. The access to database must be stable and fast.

<br>

#### 4.3 Maintainability
-	The database must be easy to update, containing clear documentation and well-structured code


## DER


[DER Diagram](DER.pdf)

<br>

## ER

[ER Diagram](ER.pdf)