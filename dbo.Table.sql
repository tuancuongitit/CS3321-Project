CREATE TABLE [dbo].[Table]
(
	[userID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[password] VARCHAR(20) NOT NULL, 
    [fName] NCHAR(10) NOT NULL, 
    [lName] NCHAR(10) NOT NULL, 
    [userType] NCHAR(10) NULL
)
