/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:58:57
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_base_code
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_base_code";
CREATE TABLE "t_base_code" (
"type_no"  varchar(2) NOT NULL,
"code_id"  varchar(4) NOT NULL,
"code_name"  varchar(30),
"english_name"  varchar(20),
"code_type"  varchar(20),
"memo"  varchar(255),
PRIMARY KEY ("type_no" ASC, "code_id" ASC)
);
