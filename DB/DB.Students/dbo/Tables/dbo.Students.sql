CREATE TABLE [dbo].[Students] (
    [Id]           INT  NOT NULL,
    [Name]         TEXT NOT NULL,
    [RecordBookID] INT  NOT NULL,
    [Family]       TEXT NOT NULL,
    [SecondName]   TEXT NOT NULL,
    [Age]          INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

