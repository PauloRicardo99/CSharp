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
    [DataNascimento] VARCHAR(10) NOT NULL,
    [Telefone] VARCHAR(11) NOT NULL,
    [Email] VARCHAR(80) NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Funcionários] (
    [Id] int NOT NULL IDENTITY,
    [Salario] real NOT NULL,
    [Categoria] nvarchar(max) NOT NULL,
    [Nome] VARCHAR(80) NOT NULL,
    [CPF] VARCHAR(11) NOT NULL,
    [DataNascimento] VARCHAR(10) NOT NULL,
    [Telefone] VARCHAR(11) NOT NULL,
    [Email] VARCHAR(80) NULL,
    CONSTRAINT [PK_Funcionários] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Enderecos Clientes] (
    [Id] int NOT NULL IDENTITY,
    [Estado] VARCHAR(2) NOT NULL,
    [Cidade] VARCHAR(80) NOT NULL,
    [CEP] VARCHAR(8) NOT NULL,
    [Numero] int NOT NULL,
    [ClienteId] int NOT NULL,
    CONSTRAINT [PK_Enderecos Clientes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Enderecos Clientes_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Enderecos Funcionarios] (
    [Id] int NOT NULL IDENTITY,
    [Estado] VARCHAR(2) NOT NULL,
    [Cidade] VARCHAR(80) NOT NULL,
    [CEP] VARCHAR(8) NOT NULL,
    [Numero] int NOT NULL,
    [FuncionarioId] int NOT NULL,
    CONSTRAINT [PK_Enderecos Funcionarios] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Enderecos Funcionarios_Funcionários_FuncionarioId] FOREIGN KEY ([FuncionarioId]) REFERENCES [Funcionários] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Enderecos Clientes_ClienteId] ON [Enderecos Clientes] ([ClienteId]);
GO

CREATE INDEX [IX_Enderecos Funcionarios_FuncionarioId] ON [Enderecos Funcionarios] ([FuncionarioId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210504194836_PrimeiraMigracao', N'5.0.5');
GO

COMMIT;
GO

