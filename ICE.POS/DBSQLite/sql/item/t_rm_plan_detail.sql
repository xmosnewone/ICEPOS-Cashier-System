/*
Navicat SQLite Data Transfer

Source Server         : ssis_item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-08-05 14:04:28
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_rm_plan_detail
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_rm_plan_detail";
CREATE TABLE t_rm_plan_detail(
plan_no varchar(20) NOT NULL,
row_id numeric(14, 0) NOT NULL,
rule_para varchar(10) NOT NULL,
rule_val varchar(50) NULL,
constraint PK_T_RM_PLAN_MASTER primary key(plan_no,row_id,rule_para)
);
