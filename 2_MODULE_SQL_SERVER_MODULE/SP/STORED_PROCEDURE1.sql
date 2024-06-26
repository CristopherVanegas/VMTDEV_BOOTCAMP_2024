USE VENTAS;
GO

-- STORED PROCEDURE - SP
CREATE PROCEDURE SP_CONSULTA_VTAS_SUCURSAL
AS

SELECT YEAR(V.FECHA_HORA) AS ANIO, SUM(UNIDADES) AS UNIDADES
FROM VENTAS V
GROUP BY YEAR(V.FECHA_HORA);
GO

EXEC SP_CONSULTA_VTAS_SUCURSAL;
GO;

DROP PROCEDURE SP_CONSULTA_VTAS_SUCURSAL;
GO;

-- STORED PROCEDURE - SP
ALTER PROCEDURE SP_CONSULTA_VTAS_SUCURSAL
@FECHA_INI DATETIME,
@FECHA_FIN DATETIME
AS
BEGIN
	SELECT
	S.SUCURSAL_NOMBRE,
	SUM(V.UNIDADES) AS UNIDADES_VENDIDAS,
	SUM(UNIDADES * PRECIO) AS USD_VENTA,
	COUNT(*) AS REGISTROS
	FROM SUCURSAL AS S
	INNER JOIN VENTAS V ON S.SUCURSAL_ID = V.SUCURSAL_ID
	WHERE FECHA_HORA BETWEEN @FECHA_INI AND @FECHA_FIN
	GROUP BY S.SUCURSAL_NOMBRE
END
-- LLAMADA AL SP
EXEC SP_CONSULTA_VTAS_SUCURSAL '20160101', '20171231'