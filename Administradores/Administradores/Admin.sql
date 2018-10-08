CREATE TABLE [dbo].[Admin]
(
    [IDAdministrador]      INT           IDENTITY (1, 1) NOT NULL,
	[Dui]      NVARCHAR (50) NULL,
    [Nombre]       NVARCHAR (50) NULL,
    [Apellido]      NVARCHAR (50) NULL,
	[FechaDeNacimiento] DATETIME      NULL,
	[Genero]      NVARCHAR (50) NULL,
	[Direccion]      NVARCHAR (50) NULL,
	[Telefono]      NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([IDAdministrador] ASC)
)
