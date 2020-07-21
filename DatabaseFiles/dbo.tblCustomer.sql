CREATE TABLE [dbo].[tblCustomer]
(
	[AccountNo] INT NOT NULL PRIMARY KEY,
	[Full Name] VARCHAR(100) NOT NULL,
	[Username]  VARCHAR(50) NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[Email] VARCHAR(50) NOT NULL,
	[IsPaymentSaved?] BIT NOT NULL DEFAULT 0
 )
