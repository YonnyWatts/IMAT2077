CREATE TABLE [dbo].[tblCustomerPaymentInfo]
(
	[Email] VARCHAR(50)NOT NULL PRIMARY KEY,
	[FullName] VARCHAR(100) NOT NULL,
	[CardNumber] VARCHAR(16) NOT NULL,
	[ExpiryDate] DATE NOT NULL,
	[StreetAddress] VARCHAR(100) NOT NULL,
	[City] VARCHAR(50) NOT NULL,
	[PostCode] VARCHAR(10) NOT NULL

)
