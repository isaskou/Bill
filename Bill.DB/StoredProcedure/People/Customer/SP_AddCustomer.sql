CREATE PROCEDURE [dbo].[SP_AddCustomer]
	@fn nvarchar(50),
	@ln nvarchar(50),
	@surname nvarchar(50),
	@company nvarchar(255),
	@tva nvarchar(50),
	@phone nvarchar(10),
	@mail nvarchar(255),
	@adressId int


AS
	BEGIN
		INSERT INTO Customer(FirstName, LastName, Surname, CompanyName, TVANumber, Phone, Email, AdressId)
		OUTPUT inserted.Id
		VALUES (@fn, @ln, @surname, @company, @tva, @phone, @mail, @adressId)
	END
