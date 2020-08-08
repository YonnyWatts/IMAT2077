CREATE PROCEDURE [dbo].[sproc_tblCustomerPaymentInfo_Add]
	@Email varchar(50),
	@Name varchar(100),
	@Card varchar(16),
	@Date date,
	@Street varchar (100),
	@City varchar(50),
	@PostCode varchar(10)
AS
	Insert into tblCustomerPaymentInfo(Email, FullName, CardNumber, ExpiryDate, StreetAddress, City, PostCode)
	values (@Email, @Name, @Card, @Date, @Street, @City, @PostCode)
RETURN 0