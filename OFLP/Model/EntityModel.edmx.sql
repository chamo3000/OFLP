
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/16/2023 09:43:19
-- Generated from EDMX file: C:\Users\jbedoya\Documents\OFLP\OFLP\OFLP\Model\EntityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MIGAN];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__FACTURA__claseID__220B0B18]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FACTURA] DROP CONSTRAINT [FK__FACTURA__claseID__220B0B18];
GO
IF OBJECT_ID(N'[dbo].[FK__FACTURA__cliente__2116E6DF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FACTURA] DROP CONSTRAINT [FK__FACTURA__cliente__2116E6DF];
GO
IF OBJECT_ID(N'[dbo].[fk_Factura_Comprador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FACTURA] DROP CONSTRAINT [fk_Factura_Comprador];
GO
IF OBJECT_ID(N'[dbo].[FK__FACTURA__gastoID__23F3538A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FACTURA] DROP CONSTRAINT [FK__FACTURA__gastoID__23F3538A];
GO
IF OBJECT_ID(N'[dbo].[FK__FACTURA__sexoID__22FF2F51]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FACTURA] DROP CONSTRAINT [FK__FACTURA__sexoID__22FF2F51];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIO_ROL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO] DROP CONSTRAINT [FK_USUARIO_ROL];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CLASE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CLASE];
GO
IF OBJECT_ID(N'[dbo].[CLIENTE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CLIENTE];
GO
IF OBJECT_ID(N'[dbo].[FACTURA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FACTURA];
GO
IF OBJECT_ID(N'[dbo].[GASTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GASTO];
GO
IF OBJECT_ID(N'[dbo].[ROL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ROL];
GO
IF OBJECT_ID(N'[dbo].[SEXO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SEXO];
GO
IF OBJECT_ID(N'[dbo].[USUARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIO];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CLASE'
CREATE TABLE [dbo].[CLASE] (
    [id] int IDENTITY(1,1) NOT NULL,
    [claseGanado] char(1)  NOT NULL,
    [clase1] varchar(20)  NOT NULL,
    [descripcion] varchar(50)  NOT NULL
);
GO

-- Creating table 'CLIENTE'
CREATE TABLE [dbo].[CLIENTE] (
    [PRIMERAPELLIDO] varchar(255)  NOT NULL,
    [SEGUNDOAPELLIDO] varchar(255)  NULL,
    [NOMBRE] varchar(255)  NOT NULL,
    [CEDULA] int  NOT NULL,
    [ID] int  NOT NULL
);
GO

-- Creating table 'FACTURA'
CREATE TABLE [dbo].[FACTURA] (
    [id] int IDENTITY(1,1) NOT NULL,
    [consecutivo] int  NOT NULL,
    [reunion] int  NOT NULL,
    [fecha] datetime  NOT NULL,
    [cabezas] int  NOT NULL,
    [corral] int  NULL,
    [kilos] int  NOT NULL,
    [valorkilo] int  NOT NULL,
    [valortotal] int  NOT NULL,
    [anio] int  NOT NULL,
    [clienteID] int  NOT NULL,
    [claseID] int  NOT NULL,
    [sexoID] int  NOT NULL,
    [gastoID] int  NOT NULL,
    [compradorID] int  NOT NULL
);
GO

-- Creating table 'GASTO'
CREATE TABLE [dbo].[GASTO] (
    [id] int IDENTITY(1,1) NOT NULL,
    [reunion] int  NULL,
    [cliente] int  NULL,
    [bascula] int  NULL,
    [transporte] int  NULL,
    [bano] int  NULL,
    [recibida] int  NULL,
    [comisionF] int  NULL,
    [comisionG] int  NULL,
    [vacuna] int  NULL,
    [anticipo] int  NULL,
    [otros] int  NULL,
    [observacion] varchar(500)  NULL,
    [idfactura] int  NOT NULL,
    [Total] int  NOT NULL
);
GO

-- Creating table 'ROL'
CREATE TABLE [dbo].[ROL] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ROL1] varchar(50)  NOT NULL
);
GO

-- Creating table 'SEXO'
CREATE TABLE [dbo].[SEXO] (
    [id] int IDENTITY(1,1) NOT NULL,
    [sexo1] char(1)  NOT NULL,
    [descripcion] varchar(20)  NOT NULL
);
GO

-- Creating table 'USUARIO'
CREATE TABLE [dbo].[USUARIO] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [USUARIO1] varchar(50)  NOT NULL,
    [CONTRASENA] varchar(50)  NOT NULL,
    [NOMBRE] varchar(50)  NOT NULL,
    [APELLIDO] varchar(50)  NOT NULL,
    [IDPERFIL] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'CLASE'
ALTER TABLE [dbo].[CLASE]
ADD CONSTRAINT [PK_CLASE]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [CEDULA] in table 'CLIENTE'
ALTER TABLE [dbo].[CLIENTE]
ADD CONSTRAINT [PK_CLIENTE]
    PRIMARY KEY CLUSTERED ([CEDULA] ASC);
GO

-- Creating primary key on [id] in table 'FACTURA'
ALTER TABLE [dbo].[FACTURA]
ADD CONSTRAINT [PK_FACTURA]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'GASTO'
ALTER TABLE [dbo].[GASTO]
ADD CONSTRAINT [PK_GASTO]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [ID] in table 'ROL'
ALTER TABLE [dbo].[ROL]
ADD CONSTRAINT [PK_ROL]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [id] in table 'SEXO'
ALTER TABLE [dbo].[SEXO]
ADD CONSTRAINT [PK_SEXO]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [ID] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [PK_USUARIO]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [claseID] in table 'FACTURA'
ALTER TABLE [dbo].[FACTURA]
ADD CONSTRAINT [FK__FACTURA__claseID__220B0B18]
    FOREIGN KEY ([claseID])
    REFERENCES [dbo].[CLASE]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__FACTURA__claseID__220B0B18'
CREATE INDEX [IX_FK__FACTURA__claseID__220B0B18]
ON [dbo].[FACTURA]
    ([claseID]);
GO

-- Creating foreign key on [clienteID] in table 'FACTURA'
ALTER TABLE [dbo].[FACTURA]
ADD CONSTRAINT [FK__FACTURA__cliente__2116E6DF]
    FOREIGN KEY ([clienteID])
    REFERENCES [dbo].[CLIENTE]
        ([CEDULA])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__FACTURA__cliente__2116E6DF'
CREATE INDEX [IX_FK__FACTURA__cliente__2116E6DF]
ON [dbo].[FACTURA]
    ([clienteID]);
GO

-- Creating foreign key on [compradorID] in table 'FACTURA'
ALTER TABLE [dbo].[FACTURA]
ADD CONSTRAINT [fk_Factura_Comprador]
    FOREIGN KEY ([compradorID])
    REFERENCES [dbo].[CLIENTE]
        ([CEDULA])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_Factura_Comprador'
CREATE INDEX [IX_fk_Factura_Comprador]
ON [dbo].[FACTURA]
    ([compradorID]);
GO

-- Creating foreign key on [gastoID] in table 'FACTURA'
ALTER TABLE [dbo].[FACTURA]
ADD CONSTRAINT [FK__FACTURA__gastoID__23F3538A]
    FOREIGN KEY ([gastoID])
    REFERENCES [dbo].[GASTO]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__FACTURA__gastoID__23F3538A'
CREATE INDEX [IX_FK__FACTURA__gastoID__23F3538A]
ON [dbo].[FACTURA]
    ([gastoID]);
GO

-- Creating foreign key on [sexoID] in table 'FACTURA'
ALTER TABLE [dbo].[FACTURA]
ADD CONSTRAINT [FK__FACTURA__sexoID__22FF2F51]
    FOREIGN KEY ([sexoID])
    REFERENCES [dbo].[SEXO]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__FACTURA__sexoID__22FF2F51'
CREATE INDEX [IX_FK__FACTURA__sexoID__22FF2F51]
ON [dbo].[FACTURA]
    ([sexoID]);
GO

-- Creating foreign key on [IDPERFIL] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [FK_USUARIO_ROL]
    FOREIGN KEY ([IDPERFIL])
    REFERENCES [dbo].[ROL]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIO_ROL'
CREATE INDEX [IX_FK_USUARIO_ROL]
ON [dbo].[USUARIO]
    ([IDPERFIL]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------