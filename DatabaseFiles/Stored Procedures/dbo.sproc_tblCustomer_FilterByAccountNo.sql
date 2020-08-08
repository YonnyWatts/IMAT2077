CREATE PROCEDURE [dbo].[sproc_tblCustomer_FilterByAccountNo]
	@AccountNo int
AS
	SELECT * from tblCustomer where AccountNo = @AccountNo
RETURN 0