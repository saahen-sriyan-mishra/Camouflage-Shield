CREATE TABLE [dbo].[EncryptedData]
(
	[ID] INT PRIMARY KEY IDENTITY(1,1),
    [Username] NVARCHAR(50) NOT NULL, 
    [EncryptedText] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT Unique_Username_EncryptedData UNIQUE (Username)
)
