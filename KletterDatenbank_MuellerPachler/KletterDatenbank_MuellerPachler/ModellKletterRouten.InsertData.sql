
-- --------------------------------------------------
-- Einfügen von Grunddaten
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EF_KletterRouten];
GO

-- INSERT Daten in die Tabelle Gebiet

GO
SET IDENTITY_INSERT dbo.Gebiet ON
GO


INSERT INTO dbo.Gebiet (ID_Gebiet, NameGebiet, Ort, PLZ, GPS_Parkplatz)
VALUES (1, 'Waxenberg', 'Waxenberg', 4181,'123456');
INSERT INTO dbo.Gebiet (ID_Gebiet, NameGebiet, Ort, PLZ, GPS_Parkplatz)
VALUES (2, 'Rindbachtal', 'Ebensee', 4123,'123456');
INSERT INTO dbo.Gebiet (ID_Gebiet, NameGebiet, Ort, PLZ, GPS_Parkplatz)
VALUES (3, 'Zillertal', 'Zillertal', 6123,'123456');

GO
SET IDENTITY_INSERT dbo.Gebiet OFF
GO


---- INSERT Daten in die Tabelle Persons

GO
SET IDENTITY_INSERT dbo.Person ON
GO

INSERT INTO dbo.Person (ID_Person, Vorname, Nachname, Geburtsdatum)
VALUES (1, 'Tobias', 'Müller', '1992-12-04');
INSERT INTO dbo.Person (ID_Person, Vorname, Nachname, Geburtsdatum)
VALUES (2, 'Martin', 'Pachler', '1989-05-12');

GO
SET IDENTITY_INSERT dbo.Person OFF
GO

---- INSERT Daten in die Tabelle Sektor

GO
SET IDENTITY_INSERT dbo.Sektor ON
GO

INSERT INTO dbo.Sektor (ID_Sektor, ID_Gebiet, NameSektor, GPS_Exakt)
VALUES (1, 3, 'Ewige Jagdgründe', '12-12-12');
INSERT INTO dbo.Sektor (ID_Sektor, ID_Gebiet, NameSektor, GPS_Exakt)
VALUES (2, 3, 'Bergstation', '12-12-14');
INSERT INTO dbo.Sektor (ID_Sektor, ID_Gebiet, NameSektor, GPS_Exakt)
VALUES (3, 3, 'Zillergrund', '12-12-26');
INSERT INTO dbo.Sektor (ID_Sektor, ID_Gebiet, NameSektor, GPS_Exakt)
VALUES (4, 3, 'Sundergrund', '12-13-19');

GO
SET IDENTITY_INSERT dbo.Sektor OFF
GO

-- INSERT Daten in die Tabelle Route

GO
SET IDENTITY_INSERT dbo.Route ON
GO

INSERT INTO dbo.Route (ID_Route, ID_Sektor, Name, Schwierigkeitsgrad, IstBoulder)
VALUES (1, 1, 'Muttertag', '7b+',0);
INSERT INTO dbo.Route (ID_Route, ID_Sektor, Name, Schwierigkeitsgrad, IstBoulder)
VALUES (2, 1, 'Maracuja', '7a',0);
INSERT INTO dbo.Route (ID_Route, ID_Sektor, Name, Schwierigkeitsgrad, IstBoulder)
VALUES (3, 4, 'Moonwalk', '7a+',1);

GO
SET IDENTITY_INSERT dbo.Route OFF
GO


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------