/*
Navicat SQLite Data Transfer

Source Server         : sale
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:59
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_pending_order
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_pending_order";
CREATE TABLE t_pending_order (
flow_no              varchar(30)                    not null default null,
sale_man             varchar(20)                     default null,     
pending_type         varchar(10)                    DEFAULT normal,
vip_no               varchar(20),
primary key (flow_no)
);
