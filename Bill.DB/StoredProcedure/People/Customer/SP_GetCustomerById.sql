CREATE PROCEDURE [dbo].[SP_GetCustomerById]
	@id INT
AS
	SELECT *
	FROM Customer
	Where Id=@id
RETURN 0
