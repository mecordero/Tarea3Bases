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
CREATE PROCEDURE ModificarCarrera
	-- Add the parameters for the stored procedure here
	@id_carreraViejo int,
	@id_carreraNuevo int,
	@nombreNuevo nchar(20),
	@encargadoNuevo nchar(30),
	@ubicacionNueva nchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    UPDATE CARRERA
	SET	id_carrera = @id_carreraNuevo,
		nombre = @nombreNuevo,
		encargado = @encargadoNuevo,
		ubicacion = @ubicacionNueva
	WHERE id_carrera = @id_carreraViejo
END
GO
