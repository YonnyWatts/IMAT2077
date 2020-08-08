CREATE PROCEDURE [dbo].[sproc_tblCustomer_Add]
	@Username varchar(50),
	@Password varchar(50),
	@Realname varchar(100),
	@Email    varchar(50),
	@paymentInfo bit

AS
	Insert into tblCustomer(FullName, Username, Password, Email, IsPaymentSaved) 
	values (@Realname, @Username, @Password, @Email, @paymentInfo)
RETURN @@Identity