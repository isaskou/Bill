CREATE TABLE [dbo].[Provider]
(
	[Id] INT NOT NULL IDENTITY,
	FirstName nvarchar(50) NULL,
	LastName nvarchar(50) NULL,
	CompanyName nvarchar(50) NULL,
	TVANumber nvarchar(50) UNIQUE NULL,
	PhoneNumber nvarchar(25) NULL,
	Email nvarchar(255) NOT NULL,

	AdressId int NULL


	CONSTRAINT PK_ProviderId PRIMARY KEY (Id),

	CONSTRAINT CK_Provider_Email
		CHECK (Email LIKE '%@%.%'),

	CONSTRAINT FK_Provider_Adress
		Foreign key (AdressId)
		REFERENCES Adress(Id)
)
