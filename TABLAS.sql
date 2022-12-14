CREATE DATABASE CAVH3
USE CAVH3

DROP TABLE GESTION;

CREATE TABLE GESTION
(
ID_GESTION VARCHAR(10)NOT NULL,
DESCRIPCION VARCHAR (20),
FECHA_INICIO DATE ,
FECHA_FIN DATE,
PRIMARY KEY (ID_GESTION)
);

/*+++++++++++++++++++++ N I V E L +++++++++++++++++++++++++++*/
DROP TABLE NIVEL

CREATE TABLE NIVEL 
(
ID_NIVEL VARCHAR (10) NOT NULL,
DESCRIPCION VARCHAR (20),
PRIMARY KEY (ID_NIVEL),
);

SELECT * FROM NIVEL

/*+++++++++++++++++++++ C U R S O +++++++++++++++++++++++++++*/

DROP TABLE CURSO;

CREATE TABLE CURSO
(
ID_CURSO VARCHAR(10) NOT NULL,
NOMBRE VARCHAR (30),
ID_NIVEL VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_CURSO),
FOREIGN KEY (ID_NIVEL) REFERENCES NIVEL (ID_NIVEL)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT * FROM CURSO

/*+++++++++++++++++++++ P A R A L E L O++++++++++++++++++++++++++*/

DROP  TABLE PARALELO

CREATE TABLE PARALELO
(
ID_PARALELO VARCHAR (10) NOT NULL,
DESCRIPCION VARCHAR (30),
CUPOS_LLENOS INT,
CUPO_MAX INT,
ID_CURSO VARCHAR (10) NOT NULL,
GESTION VARCHAR (10) ,
PRIMARY KEY (ID_PARALELO),
FOREIGN KEY (ID_CURSO) REFERENCES CURSO (ID_CURSO)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT * FROM PARALELO

/*+++++++++++++++++++++ M A T E R I A +++++++++++++++++++++++++++*/

DROP TABLE MATERIA;

CREATE TABLE MATERIA
(
ID_MATERIA VARCHAR (10) NOT NULL,
NOMBRE VARCHAR (20),
PRIMARY KEY (ID_MATERIA)
);

SELECT * FROM MATERIA


/*+++++++++++++++++++++ MATERIA_CURSO +++++++++++++++++++++++++++*/

DROP TABLE MATERIA_CURSO

CREATE TABLE MATERIA_CURSO
(
ID_CURSO_MC VARCHAR (10) NOT NULL,
ID_MATERIA_MC VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_CURSO_MC, ID_MATERIA_MC),
FOREIGN KEY (ID_CURSO_MC) REFERENCES CURSO (ID_CURSO)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (ID_MATERIA_MC) REFERENCES MATERIA (ID_MATERIA)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT* FROM MATERIA_CURSO

/*+++++++++++++++++++++ HORARIO +++++++++++++++++++++++++++*/


DROP TABLE HORARIO

CREATE TABLE HORARIO
(
ID_HORARIO VARCHAR (10) NOT NULL,
HORA_INICIO TIME ,
HORA_FIN TIME, 
AULA VARCHAR (30),
CURSO VARCHAR (10) NOT NULL,
PARALELO VARCHAR (10) NOT NULL,
MATERIA VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_HORARIO),
FOREIGN KEY (CURSO, MATERIA) REFERENCES MATERIA_CURSO (ID_CURSO_MC, ID_MATERIA_MC)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
FOREIGN KEY (PARALELO) REFERENCES PARALELO (ID_PARALELO)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
);

SELECT * FROM HORARIO


/*+++++++++++++++++++++ DOCENTE +++++++++++++++++++++++++++*/
DROP TABLE DOCENTE;

CREATE TABLE DOCENTE 
(
ID_DOCENTE VARCHAR (10) NOT NULL,
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
HORAS_TRABAJO INT ,
TELEFONO INT,
DIRECCION VARCHAR (50),
FECHA_NACIMIENTO DATE,
PRIMARY KEY (ID_DOCENTE)
);

SELECT * FROM DOCENTE
/*+++++++++++++++++++++ ESPECIALIDAD +++++++++++++++++++++++++++*/


DROP TABLE ESPECIALIDAD;

CREATE TABLE ESPECIALIDAD
(
ID_ESPECIALIDAD VARCHAR (10) NOT NULL,
DESCRIPCION VARCHAR (40),
PRIMARY KEY (ID_ESPECIALIDAD)
);

SELECT * FROM ESPECIALIDAD

/*+++++++++++++++++++++ DOCENTE_ ESPECIALIDAD +++++++++++++++++++++++++++*/


DROP TABLE DOCENTE_ESPECIALIDAD

CREATE TABLE DOCENTE_ESPECIALIDAD
(
ID_DOCENTE VARCHAR (10) NOT NULL,
ID_ESPECIALIDAD VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_DOCENTE,ID_ESPECIALIDAD),
FOREIGN KEY (ID_DOCENTE) REFERENCES DOCENTE (ID_DOCENTE)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES ESPECIALIDAD (ID_ESPECIALIDAD)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);

SELECT * FROM DOCENTE_ESPECIALIDAD

/*+++++++++++++++++++++ DICTA +++++++++++++++++++++++++++*/

DROP TABLE DICTA

CREATE TABLE DICTA
(
ID_MATERIA VARCHAR (10)NOT NULL,
ID_DOCENTE VARCHAR (10)NOT NULL,
PRIMARY KEY (ID_MATERIA, ID_DOCENTE),
FOREIGN KEY (ID_MATERIA) REFERENCES MATERIA (ID_MATERIA)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
FOREIGN KEY (ID_DOCENTE) REFERENCES DOCENTE (ID_DOCENTE)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);


/*+++++++++++++++++++++ CARGO +++++++++++++++++++++++++++*/

DROP TABLE CARGO;

CREATE TABLE CARGO 
(
ID_CARGO VARCHAR (10)NOT NULL,
DESCRIPCION VARCHAR (30),
PRIORIDAD INT,
PRIMARY KEY (ID_CARGO)
);

SELECT * FROM CARGO
DELETE CARGO

/*+++++++++++++++++++++ EMPLEADO +++++++++++++++++++++++++++*/


DROP TABLE EMPLEADO;

CREATE TABLE EMPLEADO
(
ID_EMPLEADO VARCHAR (10) NOT NULL,
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
TELEFONO INT,
DIRECCION VARCHAR (50),
ESTADO_CIVIL VARCHAR (10),
FECHA_NACIMIENTO DATE,
ID_CARGO VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_EMPLEADO),
FOREIGN KEY (ID_CARGO) REFERENCES CARGO (ID_CARGO)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT * FROM EMPLEADO
/*-----------------------------++++++++++ APODERADO +++++++++++----------------------------*/
DROP TABLE APODERADO

CREATE TABLE APODERADO
(
ID_APODERADO VARCHAR (10)NOT NULL,
CI_APODERADO INT ,
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
OCUPACION VARCHAR (30),
MAYOR_GRADO_INSTRUCCION VARCHAR (30),
PROFESION VARCHAR (30),
EMPRESA_TRABAJO VARCHAR (30),
TELEFONO INT,
PARENTESCO VARCHAR (10),
DIRECCION_DOMICILIO VARCHAR (50),
DIRECCION_OFICINA VARCHAR (50),
PRIMARY KEY (ID_APODERADO)
);	

SELECT * FROM APODERADO

/*-----------------------------++++++++++ LUGAR NACIMIENTO +++++++++++----------------------------*/

DROP TABLE LUGAR_NACIMIENTO;

CREATE TABLE LUGAR_NACIMIENTO
(
ID_LN VARCHAR (10) NOT NULL,
PAIS_NACIMIENTO VARCHAR (20),
DEPARTAMENTO VARCHAR (20),
PROVINCIA_ESTADO VARCHAR (40),
CIUDAD VARCHAR (30),
PRIMARY KEY (ID_LN)
);

SELECT * FROM LUGAR_NACIMIENTO
/*-----------------------------++++++++++ ALUMNO +++++++++++----------------------------*/

DROP TABLE ALUMNO;

CREATE TABLE ALUMNO
(
ID_ALUMNO VARCHAR (10) NOT NULL,
AP_PATERNO VARCHAR (20),
AP_MATERNO VARCHAR (20),
NOMBRE VARCHAR (20),
DIRECCION VARCHAR (50),
SEXO CHAR,
ID_LN VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_ALUMNO),
FOREIGN KEY (ID_LN) REFERENCES LUGAR_NACIMIENTO(ID_LN)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT * FROM ALUMNO
/*-----------------------------++++++++++ ALUMNO - APODERADO +++++++++++----------------------------*/

DROP TABLE ALUMNO_APODERADO

CREATE TABLE ALUMNO_APODERADO
(
ID_ALUMNO VARCHAR (10) NOT NULL,
ID_APODERADO VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_ALUMNO, ID_APODERADO),
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO (ID_ALUMNO)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
FOREIGN KEY (ID_APODERADO) REFERENCES APODERADO (ID_APODERADO)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);

SELECT * FROM ALUMNO_APODERADO

/*-----------------------------++++++++++ CERTIFICADO DE NACIMIENTO +++++++++++----------------------------*/


DROP TABLE CERTIFICADO_NACIMIENTO

CREATE TABLE CERTIFICADO_NACIMIENTO
(
ID_CERTIFICADO VARCHAR (10) NOT NULL,
NRO_FOLIO INT,
NRO_LIBRO INT,
NRO_OFICIALIA INT,
NRO_PARTIDA INT,
FECHA_NACIMIENTO DATE,
ID_ALUMNO VARCHAR (10),
PRIMARY KEY (ID_CERTIFICADO),
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO (ID_ALUMNO)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT * FROM CERTIFICADO_NACIMIENTO

/*-----------------------------++++++++++ INSCRIPCION +++++++++++----------------------------*/

DROP TABLE INSCRIPCION

CREATE TABLE INSCRIPCION
(
ID_INSCRIPCION VARCHAR (10) NOT NULL,
FECHA DATE ,
ID_GESTION VARCHAR (10) NOT NULL,
NOMBRE_ALUMNO VARCHAR(100),
ID_ALUMNO VARCHAR (10)NOT NULL,
ID_PARALELO VARCHAR (10) NOT NULL,
ID_EMPLEADO VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_INSCRIPCION),
FOREIGN KEY (ID_GESTION) REFERENCES GESTION (ID_GESTION)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO (ID_ALUMNO)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (ID_PARALELO) REFERENCES PARALELO (ID_PARALELO)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (ID_EMPLEADO) REFERENCES EMPLEADO (ID_EMPLEADO)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT * FROM INSCRIPCION
SELECT * FROM PARALELO
/*-----------------------------++++++++++ LIBRETA +++++++++++----------------------------*/

DROP TABLE LIBRETA

CREATE TABLE LIBRETA
(
ID_LIBRETA VARCHAR (10) NOT NULL,
A?O INT,
CURSO VARCHAR (10) NOT NULL,
MATERIA VARCHAR (10) NOT NULL,
NOTA_REFORZAMIENTO INT,
NOTA_ANUAL INT,
ID_EMPLEADO VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_LIBRETA,MATERIA),
FOREIGN KEY (ID_EMPLEADO) REFERENCES EMPLEADO (ID_EMPLEADO)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO (ID_ALUMNO)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (CURSO, MATERIA) REFERENCES MATERIA_CURSO (ID_CURSO_MC, ID_MATERIA_MC)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT * FROM LIBRETA

/*-----------------------------++++++++++ NOTA TRIMESTRAL +++++++++++----------------------------*/
DROP TABLE BOLETIN_TRIMESTRAL

CREATE TABLE BOLETIN_TRIMESTRAL
(
ID_TRIMESTRE VARCHAR (10) NOT NULL,
NOMBRE_TRIMESTRE VARCHAR (20),
ID_ALUMNO VARCHAR (10) NOT NULL,
CURSO VARCHAR (10) NOT NULL,
MATERIA VARCHAR (10) NOT NULL,
PUNTAJE_CONOCIMIENTO INT,
PUNTAJE_DPS INT,
PUNTAJE_TRIMESTRE INT,
ID_LIBRETA VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_TRIMESTRE, MATERIA),
FOREIGN KEY (ID_LIBRETA, MATERIA) REFERENCES LIBRETA (ID_LIBRETA, MATERIA)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
FOREIGN KEY (CURSO, MATERIA) REFERENCES MATERIA_CURSO (ID_CURSO_MC, ID_MATERIA_MC)
ON DELETE NO ACTION
ON UPDATE NO ACTION,
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO (ID_ALUMNO)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);

SELECT * FROM BOLETIN_TRIMESTRAL
/*********************++++++++++++++++++ NOTAS +++++++++++++++++**********************/
DROP TABLE NOTAS

CREATE TABLE NOTAS
(
ID_NOTAS VARCHAR (10) NOT NULL,
TIPO VARCHAR (20),
CALIFICACION INT,
FECHA DATE,
MATERIA VARCHAR (10) NOT NULL,
CURSO VARCHAR (10) NOT NULL,
ID_TRIMESTRE VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10) NOT NULL,
PRIMARY KEY (ID_NOTAS),
FOREIGN KEY (CURSO, MATERIA) REFERENCES MATERIA_CURSO (ID_CURSO_MC, ID_MATERIA_MC)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (ID_TRIMESTRE,MATERIA) REFERENCES BOLETIN_TRIMESTRAL (ID_TRIMESTRE, MATERIA)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO (ID_ALUMNO)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);

SELECT * FROM PARALELO
SELECT* FROM NOTAS 
/*********************++++++++++++++++++ RUDE +++++++++++++++++**********************/
DROP TABLE RUDE

CREATE TABLE RUDE
(
COD_RUDE VARCHAR (20) NOT NULL,
NOMBRE_UE VARCHAR (30),
CODIGO_SIE INT,
CODIGO_PROCEDENCIA INT,
DEPENDENCIA_UE VARCHAR (50),
NOMBRE_UE_PROCEDENCIA VARCHAR (50),
ID_ALUMNO VARCHAR (10) NOT NULL,
PRIMARY KEY (COD_RUDE),
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO(ID_ALUMNO)
ON DELETE CASCADE
ON UPDATE CASCADE
);

SELECT * FROM RUDE

/*********************++++++++++++++++++ SEGURO +++++++++++++++++**********************/
 DROP TABLE SEGURO
 
 CREATE TABLE SEGURO
 ( 
ID_SEGURO VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10) NOT NULL,
ESTADO VARCHAR (10),
FECHA DATE ,
ID_GESTION VARCHAR(10),
PRIMARY KEY (ID_SEGURO),
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO (ID_ALUMNO)
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (ID_GESTION) REFERENCES GESTION (ID_GESTION)
ON DELETE CASCADE
ON UPDATE CASCADE
 );
 SELECT * FROM SEGURO
 SELECT * FROM GESTION
 /*********************++++++++++++++++++ FOTOGRAFIA +++++++++++++++++**********************/
DROP TABLE FOTOGRAFIA
CREATE TABLE FOTOGRAFIA
(
ID_FOTO VARCHAR (10) NOT NULL,
ID_ALUMNO VARCHAR (10) NOT NULL,
FOTO IMAGE,
FECHA DATE ,
PRIMARY KEY (ID_FOTO),
FOREIGN KEY (ID_ALUMNO) REFERENCES ALUMNO (ID_ALUMNO)
ON DELETE CASCADE
ON UPDATE CASCADE
);