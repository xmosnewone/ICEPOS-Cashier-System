/*
Navicat SQLite Data Transfer

Source Server         : ssis_item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-08-05 14:04:11
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_rm_plan_rule
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_rm_plan_rule";
CREATE TABLE t_rm_plan_rule(
rule_no varchar(2) NOT NULL,
range_flag varchar(1) NOT NULL,
rule_describe varchar(200) NOT NULL,
rule_condition varchar(100) NULL,
rule_result varchar(100) NOT NULL,
plu_flag varchar(1) NOT NULL,
constraint PK_T_RM_PLAN_RULE primary key(rule_no,range_flag)
);
