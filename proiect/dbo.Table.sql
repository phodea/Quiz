CREATE TABLE [dbo].[Intrebari]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [intrebare] NCHAR(50) NOT NULL, 
    [raspuns1] NCHAR(50) NOT NULL, 
    [raspuns2] NCHAR(50) NOT NULL, 
    [raspuns3] NCHAR(50) NOT NULL, 
    [raspuns4] NCHAR(50) NOT NULL, 
    [raspuns_corect] INT NOT NULL, 
    [dificultate] INT NOT NULL 
)
