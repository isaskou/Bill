CREATE TABLE [dbo].[Adress]
(
	[Id] INT NOT NULL IDENTITY,
	Street nvarchar(255) NOT NULL,
	Num nvarchar(50) NOT NULL,
	PostalCode int NOT NULL,
	City nvarchar(50) NOT NULL,

	CONSTRAINT PK_AdressId
		PRIMARY KEY (Id),
)
