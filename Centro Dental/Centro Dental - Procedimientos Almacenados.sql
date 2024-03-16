CREATE PROCEDURE ValidarLogin
    @user VARCHAR(50),
    @pass VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Contrasena VARCHAR(50);
	DECLARE @UsuariO VARCHAR(50);

    SELECT @Contrasena = CONVERT(VARCHAR, DECRYPTBYPASSPHRASE('Password', LTRIM(RTRIM(Contrase�a))))
    FROM Usuarios
    WHERE Usuario = @user;

	SELECT @UsuariO = Usuario from Usuarios Where Usuario = @user

    IF (@Contrasena IS NOT NULL) 
		AND (@Contrasena COLLATE Latin1_General_CS_AS = @pass COLLATE Latin1_General_CS_AS) 
		AND (@UsuariO COLLATE Latin1_General_CS_AS = @user COLLATE Latin1_General_CS_AS)
    BEGIN
		SELECT * FROM Usuarios WHERE Usuario = @user and @Contrasena = @pass;
    END
END
go


















select *, CONVERT(varchar, DECRYPTBYPASSPHRASE('Password', Contrase�a)) as Contrasena from Usuarios

--CAMBIAR CONTRASE�A--
DECLARE @IdUsuario INT;
DECLARE @NuevaContrase�a VARCHAR(255);

-- Asigna el ID del usuario y la nueva contrase�a
SET @IdUsuario = 2; -- Cambia esto al ID del usuario espec�fico
SET @NuevaContrase�a = '15161516'; -- Cambia esto a la nueva contrase�a

-- Desencripta la contrase�a existente
DECLARE @Contrase�aExistente VARCHAR(255);
SELECT @Contrase�aExistente = CONVERT(VARCHAR(255), DECRYPTBYPASSPHRASE('Password', Contrase�a))
FROM Usuarios
WHERE UsuarioID = @IdUsuario;

-- Verifica si la contrase�a existente es correcta
IF @Contrase�aExistente IS NOT NULL
BEGIN
    -- Actualiza la contrase�a con la nueva
    UPDATE Usuarios
    SET Contrase�a = ENCRYPTBYPASSPHRASE('Password', @NuevaContrase�a)
    WHERE UsuarioID = @IdUsuario;

    PRINT 'Contrase�a actualizada correctamente.';
END
ELSE
BEGIN
    PRINT 'No se encontr� el usuario o la contrase�a es incorrecta.';
END;