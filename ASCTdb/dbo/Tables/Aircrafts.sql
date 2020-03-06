CREATE TABLE [dbo].[Aircrafts]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TailNumber] NVARCHAR(50) NOT NULL, 
    [LRUName] NVARCHAR(50) NOT NULL, 
    [LRUPartNumber] NVARCHAR(50) NOT NULL, 
    [SoftwareName] NVARCHAR(50) NOT NULL, 
    [SoftwarePartNumber] NVARCHAR(50) NOT NULL, 
    [ECNumber] NVARCHAR(50) NULL, 
    [PrePostCondition] NVARCHAR(50) NULL
)
