CREATE PROCEDURE [dbo].[SP_UpdateCustomer]
	@id int,
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
		UPDATE Customer 
		SET FirstName=@fn, LastName=@ln, Surname=@surname, CompanyName=@company, TVANumber=@tva, 
			Phone=@phone, Email= @mail, AdressId=@adressId
		WHERE Id=@id
	END
