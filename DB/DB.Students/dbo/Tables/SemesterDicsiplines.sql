CREATE TABLE [dbo].[SemesterDicsiplines]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SemestrID] INT NOT NULL, 
    [LectorerID] INT NOT NULL, 
    [Hours] INT NOT NULL, 
    [DisciplineID] INT NOT NULL
)
