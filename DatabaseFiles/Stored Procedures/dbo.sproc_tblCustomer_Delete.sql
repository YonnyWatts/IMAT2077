CREATE PROCEDURE [dbo].[sproc_tblCustomer_Delete]
	@AccountNo int
AS

 delete from tblCustomer where AccountNo = @AccountNo;
RETURN 0