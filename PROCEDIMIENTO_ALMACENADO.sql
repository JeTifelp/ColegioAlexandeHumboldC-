-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in

_______________________________________________

create proc VerificarCupo @Sigla VARCHAR (10),@NroCupo int output
as
   declare @CantIns int
   declare @CupoMAX int
begin 
    select @CantIns = (Select CUPOS_LLENOS  from PARALELO where ID_PARALELO =@Sigla)
    select @CupoMAX= (Select CUPO_MAX from PARALELO where ID_PARALELO =@Sigla)
    
    set @NroCupo=@CupoMAX -@CantIns
end

declare @Numero_Cupos int
exec VerificarCupo '1PRIM-A' ,@Numero_Cupos output
select @Numero_Cupos as Cupos_Disponibles

select * from PARALELO
_________________________________________________

/*** DEVUELVE EL PROMEDIO  DE UN ALUMNO ***/
SELECT* FROM BOLETIN_TRIMESTRAL
SELECT* FROM NOTAS

SELECT  AVG (CALIFICACION)
FROM NOTAS N
WHERE N.ID_ALUMNO='AL001' AND N.CURSO='1PRIM' AND N.ID_TRIMESTRE= 'TRI01' AND N.MATERIA='MAT'


SELECT * FROM BOLETIN_TRIMESTRAL
--______________________________________

create proc PROMEDIO @COD_ALUMNO VARCHAR(10), @COD_CURSO VARCHAR(10),
		 @COD_TRIMESTRE VARCHAR (10),@COD_MATERIA VARCHAR(10),
		 @CONOCIMIENTO INT OUTPUT 
AS 
	SELECT @CONOCIMIENTO= AVG(N.CALIFICACION )
	FROM NOTAS N
	WHERE @COD_ALUMNO= N.ID_ALUMNO AND @COD_CURSO= N.CURSO 
	AND @COD_TRIMESTRE= N.ID_TRIMESTRE AND @COD_MATERIA= N.MATERIA
	
	PRINT @CONOCIMIENTO
