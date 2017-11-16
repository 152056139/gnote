/*
Navicat MySQL Data Transfer

Source Server         : abc
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : gnote

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-11-16 21:01:17
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
INSERT INTO `label` VALUES ('4', '第四个');
INSERT INTO `label` VALUES ('5', 'wu');
INSERT INTO `label` VALUES ('7', '发射点发射');

-- ----------------------------
-- Table structure for nl
-- ----------------------------
DROP TABLE IF EXISTS `nl`;
CREATE TABLE `nl` (
  `note_no` int(11) DEFAULT NULL,
  `label_no` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of nl
-- ----------------------------
INSERT INTO `nl` VALUES ('14', '5');

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
  `note_text` varchar(21000) DEFAULT NULL,
  `note_content` varchar(255) DEFAULT NULL,
  `note_favourite` int(11) DEFAULT NULL,
  PRIMARY KEY (`note_no`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of note
-- ----------------------------
INSERT INTO `note` VALUES ('37', '无标题笔记本', '2017-11-11 10:05:25', '2017-11-14 17:55:26', '0', '23', '我的第一个笔记', '{\rtf1ansideff0{fonttbl{f0fnilfcharset134 \'cb\'ce\'cc\'e5;}}\r\nviewkind4uc1pardlang2052f0fs18\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a10\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1\'b0\'a1par\r\n}\r\n', '1');
INSERT INTO `note` VALUES ('38', 'c#', '2017-11-14 17:40:30', '2017-11-14 17:54:59', '0', '40', 'C#是微软公司发布的一种面向对象的、运行于.NET Framework之上的高级程序设计语言。并定于在微软职业开发者论坛(PDC)上登台亮相。C#是微软公司研究员Anders Hejlsberg的最新成果。C#看起来与Java有着惊人的相似；它包括了诸如单一继承、接口、与Java几乎同样的语法和编译成中间代码再运行的过程。但是C#与Java有着明显的不同，它借鉴了Delphi的一个特点，与COM（组件对象模型）是直接集成的，而且它是微软公司 .NET windows网络框架的主角。\nC#是一种安全的、稳定的、简单的、优雅的，由C和C++衍生出来的面向对象的编程语言。它在继承C和C++强大功能的同时去掉了一些它们的复杂特性（例如没有宏以及不允许多重继承）。C#综合了VB简单的可视化操作和C++的高运行效率，以其强大的操作能力、优雅的语法风格、创新的语言特性和便捷的面向组件编程的支持成为.NET开发的首选语言。[1] \nC#是面向对象的编程语言。它使得程序员可以快速地编写各种基于MICROSOFT .NET平台的应用程序，MICROSOFT .NET提供了一系列的工具和服务来最大程度地开发利用计算与通讯领域。\nC#使得C++程序员可以高效的开发程序，且因可调用由 C/C++ 编写的本机原生函数，因此绝不损失C/C++原有的强大的功能。因为这种继承关系，C#与C/C++具有极大的相似性，熟悉类似语言的开发者可以很快的转向C#。[2', '', '0');
INSERT INTO `note` VALUES ('39', '计算机', '2017-11-14 17:53:25', '2017-11-14 17:55:57', '0', '40', '计算机（computer）俗称电脑，是现代一种用于高速计算的电子计算机器，可以进行数值计算，又可以进行逻辑计算，还具有存储记忆功能。是能够按照程序运行，自动、高速处理海量数据的现代化智能电子设备。\n由硬件系统和软件系统所组成，没有安装任何软件的计算机称为裸机。可分为超级计算机、工业控制计算机、网络计算机、个人计算机、嵌入式计算机五类，较先进的计算机有生物计算机、光子计算机、量子计算机等。\n计算机发明者约翰·冯·诺依曼。计算机是20世纪最先进的科学技术发明之一，对人类的生产活动和社会活动产生了极其重要的影响，并以强大的生命力飞速发展。它的应用领域从最初的军事科研应用扩展到社会的各个领域，已形成了规模巨大的计算机产业，带动了全球范围的技术进步，由此引发了深刻的社会变革，计算机已遍及一般学校、企事业单位，进入寻常百姓家，成为信息社会中必不可少的工具。\n计算机的应用在中国越来越普遍，改革开放以后，中国计算机用户的数量不断攀升，应用水平不断提高，特别是互联网、通信、多媒体等领域的应用取得了不错的成绩。1996年至2009 年，计算机用户数量从原来的630万增长至6710 万台，联网计算机台数由原来的2.9万台上升至5940万台。互联网用户已经达到3.16 亿，无线互联网有6.7 亿移动用户，其中手机上网用户达1.17 亿，为全球第一位。', '', '0');
INSERT INTO `note` VALUES ('40', '数据结构', '2017-11-14 17:55:31', '2017-11-14 17:56:43', '0', '40', '名词定义\n数据结构是指相互之间存在着一种或多种关系的数据元素的集合和该集合中数据元素之间的关系组成。记为：\nData_Structure=(D,R)\n其中D是数据元素的集合，R是该集合中所有元素之间的关系的有限集合。[2] \n其它定义\nSartaj Sahni在他的《数据结构、算法与应用》一书中称：“数据结构是数据对象，以及存在于该对象的实例和组成实 例的数据元素之间的各种联系。这些联系可以通过定义相关的函数来给出。”他将数据对象（data object）定义为“一个数据对象是实例或值的集合”。\nClifford A.Shaffer在《数据结构与算法分析》一书中的定义是：“数据结构是ADT（抽象数据类型Abstract Data Type） 的物理实现。”\nRobert L.Kruse在《数据结构与程序设计》一书中，将一个数据结构的设计过程分成抽象层、数据结构层和实现层。其中，抽象层是指抽象数据类型层，它讨论数据的逻辑结构及其运算，数据结构层和实现层讨论一个数据结构的表示和在计算机内的存储细节以及运算的实现。\n数据结构具体指同一类数据元素中，各元素之间的相互关系，包括三个组成成分，数据的逻辑结构，数据的存储结构和数据运算结构。', '', '0');
INSERT INTO `note` VALUES ('41', '算法', '2017-11-14 17:57:01', '2017-11-14 17:57:25', '0', '40', '算法（Algorithm）是指解题方案的准确而完整的描述，是一系列解决问题的清晰指令，算法代表着用系统的方法描述解决问题的策略机制。也就是说，能够对一定规范的输入，在有限时间内获得所要求的输出。如果一个算法有缺陷，或不适合于某个问题，执行这个算法将不会解决这个问题。不同的算法可能用不同的时间、空间或效率来完成同样的任务。一个算法的优劣可以用空间复杂度与时间复杂度来衡量。\n算法中的指令描述的是一个计算，当其运行时能从一个初始状态和（可能为空的）初始输入开始，经过一系列有限而清晰定义的状态，最终产生输出并停止于一个终态。一个状态到另一个状态的转移不一定是确定的。随机化算法在内的一些算法，包含了一些随机输入。\n形式化算法的概念部分源自尝试解决希尔伯特提出的判定问题，并在其后尝试定义有效计算性或者有效方法中成形。这些尝试包括库尔特·哥德尔、Jacques Herbrand和斯蒂芬·科尔·克莱尼分别于1930年、1934年和1935年提出的递归函数，阿隆佐·邱奇于1936年提出的λ演算，1936年Emil Leon Post的Formulation 1和艾伦·图灵1937年提出的图灵机。即使在当前，依然常有直觉想法难以定义为形式化算法的情况。', '', '0');

-- ----------------------------
-- Table structure for notebook
-- ----------------------------
DROP TABLE IF EXISTS `notebook`;
CREATE TABLE `notebook` (
  `notebook_no` int(11) NOT NULL AUTO_INCREMENT,
  `notebook_name` varchar(255) DEFAULT NULL,
  `notebook_default` int(255) DEFAULT NULL,
  PRIMARY KEY (`notebook_no`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of notebook
-- ----------------------------
INSERT INTO `notebook` VALUES ('23', '我的第一个笔记本', '0');
INSERT INTO `notebook` VALUES ('40', '课堂笔记', '0');
INSERT INTO `notebook` VALUES ('41', '日记', '0');
INSERT INTO `notebook` VALUES ('42', '多看阅读', '0');
