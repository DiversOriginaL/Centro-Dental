CREATE PROCEDURE ValidarLogin
    @user VARCHAR(50),
    @pass VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Contrasena VARCHAR(50);
	DECLARE @UsuariO VARCHAR(50);

    SELECT @Contrasena = CONVERT(VARCHAR, DECRYPTBYPASSPHRASE('Password', LTRIM(RTRIM(Contraseña))))
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


















select *, CONVERT(varchar, DECRYPTBYPASSPHRASE('Password', Contraseña)) as Contrasena from Usuarios

--CAMBIAR CONTRASEÑA--
DECLARE @IdUsuario INT;
DECLARE @NuevaContraseña VARCHAR(255);

-- Asigna el ID del usuario y la nueva contraseña
SET @IdUsuario = 2; -- Cambia esto al ID del usuario específico
SET @NuevaContraseña = '15161516'; -- Cambia esto a la nueva contraseña

-- Desencripta la contraseña existente
DECLARE @ContraseñaExistente VARCHAR(255);
SELECT @ContraseñaExistente = CONVERT(VARCHAR(255), DECRYPTBYPASSPHRASE('Password', Contraseña))
FROM Usuarios
WHERE UsuarioID = @IdUsuario;

-- Verifica si la contraseña existente es correcta
IF @ContraseñaExistente IS NOT NULL
BEGIN
    -- Actualiza la contraseña con la nueva
    UPDATE Usuarios
    SET Contraseña = ENCRYPTBYPASSPHRASE('Password', @NuevaContraseña)
    WHERE UsuarioID = @IdUsuario;

    PRINT 'Contraseña actualizada correctamente.';
END
ELSE
BEGIN
    PRINT 'No se encontró el usuario o la contraseña es incorrecta.';
END;