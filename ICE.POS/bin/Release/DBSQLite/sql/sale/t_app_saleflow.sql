/*
Navicat SQLite Data Transfer

Source Server         : sale
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:46
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_app_saleflow
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_app_saleflow";
CREATE TABLE t_app_saleflow (
id                   integer                        not null default null,
flow_id              integer                         default null,
flow_no              varchar(30)                     default null,
item_no              varchar(20)                     default null,
unit_price           numeric(10,4)                   default null,
sale_price           numeric(10,4)                   default null,
sale_qnty            numeric(10,4)                   default null,
sale_money           numeric(10,4)                   default null,
sale_way             varchar(1)                      default 'n',
discount_rate        numeric(10,2)                   default 0,
oper_id              varchar(6)                      default null,
oper_date            datetime                        default null,
item_subno           varchar(30)                     default null,
item_clsno           varchar(6)                      default null,
item_name            varchar(60)                     default null,
item_status          varchar(1)                      default null,
item_subname         varchar(60)                     default null,
reasonid             integer,
branch_no            varchar(10),
pos_id               varchar(10),
com_flag             varchar(1)						 default '0',
price				numeric(16,4)					default null,
plan_no				varchar(30)						default null,
item_brand			varchar(30)						default null,
primary key (id)
);
