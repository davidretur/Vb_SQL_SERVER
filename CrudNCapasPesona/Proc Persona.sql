CREATE DATABASE VBdb

USE VBdb
GO

CREATE TABLE Persona(
IdPersona INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50),
Pais VARCHAR(50),
Correo VARCHAR(50),
)

IF OBJECT_ID('SP_ListarPersonas') IS NOT NULL
BEGIN
DROP PROC SP_ListarPersonas
END
GO
-- PROC PARA LISTAR LA TABLA PERSONAS
CREATE PROC SP_ListarPersonas
AS
BEGIN
SELECT
idPersona AS Codigo,
Nombre,
Pais,
Correo
FROM Persona
END

--- PROC PARA CONSULTAR UNA PERSONA
	IF OBJECT_ID('SP_ConsultarUnaPersona') IS NOT NULL
BEGIN
DROP PROC SP_ConsultarUnaPersona
END
GO

CREATE PROC SP_ConsultarUnaPersona
@IdPersona INT
AS
BEGIN
SELECT * FROM Persona WHERE IdPersona = @IdPersona
END

-- DEBULVE EL ULTIMO REGISTRO AGRGADO
	IF OBJECT_ID('SP_GetUltCodigoPersonas') IS NOT NULL
BEGIN
DROP PROC SP_GetUltCodigoPersonas
END
GO

CREATE PROC SP_GetUltCodigoPersonas
AS
BEGIN
SELECT 
TOP 1 IdPersona
FROM Persona
ORDER BY IdPersona DESC
END

-- PROC REGISTRAR PERSONA

	IF OBJECT_ID('SP_NuevaPersona') IS NOT NULL
BEGIN
DROP PROC SP_NuevaPersona
END
GO

CREATE PROC SP_NuevaPersona
@Nombre VARCHAR(250),
@Pais VARCHAR(150),
@Correo VARCHAR(150)
AS
BEGIN
INSERT INTO Persona([Nombre],
[Pais],
[Correo])
VALUES (@Nombre, @Pais, @Correo)
END
--- PROC PARA MODIFICAR PERSONAS
	IF OBJECT_ID('SP_ModificarPersona') IS NOT NULL
BEGIN
DROP PROC SP_ModificarPersona
END
GO

CREATE PROC SP_ModificarPersona
@IdPersona INT,
@Nombre VARCHAR(250),
@Pais VARCHAR(150),
@Correo VARCHAR(150)
AS
BEGIN
UPDATE Persona
SET [Nombre] = @Nombre,
[Pais] = @Pais,
[Correo] = @Correo
WHERE  [IdPersona] = @IdPersona
END
GO

--- PROC PARA ELIMINAR PERSONAS
	IF OBJECT_ID('SP_EliminarPersona') IS NOT NULL
BEGIN
DROP PROC SP_EliminarPersona
END
GO

CREATE PROC SP_EliminarPersona
@IdPersona INT
AS
BEGIN
DELETE FROM Persona WHERE IdPersona = @IdPersona
END


--- verificar este

CREATE PROCEDURE [dbo].[SP_ObtenerPersonaPorID]
    @ID INT
AS
BEGIN
    -- Manejo de errores
    BEGIN TRY
        -- Seleccionar los datos de la persona basada en el ID proporcionado
        SELECT 
            ID,
            Nombre,
            Pais,
            Correo
        FROM 
            Personas
        WHERE 
            ID = @ID;
    END TRY
    BEGIN CATCH
        -- Manejo de errores en caso de que ocurra algún problema
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        -- Lanzar el error para que pueda ser manejado por la aplicación cliente
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END
