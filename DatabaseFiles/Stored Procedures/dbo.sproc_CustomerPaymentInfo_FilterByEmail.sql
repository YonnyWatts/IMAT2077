CREATE PROCEDURE [dbo].[sproc_CustomerPaymentInfo_FilterByEmail]
	@Email Varchar(50)

AS
	SELECT * from tblCustomerPaymentInfo where Email = @Email
RETURN 0