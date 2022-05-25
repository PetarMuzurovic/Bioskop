Create database Bioskop
use Bioskop

CREATE TABLE Korisnik 
(
	ID int Identity(1, 1) PRIMARY KEY,
	Ime nvarchar(50) not null,
	Prezime nvarchar(50) not null,
	Email nvarchar(50) not null,
	Lozinka nvarchar(50) not null,
)
Drop table Korisnik

CREATE TABLE Film
(
	ID int Identity(1, 1) PRIMARY KEY,
	Naziv nvarchar(50) not null,
	Datum Date not null,
	Vreme time not null,
	Br_mesta int not null,
)
Drop table Film

CREATE TABLE Rezervacije 
(
	ID int Identity(1, 1) PRIMARY KEY,
	ID_korisnik int FOREIGN KEY references Korisnik(ID),
	ID_Film int FOREIGN KEY references Film(ID),
	Mesto int not null,
)
Drop table Rezervacije

INSERT INTO Korisnik VALUES
('Milos', 'Tomic', 'milostomic@gmail.com', 'milos123'),
('Andrej', 'Bratic', 'andrejbratic@gmail.com', 'andrej123'),
('Milan', 'Djuric', 'milandjuric@gmail.com', 'milan123'),
('Petar', 'Ilic', 'petarilic@gmail.com', 'petar123')


SET DATEFORMAT YMD
INSERT INTO Film VALUES
('Underground', '2022-7-21', '20:20', 25),
('My name is nobody', '2022-7-21', '17:30', 20),
('Plague dogs', '2022-7-26', '19:00', 18),
('Layer cake', '2022-6-24', '13:45', 25),
('Knives out', '2022-7-24', '20:20', 30),
('300', '2022-7-21', '20:20', 23)



SELECT * FROM Korisnik WHERE Email = 'milostomic@gmail.com'

SELECT DISTINCT Naziv FROM Film WHERE Datum > GETDATE()

Select * from Rezervacije 

Select Film.Naziv, Film.Datum, Film.Vreme, Mesto from Rezervacije join Film on Rezervacije.ID_Film = Film.ID where ID_korisnik = '4' AND ID_Film = '4'

SELECT ID FROM Film WHERE Convert(nvarchar(10), Datum) LIKE Convert(nvarchar(10), '2022-07-21') AND Convert(nvarchar(5), Vreme) LIKE Convert(nvarchar(5), '20:20') AND Naziv = '300'