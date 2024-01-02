


create database songsystem
use songsystem

----------------------------------------------------------------------------------------------
--*********************************Tabla Cantantes *****************************************--

create table singers (
id int not null identity(1,1) primary key,
nombre varchar(40),
apellido varchar(40),
singerCode int not null unique check (singerCode >= 1000 and singerCode <= 9999),
texituraVocal varchar(50),
edad int check (edad >= 15 and edad <= 120)
);


select id, nombre, apellido, singerCode,texituraVocal,edad from singers
	where id = 1



ALTER TABLE singers
ADD protegida BIT;

UPDATE singers
SET protegida = 1
WHERE id = 1

select singerCode from singers

SELECT singerCode FROM singers
ORDER BY NULL;

SELECT singerCode, id FROM singers
ORDER BY id;
select * from singers
drop table singers

select id from singers
Order by id


--******************************************************************************************--


----------------------------------------------------------------------------------------------
--*********************************Tabla Baul de cansiones *********************************--


--Solo es posible insertar una canción por cada cantante ya existente                                
CREATE TABLE songsTrunk (
    id int not null identity(1,1) primary key,
    nameSong varchar(200),
    musicalScale varchar(5),
    idSingers int, -- ID del usuario que insertó la canción
    CONSTRAINT FK_songsTrunk_insertedBy FOREIGN KEY (idSingers)
    REFERENCES singers (id)
);
drop table songsTrunk

INSERT INTO songsTrunk (nameSong, musicalScale, idSingers)
VALUES ('Canción de ejemplo', 'Do', 5);

select * from songsTrunk


-----------------------------------------------------------------------------------------------
--******************Baul de propuestas a ensayar*****************--

CREATE TABLE proposals(
    id int not null identity(1,1) primary key,
    nameSong varchar(200) not null,
    musicalScale varchar(5),
    idSingers int not null, -- ID del usuario que insertó la canción
	stateProposals BIT DEFAULT 0,
    CONSTRAINT FK_idSingers FOREIGN KEY (idSingers)
    REFERENCES singers (id) 
);
drop table proposals
select * from proposals
--***************************************************************************************--

--**************************************************************************************--
--Trigger inserta en auntomatico a la tabla songTrunk los datos donde stateProposals = 1--

go
CREATE TRIGGER trg_UpdateSongTrunk
ON proposals
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si el campo stateSingers fue actualizado a 1
    IF UPDATE(stateProposals)
    BEGIN
        -- Insertar la canción en la tabla songTrunk
        INSERT INTO songsTrunk (nameSong, musicalScale, idSingers)
        SELECT nameSong, musicalScale, idSingers
        FROM inserted
        WHERE stateProposals = 1;

        -- Eliminar la canción de la tabla proposals
        DELETE FROM proposals
        WHERE id IN (SELECT id FROM deleted WHERE stateProposals = 1);
    END
END;

delete from proposals 
where stateProposals = 1;


------------------------------------------------------------------------------------------



--12; 70
-------------------------------------------------------------------------------------------
--*************Dispara el trigger cuando se actualiza stateProposals*********************--


insert into proposals values ('Abre Mis Ojos o Cristo','F',4,0)




SELECT DISTINCT texituraVocal
FROM singers;

select DISTINCT musicalScale
from songsTrunk

SELECT Distinct musicalScale FROM SongsTrunk
UNION 
SELECT distinct musicalScale FROM Proposals;


------------------------------------------------------------------------------------------
--Select de las propuestas de las canciones
SELECT 
    p.id,
    p.nameSong,
    p.musicalScale,
    s.nombre AS singerName,
    p.stateProposals
FROM proposals AS p
INNER JOIN singers AS s ON p.idSingers = s.id;

SELECT 
    p.id,
    p.nameSong,
    p.musicalScale,
    s.nombre AS singerName,
    s.texituraVocal
FROM proposals AS p
INNER JOIN singers AS s ON p.idSingers = s.id;

--------------------------------------------------------------------------------------=---




--***********************************Delete Sing*******************************************--

DELETE FROM songsTrunk WHERE idSingers IN (SELECT id FROM singers WHERE id = 6);
DELETE FROM singers WHERE id = 6;
--*****************************************************************************************--



---------------------------------------------------------------------------------------------
--***********************************Agregar Singer****************************************--
select * from singers



--*****************************************************************************************--



----------------------------------------------------------------------------------------------
--*******************************Todos los cantantes****************************************--

select id,nombre, apellido, texituraVocal from singers


select nombre from singers
--*****************************************************************************************--





-------------------------------------------------------------------


-------------------------------------------------------------------
--******************Buscar por texitura vocal**********************--

CREATE PROCEDURE BuscarPorTexitura
    @nombreBusqueda NVARCHAR(200)
AS
BEGIN
SELECT st.id, st.nameSong, st.musicalScale, s.nombre AS singerName, s.texituraVocal
FROM songsTrunk st
INNER JOIN singers s ON st.idSingers = s.id
    WHERE s.texituraVocal LIKE '%' + @nombreBusqueda + '%';
END;

EXEC BuscarPorTexitura @nombreBusqueda = 'Baritono';



-------------------------------------------------------------------

--Slecciona los cantantes con sus nombres y notas musicales--
SELECT st.id, st.nameSong, st.musicalScale, s.nombre AS singerName
FROM songsTrunk st
INNER JOIN singers s ON st.idSingers = s.id


SELECT st.id, st.nameSong, st.musicalScale, s.nombre AS singerName, s.texituraVocal
FROM songsTrunk st
INNER JOIN singers s ON st.idSingers = s.id;

-------------------------------------------------------------------
--******************Buscar canciones ****************************--


CREATE PROCEDURE BuscarPropuestasPorNombres
    @nombreBusqueda NVARCHAR(200)
AS
BEGIN
SELECT st.id, st.nameSong, st.musicalScale, s.nombre AS singerName, s.texituraVocal
FROM songsTrunk st
INNER JOIN singers s ON st.idSingers = s.id
    WHERE nameSong LIKE '%' + @nombreBusqueda + '%';
END;

EXEC BuscarPropuestasPorNombres @nombreBusqueda = 'z';
drop PROCEDURE BuscarPropuestasPorNombres



SELECT st.id, st.nameSong, st.musicalScale, s.nombre AS singerName, s.texituraVocal
FROM songsTrunk st
INNER JOIN singers s ON st.idSingers = s.id
    WHERE nombre LIKE '%' + 'Maycool' + '%';
-------------------------------------------------------------------




-------------------------------------------------------------------
--******************Buscar por nombre*********************--

CREATE PROCEDURE BuscarPorNombreUsuario
    @nombreBusqueda NVARCHAR(200)
AS
BEGIN
SELECT st.id, st.nameSong, st.musicalScale, s.nombre AS singerName, s.texituraVocal
FROM songsTrunk st
INNER JOIN singers s ON st.idSingers = s.id
    WHERE nombre LIKE '%' + @nombreBusqueda + '%';
END;

EXEC BuscarPorNombreUsuario @nombreBusqueda = 'Maycool';

-------------------------------------------------------------------
-------------------------------------------------------------------
--******************Buscar por nota musical**********************--


CREATE PROCEDURE BuscarPorNombreEscala
    @nombreBusqueda NVARCHAR(200)
AS
BEGIN
SELECT st.id, st.nameSong, st.musicalScale, s.nombre AS singerName, s.texituraVocal
FROM songsTrunk st
INNER JOIN singers s ON st.idSingers = s.id
    WHERE musicalScale LIKE '%' + @nombreBusqueda + '%';
END;

EXEC BuscarPorNombreEscala @nombreBusqueda = 'F#';


-------------------------------------------------------------------







--Los usuarios solamente podran ver e insertar propuestas de 
--canciones y cada vez que se inserte una propuesta el usuario principal es quien decide si
--esa cancion se agrega al baúl de canciones


--*******************************************************************************************************************************--
--***************** Buscar en la tabla proposals ********************************************************************************
CREATE PROCEDURE BuscarPropuestas
    @nombreBusqueda NVARCHAR(200)
AS
BEGIN
    SELECT 
        p.id,
        p.nameSong,
        p.musicalScale,
        s.nombre AS singerName,
        s.texituraVocal
    FROM proposals p
    INNER JOIN singers s ON p.idSingers = s.id
    WHERE p.nameSong LIKE '%' + @nombreBusqueda + '%';
END;

EXEC BuscarPropuestas @nombreBusqueda = 'x';

--*******************************************************************************************************************************--





--***************** Buscar en la tabla proposals por nombre ************************************************************************--
CREATE PROCEDURE BuscarPorNombre
    @nombreCantante NVARCHAR(200)
AS
BEGIN
    SELECT 
        p.id,
        p.nameSong,
        p.musicalScale,
        s.nombre AS singerName,
        s.texituraVocal
    FROM proposals p
    INNER JOIN singers s ON p.idSingers = s.id
    WHERE s.nombre LIKE '%' + @nombreCantante + '%';
END;

EXEC BuscarPorNombre @nombreCantante = 'Josias';

select * from proposals 

--**********************************************************************************************************************************--
--***************** Buscar en la tabla proposals por escalas ************************************************************************--

CREATE PROCEDURE BuscarPropuestasPorEscala
    @escalaBusqueda VARCHAR(5)
AS
BEGIN
    SELECT 
        id,
        nameSong,
        musicalScale,
        idSingers
    FROM proposals
    WHERE musicalScale = @escalaBusqueda;
END;

EXEC BuscarPropuestasPorEscala @escalaBusqueda = '  F#m';




CREATE PROCEDURE BuscarPorEscala
    @escalaMusical NVARCHAR(200)
AS
BEGIN
    SELECT 
        p.id,
        p.nameSong,
        p.musicalScale,
        s.nombre AS singerName,
        s.texituraVocal
    FROM proposals p
    INNER JOIN singers s ON p.idSingers = s.id
    WHERE p.musicalScale LIKE '%' + @escalaMusical + '%';
END;

EXEC BuscarPorEscala @escalaMusical = '  F#m';

--**********************************************************************************************************************************--
--********** Buscar por nombre *****************************************************************************************************--
CREATE PROCEDURE BuscarPropuestaPorNombre
    @nombreBusqueda NVARCHAR(200)
AS
BEGIN
    SELECT 
        p.id,
        p.nameSong,
        p.musicalScale,
        s.nombre AS singerName,
        s.texituraVocal
    FROM proposals AS p
    INNER JOIN singers s ON p.idSingers = s.id
    WHERE nombre LIKE '%' + @nombreBusqueda + '%';
END;

drop procedure BuscarPropuestaPorNombre @nombreBusqueda = 'Josias';

EXEC BuscarPropuestaPorNombre @nombreBusqueda = 'J';

select * from proposals
select * from singers

--****************************************************************************************--
--**************** Buscar por Texitura en la tabla proposals *****************************--
CREATE PROCEDURE BuscarPropuestasPorTexturaVocal
    @texituraBusqueda NVARCHAR(50)
AS
BEGIN
    SELECT 
        p.id,
        p.nameSong,
        p.musicalScale,
        s.nombre AS singerName,
        s.texituraVocal
    FROM proposals AS p
    INNER JOIN singers AS s ON p.idSingers = s.id
    WHERE s.texituraVocal LIKE '%' + @texituraBusqueda + '%';
END;

drop procedure BuscarPropuestasPorTexturaVocal

EXEC BuscarPropuestasPorTexturaVocal @texituraBusqueda = 'Baritono';


--*****************************************************************************************************--
--******************* Update para marcar propuestas como ensayadas ************************************--


UPDATE proposals
SET stateProposals = 1
WHERE id = 50;



select* from proposals

select * from songsTrunk

select * from singers
--*****************************************************************************************************--

--****************************** Editar Propuesta *****************************************************--

CREATE PROCEDURE EditarCancion
    @id INT,
    @nameSong VARCHAR(200),
    @musicalScale VARCHAR(5)
AS
BEGIN
    UPDATE proposals
    SET nameSong = @nameSong,
        musicalScale = @musicalScale
    WHERE id = @id;
END;

EXEC EditarCancion @id = 50, @nameSong = 'Rey Por Siempre', @musicalScale = 'F#m'
EXEC EditarCancion @id = 51, @nameSong = '"+cancion+"', @musicalScale = '"+nota+"'


select * from proposals

--*******************************************************************************************************--


create procedure actualizarCantante
	@id int,
	@nombreA varchar (100),
	@apellidoA varchar(100),
	@singerCodeA int,
	@texituraVocalA varchar(100),
	@edadA int
AS
begin
	UPDATE singers
	SET nombre = @nombreA,
		apellido = @apellidoA,
		singerCode = @singerCodeA,
		texituraVocal = @texituraVocalA,
		edad = @edadA
	WHERE id = @id;
end;

Update singers
	set singerCode = 1920
	where id =7;
	
exec actualizarCantante @id = 7,@nombreA = 'Nombre',@apellidoA = 'Hernandez', @singerCodeA = 1234, @texituraVocalA = 'Bajo', @edadA = 25; 

insert into singers values ('Nombre','Galv',1234,'soprano',18,0)

insert into proposals values('','',4,0)
insert into proposals values('"+cancion+"','Em',1,0)
select * from proposals

delete singers 
where id = 5;

select nombre, apellido, singerCode, texituraVocal, edad from singers
	where id = 3

select nombre from singers
--------------------------------------------------------------------------------------------------

CREATE PROCEDURE ObtenerIdPorClave
    @singerCode INT,
    @id INT OUTPUT
AS
BEGIN
    SELECT @id = id
    FROM singers
    WHERE singerCode = @singerCode;
END;

DECLARE @singerCodeInput INT = 1924;
DECLARE @resultId INT;

EXEC ObtenerIdPorClave @singerCode = @singerCodeInput, @id = @resultId OUTPUT;

SELECT @resultId AS Resultado;

