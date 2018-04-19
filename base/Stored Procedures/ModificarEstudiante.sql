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
CREATE PROCEDURE ModificarEstudiante
	-- Add the parameters for the stored procedure here
	@carnetViejo int, 
	@carnetNuevo int, 
	@cedulaNueva int, 
	@nombreNuevo nchar(30)
	--foto
	--videoCV
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE ESTUDIANTE
	SET carnet = @carnetNuevo,
		cedula = @cedulaNueva, 
		nombre = @nombreNuevo
	WHERE carnet = @carnetViejo
END
GO
