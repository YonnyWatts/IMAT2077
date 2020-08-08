CREATE TABLE [dbo].[tblCustomer] (
    [AccountNo]      INT           IDENTITY (1, 1) NOT NULL,
    [FullName]       VARCHAR (100) NOT NULL,
    [Username]       VARCHAR (50)  NOT NULL,
    [Password]       VARCHAR (50)  NOT NULL,
    [Email]          VARCHAR (50)  NOT NULL,
    [IsPaymentSaved] BIT           DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([AccountNo] ASC)
);

