/*
Navicat SQLite Data Transfer

Source Server         : sale
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 17:00:06
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_rm_pos_account
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_rm_pos_account";
CREATE TABLE t_rm_pos_account 
                   (flow_id integer primary key autoincrement,
                   branch_no  char(6)  not null,
                   pos_id  char(4)  not null,
                   oper_id  char(4)  not null,
                   oper_date  datetime null,
                   start_time  datetime null,
                   end_time  datetime null,
                   sale_amt  numeric(16,4) null default (0),
                   hand_amt  numeric(16,4) null default (0),
                   com_flag  char(1)  null default ('0'));
