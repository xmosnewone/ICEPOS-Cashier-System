/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:33
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_sys_setting
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_sys_setting";
CREATE TABLE "t_sys_setting" (
"sys_var_id"  varchar(10) NOT NULL,
"sys_var_value"  varchar(100),
PRIMARY KEY ("sys_var_id")
);
