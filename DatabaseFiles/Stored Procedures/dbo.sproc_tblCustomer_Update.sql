CREATE PROCEDURE [dbo].[sproc_tblCustomer_Update]
@AccountNo int,
@Username varchar(50),
@Password varchar(50),
@Realname varchar(100),
@Email    varchar(50),
@paymentInfo bit

AS
UPDATE tblCustomer SET Username = @Username, Password = @Password, FullName = @Realname, Email = @Email, IsPaymentSaved = @paymentInfo
WHERE AccountNo = @AccountNo