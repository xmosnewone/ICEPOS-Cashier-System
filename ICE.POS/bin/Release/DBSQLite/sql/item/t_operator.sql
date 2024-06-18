/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:16
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_operator
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_operator";
CREATE TABLE "t_operator" (
"oper_id"  varchar(4) NOT NULL,
"oper_name"  varchar(10) NOT NULL,
"oper_pwd"  varchar(20),
"full_name"  varchar(10),
"oper_role"  varchar(10),
"oper_state"  varchar(8),
"branch_id"  varchar(12),
"last_date"  datetime,
"Oper_flag"  varchar(1),
"group_id"  varchar(1),
"cash_grant" varchar(40),
"discount_rate" numeric(4,10),
PRIMARY KEY ("oper_id" ASC, "oper_name" ASC)
);
