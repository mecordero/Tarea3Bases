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
CREATE PROCEDURE AgregarEstudianteEnCarrera
	-- Add the parameters for the stored procedure here
	@carnetEstudiante int,
	@id_carrera int,
	@fecha_ingreso date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO ESTUDIANTEXCARRERA (estudiante, carrera, fecha_ingreso)
	VALUES (@carnetEstudiante, @id_carrera, @fecha_ingreso)
END
GO
