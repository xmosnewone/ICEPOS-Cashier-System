/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:02
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_base_code_type
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_base_code_type";
CREATE TABLE "t_base_code_type" (
"type_no"  varchar(2) NOT NULL,
"type_name"  varchar(255),
PRIMARY KEY ("type_no")
);
