CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Login] VARCHAR(25) NULL, 
    [Hash_code] VARCHAR(128) NOT NULL, 
    [Email] VARCHAR(254) NULL, 
    [Institute] INT NOT NULL, 
    [Group_name] INT NOT NULL, 
    [Full_name] VARCHAR(55) NOT NULL,
	[Is_teacher] BIT NOT NULL
)
