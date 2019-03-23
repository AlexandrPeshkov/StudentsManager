CREATE TABLE [dbo].[RecordBookLine]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [RecordBookID] INT NOT NULL, 
    [Date] DATE NOT NULL, 
    [Mark] INT NOT NULL, 
    [LectorID] INT NOT NULL, 
    [Hours] INT NOT NULL, 
    [DisciplinesID] INT NOT NULL, 
    [SemesterID] INT NOT NULL
)
