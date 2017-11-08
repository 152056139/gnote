/*
Navicat MySQL Data Transfer

Source Server         : abc
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : gnote

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-11-06 10:21:37
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for label
-- ----------------------------
DROP TABLE IF EXISTS `label`;
CREATE TABLE `label` (
  `label_no` int(11) NOT NULL AUTO_INCREMENT,
  `label_name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`label_no`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of label
-- ----------------------------
INSERT INTO `label` VALUES ('1', '第一个标签');
INSERT INTO `label` VALUES ('2', '第二个');
INSERT INTO `label` VALUES ('3', '第三个');
INSERT INTO `label` VALUES ('4', '第四个');
INSERT INTO `label` VALUES ('5', 'wu');
INSERT INTO `label` VALUES ('6', '刘');
INSERT INTO `label` VALUES ('7', '发射点发射');

-- ----------------------------
-- Table structure for note
-- ----------------------------
DROP TABLE IF EXISTS `note`;
CREATE TABLE `note` (
  `note_no` int(11) NOT NULL AUTO_INCREMENT,
  `note_name` varchar(255) DEFAULT NULL,
  `note_create_time` datetime DEFAULT NULL,
  `note_modify_time` datetime DEFAULT NULL,
  `note_has_delete` int(11) DEFAULT NULL,
  `notebook_no` int(11) DEFAULT NULL,
  `note_content` text,
  PRIMARY KEY (`note_no`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of note
-- ----------------------------
INSERT INTO `note` VALUES ('6', '无标题笔记本', '2017-11-05 15:38:19', '2017-11-05 15:38:19', '0', '23', '发射点发问额');
INSERT INTO `note` VALUES ('7', '无标题笔记本', '2017-11-05 15:41:26', '2017-11-05 15:41:26', '0', '23', '服务俄方万恶');
INSERT INTO `note` VALUES ('8', '无标题笔记本', '2017-11-05 15:41:29', '2017-11-05 15:41:29', '0', '23', '仿盛大范德萨');
INSERT INTO `note` VALUES ('9', '无标题笔记本', '2017-11-05 15:42:37', '2017-11-05 15:42:37', '0', '23', '');
INSERT INTO `note` VALUES ('10', '无标题笔记本', '2017-11-05 15:42:39', '2017-11-05 15:42:39', '0', '23', '');
INSERT INTO `note` VALUES ('11', '无标题笔记本', '2017-11-05 15:42:42', '2017-11-05 15:42:42', '0', '23', '');
INSERT INTO `note` VALUES ('12', '无标题笔记本', '2017-11-05 18:36:35', '2017-11-05 18:36:35', '0', '33', '');
INSERT INTO `note` VALUES ('13', '无标题笔记本', '2017-11-05 20:21:43', '2017-11-05 20:21:43', '0', '23', '');

-- ----------------------------
-- Table structure for notebook
-- ----------------------------
DROP TABLE IF EXISTS `notebook`;
CREATE TABLE `notebook` (
  `notebook_no` int(11) NOT NULL AUTO_INCREMENT,
  `notebook_name` varchar(255) DEFAULT NULL,
  `notebook_default` int(255) DEFAULT NULL,
  PRIMARY KEY (`notebook_no`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of notebook
-- ----------------------------
INSERT INTO `notebook` VALUES ('23', '我的第一个笔记本', '1');
INSERT INTO `notebook` VALUES ('29', '第二个', '0');
INSERT INTO `notebook` VALUES ('31', '厉害了', '0');
INSERT INTO `notebook` VALUES ('33', '孙大发手动阀首发式发生', '0');
