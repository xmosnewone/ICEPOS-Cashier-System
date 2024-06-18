/*
Navicat SQLite Data Transfer

Source Server         : ssis_item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-08-05 14:04:21
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_rm_plan_master
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_rm_plan_master";
CREATE TABLE t_rm_plan_master(
plan_no varchar(20) NOT NULL,
plan_name varchar(50) NOT NULL,
plan_memo varchar(200) NOT NULL,
begin_date datetime NOT NULL,
end_date datetime NOT NULL,
week varchar(7) NOT NULL,
vip_type varchar(6) NULL,
oper_date datetime NOT NULL,
oper_man varchar(6) NULL,
confirm_date datetime NULL,
confirm_man varchar(6) NULL,
stop_date datetime NULL,
stop_man varchar(6) NULL,
approve_flag varchar(1) NOT NULL,
rule_no varchar(2) NOT NULL,
range_flag varchar(1) NOT NULL,
constraint PK_T_RM_PLAN_MASTER primary key(plan_no)
);
