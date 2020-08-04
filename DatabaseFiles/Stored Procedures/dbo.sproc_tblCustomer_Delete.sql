CREATE PROCEDURE [dbo].[sproc_tblCustomer_Delete]
	@AccountNo int = 0
AS

 delete from tblCustomer where AccountNo = @AccountNo;
RETURN 0
