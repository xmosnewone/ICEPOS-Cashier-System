/*
Navicat SQLite Data Transfer

Source Server         : sale
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-09-01 11:04:29
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_app_viplist
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_app_viplist";
CREATE TABLE "t_app_viplist" (
"flow_no"  char(20) NOT NULL,
"card_no"  char(20) NOT NULL,
"score"  decimal(16,4) NOT NULL,
"sale_amt"  decimal(16,4) NOT NULL,
"card_score"  decimal(16,4) NOT NULL DEFAULT 0,
"card_amount"  decimal(16,4) NOT NULL DEFAULT 0,
"oper_date"  datetime NOT NULL,
"voucher_no"  char(20),
"over_flag"  char(1) NOT NULL DEFAULT 0,
"com_flag"  char(1) DEFAULT 0,
PRIMARY KEY ("flow_no", "card_no")
);
