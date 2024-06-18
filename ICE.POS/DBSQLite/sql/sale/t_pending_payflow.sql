/*
Navicat SQLite Data Transfer

Source Server         : sale
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-10-28 16:19:39
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_pending_payflow
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_pending_payflow";
CREATE TABLE "t_pending_payflow" (
flow_id  integer PRIMARY KEY AUTOINCREMENT NOT NULL DEFAULT 1,
flow_no  varchar(30) DEFAULT null,
sale_amount  numeric(10,2) DEFAULT null,
pay_way  varchar(3) DEFAULT null,
pay_amount  numeric(10,2) DEFAULT null,
coin_type  varchar(5) DEFAULT null,
pay_name  varchar(50) DEFAULT null,
coin_rate  numeric(10,2) DEFAULT null,
convert_amt  numeric(10,2) DEFAULT null,
card_no  varchar(20) DEFAULT null,
memo  varchar(50) DEFAULT null,
oper_date  datetime DEFAULT null,
oper_id  varchar(6) DEFAULT null,
voucher_no  varchar(30) DEFAULT null,
branch_no  varchar(10),
pos_id  varchar(10),
sale_way  varchar(1),
vip_no  varchar(20) DEFAULT null
);