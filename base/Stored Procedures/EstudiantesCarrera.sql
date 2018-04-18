-- ==========================================================
-- Create Stored Procedure Template for Windows Azure SQL Database
-- ==========================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE EstudiantesCarrera
	-- Add the parameters for the stored procedure here
	@carrera nchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT e.carnet, e.cedula, e.nombre, e.foto, e.videoCV
	FROM ESTUDIANTE e
	INNER JOIN ESTUDIANTEXCARRERA ec
	ON e.carnet = ec.estudiante
	INNER JOIN CARRERA c
	ON c.id_carrera = ec.carrera
	WHERE c.nombre = @carrera
END
GO
