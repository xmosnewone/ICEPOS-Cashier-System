/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-09-16 10:31:35
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_sp_infos
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_sp_infos";
CREATE TABLE "t_sp_infos" (
"sp_no"  varchar(10) NOT NULL,
"sp_name"  varchar(120) NOT NULL,
PRIMARY KEY ("sp_no" ASC)
);
