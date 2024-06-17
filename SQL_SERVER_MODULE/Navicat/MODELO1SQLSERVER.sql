CREATE TABLE [EMPRESA] (
  [empresa_id] int IDENTITY(1,1) NOT NULL,
  [empresa_ruc] varchar(13) NULL,
  [empresa_razonsocial] varchar(150) NULL,
  [empresa_direccion] varchar(150) NULL,
  [empresa_telefono] varchar(150) NULL,
  [estado] char(1) NULL,
  [fecha_hora_reg] datetime2 NULL,
  [usu_id_reg] datetime2 NULL,
  [fecha_hora_modif] varchar(255) NULL,
  [usu_id_modif] int NULL,
  PRIMARY KEY CLUSTERED ([empresa_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [SUCURSAL] (
  [sucursal_id] int IDENTITY(1,1) NOT NULL,
  [sucursal_nombre] varchar(150) NULL,
  [sucursal_direccion] varchar(max) NULL,
  [sucursal_ruc] varchar(13) NULL,
  [sucursal_telefono] varchar(10) NULL,
  [estado] char(1) NULL,
  [empresa_id] int NULL,
  CONSTRAINT [_copy_1] PRIMARY KEY CLUSTERED ([sucursal_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

ALTER TABLE [SUCURSAL] ADD CONSTRAINT [FK_EMPRESA_SUCURSAL] FOREIGN KEY ([empresa_id]) REFERENCES [EMPRESA] ([empresa_id])
GO

