/* Create Database */
CREATE DATABASE tutorialDb;

/* Use The Newly Created Database */
USE tutorialDb;

/* Creating Table */
CREATE TABLE school (
  id INTEGER NOT NULL,
  name VARCHAR(120),
  PRIMARY KEY(id)
);

/* Insert Values In Table */
INSERT INTO school (id, name) VALUES (1, "Oxford. Sr. Sec. School");
INSERT INTO school (id, name) VALUES (2, "Amity International");
INSERT INTO school (id, name) VALUES (3, "Kamal Public School");
INSERT INTO school (id, name) VALUES (4, "DAV Public School");
INSERT INTO school (id, name) VALUES (5, "Ryan International");