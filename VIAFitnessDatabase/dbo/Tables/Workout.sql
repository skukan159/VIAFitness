﻿CREATE TABLE [dbo].[Workout]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
	[UserId] NVARCHAR(128) NOT NULL,
    [Type] NVARCHAR(50) NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
