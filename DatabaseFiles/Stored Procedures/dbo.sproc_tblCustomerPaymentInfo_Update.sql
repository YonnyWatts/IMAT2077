CREATE PROCEDURE [dbo].[sproc_tblCustomerPaymentInfo_Update]
@OldEmail varchar(50),
@Email varchar(50),
@Name varchar(100),
@Card varchar(16),
@Date date,
@Street varchar(100),
@City   varchar(50),
@Post varchar(10)
AS
	UPDATE tblCustomerPaymentInfo SET Email = @Email, FullName = @Name, CardNumber = @Card, ExpiryDate = @Date, StreetAddress = @Street, City= @City, PostCode = @Post
WHERE Email = @OldEmail
RETURN 0