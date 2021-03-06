# ValorantStatsApp
## Matthew Parnham

This is the solution for my Visual Studio project.  Load up in visual studio to run. Edit App.config to contain your DB credentials.

Run these commands in SQL to set up your own database!
```sql
CREATE TABLE MatchDetails (
    MatchID INT PRIMARY KEY AUTO_INCREMENT,
    Map INT,
    Win BOOLEAN,
    RoundsWon INT,
    RoundsLost INT,
    Date DATE,
    isDeleted BOOLEAN
);

CREATE TABLE Scoreboard (
    MatchID INT,
    PlayerName VARCHAR(32),
    Hero INT,
    AVGCombatScore INT,
    Kills INT,
    Deaths INT,
    Assists INT,
    EconRating INT,
    FirstBloods INT,
    Plants INT,
    Defuses INT
);

CREATE TABLE Timeline (
    MatchID INT,
    RoundNum INT,
    Score INT,
    Kills INT,
    Assists INT,
    Died BOOLEAN,
    MoneySpent INT,
    Weapon INT,
    Won BOOLEAN
);

CREATE TABLE Performance (
  MatchID INT,
  PlayerName VARCHAR(32),
  Kills INT,
  Deaths INT,
  Assists INT
);

CREATE TABLE Practice (
  PracticeType VARCHAR(32),
  KillCount INT,
  MinutesPlayed INT,
  Date DATE
);


CREATE TABLE Heroes (
    HeroID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(16)
);

CREATE TABLE Weapons (
    WeaponID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(16)
);

CREATE TABLE Maps (
    MapID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(16)
)

CREATE VIEW EnabledMatches AS
SELECT *
FROM MatchDetails
WHERE isDeleted = 0;

CREATE VIEW DeletedMatches AS
SELECT *
FROM MatchDetails
WHERE isDeleted = 1;

ALTER TABLE MatchDetails
ADD UNIQUE MatchID_Index (MatchID);

ALTER TABLE Scoreboard
ADD CONSTRAINT
FOREIGN KEY (MatchID)
REFERENCES MatchDetails(MatchID);

ALTER TABLE Timeline
ADD CONSTRAINT
FOREIGN KEY (MatchID)
REFERENCES MatchDetails(MatchID);

ALTER TABLE Performance
ADD CONSTRAINT
FOREIGN KEY (MatchID)
REFERENCES MatchDetails(MatchID);

ALTER TABLE Scoreboard
ADD CONSTRAINT
FOREIGN KEY (Hero)
REFERENCES Heroes(HeroID);

ALTER TABLE Timeline
ADD CONSTRAINT
FOREIGN KEY (Weapon)
REFERENCES Weapons(WeaponID);

ALTER TABLE MatchDetails
ADD CONSTRAINT
FOREIGN KEY (Map)
REFERENCES Maps(MapID);


INSERT INTO Maps(Name)
VALUES('Bind');
INSERT INTO Maps(Name)
VALUES('Haven');
INSERT INTO Maps(Name)
VALUES('Split');
INSERT INTO Heroes(Name)
VALUES('Phoenix');
INSERT INTO Heroes(Name)
VALUES('Jett');
INSERT INTO Heroes(Name)
VALUES('Viper');
INSERT INTO Heroes(Name)
VALUES('Sova');
INSERT INTO Heroes(Name)
VALUES('Cypher');
INSERT INTO Heroes(Name)
VALUES('Brimstone');
INSERT INTO Heroes(Name)
VALUES('Sage');
INSERT INTO Heroes(Name)
VALUES('Omen');
INSERT INTO Heroes(Name)
VALUES('Breach');
INSERT INTO Heroes(Name)
VALUES('Raze');
INSERT INTO Weapons(Name)
VALUES('Bulldog');
INSERT INTO Weapons(Name)
VALUES('Vandal');
INSERT INTO Weapons(Name)
VALUES('Phantom');
INSERT INTO Weapons(Name)
VALUES('Guardian');
INSERT INTO Weapons(Name)
VALUES('Marshall');
INSERT INTO Weapons(Name)
VALUES('Operator');
INSERT INTO Weapons(Name)
VALUES('Classic');
INSERT INTO Weapons(Name)
VALUES('Shorty');
INSERT INTO Weapons(Name)
VALUES('Frenzy');
INSERT INTO Weapons(Name)
VALUES('Ghost');
INSERT INTO Weapons(Name)
VALUES('Sheriff');
INSERT INTO Weapons(Name)
VALUES('Stinger');
INSERT INTO Weapons(Name)
VALUES('Spectre');
INSERT INTO Weapons(Name)
VALUES('Bucky');
INSERT INTO Weapons(Name)
VALUES('Judge');
INSERT INTO Weapons(Name)
VALUES('Ares');
INSERT INTO Weapons(Name)
VALUES('Odin');
```
