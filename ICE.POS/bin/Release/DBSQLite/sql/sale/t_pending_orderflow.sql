/*
Navicat SQLite Data Transfer

Source Server         : sale
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 17:00:03
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_pending_orderflow
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_pending_orderflow";
CREATE TABLE t_pending_orderflow (
flow_id              integer                        not null default null,
flow_no              varchar(30)                    not null default null,
item_no              varchar(20)                     default null,
unit_price           numeric(4,10)                   default null,
sale_price           numeric(4,10)                   default null,
sale_qnty            numeric(4,10)                   default null,
sale_money           numeric(4,10)                   default null,
"discount_rate"        numeric(4,10)                   default 0,
oper_id              varchar(6)                      default null,
oper_date            datetime                        default null,
item_subno           varchar(30)                     default null,
item_clsno           varchar(6)                      default null,
item_name            varchar(60)                     default null,
item_status          varchar(1)                      default null,
item_subname         varchar(60)                     default null,
plan_no				varchar(30)						default null,
item_brand			varchar(30)						default null,
vip_acc_flag    	varchar(1)						default null,
primary key (flow_id, flow_no)
);
