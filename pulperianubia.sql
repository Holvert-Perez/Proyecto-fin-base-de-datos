/*
 Navicat Premium Data Transfer

 Source Server         : holvert
 Source Server Type    : MySQL
 Source Server Version : 50511
 Source Host           : 127.0.0.1:3306
 Source Schema         : pulperianubia

 Target Server Type    : MySQL
 Target Server Version : 50511
 File Encoding         : 65001

 Date: 24/11/2018 12:19:27
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
INSERT INTO `clientes_correo` VALUES (1, '1');
INSERT INTO `clientes_correo` VALUES (20, '123-456789-0565H');
INSERT INTO `clientes_correo` VALUES (2, '2');
INSERT INTO `clientes_correo` VALUES (19, '534-343646-34632');
INSERT INTO `clientes_correo` VALUES (13, 'ghjhbjhh');
INSERT INTO `clientes_correo` VALUES (12, 'kjhgsnjln');
INSERT INTO `clientes_correo` VALUES (15, 'q2eqweqwrq');
INSERT INTO `clientes_correo` VALUES (11, 'vvvvvvvvvvvvv');

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
INSERT INTO `clientes_credito` VALUES ('1', 'holvert', 'perez', 'gyfyyf');
INSERT INTO `clientes_credito` VALUES ('121-312312-4124F', 'werwerwerwewef', 'fsdfsdf', 'werwerwer');
INSERT INTO `clientes_credito` VALUES ('122-123124-1241F', 'qwrqwrqwrqwrqwrqw', 'rfsdfsdfsf', 'wrqrqwrqwr');
INSERT INTO `clientes_credito` VALUES ('123-456789-0565H', 'rwtesdyfgjkhljj', 'sdfghj', 'sdfg');
INSERT INTO `clientes_credito` VALUES ('2', 'jester', 'lopez', 'jinotega');
INSERT INTO `clientes_credito` VALUES ('223-423423-23324', 'sdfsdfsd', 'fsdfsd', 'dfsfsdfsdfs');
INSERT INTO `clientes_credito` VALUES ('444445454', 'fatima', 'garcia', 'ocotal');
INSERT INTO `clientes_credito` VALUES ('534-343646-34632', 'jester', 'lopez', 'jinotega');
INSERT INTO `clientes_credito` VALUES ('ghjhbjhh', 'vhvhjh', 'vjvjgvjg', 'jgvjgvjg');
INSERT INTO `clientes_credito` VALUES ('kjhgsnjln', 'gvgvxcjvdhfb', 'dhcvkvbh', 'cbdkbvdkj');
INSERT INTO `clientes_credito` VALUES ('q2eqweqwrq', 'sdfsdfsd', 'fsdfsd', 'dfsfsdfsdfsw');
INSERT INTO `clientes_credito` VALUES ('vvvvvvvvvvvvv', 'vvvvvvvvvvvvvv', 'vvvvvvvvv', 'vvvvvvvvvvv');

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
INSERT INTO `clientes_credito_telefono` VALUES ('1', 55);
INSERT INTO `clientes_credito_telefono` VALUES ('2', 57);
INSERT INTO `clientes_credito_telefono` VALUES ('vvvvvvvvvvvvv', 55557);
INSERT INTO `clientes_credito_telefono` VALUES ('kjhgsnjln', 55560);
INSERT INTO `clientes_credito_telefono` VALUES ('ghjhbjhh', 55561);
INSERT INTO `clientes_credito_telefono` VALUES ('q2eqweqwrq', 55563);
INSERT INTO `clientes_credito_telefono` VALUES ('122-123124-1241F', 55564);
INSERT INTO `clientes_credito_telefono` VALUES ('121-312312-4124F', 55565);
INSERT INTO `clientes_credito_telefono` VALUES ('223-423423-23324', 55566);
INSERT INTO `clientes_credito_telefono` VALUES ('534-343646-34632', 55567);
INSERT INTO `clientes_credito_telefono` VALUES ('123-456789-0565H', 55568);

-- ----------------------------
-- Table structure for compra
-- ----------------------------
DROP TABLE IF EXISTS `compra`;
CREATE TABLE `compra`  (
  `codigo_compra` int(11) NOT NULL AUTO_INCREMENT,
  `costo_total` int(11) NULL DEFAULT NULL,
  `ruc` varchar(11) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `fecha_compra` datetime NULL DEFAULT NULL,
  `fecha_pago` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_compra`) USING BTREE,
  INDEX `fkcompra`(`ruc`) USING BTREE,
  CONSTRAINT `fkcompra` FOREIGN KEY (`ruc`) REFERENCES `proveedores` (`ruc`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 25180 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of compra
-- ----------------------------
INSERT INTO `compra` VALUES (25156, 400, '5', '2018-11-20 17:00:15', '2018-12-05 17:00:15');
INSERT INTO `compra` VALUES (25157, 150, '5', '2018-11-22 14:10:33', '2018-12-07 14:10:33');
INSERT INTO `compra` VALUES (25158, 70, '5', '2018-11-22 14:11:59', '2018-12-07 14:11:59');
INSERT INTO `compra` VALUES (25159, 96, '5', '2018-11-22 14:13:14', '2018-12-07 14:13:14');
INSERT INTO `compra` VALUES (25160, 7000, '5', '2018-11-22 14:14:53', '2018-12-07 14:14:53');
INSERT INTO `compra` VALUES (25161, 40, '5', '2018-11-22 14:17:04', '2018-12-07 14:17:04');
INSERT INTO `compra` VALUES (25162, 10, '5', '2018-11-22 14:17:38', '2018-12-07 14:17:38');
INSERT INTO `compra` VALUES (25163, 10, '5', '2018-11-22 14:20:19', '2018-12-07 14:20:19');
INSERT INTO `compra` VALUES (25164, 50, '5', '2018-11-22 14:22:00', '2018-12-07 14:22:00');
INSERT INTO `compra` VALUES (25165, 3000, '5', '2018-11-22 14:22:58', '2018-12-07 14:22:58');
INSERT INTO `compra` VALUES (25166, 10, '5', '2018-11-22 14:25:27', '2018-12-07 14:25:27');
INSERT INTO `compra` VALUES (25167, 20, '5', '2018-11-22 14:26:18', '2018-12-07 14:26:18');
INSERT INTO `compra` VALUES (25168, 50, '5', '2018-11-22 14:26:38', '2018-12-07 14:26:38');
INSERT INTO `compra` VALUES (25169, 110, '5', '2018-11-22 14:27:29', '2018-12-07 14:27:29');
INSERT INTO `compra` VALUES (25170, 60, '5', '2018-11-22 14:28:01', '2018-12-07 14:28:01');
INSERT INTO `compra` VALUES (25171, 80, '5', '2018-11-22 14:28:53', '2018-12-07 14:28:53');
INSERT INTO `compra` VALUES (25172, 120, '5', '2018-11-22 15:56:29', '2018-12-07 15:56:29');
INSERT INTO `compra` VALUES (25173, 120, '5', '2018-11-22 15:56:41', '2018-12-07 15:56:41');
INSERT INTO `compra` VALUES (25174, 120, '5', '2018-11-22 15:57:21', '2018-12-07 15:57:21');
INSERT INTO `compra` VALUES (25175, 40, '5', '2018-11-22 15:59:03', '2018-12-07 15:59:03');
INSERT INTO `compra` VALUES (25176, 70, '5', '2018-11-22 16:00:35', '2018-12-07 16:00:35');
INSERT INTO `compra` VALUES (25177, 40, '5', '2018-11-23 17:00:50', '2018-12-08 17:00:50');
INSERT INTO `compra` VALUES (25178, 6155, '5', '2018-11-23 17:17:27', '2018-12-08 17:17:27');
INSERT INTO `compra` VALUES (25179, 2000, '5', '2018-11-24 12:04:29', '2018-12-09 12:04:29');

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
INSERT INTO `compras_tipo` VALUES (2, 25156);
INSERT INTO `compras_tipo` VALUES (2, 25157);
INSERT INTO `compras_tipo` VALUES (2, 25158);
INSERT INTO `compras_tipo` VALUES (2, 25159);
INSERT INTO `compras_tipo` VALUES (2, 25160);
INSERT INTO `compras_tipo` VALUES (2, 25161);
INSERT INTO `compras_tipo` VALUES (2, 25162);
INSERT INTO `compras_tipo` VALUES (2, 25163);
INSERT INTO `compras_tipo` VALUES (2, 25164);
INSERT INTO `compras_tipo` VALUES (2, 25165);
INSERT INTO `compras_tipo` VALUES (2, 25166);
INSERT INTO `compras_tipo` VALUES (2, 25167);
INSERT INTO `compras_tipo` VALUES (2, 25168);
INSERT INTO `compras_tipo` VALUES (2, 25169);
INSERT INTO `compras_tipo` VALUES (2, 25170);
INSERT INTO `compras_tipo` VALUES (2, 25171);
INSERT INTO `compras_tipo` VALUES (2, 25172);
INSERT INTO `compras_tipo` VALUES (2, 25173);
INSERT INTO `compras_tipo` VALUES (2, 25174);
INSERT INTO `compras_tipo` VALUES (2, 25175);
INSERT INTO `compras_tipo` VALUES (2, 25176);
INSERT INTO `compras_tipo` VALUES (1, 25177);
INSERT INTO `compras_tipo` VALUES (1, 25178);
INSERT INTO `compras_tipo` VALUES (2, 25179);

-- ----------------------------
-- Table structure for correos
-- ----------------------------
DROP TABLE IF EXISTS `correos`;
CREATE TABLE `correos`  (
  `codigo_correo` int(11) NOT NULL AUTO_INCREMENT,
  `direccion_correo` longtext CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL,
  `ID_Usuario` int(10) NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_correo`) USING BTREE,
  INDEX `FK_Usuario`(`ID_Usuario`) USING BTREE,
  CONSTRAINT `FK_Usuario` FOREIGN KEY (`ID_Usuario`) REFERENCES `usuario` (`ID_Usuario`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 21 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of correos
-- ----------------------------
INSERT INTO `correos` VALUES (1, 'pereshol13@gmail.com', NULL);
INSERT INTO `correos` VALUES (2, 'loco@gmail.com', NULL);
INSERT INTO `correos` VALUES (3, 'loco@gmail.com', NULL);
INSERT INTO `correos` VALUES (4, 'gggggg', NULL);
INSERT INTO `correos` VALUES (5, 'ggggg', NULL);
INSERT INTO `correos` VALUES (6, 'dsdgjfhjk.', NULL);
INSERT INTO `correos` VALUES (7, 'vfgnhmj,kl', NULL);
INSERT INTO `correos` VALUES (8, 'bbb', NULL);
INSERT INTO `correos` VALUES (9, 'vvvvvvvvvvv', NULL);
INSERT INTO `correos` VALUES (10, 'vvvvvvvvvvv', NULL);
INSERT INTO `correos` VALUES (11, 'bbbbbb', NULL);
INSERT INTO `correos` VALUES (12, 'dsckb cbj ', NULL);
INSERT INTO `correos` VALUES (13, 'gvvgjvvjh', NULL);
INSERT INTO `correos` VALUES (14, '', NULL);
INSERT INTO `correos` VALUES (15, 'dfsdfsdfsdsdhhdhsh', NULL);
INSERT INTO `correos` VALUES (16, 'fswsdfwfe234', NULL);
INSERT INTO `correos` VALUES (17, '4352', NULL);
INSERT INTO `correos` VALUES (18, 'dfsdfsdfsdsdhhdhsh', NULL);
INSERT INTO `correos` VALUES (19, 'loco@gmail.com', NULL);
INSERT INTO `correos` VALUES (20, 'ewsdfchgjh', NULL);

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
) ENGINE = InnoDB AUTO_INCREMENT = 38 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of detalles_compra
-- ----------------------------
INSERT INTO `detalles_compra` VALUES (10, 100, 2, 200, 25156, 2);
INSERT INTO `detalles_compra` VALUES (11, 100, 2, 200, 25156, 2);
INSERT INTO `detalles_compra` VALUES (12, 15, 10, 150, 25157, 2);
INSERT INTO `detalles_compra` VALUES (13, 7, 10, 70, 25158, 4);
INSERT INTO `detalles_compra` VALUES (14, 6, 16, 96, 25159, 2);
INSERT INTO `detalles_compra` VALUES (15, 7, 10, 70, 25160, 2);
INSERT INTO `detalles_compra` VALUES (16, 4, 10, 40, 25161, 2);
INSERT INTO `detalles_compra` VALUES (17, 1, 10, 10, 25162, 2);
INSERT INTO `detalles_compra` VALUES (18, 1, 10, 10, 25163, 2);
INSERT INTO `detalles_compra` VALUES (19, 10, 5, 50, 25164, 2);
INSERT INTO `detalles_compra` VALUES (20, 1000, 3, 3000, 25165, 2);
INSERT INTO `detalles_compra` VALUES (21, 10, 1, 10, 25166, 2);
INSERT INTO `detalles_compra` VALUES (22, 10, 2, 20, 25167, 2);
INSERT INTO `detalles_compra` VALUES (23, 10, 2, 20, 25168, 2);
INSERT INTO `detalles_compra` VALUES (24, 10, 3, 30, 25168, 2);
INSERT INTO `detalles_compra` VALUES (25, 10, 11, 110, 25169, 2);
INSERT INTO `detalles_compra` VALUES (26, 10, 6, 60, 25170, 2);
INSERT INTO `detalles_compra` VALUES (27, 10, 8, 80, 25171, 2);
INSERT INTO `detalles_compra` VALUES (28, 10, 12, 120, 25172, 2);
INSERT INTO `detalles_compra` VALUES (29, 10, 12, 120, 25173, 2);
INSERT INTO `detalles_compra` VALUES (30, 10, 12, 120, 25174, 2);
INSERT INTO `detalles_compra` VALUES (31, 10, 2, 20, 25175, 4);
INSERT INTO `detalles_compra` VALUES (32, 10, 2, 20, 25175, 5);
INSERT INTO `detalles_compra` VALUES (33, 10, 4, 40, 25176, 4);
INSERT INTO `detalles_compra` VALUES (34, 10, 3, 30, 25176, 5);
INSERT INTO `detalles_compra` VALUES (35, 8, 5, 40, 25177, 5);
INSERT INTO `detalles_compra` VALUES (36, 1231, 5, 6155, 25178, 4);
INSERT INTO `detalles_compra` VALUES (37, 100, 20, 2000, 25179, 4);

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
) ENGINE = InnoDB AUTO_INCREMENT = 109 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of detalles_de_venta
-- ----------------------------
INSERT INTO `detalles_de_venta` VALUES (15, 48, 2, 3, 31557);
INSERT INTO `detalles_de_venta` VALUES (16, 32, 2, 2, 45558);
INSERT INTO `detalles_de_venta` VALUES (17, 32, 2, 2, 96488);
INSERT INTO `detalles_de_venta` VALUES (18, 32, 2, 2, 96489);
INSERT INTO `detalles_de_venta` VALUES (19, 48, 2, 3, 96490);
INSERT INTO `detalles_de_venta` VALUES (20, 45, 1, 3, 96491);
INSERT INTO `detalles_de_venta` VALUES (21, 32, 2, 2, 96492);
INSERT INTO `detalles_de_venta` VALUES (22, 64, 2, 4, 96492);
INSERT INTO `detalles_de_venta` VALUES (23, 60, 1, 4, 96492);
INSERT INTO `detalles_de_venta` VALUES (24, 75, 1, 5, 96492);
INSERT INTO `detalles_de_venta` VALUES (25, 32, 2, 2, 96493);
INSERT INTO `detalles_de_venta` VALUES (26, 64, 2, 4, 96493);
INSERT INTO `detalles_de_venta` VALUES (27, 60, 1, 4, 96493);
INSERT INTO `detalles_de_venta` VALUES (28, 75, 1, 5, 96493);
INSERT INTO `detalles_de_venta` VALUES (29, 32, 2, 2, 96494);
INSERT INTO `detalles_de_venta` VALUES (30, 32, 2, 2, 96494);
INSERT INTO `detalles_de_venta` VALUES (31, 48, 2, 3, 96494);
INSERT INTO `detalles_de_venta` VALUES (32, 32, 2, 2, 96494);
INSERT INTO `detalles_de_venta` VALUES (33, 48, 2, 3, 96494);
INSERT INTO `detalles_de_venta` VALUES (34, 64, 2, 4, 96494);
INSERT INTO `detalles_de_venta` VALUES (35, 48, 2, 3, 96494);
INSERT INTO `detalles_de_venta` VALUES (36, 64, 2, 4, 96494);
INSERT INTO `detalles_de_venta` VALUES (37, 48, 2, 3, 96494);
INSERT INTO `detalles_de_venta` VALUES (38, 16, 2, 1, 96495);
INSERT INTO `detalles_de_venta` VALUES (39, 32, 2, 2, 96496);
INSERT INTO `detalles_de_venta` VALUES (40, 32, 2, 2, 96497);
INSERT INTO `detalles_de_venta` VALUES (41, 32, 2, 2, 96498);
INSERT INTO `detalles_de_venta` VALUES (42, 48, 2, 3, 96498);
INSERT INTO `detalles_de_venta` VALUES (43, 48, 2, 3, 96498);
INSERT INTO `detalles_de_venta` VALUES (44, 48, 2, 3, 96498);
INSERT INTO `detalles_de_venta` VALUES (45, 48, 2, 3, 96498);
INSERT INTO `detalles_de_venta` VALUES (46, 48, 2, 3, 96498);
INSERT INTO `detalles_de_venta` VALUES (47, 32, 2, 2, 96499);
INSERT INTO `detalles_de_venta` VALUES (48, 48, 2, 3, 96499);
INSERT INTO `detalles_de_venta` VALUES (49, 48, 2, 3, 96499);
INSERT INTO `detalles_de_venta` VALUES (50, 48, 2, 3, 96499);
INSERT INTO `detalles_de_venta` VALUES (51, 48, 2, 3, 96499);
INSERT INTO `detalles_de_venta` VALUES (52, 48, 2, 3, 96499);
INSERT INTO `detalles_de_venta` VALUES (53, 48, 2, 3, 96499);
INSERT INTO `detalles_de_venta` VALUES (54, 64, 2, 4, 96499);
INSERT INTO `detalles_de_venta` VALUES (55, 64, 2, 4, 96499);
INSERT INTO `detalles_de_venta` VALUES (56, 64, 2, 4, 96499);
INSERT INTO `detalles_de_venta` VALUES (57, 64, 2, 4, 96499);
INSERT INTO `detalles_de_venta` VALUES (58, 80, 2, 5, 96499);
INSERT INTO `detalles_de_venta` VALUES (59, 96, 2, 6, 96499);
INSERT INTO `detalles_de_venta` VALUES (60, 64, 2, 4, 96499);
INSERT INTO `detalles_de_venta` VALUES (61, 192, 2, 12, 96499);
INSERT INTO `detalles_de_venta` VALUES (62, 176, 2, 11, 96499);
INSERT INTO `detalles_de_venta` VALUES (63, 160, 2, 10, 96499);
INSERT INTO `detalles_de_venta` VALUES (64, 144, 2, 9, 96499);
INSERT INTO `detalles_de_venta` VALUES (65, 112, 2, 7, 96499);
INSERT INTO `detalles_de_venta` VALUES (66, 128, 2, 8, 96499);
INSERT INTO `detalles_de_venta` VALUES (67, 64, 2, 4, 96500);
INSERT INTO `detalles_de_venta` VALUES (68, 48, 2, 3, 96501);
INSERT INTO `detalles_de_venta` VALUES (69, 64, 2, 4, 96502);
INSERT INTO `detalles_de_venta` VALUES (70, 48, 2, 3, 96502);
INSERT INTO `detalles_de_venta` VALUES (71, 48, 2, 3, 96502);
INSERT INTO `detalles_de_venta` VALUES (72, 48, 2, 3, 96502);
INSERT INTO `detalles_de_venta` VALUES (73, 48, 2, 3, 96502);
INSERT INTO `detalles_de_venta` VALUES (74, 32, 2, 2, 96502);
INSERT INTO `detalles_de_venta` VALUES (75, 48, 2, 3, 96502);
INSERT INTO `detalles_de_venta` VALUES (76, 32, 2, 2, 96503);
INSERT INTO `detalles_de_venta` VALUES (77, 32, 2, 2, 96504);
INSERT INTO `detalles_de_venta` VALUES (78, 160, 2, 10, 96505);
INSERT INTO `detalles_de_venta` VALUES (79, 160, 2, 10, 96506);
INSERT INTO `detalles_de_venta` VALUES (80, 160, 1, 10, 96507);
INSERT INTO `detalles_de_venta` VALUES (81, 160, 2, 10, 96508);
INSERT INTO `detalles_de_venta` VALUES (82, 160, 2, 10, 96509);
INSERT INTO `detalles_de_venta` VALUES (83, 60, 1, 4, 96510);
INSERT INTO `detalles_de_venta` VALUES (84, 45, 1, 3, 96511);
INSERT INTO `detalles_de_venta` VALUES (85, 60, 1, 4, 96512);
INSERT INTO `detalles_de_venta` VALUES (86, 60, 1, 4, 96513);
INSERT INTO `detalles_de_venta` VALUES (87, 60, 1, 4, 96514);
INSERT INTO `detalles_de_venta` VALUES (88, 60, 1, 4, 96515);
INSERT INTO `detalles_de_venta` VALUES (89, 60, 1, 4, 96516);
INSERT INTO `detalles_de_venta` VALUES (90, 60, 1, 4, 96517);
INSERT INTO `detalles_de_venta` VALUES (91, 60, 1, 4, 96518);
INSERT INTO `detalles_de_venta` VALUES (92, 60, 1, 4, 96519);
INSERT INTO `detalles_de_venta` VALUES (93, 10, 4, 1, 96520);
INSERT INTO `detalles_de_venta` VALUES (94, 60, 1, 4, 96521);
INSERT INTO `detalles_de_venta` VALUES (95, 60, 1, 4, 96522);
INSERT INTO `detalles_de_venta` VALUES (96, 30, 4, 3, 96523);
INSERT INTO `detalles_de_venta` VALUES (97, 30, 4, 3, 96525);
INSERT INTO `detalles_de_venta` VALUES (98, 110, 4, 11, 96526);
INSERT INTO `detalles_de_venta` VALUES (99, 110, 5, 11, 96527);
INSERT INTO `detalles_de_venta` VALUES (100, 30, 5, 3, 96528);
INSERT INTO `detalles_de_venta` VALUES (101, 10, 5, 1, 96529);
INSERT INTO `detalles_de_venta` VALUES (102, 48, 2, 3, 96530);
INSERT INTO `detalles_de_venta` VALUES (103, 40, 4, 4, 96533);
INSERT INTO `detalles_de_venta` VALUES (104, 64, 2, 4, 96534);
INSERT INTO `detalles_de_venta` VALUES (105, 30, 5, 3, 96535);
INSERT INTO `detalles_de_venta` VALUES (106, 40, 5, 4, 96536);
INSERT INTO `detalles_de_venta` VALUES (107, 100, 4, 10, 96537);
INSERT INTO `detalles_de_venta` VALUES (108, 20, 5, 2, 96539);

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
) ENGINE = InnoDB AUTO_INCREMENT = 12 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of producto
-- ----------------------------
INSERT INTO `producto` VALUES (1, 'arroz', 15, 0);
INSERT INTO `producto` VALUES (2, 'frijoles', 16, 0);
INSERT INTO `producto` VALUES (4, 'aceite', 10, 5);
INSERT INTO `producto` VALUES (5, 'gaseosa', 10, 1);
INSERT INTO `producto` VALUES (8, 'maseca', 10, 0);
INSERT INTO `producto` VALUES (9, 'avena', 6, 0);
INSERT INTO `producto` VALUES (10, 'Azucar', 15, 0);
INSERT INTO `producto` VALUES (11, 'pasta', 15, 0);

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
INSERT INTO `proveedores` VALUES ('5', 'ihbkhbh', 'hbbbhbh', 'bbbb');

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
INSERT INTO `proveedores_correo` VALUES ('5', 3);
INSERT INTO `proveedores_correo` VALUES ('5', 6);

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
INSERT INTO `proveedores_telefono` VALUES ('5', 59);

-- ----------------------------
-- Table structure for telefonos
-- ----------------------------
DROP TABLE IF EXISTS `telefonos`;
CREATE TABLE `telefonos`  (
  `codigo_telefono` int(11) NOT NULL AUTO_INCREMENT,
  `numero_telefono` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_telefono`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 55569 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of telefonos
-- ----------------------------
INSERT INTO `telefonos` VALUES (55, '57447776');
INSERT INTO `telefonos` VALUES (57, '54878969');
INSERT INTO `telefonos` VALUES (59, 'hjjhjf');
INSERT INTO `telefonos` VALUES (60, '464545654546');
INSERT INTO `telefonos` VALUES (55557, 'vvvvvvvvvvvv');
INSERT INTO `telefonos` VALUES (55560, '545453355');
INSERT INTO `telefonos` VALUES (55561, 'gjjvgjvg');
INSERT INTO `telefonos` VALUES (55563, '345235');
INSERT INTO `telefonos` VALUES (55564, '232324135135');
INSERT INTO `telefonos` VALUES (55565, '435634');
INSERT INTO `telefonos` VALUES (55566, '345235');
INSERT INTO `telefonos` VALUES (55567, '2342341243');
INSERT INTO `telefonos` VALUES (55568, '234356');

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
  `ID_Usuario` int(2) NOT NULL AUTO_INCREMENT,
  `Nombre_Usuario` varchar(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `Clave` varchar(12) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ID_Usuario`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 24 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of usuario
-- ----------------------------
INSERT INTO `usuario` VALUES (1, 'Jester', '1234');
INSERT INTO `usuario` VALUES (2, 'Jesterws', 'Jester2$d');
INSERT INTO `usuario` VALUES (3, 'Jesterws', 'Jester2$d');
INSERT INTO `usuario` VALUES (4, 'Jesterlopez', 'J3$jdhjla');
INSERT INTO `usuario` VALUES (5, 'JesterLopez', 'Jester2#j');
INSERT INTO `usuario` VALUES (6, 'JesterLopezz', '1\"Jester');
INSERT INTO `usuario` VALUES (8, 'Jester', 'Lopez1#h');
INSERT INTO `usuario` VALUES (12, 'Jester', 'Lopez1#h');
INSERT INTO `usuario` VALUES (13, 'Jester', 'Lopez12#');
INSERT INTO `usuario` VALUES (14, 'bdfbd', '2!dasaDd');
INSERT INTO `usuario` VALUES (15, 'terter', '1\"ghsFkj');
INSERT INTO `usuario` VALUES (16, 'gdfgdfg', 'sdsfs1\"D');
INSERT INTO `usuario` VALUES (17, 'gerger', 'jJ2#hdsdf');
INSERT INTO `usuario` VALUES (18, 'Jester', 'Jester1\"');
INSERT INTO `usuario` VALUES (19, 'Jester', 'Jeter1\"3');
INSERT INTO `usuario` VALUES (20, 'Jestert', 'Jester6%');
INSERT INTO `usuario` VALUES (21, 'asfasfas', 'Jeste3#e');
INSERT INTO `usuario` VALUES (22, 'Jesterds', 'Jester1\"3');
INSERT INTO `usuario` VALUES (23, 'holvert', 'Holvert2018$');

-- ----------------------------
-- Table structure for ventas
-- ----------------------------
DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas`  (
  `codigo_venta` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` datetime NULL DEFAULT NULL,
  `precio_total` int(10) NULL DEFAULT NULL,
  `fecha_pago` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`codigo_venta`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 96540 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of ventas
-- ----------------------------
INSERT INTO `ventas` VALUES (31557, '2018-11-20 16:22:37', 48, '2010-03-23 06:00:00');
INSERT INTO `ventas` VALUES (36888, '2018-11-20 16:42:31', 32, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (45558, '2018-11-20 16:23:13', 32, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96488, '2018-11-20 16:46:51', 32, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96489, '2018-11-20 17:15:27', 32, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96490, '2018-11-20 17:23:41', 48, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96491, '2018-11-20 17:42:15', 45, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96492, '2018-11-20 17:50:53', 231, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96493, '2018-11-20 17:51:18', 231, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96494, '2018-11-20 18:52:25', 416, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96495, '2018-11-20 18:54:19', 16, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96496, '2018-11-20 19:03:34', 32, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96497, '2018-11-20 19:03:50', 32, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96498, '2018-11-20 19:04:52', 272, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96499, '2018-11-20 19:06:51', 1728, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96500, '2018-11-20 20:04:16', 64, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96501, '2018-11-20 20:07:07', 48, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96502, '2018-11-20 20:08:44', 336, '2018-12-05 06:00:00');
INSERT INTO `ventas` VALUES (96503, '2018-11-22 10:27:23', 32, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96504, '2018-11-22 10:30:48', 32, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96505, '2018-11-22 16:09:39', 160, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96506, '2018-11-22 16:09:58', 160, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96507, '2018-11-22 16:26:49', 160, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96508, '2018-11-22 16:29:48', 160, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96509, '2018-11-22 16:30:58', 160, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96510, '2018-11-22 16:34:53', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96511, '2018-11-22 16:37:06', 45, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96512, '2018-11-22 16:40:22', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96513, '2018-11-22 16:40:26', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96514, '2018-11-22 16:40:28', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96515, '2018-11-22 16:40:31', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96516, '2018-11-22 16:40:33', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96517, '2018-11-22 18:48:35', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96518, '2018-11-22 18:48:39', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96519, '2018-11-22 18:48:42', 60, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96520, '2018-11-22 18:48:50', 70, '2018-12-07 06:00:00');
INSERT INTO `ventas` VALUES (96521, '2018-11-23 16:58:48', 60, '2018-12-08 06:00:00');
INSERT INTO `ventas` VALUES (96522, '2018-11-23 16:59:05', 90, '2018-12-08 06:00:00');
INSERT INTO `ventas` VALUES (96523, '2018-11-23 16:59:10', 90, '2018-12-08 06:00:00');
INSERT INTO `ventas` VALUES (96524, '2018-11-23 17:18:03', 15, '2018-12-08 06:00:00');
INSERT INTO `ventas` VALUES (96525, '2018-11-23 23:04:24', 90, '2018-12-08 06:00:00');
INSERT INTO `ventas` VALUES (96526, '2018-11-24 09:27:20', 210, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96527, '2018-11-24 09:44:54', 110, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96528, '2018-11-24 09:46:11', 30, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96529, '2018-11-24 09:48:55', 10, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96530, '2018-11-24 09:51:01', 48, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96531, '2018-11-24 09:52:33', 48, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96532, '2018-11-24 09:54:20', 10, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96533, '2018-11-24 11:31:56', 40, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96534, '2018-11-24 11:48:35', 64, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96535, '2018-11-24 11:50:32', 30, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96536, '2018-11-24 11:53:37', 40, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96537, '2018-11-24 12:04:54', 120, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96538, '2018-11-24 12:06:14', 100, '2018-12-09 06:00:00');
INSERT INTO `ventas` VALUES (96539, '2018-11-24 12:08:34', 20, '2018-12-09 06:00:00');

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
INSERT INTO `ventas_clientes_credito` VALUES (96524, '1');
INSERT INTO `ventas_clientes_credito` VALUES (96531, '1');
INSERT INTO `ventas_clientes_credito` VALUES (96538, '1');
INSERT INTO `ventas_clientes_credito` VALUES (96490, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96495, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96496, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96497, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96498, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96499, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96500, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96501, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96505, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96506, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96521, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96522, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96523, '444445454');
INSERT INTO `ventas_clientes_credito` VALUES (96532, '534-343646-34632');
INSERT INTO `ventas_clientes_credito` VALUES (96491, 'kjhgsnjln');
INSERT INTO `ventas_clientes_credito` VALUES (96493, 'kjhgsnjln');
INSERT INTO `ventas_clientes_credito` VALUES (96494, 'kjhgsnjln');
INSERT INTO `ventas_clientes_credito` VALUES (96502, 'kjhgsnjln');
INSERT INTO `ventas_clientes_credito` VALUES (96539, 'kjhgsnjln');

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
INSERT INTO `ventas_tipo` VALUES (96490, 1);
INSERT INTO `ventas_tipo` VALUES (96491, 1);
INSERT INTO `ventas_tipo` VALUES (96493, 1);
INSERT INTO `ventas_tipo` VALUES (96494, 1);
INSERT INTO `ventas_tipo` VALUES (96495, 1);
INSERT INTO `ventas_tipo` VALUES (96496, 1);
INSERT INTO `ventas_tipo` VALUES (96497, 1);
INSERT INTO `ventas_tipo` VALUES (96498, 1);
INSERT INTO `ventas_tipo` VALUES (96499, 1);
INSERT INTO `ventas_tipo` VALUES (96500, 1);
INSERT INTO `ventas_tipo` VALUES (96501, 1);
INSERT INTO `ventas_tipo` VALUES (96502, 1);
INSERT INTO `ventas_tipo` VALUES (96505, 1);
INSERT INTO `ventas_tipo` VALUES (96506, 1);
INSERT INTO `ventas_tipo` VALUES (96521, 1);
INSERT INTO `ventas_tipo` VALUES (96522, 1);
INSERT INTO `ventas_tipo` VALUES (96523, 1);
INSERT INTO `ventas_tipo` VALUES (96524, 1);
INSERT INTO `ventas_tipo` VALUES (96531, 1);
INSERT INTO `ventas_tipo` VALUES (96532, 1);
INSERT INTO `ventas_tipo` VALUES (96538, 1);
INSERT INTO `ventas_tipo` VALUES (96539, 1);
INSERT INTO `ventas_tipo` VALUES (31557, 2);
INSERT INTO `ventas_tipo` VALUES (45558, 2);
INSERT INTO `ventas_tipo` VALUES (96488, 2);
INSERT INTO `ventas_tipo` VALUES (96489, 2);
INSERT INTO `ventas_tipo` VALUES (96492, 2);
INSERT INTO `ventas_tipo` VALUES (96503, 2);
INSERT INTO `ventas_tipo` VALUES (96504, 2);
INSERT INTO `ventas_tipo` VALUES (96507, 2);
INSERT INTO `ventas_tipo` VALUES (96508, 2);
INSERT INTO `ventas_tipo` VALUES (96509, 2);
INSERT INTO `ventas_tipo` VALUES (96510, 2);
INSERT INTO `ventas_tipo` VALUES (96511, 2);
INSERT INTO `ventas_tipo` VALUES (96512, 2);
INSERT INTO `ventas_tipo` VALUES (96513, 2);
INSERT INTO `ventas_tipo` VALUES (96514, 2);
INSERT INTO `ventas_tipo` VALUES (96515, 2);
INSERT INTO `ventas_tipo` VALUES (96516, 2);
INSERT INTO `ventas_tipo` VALUES (96517, 2);
INSERT INTO `ventas_tipo` VALUES (96518, 2);
INSERT INTO `ventas_tipo` VALUES (96519, 2);
INSERT INTO `ventas_tipo` VALUES (96520, 2);
INSERT INTO `ventas_tipo` VALUES (96525, 2);
INSERT INTO `ventas_tipo` VALUES (96526, 2);
INSERT INTO `ventas_tipo` VALUES (96527, 2);
INSERT INTO `ventas_tipo` VALUES (96528, 2);
INSERT INTO `ventas_tipo` VALUES (96529, 2);
INSERT INTO `ventas_tipo` VALUES (96530, 2);
INSERT INTO `ventas_tipo` VALUES (96533, 2);
INSERT INTO `ventas_tipo` VALUES (96534, 2);
INSERT INTO `ventas_tipo` VALUES (96535, 2);
INSERT INTO `ventas_tipo` VALUES (96536, 2);
INSERT INTO `ventas_tipo` VALUES (96537, 2);

-- ----------------------------
-- View structure for factura
-- ----------------------------
DROP VIEW IF EXISTS `factura`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `factura` AS SELECT ventas.codigo_venta,descripcion,precio_unitario,cantidad,sub_total,fecha,clientes_credito.cedula,nombre,apellido,direccion,tipo
FROM producto,detalles_de_venta,ventas_clientes_credito,ventas,clientes_credito,tipo_venta,ventas_tipo
WHERE producto.codigo_producto=detalles_de_venta.codigo_producto
AND detalles_de_venta.codigo_venta=ventas.codigo_venta
AND ventas_clientes_credito.codigo_venta=ventas.codigo_venta
AND clientes_credito.cedula=ventas_clientes_credito.cedula 
AND ventas_tipo.codigo_tipoventa=tipo_venta.codigo_tipoventa
AND ventas.codigo_venta=ventas_tipo.codigo_venta ;

-- ----------------------------
-- View structure for factura_contado
-- ----------------------------
DROP VIEW IF EXISTS `factura_contado`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `factura_contado` AS SELECT ventas.codigo_venta,descripcion,precio_unitario,cantidad,sub_total,fecha,tipo
FROM producto,detalles_de_venta,ventas,tipo_venta,ventas_tipo
WHERE producto.codigo_producto=detalles_de_venta.codigo_producto
AND detalles_de_venta.codigo_venta=ventas.codigo_venta
AND ventas_tipo.codigo_tipoventa=tipo_venta.codigo_tipoventa
AND ventas.codigo_venta=ventas_tipo.codigo_venta 
AND ventas_tipo.codigo_tipoventa='2' ;

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
CREATE PROCEDURE `Agregar_Usuario`(IN `pNombre_usuario` varchar(15),IN `pClave` varchar(12))
BEGIN
	#Routine body goes here...
INSERT INTO usuario(Nombre_Usuario,Clave)
VALUES(pNombre_usuario,pClave);
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
CREATE PROCEDURE `editarproducto`(IN `pcodigo` integer,IN `pdescripcion` varchar(30))
BEGIN
	#Routine body goes here...
UPDATE producto set producto.descripcion=pdescripcion
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
CREATE PROCEDURE `nuevaventa`(IN `pfecha` datetime,IN `pfecha_pago` datetime,IN `ppreciototal` integer)
BEGIN
	#Routine body goes here...
	DECLARE x INT;
INSERT INTO ventas (fecha,precio_total) VALUES (pfecha,ppreciototal);
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
	SELECT ID_usuario INTO pRes FROM usuario
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

SET FOREIGN_KEY_CHECKS = 1;
