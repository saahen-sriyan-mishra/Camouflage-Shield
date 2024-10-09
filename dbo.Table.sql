CREATE TABLE [dbo].[Signup]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [date] VARCHAR(50) NULL, 
    [email] VARCHAR(50) NULL, 
    [phonenumber] INT NULL, 
    [username] VARCHAR(50) NULL, 
    [password] VARCHAR(MAX) NULL
)
