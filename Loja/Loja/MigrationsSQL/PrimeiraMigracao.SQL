IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clientes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] VARCHAR(80) NOT NULL,
    [CPF] VARCHAR(11) NOT NULL,
    [DataNascimento] datetime2 NOT NULL,
    [Telefone] VARCHAR(11) NOT NULL,
    [Email] VARCHAR(80) NULL,
    [Estado] VARCHAR(2) NOT NULL,
    [Cidade] VARCHAR(80) NOT NULL,
    [CEP] VARCHAR(8) NOT NULL,
    [Numero] int NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Funcionários] (
    [Id] int NOT NULL IDENTITY,
    [Salario] real NOT NULL,
    [Categoria] nvarchar(max) NOT NULL,
    [Nome] VARCHAR(80) NOT NULL,
    [CPF] VARCHAR(11) NOT NULL,
    [DataNascimento] datetime2 NOT NULL,
    [Telefone] VARCHAR(11) NOT NULL,
    [Email] VARCHAR(80) NULL,
    [Estado] VARCHAR(2) NOT NULL,
    [Cidade] VARCHAR(80) NOT NULL,
    [CEP] VARCHAR(8) NOT NULL,
    [Numero] int NOT NULL,
    CONSTRAINT [PK_Funcionários] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210422173245_PrimeiraMigracao', N'5.0.5');
GO

COMMIT;
GO

