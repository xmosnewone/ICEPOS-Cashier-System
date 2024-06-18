/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-08-26 15:53:14
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_bd_item_combsplit
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_bd_item_combsplit";
CREATE TABLE "t_bd_item_combsplit" (
"comb_item_no"  varchar(20) NOT NULL,
"item_no"  varchar(20) NOT NULL,
"item_qty"  decimal(16,4) NOT NULL,
"memo"  varchar(20),
"relation_px"  char(1),
PRIMARY KEY ("comb_item_no", "item_no")
);
