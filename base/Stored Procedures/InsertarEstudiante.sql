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
CREATE PROCEDURE InsertarEstudiante 
	-- Add the parameters for the stored procedure here
	@carnet int,
	@cedula int,
	@nombre nchar(30)
	--foto
	--video
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO ESTUDIANTE (carnet, cedula, nombre)
	VALUES (@carnet, @cedula, @nombre)
END
GO
