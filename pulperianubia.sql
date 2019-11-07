/*
 Navicat Premium Data Transfer

 Source Server         : web
 Source Server Type    : MySQL
 Source Server Version : 100137
 Source Host           : localhost:3306
 Source Schema         : pulperianubia

 Target Server Type    : MySQL
 Target Server Version : 100137
 File Encoding         : 65001

 Date: 07/11/2019 10:37:55
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for clientes_correo
-- ----------------------------
DROP TABLE IF EXISTS `clientes_correo`;
CREATE TABLE `clientes_correo`  (
  `codigo_correo` int(11) NOT NULL,
  `cedula` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`codigo_correo`, `cedula`) USING BTREE,
  INDEX `fkclientes`(`cedula`) USING BTREE,
  CONSTRAINT `fkclientes` FOREIGN KEY (`cedula`) REFERENCES `clientes_credito` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fkcorreos` FOREIGN KEY (`codigo_correo`) REFERENCES `correos` (`codigo_correo`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of clientes_correo
-- ----------------------------
INSERT INTO `clientes_correo` VALUES (35, '161-261198-0001W');

-- ----------------------------
-- Table structure for clientes_credito
-- ----------------------------
DROP TABLE IF EXISTS `clientes_credito`;
CREATE TABLE `clientes_credito`  (
  `cedula` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '',
  `nombre` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `apellido` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `direccion` longtext CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL,
  PRIMARY KEY (`cedula`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of clientes_credito
-- ----------------------------
INSERT INTO `clientes_credito` VALUES ('161-261198-0001W', 'Holvert', 'Josue', 'km 157 c norte, 300 m oeste, esteli');

-- ----------------------------
-- Table structure for clientes_credito_telefono
-- ----------------------------
DROP TABLE IF EXISTS `clientes_credito_telefono`;
CREATE TABLE `clientes_credito_telefono`  (
  `cedula` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `codigo_telefono` int(11) NOT NULL,
  PRIMARY KEY (`cedula`, `codigo_telefono`) USING BTREE,
  INDEX `fktelefonoclientes`(`codigo_telefono`) USING BTREE,
  CONSTRAINT `fkclientestelefono` FOREIGN KEY (`cedula`) REFERENCES `clientes_credito` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fktelefonoclientes` FOREIGN KEY (`codigo_telefono`) REFERENCES `telefonos` (`codigo_telefono`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of clientes_credito_telefono
-- ----------------------------
INSERT INTO `clientes_credito_telefono` VALUES ('161-261198-0001W', 55605);

-- ----------------------------
-- Table structure for compra
-- ----------------------------
DROP TABLE IF EXISTS `compra`;
CREATE TABLE `compra`  (
  `codigo_compra` int(11) NOT NULL AUTO_INCREMENT,
  `costo_total` int(11) NULL DEFAULT NULL,
  `ruc` varchar(11) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `fecha_compra` datetime(0) NULL DEFAULT NULL,
  `ID_Usuario` int(11) NULL DEFAULT NULL,
  `fecha_pago` date NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_compra`) USING BTREE,
  INDEX `fkcompra`(`ruc`) USING BTREE,
  CONSTRAINT `fkcompra` FOREIGN KEY (`ruc`) REFERENCES `proveedores` (`ruc`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of compra
-- ----------------------------
INSERT INTO `compra` VALUES (1, 1200, 'egw5rtj6kyu', '2019-11-03 12:24:48', NULL, '2019-11-18');
INSERT INTO `compra` VALUES (2, 90, 'egw5rtj6kyu', '2019-11-03 12:26:24', NULL, '2019-11-18');

-- ----------------------------
-- Table structure for compras_tipo
-- ----------------------------
DROP TABLE IF EXISTS `compras_tipo`;
CREATE TABLE `compras_tipo`  (
  `codigo_tipocompra` int(11) NOT NULL,
  `codigo_compra` int(11) NOT NULL,
  PRIMARY KEY (`codigo_tipocompra`, `codigo_compra`) USING BTREE,
  INDEX `fkcomprastipo`(`codigo_compra`) USING BTREE,
  CONSTRAINT `fkcomprastipo` FOREIGN KEY (`codigo_compra`) REFERENCES `compra` (`codigo_compra`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fktipocompras` FOREIGN KEY (`codigo_tipocompra`) REFERENCES `tipo_compra` (`codigo_tipocompra`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of compras_tipo
-- ----------------------------
INSERT INTO `compras_tipo` VALUES (2, 1);
INSERT INTO `compras_tipo` VALUES (2, 2);

-- ----------------------------
-- Table structure for correos
-- ----------------------------
DROP TABLE IF EXISTS `correos`;
CREATE TABLE `correos`  (
  `codigo_correo` int(11) NOT NULL AUTO_INCREMENT,
  `direccion_correo` longtext CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`codigo_correo`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 36 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of correos
-- ----------------------------
INSERT INTO `correos` VALUES (32, 'No tiene');
INSERT INTO `correos` VALUES (33, 'dvfghfjgkhljñl');
INSERT INTO `correos` VALUES (34, 'No tiene');
INSERT INTO `correos` VALUES (35, 'pereshol13@gmail.com');

-- ----------------------------
-- Table structure for descuentos
-- ----------------------------
DROP TABLE IF EXISTS `descuentos`;
CREATE TABLE `descuentos`  (
  `id_desc` int(11) NOT NULL AUTO_INCREMENT,
  `porcenjate` decimal(2, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`id_desc`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of descuentos
-- ----------------------------
INSERT INTO `descuentos` VALUES (1, 0.10);
INSERT INTO `descuentos` VALUES (2, 0.15);
INSERT INTO `descuentos` VALUES (3, 0.20);

-- ----------------------------
-- Table structure for detalles_compra
-- ----------------------------
DROP TABLE IF EXISTS `detalles_compra`;
CREATE TABLE `detalles_compra`  (
  `codigo_detalles_compra` int(11) NOT NULL AUTO_INCREMENT,
  `costo_unitario` int(11) NULL DEFAULT NULL,
  `cantidad` int(11) NULL DEFAULT NULL,
  `sub_total` int(11) NULL DEFAULT NULL,
  `codigo_compra` int(11) NULL DEFAULT NULL,
  `codigo_producto` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_detalles_compra`) USING BTREE,
  INDEX `fkdetallescompra`(`codigo_compra`) USING BTREE,
  INDEX `fkproductodetalles`(`codigo_producto`) USING BTREE,
  CONSTRAINT `fkdetallescompra` FOREIGN KEY (`codigo_compra`) REFERENCES `compra` (`codigo_compra`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fkproductodetalles` FOREIGN KEY (`codigo_producto`) REFERENCES `producto` (`codigo_producto`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of detalles_compra
-- ----------------------------
INSERT INTO `detalles_compra` VALUES (1, 12, 100, 1200, 1, NULL);
INSERT INTO `detalles_compra` VALUES (2, 10, 9, 90, 2, 1);

-- ----------------------------
-- Table structure for detalles_de_venta
-- ----------------------------
DROP TABLE IF EXISTS `detalles_de_venta`;
CREATE TABLE `detalles_de_venta`  (
  `codigo_detalles` int(11) NOT NULL AUTO_INCREMENT,
  `sub_total` int(11) NULL DEFAULT NULL,
  `codigo_producto` int(11) NULL DEFAULT NULL,
  `cantidad` int(11) NULL DEFAULT NULL,
  `codigo_venta` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_detalles`) USING BTREE,
  INDEX `fkproductoventa`(`codigo_producto`) USING BTREE,
  INDEX `fkventadetalles`(`codigo_venta`) USING BTREE,
  CONSTRAINT `fkproductoventa` FOREIGN KEY (`codigo_producto`) REFERENCES `producto` (`codigo_producto`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fkventadetalles` FOREIGN KEY (`codigo_venta`) REFERENCES `ventas` (`codigo_venta`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 13 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of detalles_de_venta
-- ----------------------------
INSERT INTO `detalles_de_venta` VALUES (1, 1000, 1, 1, 1);
INSERT INTO `detalles_de_venta` VALUES (2, 1000, 1, 1, 2);
INSERT INTO `detalles_de_venta` VALUES (3, 1000, 1, 1, 3);
INSERT INTO `detalles_de_venta` VALUES (4, 1000, 1, 1, 4);
INSERT INTO `detalles_de_venta` VALUES (5, 1000, 1, 1, 5);
INSERT INTO `detalles_de_venta` VALUES (6, 1000, 1, 1, 6);
INSERT INTO `detalles_de_venta` VALUES (7, 1000, 1, 1, 7);
INSERT INTO `detalles_de_venta` VALUES (8, 1000, 1, 1, 8);
INSERT INTO `detalles_de_venta` VALUES (9, 1000, 1, 1, 9);
INSERT INTO `detalles_de_venta` VALUES (10, 1000, 1, 1, 10);
INSERT INTO `detalles_de_venta` VALUES (11, 1000, 1, 1, 10);
INSERT INTO `detalles_de_venta` VALUES (12, 1000, 1, 1, 10);

-- ----------------------------
-- Table structure for producto
-- ----------------------------
DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto`  (
  `codigo_producto` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `precio_unitario` int(11) NULL DEFAULT NULL,
  `cantidad_existente` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_producto`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of producto
-- ----------------------------
INSERT INTO `producto` VALUES (1, 'arroz', 1000, 997);

-- ----------------------------
-- Table structure for proveedores
-- ----------------------------
DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE `proveedores`  (
  `ruc` varchar(11) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `nombre_proveedor` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `apellidos` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `direccion` longtext CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL,
  PRIMARY KEY (`ruc`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of proveedores
-- ----------------------------
INSERT INTO `proveedores` VALUES ('egw5rtj6kyu', 'ertrytuyliuoipo', 'esrdtfyguiop', 'rtyuyiuop');
INSERT INTO `proveedores` VALUES ('ertryuyi', 'ertyuijl', 'ertyguijkñ', 'ertyui');
INSERT INTO `proveedores` VALUES ('esgrdhtfjyg', 'dfgj', 'drftgyhjk', 'dfghjk');
INSERT INTO `proveedores` VALUES ('ghjgkh', 'frthyjukio', 'rtyuiul', 'tryui');
INSERT INTO `proveedores` VALUES ('rtnymut,iy.', 'frthyjukio', 'rtyuiul', 'tryui');

-- ----------------------------
-- Table structure for proveedores_correo
-- ----------------------------
DROP TABLE IF EXISTS `proveedores_correo`;
CREATE TABLE `proveedores_correo`  (
  `ruc` varchar(11) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `codigo_correo` int(11) NOT NULL,
  PRIMARY KEY (`ruc`, `codigo_correo`) USING BTREE,
  INDEX `fkcorreoproveedores`(`codigo_correo`) USING BTREE,
  CONSTRAINT `fkcorreoproveedores` FOREIGN KEY (`codigo_correo`) REFERENCES `correos` (`codigo_correo`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fkproveedorescorreo` FOREIGN KEY (`ruc`) REFERENCES `proveedores` (`ruc`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of proveedores_correo
-- ----------------------------
INSERT INTO `proveedores_correo` VALUES ('egw5rtj6kyu', 34);
INSERT INTO `proveedores_correo` VALUES ('ghjgkh', 32);
INSERT INTO `proveedores_correo` VALUES ('rtnymut,iy.', 33);

-- ----------------------------
-- Table structure for proveedores_telefono
-- ----------------------------
DROP TABLE IF EXISTS `proveedores_telefono`;
CREATE TABLE `proveedores_telefono`  (
  `ruc` varchar(11) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `codigo_telefono` int(11) NOT NULL,
  PRIMARY KEY (`ruc`, `codigo_telefono`) USING BTREE,
  INDEX `fktelefonoproveedor`(`codigo_telefono`) USING BTREE,
  CONSTRAINT `fkproveedorestelefono` FOREIGN KEY (`ruc`) REFERENCES `proveedores` (`ruc`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fktelefonoproveedor` FOREIGN KEY (`codigo_telefono`) REFERENCES `telefonos` (`codigo_telefono`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of proveedores_telefono
-- ----------------------------
INSERT INTO `proveedores_telefono` VALUES ('egw5rtj6kyu', 55604);
INSERT INTO `proveedores_telefono` VALUES ('ertryuyi', 55601);
INSERT INTO `proveedores_telefono` VALUES ('esgrdhtfjyg', 55600);
INSERT INTO `proveedores_telefono` VALUES ('ghjgkh', 55602);
INSERT INTO `proveedores_telefono` VALUES ('rtnymut,iy.', 55603);

-- ----------------------------
-- Table structure for telefonos
-- ----------------------------
DROP TABLE IF EXISTS `telefonos`;
CREATE TABLE `telefonos`  (
  `codigo_telefono` int(11) NOT NULL AUTO_INCREMENT,
  `numero_telefono` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_telefono`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 55606 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of telefonos
-- ----------------------------
INSERT INTO `telefonos` VALUES (55600, '');
INSERT INTO `telefonos` VALUES (55601, 'No tiene');
INSERT INTO `telefonos` VALUES (55602, '875402155');
INSERT INTO `telefonos` VALUES (55603, '1111111');
INSERT INTO `telefonos` VALUES (55604, 'No tiene');
INSERT INTO `telefonos` VALUES (55605, '57447776');

-- ----------------------------
-- Table structure for tipo_compra
-- ----------------------------
DROP TABLE IF EXISTS `tipo_compra`;
CREATE TABLE `tipo_compra`  (
  `codigo_tipocompra` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo_compra` varchar(7) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_tipocompra`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tipo_compra
-- ----------------------------
INSERT INTO `tipo_compra` VALUES (1, 'Credito');
INSERT INTO `tipo_compra` VALUES (2, 'Contado');

-- ----------------------------
-- Table structure for tipo_venta
-- ----------------------------
DROP TABLE IF EXISTS `tipo_venta`;
CREATE TABLE `tipo_venta`  (
  `codigo_tipoventa` int(11) NOT NULL,
  `tipo` varchar(7) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_tipoventa`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tipo_venta
-- ----------------------------
INSERT INTO `tipo_venta` VALUES (1, 'Credito');
INSERT INTO `tipo_venta` VALUES (2, 'Contado');

-- ----------------------------
-- Table structure for usuario
-- ----------------------------
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario`  (
  `ID_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Usuario` varchar(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Clave` varchar(12) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `primer_nombre` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `primer_apellido` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `email` varchar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `tipo` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ID_Usuario`) USING BTREE,
  UNIQUE INDEX `Nombre_Usuario`(`Nombre_Usuario`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of usuario
-- ----------------------------
INSERT INTO `usuario` VALUES (1, 'Jester', '1234', 'jester', 'lopez', 'comfinvvnhfvhfvh', 'Vendedor');
INSERT INTO `usuario` VALUES (2, 'Holvert', '123456', 'Holvert', 'Perez', 'holvertperez@hotmail.com', 'Administrador');
INSERT INTO `usuario` VALUES (3, 'holvert20', 'holvert1', 'holvert', 'talavera', 'pereshol13@gmail.com', 'vendedor');
INSERT INTO `usuario` VALUES (4, 'josel', 'joseluis2', 'jose', 'valdivia', 'escorciav93@gmail.com', 'Vendedor');

-- ----------------------------
-- Table structure for ventas
-- ----------------------------
DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas`  (
  `codigo_venta` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` datetime(0) NULL DEFAULT NULL,
  `precio_total` int(10) NULL DEFAULT NULL,
  `fecha_pago` datetime(0) NULL DEFAULT NULL,
  `ID_Usuario` int(11) NULL DEFAULT NULL,
  `id_desc` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_venta`) USING BTREE,
  INDEX `fkusarioventa`(`ID_Usuario`) USING BTREE,
  INDEX `fkdesc`(`id_desc`) USING BTREE,
  CONSTRAINT `fkdesc` FOREIGN KEY (`id_desc`) REFERENCES `descuentos` (`id_desc`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fkusarioventa` FOREIGN KEY (`ID_Usuario`) REFERENCES `usuario` (`ID_Usuario`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of ventas
-- ----------------------------
INSERT INTO `ventas` VALUES (1, '2019-11-03 12:38:09', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (2, '2019-11-03 12:48:28', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (3, '2019-11-03 13:16:57', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (4, '2019-11-03 13:24:23', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (5, '2019-11-03 13:25:11', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (6, '2019-11-03 13:26:55', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (7, '2019-11-03 13:29:41', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (8, '2019-11-03 13:31:19', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (9, '2019-11-03 13:35:02', 1000, '2019-11-18 06:00:00', NULL, 1);
INSERT INTO `ventas` VALUES (10, '2019-11-03 14:03:42', 3000, '2019-11-18 06:00:00', NULL, 1);

-- ----------------------------
-- Table structure for ventas_clientes_credito
-- ----------------------------
DROP TABLE IF EXISTS `ventas_clientes_credito`;
CREATE TABLE `ventas_clientes_credito`  (
  `codigo_venta` int(11) NOT NULL,
  `cedula` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`codigo_venta`, `cedula`) USING BTREE,
  INDEX `fkclientesventas`(`cedula`) USING BTREE,
  CONSTRAINT `fkclientesventas` FOREIGN KEY (`cedula`) REFERENCES `clientes_credito` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fkventasclientes` FOREIGN KEY (`codigo_venta`) REFERENCES `ventas` (`codigo_venta`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of ventas_clientes_credito
-- ----------------------------
INSERT INTO `ventas_clientes_credito` VALUES (4, '161-261198-0001W');
INSERT INTO `ventas_clientes_credito` VALUES (5, '161-261198-0001W');
INSERT INTO `ventas_clientes_credito` VALUES (6, '161-261198-0001W');
INSERT INTO `ventas_clientes_credito` VALUES (7, '161-261198-0001W');
INSERT INTO `ventas_clientes_credito` VALUES (8, '161-261198-0001W');
INSERT INTO `ventas_clientes_credito` VALUES (9, '161-261198-0001W');
INSERT INTO `ventas_clientes_credito` VALUES (10, '161-261198-0001W');

-- ----------------------------
-- Table structure for ventas_tipo
-- ----------------------------
DROP TABLE IF EXISTS `ventas_tipo`;
CREATE TABLE `ventas_tipo`  (
  `codigo_venta` int(11) NOT NULL,
  `codigo_tipoventa` int(11) NOT NULL,
  PRIMARY KEY (`codigo_venta`, `codigo_tipoventa`) USING BTREE,
  INDEX `fktipoventas`(`codigo_tipoventa`) USING BTREE,
  CONSTRAINT `fktipoventas` FOREIGN KEY (`codigo_tipoventa`) REFERENCES `tipo_venta` (`codigo_tipoventa`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fkventastipo` FOREIGN KEY (`codigo_venta`) REFERENCES `ventas` (`codigo_venta`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of ventas_tipo
-- ----------------------------
INSERT INTO `ventas_tipo` VALUES (1, 2);
INSERT INTO `ventas_tipo` VALUES (2, 2);
INSERT INTO `ventas_tipo` VALUES (3, 2);
INSERT INTO `ventas_tipo` VALUES (4, 1);
INSERT INTO `ventas_tipo` VALUES (5, 1);
INSERT INTO `ventas_tipo` VALUES (6, 1);
INSERT INTO `ventas_tipo` VALUES (7, 1);
INSERT INTO `ventas_tipo` VALUES (8, 1);
INSERT INTO `ventas_tipo` VALUES (9, 1);
INSERT INTO `ventas_tipo` VALUES (10, 1);

-- ----------------------------
-- View structure for factura
-- ----------------------------
DROP VIEW IF EXISTS `factura`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `factura` AS SELECT ventas.codigo_venta,descripcion,precio_unitario,cantidad,sub_total,fecha,clientes_credito.cedula,nombre,apellido,direccion,tipo,(descuentos.porcenjate*ventas.precio_total) as descuento
FROM producto,detalles_de_venta,ventas_clientes_credito,ventas,clientes_credito,tipo_venta,ventas_tipo,descuentos
WHERE producto.codigo_producto=detalles_de_venta.codigo_producto
AND detalles_de_venta.codigo_venta=ventas.codigo_venta
AND ventas_clientes_credito.codigo_venta=ventas.codigo_venta
AND clientes_credito.cedula=ventas_clientes_credito.cedula 
AND ventas_tipo.codigo_tipoventa=tipo_venta.codigo_tipoventa
AND ventas.codigo_venta=ventas_tipo.codigo_venta 
AND ventas.id_desc= descuentos.id_desc ;

-- ----------------------------
-- View structure for factura_contado
-- ----------------------------
DROP VIEW IF EXISTS `factura_contado`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `factura_contado` AS SELECT ventas.codigo_venta,descripcion,precio_unitario,cantidad,sub_total,fecha,tipo,(descuentos.porcenjate*ventas.precio_total) as descuento
FROM producto,detalles_de_venta,ventas,tipo_venta,ventas_tipo,descuentos
WHERE producto.codigo_producto=detalles_de_venta.codigo_producto
AND detalles_de_venta.codigo_venta=ventas.codigo_venta
AND ventas_tipo.codigo_tipoventa=tipo_venta.codigo_tipoventa
AND ventas.codigo_venta=ventas_tipo.codigo_venta 
AND ventas_tipo.codigo_tipoventa='2' 
AND ventas.id_desc=descuentos.id_desc ;

-- ----------------------------
-- View structure for reporteventas
-- ----------------------------
DROP VIEW IF EXISTS `reporteventas`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `reporteventas` AS SELECT ventas.codigo_venta,precio_total,fecha,tipo
FROM ventas,tipo_venta,ventas_tipo
WHERE ventas_tipo.codigo_tipoventa=tipo_venta.codigo_tipoventa
AND ventas.codigo_venta=ventas_tipo.codigo_venta 
ORDER BY fecha DESC ;

-- ----------------------------
-- View structure for vista_factura_c
-- ----------------------------
DROP VIEW IF EXISTS `vista_factura_c`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `vista_factura_c` AS SELECT fecha_compra,costo_unitario,cantidad,sub_total,descripcion,proveedores.ruc,nombre_proveedor,apellidos,direccion
FROM compra,detalles_compra,producto,proveedores
WHERE compra.codigo_compra = detalles_compra.codigo_compra
and detalles_compra.codigo_producto = producto.codigo_producto 
AND compra.ruc = proveedores.ruc ;

-- ----------------------------
-- View structure for vista_factura_v
-- ----------------------------
DROP VIEW IF EXISTS `vista_factura_v`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `vista_factura_v` AS SELECT descripcion, precio_unitario,cantidad,sub_total,fecha,clientes_credito.cedula,nombre,apellido,direccion
FROM producto,detalles_de_venta,ventas,ventas_clientes_credito,clientes_credito
WHERE producto.codigo_producto = detalles_de_venta.codigo_producto
AND detalles_de_venta.codigo_venta = ventas.codigo_venta
AND ventas_clientes_credito.codigo_venta = ventas.codigo_venta
and ventas_clientes_credito.cedula = clientes_credito.cedula ;

-- ----------------------------
-- Procedure structure for Agregar_Usuario
-- ----------------------------
DROP PROCEDURE IF EXISTS `Agregar_Usuario`;
delimiter ;;
CREATE PROCEDURE `Agregar_Usuario`(IN `pNombre_usuario` varchar(15),IN `pClave` varchar(12),IN `pnombre` varchar(100),IN `papellido` varchar(100),IN `pcargo` varchar(50),IN `pemail` varchar(150))
BEGIN
	#Routine body goes here...
INSERT INTO usuario(Nombre_Usuario,Clave,primer_nombre,primer_apellido,email,tipo)
VALUES(pNombre_usuario,pClave,pnombre,papellido,pemail,pcargo);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for codigo
-- ----------------------------
DROP PROCEDURE IF EXISTS `codigo`;
delimiter ;;
CREATE PROCEDURE `codigo`(OUT `pres` integer)
BEGIN
	#Routine body goes here...
SELECT MAX(codigo_venta) INTO pres FROM factura;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for CodigoContado
-- ----------------------------
DROP PROCEDURE IF EXISTS `CodigoContado`;
delimiter ;;
CREATE PROCEDURE `CodigoContado`(OUT `pres` integer)
BEGIN
	#Routine body goes here...
SELECT MAX(codigo_venta) INTO pres FROM factura_contado;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for ediatardetallesdeventa
-- ----------------------------
DROP PROCEDURE IF EXISTS `ediatardetallesdeventa`;
delimiter ;;
CREATE PROCEDURE `ediatardetallesdeventa`(IN `pcodigodetalles` integer,IN `pdescripcion` varchar(30),IN `ppreciounitario` integer,IN `psubtotal` integer,IN `pcodigoproducto` integer,IN `pcantidad` integer,IN `pcodigoventa` integer,IN `ppreciototal` integer,IN `pfecha` datetime,IN `ptipoventa` varchar(7))
BEGIN
	#Routine body goes here...

UPDATE detalles_de_venta SET descripcion=pdescripcion
WHERE detalles_de_venta.codigo_producto=pcodigoproducto;

UPDATE detalles_de_venta SET precio_unitario=ppreciounitario
WHERE detalles_de_venta.codigo_detalles=pcodigodetalles;

UPDATE detalles_de_venta SET sub_total=psubtotal
WHERE detalles_de_venta.codigo_detalles=pcodigodetalles;

UPDATE detalles_de_venta SET cantidad=pcantidad
WHERE detalles_de_venta.codigo_detalles=pcodigodetalles;

UPDATE ventas SET precio_total= ppreciototal
WHERE ventas.codigo_venta=pcodigoventa;

UPDATE ventas SET fecha= pfecha
WHERE ventas.codigo_venta=pcodigoventa;

UPDATE tipo_venta SET tipo= ptipoventa
WHERE tipo_venta.codigo_venta=pcodigoventa;

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for editarclientes
-- ----------------------------
DROP PROCEDURE IF EXISTS `editarclientes`;
delimiter ;;
CREATE PROCEDURE `editarclientes`(IN `pcedula` varchar(20),IN `pnombre` varchar(20),IN `papellido` varchar(20),IN `pdireccion` longtext,IN `pcodigotelefono` INTEGER,IN `ptelefono` varchar(20),IN `pcorreos` LONGTEXT,IN `pcodigo_correo` INTEGER)
BEGIN
	#Routine body goes here...
UPDATE clientes_credito set nombre =pnombre 
WHERE clientes_credito.cedula=pcedula;

UPDATE clientes_credito set apellido=papellido 
WHERE clientes_credito.cedula=pcedula;

UPDATE clientes_credito set direccion=pdireccion
WHERE clientes_credito.cedula=pcedula;

UPDATE telefonos set numero_telefono=ptelefono
WHERE codigo_telefono=pcodigotelefono;

UPDATE correos SET direccion_correo=pcorreos
WHERE codigo_correo=pcodigo_correo;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for editarproducto
-- ----------------------------
DROP PROCEDURE IF EXISTS `editarproducto`;
delimiter ;;
CREATE PROCEDURE `editarproducto`(IN `pcodigo` integer,IN `pdescripcion` varchar(30),IN `pprecio` INTEGER(11))
BEGIN
	#Routine body goes here...
UPDATE producto set producto.descripcion=pdescripcion,producto.precio_unitario=pprecio
WHERE producto.codigo_producto=pcodigo;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for editarproveedores
-- ----------------------------
DROP PROCEDURE IF EXISTS `editarproveedores`;
delimiter ;;
CREATE PROCEDURE `editarproveedores`(IN  `pruc` varchar(11),IN `pnombreproveedor` varchar(30),IN  `papellido` varchar(30),IN  `pdireccion` longtext,IN  `pcodigotelefono` INTEGER,IN  `ptelefono` varchar(20),IN  `pcorreos` LONGTEXT,IN  `pcodigo_correo` INTEGER)
BEGIN
	#Routine body goes here...
UPDATE proveedores set nombre_proveedor =pnombreproveedor
WHERE proveedores.ruc=pruc;

UPDATE proveedores set apellidos=papellido 
WHERE proveedores.ruc=pruc;

UPDATE proveedores set direccion=pdireccion
WHERE proveedores.ruc=pruc; 

UPDATE telefonos set numero_telefono=ptelefono
WHERE codigo_telefono=pcodigotelefono; 

UPDATE correos set direccion_correo=pcorreos
WHERE codigo_correo=pcodigo_correo;

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for editarproveedorestelefono
-- ----------------------------
DROP PROCEDURE IF EXISTS `editarproveedorestelefono`;
delimiter ;;
CREATE PROCEDURE `editarproveedorestelefono`(IN `ptelefono` varchar(20))
BEGIN
	#Routine body goes here...
insert INTO telefonos(numero_telefono) VALUES (ptelefono);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for editarventa
-- ----------------------------
DROP PROCEDURE IF EXISTS `editarventa`;
delimiter ;;
CREATE PROCEDURE `editarventa`(IN `pcodigo` integer,IN `pfecha` datetime,IN `pprecio` varchar(10))
BEGIN
	#Routine body goes here...
UPDATE ventas set precio_total=pprecio
WHERE ventas.codigo_venta=pcodigo;

UPDATE ventas set fecha=pfecha
WHERE ventas.codigo_venta=pcodigo;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Existencias
-- ----------------------------
DROP PROCEDURE IF EXISTS `Existencias`;
delimiter ;;
CREATE PROCEDURE `Existencias`(IN `pexistencia` INTEGER,IN `pnombreproducto` varchar(30))
BEGIN
	#Routine body goes here...
UPDATE producto SET cantidad_existente=pexistencia
WHERE descripcion=pnombreproducto;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardarcliente
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardarcliente`;
delimiter ;;
CREATE PROCEDURE `guardarcliente`(IN  `pcedula` varchar(20),IN `pnombre` varchar(30),IN `papellido` varchar(30),IN `pdireccion` longtext)
BEGIN
	#Routine body goes here...
INSERT INTO clientes_credito (cedula,nombre,apellido,direccion) VALUES(pcedula,pnombre,papellido,pdireccion);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardarclientescorreos
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardarclientescorreos`;
delimiter ;;
CREATE PROCEDURE `guardarclientescorreos`(IN `pcedula` varchar(20))
BEGIN
	#Routine body goes here...
declare x INT;
SELECT MAX(codigo_correo) into x from correos;


INSERT into clientes_correo (cedula,codigo_correo)
VALUES(pcedula,x);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardarclientestelefono
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardarclientestelefono`;
delimiter ;;
CREATE PROCEDURE `guardarclientestelefono`(IN `pcedula` varchar(16))
BEGIN
	#Routine body goes here...
declare x INT;
SELECT MAX(codigo_telefono) into x from telefonos;


INSERT into clientes_credito_telefono (cedula,codigo_telefono)
VALUES(pcedula,x);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardarcorreos
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardarcorreos`;
delimiter ;;
CREATE PROCEDURE `guardarcorreos`(IN `pcorreos` LONGTEXT)
BEGIN
	#Routine body goes here...
insert INTO correos(direccion_correo) VALUES (pcorreos);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardardetallescompra
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardardetallescompra`;
delimiter ;;
CREATE PROCEDURE `guardardetallescompra`(IN `pcostounitario` integer,IN `pcantidad` integer,IN `pcodigoproducto` integer,IN `psubtotal` integer)
BEGIN
	#Routine body goes here...
	DECLARE x INT;
SELECT max(codigo_compra) INTO x FROM compra;

INSERT INTO detalles_compra(costo_unitario,cantidad,codigo_producto,codigo_compra,sub_total) VALUES (pcostounitario,pcantidad,pcodigoproducto,x,psubtotal);

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardardetallesventa
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardardetallesventa`;
delimiter ;;
CREATE PROCEDURE `guardardetallesventa`(IN `psubtotal` integer,IN `pcodigoproducto` integer,IN `pcantidad` integer)
BEGIN
	#Routine body goes here...
DECLARE x INT;
SELECT MAX(codigo_venta) INTO x FROM ventas;

INSERT INTO detalles_de_venta(sub_total,codigo_producto,cantidad,codigo_venta) VALUES (psubtotal,pcodigoproducto,pcantidad,x);

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardarproveedores
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardarproveedores`;
delimiter ;;
CREATE PROCEDURE `guardarproveedores`(IN `pruc` varchar(11),IN  `pnombre` varchar(30),IN `papellido` varchar(30),IN `pdireccion` longtext)
BEGIN
	#Routine body goes here...
INSERT INTO proveedores (ruc,nombre_proveedor,apellidos,direccion) VALUES(pruc,pnombre,papellido,pdireccion);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardarproveedorescorreos
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardarproveedorescorreos`;
delimiter ;;
CREATE PROCEDURE `guardarproveedorescorreos`(IN `pruc` varchar(11))
BEGIN
	#Routine body goes here...
declare x INT;
SELECT MAX(codigo_correo) into x from correos;


INSERT into proveedores_correo (ruc,codigo_correo)
VALUES(pruc,x);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardarproveedorestelefono
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardarproveedorestelefono`;
delimiter ;;
CREATE PROCEDURE `guardarproveedorestelefono`(IN `pruc` varchar(11))
BEGIN
	#Routine body goes here...
declare x INT;
SELECT MAX(codigo_telefono) into x from telefonos;


INSERT into proveedores_telefono (proveedores_telefono.ruc,proveedores_telefono.codigo_telefono)
VALUES(pruc,x);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardartelefono
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardartelefono`;
delimiter ;;
CREATE PROCEDURE `guardartelefono`(IN `ptelefono` varchar(20))
BEGIN
	#Routine body goes here...
insert INTO telefonos(numero_telefono) VALUES (ptelefono);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardartipocompra
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardartipocompra`;
delimiter ;;
CREATE PROCEDURE `guardartipocompra`(IN `ptipocompra` varchar(7))
BEGIN
	#Routine body goes here...
	DECLARE x int;
SELECT MAX(codigo_compra) into x FROM compra;

INSERT INTO compras_tipo(codigo_compra,codigo_tipocompra) VALUES (x,ptipocompra);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardartipoventa
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardartipoventa`;
delimiter ;;
CREATE PROCEDURE `guardartipoventa`(IN `ptipoventa` varchar(7))
BEGIN
	#Routine body goes here...
	DECLARE x INT;
SELECT MAX(codigo_venta) INTO x FROM ventas;

INSERT INTO ventas_tipo (codigo_venta,codigo_tipoventa) VALUES	(x,ptipoventa);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for guardarventasclientes
-- ----------------------------
DROP PROCEDURE IF EXISTS `guardarventasclientes`;
delimiter ;;
CREATE PROCEDURE `guardarventasclientes`(IN `pcedula` varchar(16))
BEGIN
	#Routine body goes here...
	DECLARE x INT;
SELECT MAX(codigo_venta) INTO x FROM ventas;

INSERT INTO ventas_clientes_credito(cedula,codigo_venta) VALUES (pcedula,x);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for nuevacompra
-- ----------------------------
DROP PROCEDURE IF EXISTS `nuevacompra`;
delimiter ;;
CREATE PROCEDURE `nuevacompra`(IN `pruc` varchar(11),IN `pfechacompra` Datetime,IN `pcostototal` integer)
BEGIN
	#Routine body goes here...
INSERT INTO compra (ruc,costo_total,fecha_compra) VALUES (pruc,pcostototal,pfechacompra);
UPDATE compra SET fecha_pago= ADDDATE(fecha_compra,INTERVAL 15 DAY);
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for nuevaventa
-- ----------------------------
DROP PROCEDURE IF EXISTS `nuevaventa`;
delimiter ;;
CREATE PROCEDURE `nuevaventa`(IN `pfecha` datetime,IN `pfecha_pago` datetime,IN `ppreciototal` integer,IN `pdesc` integer)
BEGIN
	#Routine body goes here...
	DECLARE x INT;
INSERT INTO ventas (fecha,precio_total,id_desc) VALUES (pfecha,ppreciototal,pdesc);
SELECT MAX(codigo_venta) into x from ventas;

UPDATE ventas SET fecha_pago=pfecha_pago WHERE
ventas.codigo_venta=x;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for obtener_cliente_con_deuda
-- ----------------------------
DROP PROCEDURE IF EXISTS `obtener_cliente_con_deuda`;
delimiter ;;
CREATE PROCEDURE `obtener_cliente_con_deuda`(IN `pcedula` varchar(16),OUT `prespuesta` integer)
BEGIN
	#Routine body goes here...
SELECT COUNT(*) INTO prespuesta FROM ventas_clientes_credito
WHERE ventas_clientes_credito.cedula=pcedula;

if prespuesta > 0 THEN
SELECT cedula INTO prespuesta FROM ventas_clientes_credito
WHERE ventas_clientes_credito.cedula=pcedula;
ELSE
SET prespuesta=0;
END IF;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for obtener_existencia
-- ----------------------------
DROP PROCEDURE IF EXISTS `obtener_existencia`;
delimiter ;;
CREATE PROCEDURE `obtener_existencia`(OUT `prespuesta` VARCHAR(30),IN `pcodigo` integer)
BEGIN
	#Routine body goes here...
SELECT cantidad_existente into prespuesta from  producto 
WHERE producto.codigo_producto=pcodigo;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for obtener_Usuario
-- ----------------------------
DROP PROCEDURE IF EXISTS `obtener_Usuario`;
delimiter ;;
CREATE PROCEDURE `obtener_Usuario`(IN `pUsuario` varchar(15),IN `pClave` varchar(12),OUT `pRes` int)
BEGIN
	#Routine body goes here...
SELECT COUNT(*) into pRes from usuario
WHERE Nombre_Usuario = pUsuario
and Clave=pClave;

if pRes >0 THEN
	SELECT ID_usuario into pRes FROM usuario
WHERE Nombre_Usuario=pUsuario
and Clave=pclave;

	ELSE
	SET pRes=0;
end IF;

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Validar_producto
-- ----------------------------
DROP PROCEDURE IF EXISTS `Validar_producto`;
delimiter ;;
CREATE PROCEDURE `Validar_producto`(IN `pnombreproducto` varchar(30),OUT `prespuesta` varchar(30),IN `pprecio` INTEGER)
BEGIN
	#Routine body goes here...
	DECLARE x VARCHAR(30);

SELECT descripcion INTO x from producto
WHERE descripcion=pnombreproducto;

IF x=pnombreproducto THEN
SET prespuesta='si';
ELSE
SET prespuesta='no';
INSERT INTO producto(descripcion,precio_unitario,cantidad_existente) VALUES (pnombreproducto,pprecio,'0');
END IF;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Verificar_ExisteNUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `Verificar_ExisteNUser`;
delimiter ;;
CREATE PROCEDURE `Verificar_ExisteNUser`(IN `pnuser` varchar (15),OUT `pexiste` varchar (15))
BEGIN
	#Routine body goes here...
	declare x int;
SELECT COUNT(*) Nombre_Usuario into x from usuario
WHERE pnuser=Nombre_Usuario;

SELECT Nombre_Usuario  into pexiste from usuario
WHERE pnuser=Nombre_Usuario;



END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
