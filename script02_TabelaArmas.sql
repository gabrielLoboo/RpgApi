BEGIN TRANSACTION;
GO

CREATE TABLE [Arma] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Dano] int NOT NULL,
    CONSTRAINT [PK_Arma] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[Arma]'))
    SET IDENTITY_INSERT [Arma] ON;
INSERT INTO [Arma] ([Id], [Dano], [Nome])
VALUES (1, 47, N'facaak47'),
(2, 30, N'bazuca'),
(3, 2, N'm4'),
(4, 100, N'espadadedima'),
(5, 500, N'bananinha'),
(6, 250, N'bolacha'),
(7, 2000, N'zeus');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[Arma]'))
    SET IDENTITY_INSERT [Arma] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220929113254_MigrationArma', N'6.0.9');
GO

COMMIT;
GO

