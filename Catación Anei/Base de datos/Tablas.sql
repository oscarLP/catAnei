CREATE TABLE PERSONA(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
cedula VARCHAR(20) NOT NULL UNIQUE,
nombre VARCHAR(30) NOT NULL,
apellido VARCHAR(40) NOT NULL,
telefono VARCHAR(20),
correo VARCHAR(40),
tipo_persona VARCHAR(15) NOT NULL,
CONSTRAINT ck_tipo_persona CHECK(tipo_persona IN('Usuario', 'Proveedor', 'Productor')))

CREATE TABLE USUARIO(
codigo VARCHAR(7) PRIMARY KEY,
nombre_usuario VARCHAR(30) NOT NULL UNIQUE,
contrasenia VARCHAR(30) NOT NULL,
permiso VARCHAR(2) NOT NULL DEFAULT 'Si',
tipo_usuario VARCHAR(15) NOT NULL DEFAULT 'Catador',
fk_codigo_persona VARCHAR(7) NOT NULL,
CONSTRAINT fk_codPersona1 FOREIGN KEY(fk_codigo_persona) REFERENCES PERSONA(codigo) ON DELETE CASCADE,
CONSTRAINT ck_codTipo_usuario1 CHECK(tipo_usuario IN('Catador', 'Administrador')),
CONSTRAINT ck_permiso CHECK(permiso IN('Si','No')))

CREATE TABLE PAIS(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
nombre VARCHAR(30) NOT NULL UNIQUE)
INSERT INTO PAIS (codigo, nombre) VALUES('1234567', 'Colombia')

CREATE TABLE CIUDAD(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
nombre VARCHAR(30) NOT NULL UNIQUE,
fk_codigo_pais VARCHAR(7) NOT NULL,
CONSTRAINT fk_codPais1 FOREIGN KEY(fk_codigo_pais) REFERENCES PAIS(codigo) ON UPDATE CASCADE)

CREATE TABLE SESION_CATADO(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
fecha_inicio VARCHAR(40) NOT NULL,
hora_inicio VARCHAR(40) NOT NULL,
descripcion VARCHAR(MAX),
fk_codigo_ciudad VARCHAR(7) NOT NULL,
estructura_identificador VARCHAR(9) NOT NULL DEFAULT 'Letra',
protocolo VARCHAR(7) NOT NULL DEFAULT 'Arábica',
numero_muestras NUMERIC(3,0) NOT NULL DEFAULT 1,
fk_codigo_usuario VARCHAR(7) NOT NULL,
estado VARCHAR(10) NOT NULL DEFAULT 'Incompleto',
CONSTRAINT fk_codUsuario1 FOREIGN KEY(fk_codigo_usuario) REFERENCES USUARIO(codigo),
CONSTRAINT fk_codCiudad1 FOREIGN KEY(fk_codigo_ciudad) REFERENCES CIUDAD(codigo),
CONSTRAINT ck_estructura_identificador CHECK(estructura_identificador IN('Letras','Digitos')),
CONSTRAINT ck_protocolo CHECK(protocolo IN('Arábica','Robusta')),
CONSTRAINT ck_estado1 CHECK(estado IN('Completo','Incompleto')),
CONSTRAINT ck_numero_muestras CHECK(numero_muestras > 0 AND numero_muestras <= 100))

CREATE TABLE PROVEEDOR(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
vereda VARCHAR(MAX),
finca VARCHAR(MAX),
fk_codigo_ciudad VARCHAR(7) NOT NULL,
fk_codigo_persona VARCHAR(7) NOT NULL,
CONSTRAINT fk_codCiudad2 FOREIGN KEY(fk_codigo_ciudad) REFERENCES CIUDAD(codigo) ON UPDATE CASCADE,
CONSTRAINT fk_codPersona2 FOREIGN KEY(fk_codigo_persona) REFERENCES PERSONA(codigo) ON DELETE CASCADE)

CREATE TABLE PRODUCTOR(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
vereda VARCHAR(MAX),
finca VARCHAR(MAX),
fk_codigo_ciudad VARCHAR(7) NOT NULL,
fk_codigo_persona VARCHAR(7) NOT NULL,
CONSTRAINT fk_codCiudad3 FOREIGN KEY(fk_codigo_ciudad) REFERENCES CIUDAD(codigo) ON UPDATE CASCADE,
CONSTRAINT fk_codPersona3 FOREIGN KEY(fk_codigo_persona) REFERENCES PERSONA(codigo) ON DELETE CASCADE)

CREATE TABLE MUESTRA(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
valor_identificado VARCHAR(3) NOT NULL,
nombre VARCHAR(30) DEFAULT '',
descripcion VARCHAR(MAX) DEFAULT '',
especie VARCHAR(30) DEFAULT '',
anio_cosecha VARCHAR(30) DEFAULT '',
humedad VARCHAR(3) DEFAULT '',
fk_codigo_sesion VARCHAR(7) NOT NULL,
fk_codigo_ciudad VARCHAR(7) DEFAULT '',
fk_codigo_productor VARCHAR(7) DEFAULT '',
fk_codigo_proveedor VARCHAR(7) DEFAULT '',
CONSTRAINT fk_codSesion_catador1 FOREIGN KEY(fk_codigo_sesion) REFERENCES SESION_CATADO(codigo) ON DELETE CASCADE)

CREATE TABLE PARTICIPACION(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
fk_codigo_usuario VARCHAR(7) NOT NULL,
fk_codigo_muestra VARCHAR(7) NOT NULL,
CONSTRAINT fk_codUsuario2 FOREIGN KEY(fk_codigo_usuario) REFERENCES USUARIO(codigo),
CONSTRAINT fk_codMuestra1 FOREIGN KEY(fk_codigo_muestra) REFERENCES MUESTRA(codigo) ON DELETE CASCADE)

CREATE TABLE ARABICA_ROBUSTA(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
fk_codigo_muestra VARCHAR(7) NOT NULL,
nivel_tueste VARCHAR(1) NOT NULL DEFAULT '3',
puntaje_fragancia_aroma NUMERIC(2,1) NOT NULL DEFAULT 7.5,
puntaje_sabor NUMERIC(2,1) NOT NULL DEFAULT 7.5,
puntaje_sabor_boca NUMERIC(2,1) NOT NULL DEFAULT 7.5,
puntaje_balance NUMERIC(2,1) NOT NULL DEFAULT 7.5,
puntaje_general NUMERIC(2,1) NOT NULL DEFAULT 7.5,
puntaje_uniformidad NUMERIC(2,0) NOT NULL DEFAULT 10,
uniformidad1 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
uniformidad2 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
uniformidad3 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
uniformidad4 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
uniformidad5 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
puntaje_taza_limpia NUMERIC(2,0) NOT NULL DEFAULT 10,
taza_limpia1 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
taza_limpia2 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
taza_limpia3 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
taza_limpia4 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
taza_limpia5 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
numero_defectos NUMERIC(3,0) NOT NULL DEFAULT 0,
nota VARCHAR(MAX) DEFAULT '',
CONSTRAINT fk_codMuestra2 FOREIGN KEY(fk_codigo_muestra) REFERENCES MUESTRA(codigo) ON DELETE CASCADE)

CREATE TABLE ARABICA(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
fk_codigo_muestra VARCHAR(7) NOT NULL,
calificacion NUMERIC(3,1) NOT NULL DEFAULT 82.5,
puntaje_acidez NUMERIC(2,1) NOT NULL DEFAULT 7.5,
puntaje_cuerpo NUMERIC(2,1) NOT NULL DEFAULT 7.5,
puntaje_dulzor NUMERIC(2,0) NOT NULL DEFAULT 7.5,
dulzor1 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
dulzor2 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
dulzor3 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
dulzor4 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
dulzor5 VARCHAR(9) NOT NULL DEFAULT 'Verdadero',
CONSTRAINT fk_codMuestra3 FOREIGN KEY(fk_codigo_muestra) REFERENCES MUESTRA(codigo) ON DELETE CASCADE)

CREATE TABLE ROBUSTA(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
fk_codigo_muestra VARCHAR(7) NOT NULL,
calificacion NUMERIC(3,1) NOT NULL DEFAULT 82.5,
sabor_boca NUMERIC(1,0),
puntaje_sal_acido NUMERIC(2,1) NOT NULL DEFAULT 7.5,
baja_salinidad VARCHAR(1),
alta_acidez VARCHAR(1),
puntaje_amargo_dulce NUMERIC(2,1) NOT NULL DEFAULT 7.5,
bajo_amargor VARCHAR(1),
alto_dulzor VARCHAR(1),
puntaje_sensacion_boca NUMERIC(2,1) NOT NULL DEFAULT 7.5,
sensacion_boca VARCHAR(1),
CONSTRAINT fk_codMuestra4 FOREIGN KEY(fk_codigo_muestra) REFERENCES MUESTRA(codigo) ON DELETE CASCADE)

CREATE TABLE DESCRIPTORES(
codigo VARCHAR(7) NOT NULL PRIMARY KEY,
fk_codigo_muestra VARCHAR(7) NOT NULL,
evaluacion VARCHAR(30) NOT NULL,
nombre_descriptor VARCHAR(MAX) NOT NULL,
CONSTRAINT fk_codMuestra5 FOREIGN KEY(fk_codigo_muestra) REFERENCES MUESTRA(codigo) ON DELETE CASCADE)