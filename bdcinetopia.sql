-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 04-08-2016 a las 06:21:04
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `bdcinetopia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignacionasiento`
--

CREATE TABLE IF NOT EXISTS `asignacionasiento` (
  `pkidasignacion` int(11) NOT NULL AUTO_INCREMENT,
  `pkidfactura` int(11) DEFAULT NULL,
  `pkidpelicula` int(11) DEFAULT NULL,
  `pkidsala` int(11) DEFAULT NULL,
  `pkidbutaca` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidasignacion`),
  KEY `RefFactura57` (`pkidfactura`),
  KEY `RefPelicula59` (`pkidpelicula`),
  KEY `RefSala60` (`pkidsala`),
  KEY `RefButaca61` (`pkidbutaca`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `butaca`
--

CREATE TABLE IF NOT EXISTS `butaca` (
  `pkidbutaca` int(11) NOT NULL AUTO_INCREMENT,
  `filabutaca` varchar(10) NOT NULL,
  `columnabutaca` int(11) NOT NULL,
  `pkidsala` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidbutaca`),
  KEY `RefSala20` (`pkidsala`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `pkidcategorias` int(11) NOT NULL AUTO_INCREMENT,
  `nomcategoria` varchar(20) NOT NULL,
  PRIMARY KEY (`pkidcategorias`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cine`
--

CREATE TABLE IF NOT EXISTS `cine` (
  `pkidcine` int(11) NOT NULL AUTO_INCREMENT,
  `nomcine` varchar(20) NOT NULL,
  `direccine` varchar(20) NOT NULL,
  PRIMARY KEY (`pkidcine`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clasificacion`
--

CREATE TABLE IF NOT EXISTS `clasificacion` (
  `pkidclasificacion` int(11) NOT NULL AUTO_INCREMENT,
  `nomclasificacion` varchar(20) NOT NULL,
  `descclasificacion` varchar(100) NOT NULL,
  PRIMARY KEY (`pkidclasificacion`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `clasificacion`
--

INSERT INTO `clasificacion` (`pkidclasificacion`, `nomclasificacion`, `descclasificacion`) VALUES
(1, 'asdf', 'sadf');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clasificacionedad`
--

CREATE TABLE IF NOT EXISTS `clasificacionedad` (
  `pkidedad` int(11) NOT NULL AUTO_INCREMENT,
  `nomedad` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`pkidedad`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `pkidcliente` int(11) NOT NULL AUTO_INCREMENT,
  `dpicliente` decimal(10,0) NOT NULL,
  `nom1cliente` varchar(20) NOT NULL,
  `nom2cliente` varchar(20) NOT NULL,
  `ape1cliente` varchar(20) NOT NULL,
  `ape2cliente` varchar(20) NOT NULL,
  `direccion` varchar(20) NOT NULL,
  `correocliente` varchar(20) NOT NULL,
  `pkidpelicula` int(11) DEFAULT NULL,
  `pkidtarjeta` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidcliente`),
  KEY `RefPelicula11` (`pkidpelicula`),
  KEY `RefTarjeta35` (`pkidtarjeta`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE IF NOT EXISTS `detallefactura` (
  `pkiddetallefact` int(11) NOT NULL AUTO_INCREMENT,
  `pkidfactura` int(11) DEFAULT NULL,
  `pkidtarifas` int(11) DEFAULT NULL,
  `cantidaddetallefact` float(8,0) DEFAULT NULL,
  PRIMARY KEY (`pkiddetallefact`),
  KEY `RefFactura50` (`pkidfactura`),
  KEY `RefTarifa53` (`pkidtarifas`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE IF NOT EXISTS `empleado` (
  `pkidempleado` int(11) NOT NULL AUTO_INCREMENT,
  `nom1empleado` varchar(20) NOT NULL,
  `nom2empleado` varchar(20) NOT NULL,
  `ape1empleado` varchar(20) NOT NULL,
  `ape2empleado` varchar(20) NOT NULL,
  `dirempleado` varchar(20) NOT NULL,
  `dpiempleado` decimal(20,0) NOT NULL,
  `nitempleado` varchar(20) NOT NULL,
  `fechanacempleado` date NOT NULL,
  `pkidcine` int(11) DEFAULT NULL,
  `pkidpuesto` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidempleado`),
  KEY `RefCine1` (`pkidcine`),
  KEY `RefPuesto2` (`pkidpuesto`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`pkidempleado`, `nom1empleado`, `nom2empleado`, `ape1empleado`, `ape2empleado`, `dirempleado`, `dpiempleado`, `nitempleado`, `fechanacempleado`, `pkidcine`, `pkidpuesto`) VALUES
(1, 'juan', 'jose', 'df', 'sdf', 'ffgfgfgff', '2323232', '232321', '2016-08-09', 1, 1),
(2, 'rrer', 'ere', 'wew', 'wewr', 'dfgdfgdfgdf', '34343', '3434', '2016-08-02', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE IF NOT EXISTS `factura` (
  `pkidfactura` int(11) NOT NULL AUTO_INCREMENT,
  `fechafactura` date DEFAULT NULL,
  `pkidformapago` int(11) DEFAULT NULL,
  `pkidcliente` int(11) DEFAULT NULL,
  `pkidempleado` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidfactura`),
  KEY `RefCliente55` (`pkidcliente`),
  KEY `RefEmpleado58` (`pkidempleado`),
  KEY `RefFormaPago30` (`pkidformapago`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `fechascartelera`
--

CREATE TABLE IF NOT EXISTS `fechascartelera` (
  `pkidfcar` int(11) NOT NULL,
  `fechainicar` date DEFAULT NULL,
  `fechafinalcar` date DEFAULT NULL,
  PRIMARY KEY (`pkidfcar`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `formapago`
--

CREATE TABLE IF NOT EXISTS `formapago` (
  `pkidformapago` int(11) NOT NULL AUTO_INCREMENT,
  `nomformapago` varchar(20) NOT NULL,
  `descformapago` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`pkidformapago`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horario`
--

CREATE TABLE IF NOT EXISTS `horario` (
  `pkidhorario` int(11) NOT NULL AUTO_INCREMENT,
  `horainiciohor` time NOT NULL,
  `horafinalhor` time NOT NULL,
  PRIMARY KEY (`pkidhorario`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `horario`
--

INSERT INTO `horario` (`pkidhorario`, `horainiciohor`, `horafinalhor`) VALUES
(1, '12:00:00', '15:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `idioma`
--

CREATE TABLE IF NOT EXISTS `idioma` (
  `pkididioma` int(11) NOT NULL AUTO_INCREMENT,
  `nomidioma` varchar(20) NOT NULL,
  `descidioma` varchar(100) NOT NULL,
  PRIMARY KEY (`pkididioma`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pelicula`
--

CREATE TABLE IF NOT EXISTS `pelicula` (
  `pkidpelicula` int(11) NOT NULL AUTO_INCREMENT,
  `nompelicula` varchar(18) NOT NULL,
  `despelicula` varchar(100) NOT NULL,
  `imagenpelicula` longblob NOT NULL,
  `vinculopelicula` varchar(100) DEFAULT NULL,
  `pkidsala` int(11) DEFAULT NULL,
  `pkididioma` int(11) DEFAULT NULL,
  `pkidproyeccion` int(11) DEFAULT NULL,
  `pkidclasificacion` int(11) DEFAULT NULL,
  `pkidcategorias` int(11) DEFAULT NULL,
  `pkidcine` int(11) DEFAULT NULL,
  `pkidfcar` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidpelicula`),
  KEY `RefCine46` (`pkidcine`),
  KEY `RefFechasCartelera49` (`pkidfcar`),
  KEY `RefSala16` (`pkidsala`),
  KEY `RefIdioma31` (`pkididioma`),
  KEY `RefTipoProyeccione32` (`pkidproyeccion`),
  KEY `RefClasificacione34` (`pkidclasificacion`),
  KEY `RefCategoria38` (`pkidcategorias`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto`
--

CREATE TABLE IF NOT EXISTS `puesto` (
  `pkidpuesto` int(11) NOT NULL AUTO_INCREMENT,
  `nompuesto` varchar(20) NOT NULL,
  `sueldopuesto` decimal(10,0) NOT NULL,
  `descpuesto` varchar(100) NOT NULL,
  PRIMARY KEY (`pkidpuesto`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `role`
--

CREATE TABLE IF NOT EXISTS `role` (
  `pkidrole` int(11) NOT NULL AUTO_INCREMENT,
  `role` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`pkidrole`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `role`
--

INSERT INTO `role` (`pkidrole`, `role`) VALUES
(1, 'administrativo'),
(2, 'operativo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sala`
--

CREATE TABLE IF NOT EXISTS `sala` (
  `pkidsala` int(11) NOT NULL AUTO_INCREMENT,
  `nomsala` varchar(20) NOT NULL,
  `pkidcine` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidsala`),
  KEY `RefCine15` (`pkidcine`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarifa`
--

CREATE TABLE IF NOT EXISTS `tarifa` (
  `pkidtarifas` int(11) NOT NULL AUTO_INCREMENT,
  `pkidproyeccion` int(11) DEFAULT NULL,
  `pkidedad` int(11) DEFAULT NULL,
  `costotarifa` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidtarifas`),
  KEY `RefTipoProyeccione51` (`pkidproyeccion`),
  KEY `RefClasificacionEdade52` (`pkidedad`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarjeta`
--

CREATE TABLE IF NOT EXISTS `tarjeta` (
  `pkidtarjeta` int(11) NOT NULL AUTO_INCREMENT,
  `puntostarjeta` decimal(18,0) NOT NULL,
  PRIMARY KEY (`pkidtarjeta`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefono`
--

CREATE TABLE IF NOT EXISTS `telefono` (
  `pkidtelefono` int(11) NOT NULL AUTO_INCREMENT,
  `teltelefono` decimal(20,0) NOT NULL,
  PRIMARY KEY (`pkidtelefono`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefonocine`
--

CREATE TABLE IF NOT EXISTS `telefonocine` (
  `pkidtelcine` int(11) NOT NULL AUTO_INCREMENT,
  `pkidcine` int(11) DEFAULT NULL,
  `pkidtelefono` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidtelcine`),
  KEY `RefCine39` (`pkidcine`),
  KEY `RefTelefono40` (`pkidtelefono`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefonocliente`
--

CREATE TABLE IF NOT EXISTS `telefonocliente` (
  `pkidtelcliente` int(11) NOT NULL AUTO_INCREMENT,
  `pkidcliente` int(11) DEFAULT NULL,
  `pkidtelefono` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidtelcliente`),
  KEY `RefCliente42` (`pkidcliente`),
  KEY `RefTelefono43` (`pkidtelefono`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefonoempleado`
--

CREATE TABLE IF NOT EXISTS `telefonoempleado` (
  `idtel_emp` int(11) NOT NULL AUTO_INCREMENT,
  `pkidempleado` int(11) DEFAULT NULL,
  `pkidtelefono` int(11) DEFAULT NULL,
  PRIMARY KEY (`idtel_emp`),
  KEY `RefEmpleado41` (`pkidempleado`),
  KEY `RefTelefono44` (`pkidtelefono`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoproyeccion`
--

CREATE TABLE IF NOT EXISTS `tipoproyeccion` (
  `pkidproyeccion` int(11) NOT NULL AUTO_INCREMENT,
  `nomtproyecccion` varchar(20) NOT NULL,
  PRIMARY KEY (`pkidproyeccion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `pkidusuario` int(11) NOT NULL AUTO_INCREMENT,
  `nomusuario` varchar(20) NOT NULL,
  `contusuario` varchar(20) NOT NULL,
  `pkidempleado` int(11) DEFAULT NULL,
  `pkidrole` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidusuario`),
  KEY `RefEmpleado37` (`pkidempleado`),
  KEY `RefRole62` (`pkidrole`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`pkidusuario`, `nomusuario`, `contusuario`, `pkidempleado`, `pkidrole`) VALUES
(5, 'Walter', '123', 2, 2),
(4, 'Rodrigosr', '123', 1, 1),
(6, 'Roberto', '123', 1, 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
