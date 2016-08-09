-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Aug 08, 2016 at 09:02 PM
-- Server version: 5.5.24-log
-- PHP Version: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bdcinetopia`
--

-- --------------------------------------------------------

--
-- Table structure for table `asignacionasiento`
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
-- Table structure for table `butaca`
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
-- Table structure for table `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `pkidcategorias` int(11) NOT NULL AUTO_INCREMENT,
  `nomcategoria` varchar(20) NOT NULL,
  PRIMARY KEY (`pkidcategorias`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `categoria`
--

INSERT INTO `categoria` (`pkidcategorias`, `nomcategoria`) VALUES
(1, 'Comedia'),
(2, 'Terror'),
(3, 'Ciencia Ficcion'),
(4, 'Infantil');

-- --------------------------------------------------------

--
-- Table structure for table `cine`
--

CREATE TABLE IF NOT EXISTS `cine` (
  `pkidcine` int(11) NOT NULL AUTO_INCREMENT,
  `nomcine` varchar(20) NOT NULL,
  `direccine` varchar(20) NOT NULL,
  PRIMARY KEY (`pkidcine`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `cine`
--

INSERT INTO `cine` (`pkidcine`, `nomcine`, `direccine`) VALUES
(1, 'Cayala', '6ta ave. 30-23'),
(2, 'Miraflores', 'calz, Roosvelt'),
(3, 'Oakland', '6ta ave. 30-23'),
(4, 'Santa Clara', 'calz, Roosvelt');

-- --------------------------------------------------------

--
-- Table structure for table `clasificacion`
--

CREATE TABLE IF NOT EXISTS `clasificacion` (
  `pkidclasificacion` int(11) NOT NULL AUTO_INCREMENT,
  `nomclasificacion` varchar(20) NOT NULL,
  `descclasificacion` varchar(100) NOT NULL,
  PRIMARY KEY (`pkidclasificacion`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `clasificacion`
--

INSERT INTO `clasificacion` (`pkidclasificacion`, `nomclasificacion`, `descclasificacion`) VALUES
(1, 'asdf', 'sadf');

-- --------------------------------------------------------

--
-- Table structure for table `clasificacionedad`
--

CREATE TABLE IF NOT EXISTS `clasificacionedad` (
  `pkidedad` int(11) NOT NULL AUTO_INCREMENT,
  `nomedad` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`pkidedad`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `clasificacionedad`
--

INSERT INTO `clasificacionedad` (`pkidedad`, `nomedad`) VALUES
(1, 'Todo Publi'),
(2, 'PG-13'),
(3, 'Todo Publi'),
(4, 'PG13'),
(5, 'PG15'),
(6, 'PG18');

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
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
-- Table structure for table `detallefactura`
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
-- Table structure for table `empleado`
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
-- Dumping data for table `empleado`
--

INSERT INTO `empleado` (`pkidempleado`, `nom1empleado`, `nom2empleado`, `ape1empleado`, `ape2empleado`, `dirempleado`, `dpiempleado`, `nitempleado`, `fechanacempleado`, `pkidcine`, `pkidpuesto`) VALUES
(1, 'juan', 'jose', 'df', 'sdf', 'ffgfgfgff', '2323232', '232321', '2016-08-09', 1, 1),
(2, 'rrer', 'ere', 'wew', 'wewr', 'dfgdfgdfgdf', '34343', '3434', '2016-08-02', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `factura`
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
-- Table structure for table `fechascartelera`
--

CREATE TABLE IF NOT EXISTS `fechascartelera` (
  `pkidfcar` int(11) NOT NULL,
  `fechainicar` date DEFAULT NULL,
  `fechafinalcar` date DEFAULT NULL,
  PRIMARY KEY (`pkidfcar`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `formapago`
--

CREATE TABLE IF NOT EXISTS `formapago` (
  `pkidformapago` int(11) NOT NULL AUTO_INCREMENT,
  `nomformapago` varchar(20) NOT NULL,
  `descformapago` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`pkidformapago`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `horario`
--

CREATE TABLE IF NOT EXISTS `horario` (
  `pkidhorario` int(11) NOT NULL AUTO_INCREMENT,
  `horainiciohor` time NOT NULL,
  `horafinalhor` time NOT NULL,
  PRIMARY KEY (`pkidhorario`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `horario`
--

INSERT INTO `horario` (`pkidhorario`, `horainiciohor`, `horafinalhor`) VALUES
(1, '12:00:00', '15:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `idioma`
--

CREATE TABLE IF NOT EXISTS `idioma` (
  `pkididioma` int(11) NOT NULL AUTO_INCREMENT,
  `nomidioma` varchar(20) NOT NULL,
  `descidioma` varchar(100) NOT NULL,
  PRIMARY KEY (`pkididioma`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `idioma`
--

INSERT INTO `idioma` (`pkididioma`, `nomidioma`, `descidioma`) VALUES
(1, 'Espanol', 'idioma hablado por latinoamerica'),
(2, 'Ingles', 'Idioma hablado por norteamerica');

-- --------------------------------------------------------

--
-- Table structure for table `pelicula`
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
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `pelicula`
--

INSERT INTO `pelicula` (`pkidpelicula`, `nompelicula`, `despelicula`, `imagenpelicula`, `vinculopelicula`, `pkidsala`, `pkididioma`, `pkidproyeccion`, `pkidclasificacion`, `pkidcategorias`, `pkidcine`, `pkidfcar`) VALUES

-- --------------------------------------------------------

--
-- Table structure for table `puesto`
--

CREATE TABLE IF NOT EXISTS `puesto` (
  `pkidpuesto` int(11) NOT NULL AUTO_INCREMENT,
  `nompuesto` varchar(20) NOT NULL,
  `sueldopuesto` decimal(10,0) NOT NULL,
  `descpuesto` varchar(100) NOT NULL,
  PRIMARY KEY (`pkidpuesto`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `puesto`
--

INSERT INTO `puesto` (`pkidpuesto`, `nompuesto`, `sueldopuesto`, `descpuesto`) VALUES
(1, 'Gerente', '5000', 'encargado de los vendedores'),
(2, 'Cajero', '3000', 'encargado de procesar la venta');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE IF NOT EXISTS `role` (
  `pkidrole` int(11) NOT NULL AUTO_INCREMENT,
  `role` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`pkidrole`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`pkidrole`, `role`) VALUES
(1, 'administrativo'),
(2, 'operativo');

-- --------------------------------------------------------

--
-- Table structure for table `sala`
--

CREATE TABLE IF NOT EXISTS `sala` (
  `pkidsala` int(11) NOT NULL AUTO_INCREMENT,
  `nomsala` varchar(20) NOT NULL,
  `pkidcine` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkidsala`),
  KEY `RefCine15` (`pkidcine`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `sala`
--

INSERT INTO `sala` (`pkidsala`, `nomsala`, `pkidcine`) VALUES
(1, 'a4', 1),
(2, 'a5', 2);

-- --------------------------------------------------------

--
-- Table structure for table `tarifa`
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
-- Table structure for table `tarjeta`
--

CREATE TABLE IF NOT EXISTS `tarjeta` (
  `pkidtarjeta` int(11) NOT NULL AUTO_INCREMENT,
  `puntostarjeta` decimal(18,0) NOT NULL,
  PRIMARY KEY (`pkidtarjeta`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `telefono`
--

CREATE TABLE IF NOT EXISTS `telefono` (
  `pkidtelefono` int(11) NOT NULL AUTO_INCREMENT,
  `teltelefono` decimal(20,0) NOT NULL,
  PRIMARY KEY (`pkidtelefono`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `telefonocine`
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
-- Table structure for table `telefonocliente`
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
-- Table structure for table `telefonoempleado`
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
-- Table structure for table `tipoproyeccion`
--

CREATE TABLE IF NOT EXISTS `tipoproyeccion` (
  `pkidproyeccion` int(11) NOT NULL AUTO_INCREMENT,
  `nomtproyecccion` varchar(20) NOT NULL,
  PRIMARY KEY (`pkidproyeccion`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `tipoproyeccion`
--

INSERT INTO `tipoproyeccion` (`pkidproyeccion`, `nomtproyecccion`) VALUES
(1, '2d Digital'),
(2, '3D'),
(3, 'IMAX'),
(4, '4DX');

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
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
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`pkidusuario`, `nomusuario`, `contusuario`, `pkidempleado`, `pkidrole`) VALUES
(5, 'Walter', '123', 2, 2),
(4, 'Rodrigosr', '123', 1, 1),
(6, 'Roberto', '123', 1, 1),
(8, 'Ana', 'AOUnPZYPHjo=', 1, 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;