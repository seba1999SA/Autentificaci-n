
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/24/2023 20:35:14
-- Generated from EDMX file: C:\Users\jpgod\source\repos\Autentificaci-n\Autentificación\modelos\BD\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [trabajo_nacional];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RequerimientosEstado_Requerimiento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequerimientosSet] DROP CONSTRAINT [FK_RequerimientosEstado_Requerimiento];
GO
IF OBJECT_ID(N'[dbo].[FK_tipo_de_requerimientoRequerimientos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequerimientosSet] DROP CONSTRAINT [FK_tipo_de_requerimientoRequerimientos];
GO
IF OBJECT_ID(N'[dbo].[FK_RolUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioSet] DROP CONSTRAINT [FK_RolUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_RolRequerimientos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequerimientosSet] DROP CONSTRAINT [FK_RolRequerimientos];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSet];
GO
IF OBJECT_ID(N'[dbo].[RequerimientosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RequerimientosSet];
GO
IF OBJECT_ID(N'[dbo].[Estado_RequerimientoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estado_RequerimientoSet];
GO
IF OBJECT_ID(N'[dbo].[tipo_de_requerimientoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tipo_de_requerimientoSet];
GO
IF OBJECT_ID(N'[dbo].[RolSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id_Usuario] int IDENTITY(1,1) NOT NULL,
    [Rut_Usuario] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [CorreoElectronico] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL,
    [RolID] int  NOT NULL
);
GO

-- Creating table 'RequerimientosSet'
CREATE TABLE [dbo].[RequerimientosSet] (
    [Id_Requerimiento] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Prioridad] nvarchar(max)  NOT NULL,
    [Estado_RequerimientoId_Estado] int  NOT NULL,
    [tipo_de_requerimientoId_Tipo_Req] int  NOT NULL,
    [RolID] int  NOT NULL
);
GO

-- Creating table 'Estado_RequerimientoSet'
CREATE TABLE [dbo].[Estado_RequerimientoSet] (
    [Id_Estado] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'tipo_de_requerimientoSet'
CREATE TABLE [dbo].[tipo_de_requerimientoSet] (
    [Id_Tipo_Req] int IDENTITY(1,1) NOT NULL,
    [Titulo_de_requerimientos] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RolSet'
CREATE TABLE [dbo].[RolSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nombre_Rol] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Usuario] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id_Usuario] ASC);
GO

-- Creating primary key on [Id_Requerimiento] in table 'RequerimientosSet'
ALTER TABLE [dbo].[RequerimientosSet]
ADD CONSTRAINT [PK_RequerimientosSet]
    PRIMARY KEY CLUSTERED ([Id_Requerimiento] ASC);
GO

-- Creating primary key on [Id_Estado] in table 'Estado_RequerimientoSet'
ALTER TABLE [dbo].[Estado_RequerimientoSet]
ADD CONSTRAINT [PK_Estado_RequerimientoSet]
    PRIMARY KEY CLUSTERED ([Id_Estado] ASC);
GO

-- Creating primary key on [Id_Tipo_Req] in table 'tipo_de_requerimientoSet'
ALTER TABLE [dbo].[tipo_de_requerimientoSet]
ADD CONSTRAINT [PK_tipo_de_requerimientoSet]
    PRIMARY KEY CLUSTERED ([Id_Tipo_Req] ASC);
GO

-- Creating primary key on [ID] in table 'RolSet'
ALTER TABLE [dbo].[RolSet]
ADD CONSTRAINT [PK_RolSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Estado_RequerimientoId_Estado] in table 'RequerimientosSet'
ALTER TABLE [dbo].[RequerimientosSet]
ADD CONSTRAINT [FK_RequerimientosEstado_Requerimiento]
    FOREIGN KEY ([Estado_RequerimientoId_Estado])
    REFERENCES [dbo].[Estado_RequerimientoSet]
        ([Id_Estado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequerimientosEstado_Requerimiento'
CREATE INDEX [IX_FK_RequerimientosEstado_Requerimiento]
ON [dbo].[RequerimientosSet]
    ([Estado_RequerimientoId_Estado]);
GO

-- Creating foreign key on [tipo_de_requerimientoId_Tipo_Req] in table 'RequerimientosSet'
ALTER TABLE [dbo].[RequerimientosSet]
ADD CONSTRAINT [FK_tipo_de_requerimientoRequerimientos]
    FOREIGN KEY ([tipo_de_requerimientoId_Tipo_Req])
    REFERENCES [dbo].[tipo_de_requerimientoSet]
        ([Id_Tipo_Req])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tipo_de_requerimientoRequerimientos'
CREATE INDEX [IX_FK_tipo_de_requerimientoRequerimientos]
ON [dbo].[RequerimientosSet]
    ([tipo_de_requerimientoId_Tipo_Req]);
GO

-- Creating foreign key on [RolID] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_RolUsuario]
    FOREIGN KEY ([RolID])
    REFERENCES [dbo].[RolSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolUsuario'
CREATE INDEX [IX_FK_RolUsuario]
ON [dbo].[UsuarioSet]
    ([RolID]);
GO

-- Creating foreign key on [RolID] in table 'RequerimientosSet'
ALTER TABLE [dbo].[RequerimientosSet]
ADD CONSTRAINT [FK_RolRequerimientos]
    FOREIGN KEY ([RolID])
    REFERENCES [dbo].[RolSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolRequerimientos'
CREATE INDEX [IX_FK_RolRequerimientos]
ON [dbo].[RequerimientosSet]
    ([RolID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------