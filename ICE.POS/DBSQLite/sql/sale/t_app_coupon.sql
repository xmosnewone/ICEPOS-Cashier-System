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
-- Table structure for t_app_coupon
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_app_coupon";
CREATE TABLE t_app_coupon (
id                   integer                        not null default null,
flow_no              varchar(30)                     default null,
giftcert_no          varchar(30)                     default null,
gift_type            varchar(11)                     default '0',
branch_no          	 varchar(30)                     default null,
oper_uid           	 varchar(30)                   	default null,
oper_date            datetime                        default null,
com_flag             varchar(1)						 default '0',
primary key (id)
);
