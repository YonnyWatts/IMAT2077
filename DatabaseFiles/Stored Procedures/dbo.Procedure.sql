CREATE PROCEDURE [dbo].[sproc_tblCustomerPaymentInfo_Add]
	@Email varchar(50),
	@Card varchar(16),
	@Date DateTime,
	@Address varchar(100),
	@City varchar(50),
	@PostCode varchar(7)

AS
	Insert into tblCustomerPaymentInfo(Email, FullName, CardNumber, ExpiryDate, StreetAddress, City, PostCode) 
	values (@Email, @Card, @Date, @Address, @City, @PostCode)
RETURN 0
