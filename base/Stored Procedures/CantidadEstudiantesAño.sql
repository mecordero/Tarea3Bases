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
CREATE PROCEDURE CantidadEstudiantesAņo
	-- Add the parameters for the stored procedure here
	@aņo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT count(*) as Cantidad
	FROM CARRERA c
	INNER JOIN ESTUDIANTEXCARRERA ec
	on c.id_carrera = ec.carrera
	INNER JOIN ESTUDIANTE e
	on e.carnet = ec.estudiante
	WHERE YEAR(ec.fecha_ingreso) = @aņo
END
GO
