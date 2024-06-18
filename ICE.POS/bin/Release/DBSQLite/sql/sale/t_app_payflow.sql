/*
Navicat SQLite Data Transfer

Source Server         : sale
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:41
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_app_payflow
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_app_payflow";
CREATE TABLE t_app_payflow (
id                   integer                        not null default null,
flow_id              integer                         default null,
flow_no              varchar(30)                     default null,
sale_amount          numeric(10,2)                   default null,
pay_way              varchar(3)                      default null,
pay_amount           numeric(10,2)                   default null,
coin_type            varchar(5)                      default null,
pay_name             varchar(50)                     default null,
coin_rate            numeric(10,4)                   default null,
convert_amt          numeric(10,2)                   default null,
card_no              varchar(20)                     default null,
memo                 varchar(50)                     default null,
oper_date            datetime                        default null,
oper_id              varchar(6)                      default null,
voucher_no           varchar(30)                     default null,
branch_no            varchar(10),
pos_id               varchar(10),
sale_way             varchar(1),
com_flag             varchar(1)						 default '0',
vip_no			     varchar(20)					 default null,
primary key (id)
);
