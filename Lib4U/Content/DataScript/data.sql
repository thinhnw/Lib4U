-- genres
INSERT INTO Genres (Name) VALUES ('Genres');
INSERT INTO Genres (Name) VALUES ('Anthropology');
INSERT INTO Genres (Name) VALUES ('Biography');
INSERT INTO Genres (Name) VALUES ('Comics');
INSERT INTO Genres (Name) VALUES ('Children''s');
INSERT INTO Genres (Name) VALUES ('Christian');
INSERT INTO Genres (Name) VALUES ('Buisness');
INSERT INTO Genres (Name) VALUES ('Fantasy');
INSERT INTO Genres (Name) VALUES ('Feminism');
INSERT INTO Genres (Name) VALUES ('Fiction');
INSERT INTO Genres (Name) VALUES ('Art');
INSERT INTO Genres (Name) VALUES ('Humanities');
INSERT INTO Genres (Name) VALUES ('Inspirational');
INSERT INTO Genres (Name) VALUES ('Reference');
INSERT INTO Genres (Name) VALUES ('Religion');
INSERT INTO Genres (Name) VALUES ('Science');
INSERT INTO Genres (Name) VALUES ('Science Fiction');

-- publishers
INSERT INTO Publishers(Name) values ('O Reilly Media');
INSERT INTO Publishers(Name) values ('A Book Apart');
INSERT INTO Publishers(Name) values ('A K PETERS');
INSERT INTO Publishers(Name) values ('Academic Press');
INSERT INTO Publishers(Name) values ('Addison Wesley');
INSERT INTO Publishers(Name) values ('Albert&Sweigart');
INSERT INTO Publishers(Name) values ('Alfred A. Knopf');
INSERT INTO Publishers(Name) values ('AMACOM');
INSERT INTO Publishers(Name) values ('AMLbook.com');
INSERT INTO Publishers(Name) values ('Apress');
INSERT INTO Publishers(Name) values ('Arpaci-Dusseau Books');
INSERT INTO Publishers(Name) values ('Artima');
INSERT INTO Publishers(Name) values ('Atlantic Monthly Press');
INSERT INTO Publishers(Name) values ('Attribution-ShareAlike License');
INSERT INTO Publishers(Name) values ('Avon');
INSERT INTO Publishers(Name) values ('Back Bay Books');
INSERT INTO Publishers(Name) values ('Bantam');
INSERT INTO Publishers(Name) values ('Bartlett Publishing');
INSERT INTO Publishers(Name) values ('Basic Books');


-- authors 
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Merritt',null,'Eric');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Linda',null,'Mui');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Alecos',null,'Papadatos');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Paul','C.van','Oorschot');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('David',null,'Cronin');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Richard',null,'Blum');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Yuval','Noah','Harari');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Paul',null,'Albitz');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('David',null,'Beazley');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('John','Paul','Shen');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Andrew',null,'Miller');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Melanie',null,'Swan');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Neal',null,'Ford');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Nir',null,'Shavit');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Tim',null,'Kindberg');
INSERT INTO Authors (First_name, Middle_name, Last_name) VALUES ('Mike',null,'McQuaid');


-- books
insert into Books (Title,Image,Total_pages,Rating,Published_date,PublisherId) values ('Lean Software Development: An Agile Toolkit','~/Uploads/nhung-cuon-sach-hay-10.jpg',240,4.17,'2003-05-18',1);
insert into Books (Title,Image,Total_pages,Rating,Published_date,PublisherId) values ('Facing the Intelligence Explosion','~/Uploads/default.jpg',91,3.87,'2013-02-01',2);
insert into Books (Title,Image,Total_pages,Rating,Published_date,PublisherId) values ('Scala in Action','~/Uploads/default.jpg',419,3.74,'2013-04-10',3);
insert into Books (Title,Image,Total_pages,Rating,Published_date,PublisherId) values ('Patterns of Software: Tales from the Software Community','~/Uploads/default.jpg',256,3.84,'1996-08-15',4);
insert into Books (Title,Image,Total_pages,Rating,Published_date,PublisherId) values ('Anatomy Of LISP','~/Uploads/default.jpg',446,4.43,'1978-01-01',5);
-- book authors

INSERT INTO BookAuthors (BookId,AuthorId) values (1,1);
INSERT INTO BookAuthors (BookId,AuthorId) values (2,2);
INSERT INTO BookAuthors (BookId,AuthorId) values (3,3);
INSERT INTO BookAuthors (BookId,AuthorId) values (4,4);
INSERT INTO BookAuthors (BookId,AuthorId) values (5,5);



-- book genres

INSERT INTO BookGenres (BookId,GenreId) VALUES(1,1);
INSERT INTO BookGenres (BookId,GenreId) VALUES(1,2);
INSERT INTO BookGenres (BookId,GenreId) VALUES(2,3);
INSERT INTO BookGenres (BookId,GenreId) VALUES(4,4);
INSERT INTO BookGenres (BookId,GenreId) VALUES(5,5);

