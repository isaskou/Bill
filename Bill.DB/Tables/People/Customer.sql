CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL Identity,
	[FirstName] nvarchar(50),
	[LastName] nvarchar(50),
	Surname nvarchar(50) NULL,
	CompanyName nvarchar(255) NULL,
	TVANumber nvarchar(50) UNIQUE NULL,
	Phone nvarchar(10) NULL,
	[Email] nvarchar(255) UNIQUE NOT NULL,
	AdressId INT NULL,


	CONSTRAINT PK_CustomerId PRIMARY KEY (Id),

	CONSTRAINT CK_Customer_Email
		CHECK (Email LIKE '%@%.%'),

	CONSTRAINT FK_Customer_Adress
		FOREIGN KEY (AdressId)
		REFERENCES Adress(Id)
)
