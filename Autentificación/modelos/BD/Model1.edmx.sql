
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/18/2023 00:18:43
-- Generated from EDMX file: C:\Users\sebas\source\repos\Autentificación\Autentificación\modelos\BD\Model1.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id_Usuario] int IDENTITY(1,1) NOT NULL,
    [Rut_Usuario] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Cargo] nvarchar(max)  NOT NULL,
    [CorreoElectronico] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL,
    [Rol] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RequerimientosSet'
CREATE TABLE [dbo].[RequerimientosSet] (
    [Id_Requerimiento] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Prioridad] nvarchar(max)  NOT NULL,
    [Nivel_Complejidad] nvarchar(max)  NOT NULL,
    [UsuarioId_Usuario] int  NOT NULL,
    [Estado_RequerimientoId_Estado] int  NOT NULL,
    [tipo_de_requerimientoId_Tipo_Req] int  NOT NULL
);
GO

-- Creating table 'DepartamentosSet'
CREATE TABLE [dbo].[DepartamentosSet] (
    [Id_Departamento] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Ubicacion] nvarchar(max)  NOT NULL,
    [Extension_Telefonica] nvarchar(max)  NOT NULL,
    [RequerimientosId_Requerimiento] int  NOT NULL,
    [Jefe_departamento] int  NOT NULL
);
GO

-- Creating table 'Estado_RequerimientoSet'
CREATE TABLE [dbo].[Estado_RequerimientoSet] (
    [Id_Estado] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [UsuarioId_Usuario] int  NOT NULL
);
GO

-- Creating table 'ComentarioSet'
CREATE TABLE [dbo].[ComentarioSet] (
    [Id_Observacion] int IDENTITY(1,1) NOT NULL,
    [Texto_Observacion] nvarchar(max)  NOT NULL,
    [RequerimientosId_Requerimiento] int  NOT NULL
);
GO

-- Creating table 'tipo_de_requerimientoSet'
CREATE TABLE [dbo].[tipo_de_requerimientoSet] (
    [Id_Tipo_Req] int IDENTITY(1,1) NOT NULL,
    [Titulo_de_requerimientos] nvarchar(max)  NOT NULL,
    [Requerimientos_Id_Requerimiento] int  NOT NULL
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

-- Creating primary key on [Id_Departamento] in table 'DepartamentosSet'
ALTER TABLE [dbo].[DepartamentosSet]
ADD CONSTRAINT [PK_DepartamentosSet]
    PRIMARY KEY CLUSTERED ([Id_Departamento] ASC);
GO

-- Creating primary key on [Id_Estado] in table 'Estado_RequerimientoSet'
ALTER TABLE [dbo].[Estado_RequerimientoSet]
ADD CONSTRAINT [PK_Estado_RequerimientoSet]
    PRIMARY KEY CLUSTERED ([Id_Estado] ASC);
GO

-- Creating primary key on [Id_Observacion] in table 'ComentarioSet'
ALTER TABLE [dbo].[ComentarioSet]
ADD CONSTRAINT [PK_ComentarioSet]
    PRIMARY KEY CLUSTERED ([Id_Observacion] ASC);
GO

-- Creating primary key on [Id_Tipo_Req] in table 'tipo_de_requerimientoSet'
ALTER TABLE [dbo].[tipo_de_requerimientoSet]
ADD CONSTRAINT [PK_tipo_de_requerimientoSet]
    PRIMARY KEY CLUSTERED ([Id_Tipo_Req] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UsuarioId_Usuario] in table 'RequerimientosSet'
ALTER TABLE [dbo].[RequerimientosSet]
ADD CONSTRAINT [FK_UsuarioRequerimientos]
    FOREIGN KEY ([UsuarioId_Usuario])
    REFERENCES [dbo].[UsuarioSet]
        ([Id_Usuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioRequerimientos'
CREATE INDEX [IX_FK_UsuarioRequerimientos]
ON [dbo].[RequerimientosSet]
    ([UsuarioId_Usuario]);
GO

-- Creating foreign key on [RequerimientosId_Requerimiento] in table 'DepartamentosSet'
ALTER TABLE [dbo].[DepartamentosSet]
ADD CONSTRAINT [FK_RequerimientosDepartamentos]
    FOREIGN KEY ([RequerimientosId_Requerimiento])
    REFERENCES [dbo].[RequerimientosSet]
        ([Id_Requerimiento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequerimientosDepartamentos'
CREATE INDEX [IX_FK_RequerimientosDepartamentos]
ON [dbo].[DepartamentosSet]
    ([RequerimientosId_Requerimiento]);
GO

-- Creating foreign key on [RequerimientosId_Requerimiento] in table 'ComentarioSet'
ALTER TABLE [dbo].[ComentarioSet]
ADD CONSTRAINT [FK_RequerimientosComentario]
    FOREIGN KEY ([RequerimientosId_Requerimiento])
    REFERENCES [dbo].[RequerimientosSet]
        ([Id_Requerimiento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequerimientosComentario'
CREATE INDEX [IX_FK_RequerimientosComentario]
ON [dbo].[ComentarioSet]
    ([RequerimientosId_Requerimiento]);
GO

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

-- Creating foreign key on [Jefe_departamento] in table 'DepartamentosSet'
ALTER TABLE [dbo].[DepartamentosSet]
ADD CONSTRAINT [FK_UsuarioDepartamentos]
    FOREIGN KEY ([Jefe_departamento])
    REFERENCES [dbo].[UsuarioSet]
        ([Id_Usuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioDepartamentos'
CREATE INDEX [IX_FK_UsuarioDepartamentos]
ON [dbo].[DepartamentosSet]
    ([Jefe_departamento]);
GO

-- Creating foreign key on [UsuarioId_Usuario] in table 'Estado_RequerimientoSet'
ALTER TABLE [dbo].[Estado_RequerimientoSet]
ADD CONSTRAINT [FK_UsuarioEstado_Requerimiento]
    FOREIGN KEY ([UsuarioId_Usuario])
    REFERENCES [dbo].[UsuarioSet]
        ([Id_Usuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioEstado_Requerimiento'
CREATE INDEX [IX_FK_UsuarioEstado_Requerimiento]
ON [dbo].[Estado_RequerimientoSet]
    ([UsuarioId_Usuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------