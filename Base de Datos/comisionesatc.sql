DROP DATABASE IF EXISTS comisionesatc;
CREATE DATABASE comisionesatc;
USE comisionesatc;

-- 
CREATE TABLE fuerza_venta
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	fuerza VARCHAR(100) NOT NULL,
    lada VARCHAR(5) NOT NULL,
    activo BOOL NOT NULL
);

INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('ABAMCQ001','429',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('ACAMCQ001','417',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('APAMCQ001','413',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('CELMCQ001','461',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('COMMCQ001','412',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('CORMCQ001','411',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('CVRMCQ001','478',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('DOLMCQ001','418',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('GTOMCQ001','473',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('IRAMCQ001','462',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('JCUMCQ001','421',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('LDMMCQ001','474',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('MORMCQ001','445',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('PAZMCQ001','468',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('RROMCQ001','465',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('SALMCQ001','464',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('SILMCQ001','472',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('SJCMCQ001','438',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('SJIMCQ001','419',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('SJRMCQ001','427',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('SLVMCQ001','466',true);
INSERT INTO fuerza_venta(fuerza,lada,activo)VALUES('VALMCQ001','456',true);


CREATE TABLE producto
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(200) NOT NULL,
	activo BOOL NOT NULL
);

INSERT INTO producto(nombre,activo)VALUES('CHIP EXPRESS 29',true);
INSERT INTO producto(nombre,activo)VALUES('CHIP X SEGUNDO',true);
INSERT INTO producto(nombre,activo)VALUES('COMISIONES DE VOLUMEN',true);
CREATE TABLE periodo
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	clave VARCHAR(10) NOT NULL,
    anio VARCHAR(10) NOT NULL,
	producto_id INT UNSIGNED NOT NULL REFERENCES producto.id ON UPDATE CASCADE
);

CREATE TABLE comisionesSemanales
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	lada VARCHAR(10) NOT NULL,
    telefono VARCHAR(10) NOT NULL,
    fuerza VARCHAR(20) NOT NULL,
    montoA DOUBLE NOT NULL,
    montoB DOUBLE NOT NULL,
    montoC DOUBLE NOT NULL,
    comision DOUBLE NOT NULL,
    tipo VARCHAR(20) NOT NULL,
    numero_id INT NOT NULL,
    puntoventa VARCHAR(20) NOT NULL,
    cliente VARCHAR(20) NOT NULL,
    periodo_id INT UNSIGNED NOT NULL REFERENCES periodo.id ON UPDATE CASCADE
);

CREATE TABLE tipo_pago
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	descripcion VARCHAR(50) NOT NULL,
    activo BOOL
);

INSERT INTO tipo_pago(descripcion,activo)VALUES('EFECTIVO',true);
INSERT INTO tipo_pago(descripcion,activo)VALUES('NOTA CR',true);

CREATE TABLE volumenVenta
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	lada VARCHAR(10) NOT NULL,
    telefono VARCHAR(10) NOT NULL,
    comision DOUBLE NOT NULL,
    tipopago VARCHAR(30) NOT NULL,
    numero_id INT UNSIGNED NOT NULL,
    puntoventa VARCHAR(20) NOT NULL,
    cliente VARCHAR(20) NOT NULL,
    recargaatc DOUBLE NOT NULL,
    utilidad DOUBLE NOT NULL,
    periodo_id INT UNSIGNED NOT NULL REFERENCES periodo.id ON UPDATE CASCADE
);

CREATE TABLE permiso
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	tipo VARCHAR(50) NOT NULL
);
INSERT INTO permiso(tipo)VALUES('NORMAL');
INSERT INTO permiso(tipo)VALUES('ADMINISTRADOR');
INSERT INTO permiso(tipo)VALUES('SUPER ADMINISTRADOR');

CREATE TABLE usuario
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(200) NOT NULL,
    activo BOOL NOT NULL
);

INSERT INTO usuario(nombre,activo)VALUES('Sistemas',true);
INSERT INTO usuario(nombre,activo)VALUES('David Samano Ferreira',true);

CREATE TABLE permiso_usuario
(	id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nickname VARCHAR(200) NOT NULL,
    pass VARCHAR(200) NOT NULL,
    usuario_id INT UNSIGNED NOT NULL REFERENCES usuario.id ON UPDATE CASCADE,
    permiso_id INT UNSIGNED NOT NULL REFERENCES permiso.id ON UPDATE CASCADE
);
INSERT INTO permiso_usuario(nickname,pass,usuario_id,permiso_id)VALUES('Sistemas','fru0ljjXxDC3pogal8pC3u0eOMTfXUjnhqGHuDThErw=',1,3);
INSERT INTO permiso_usuario(nickname,pass,usuario_id,permiso_id)VALUES('davidsf','aGHZRJC8LwYZcE7nLZm/OeWR+4WsCxPifLtE18pvcXo=',2,3);