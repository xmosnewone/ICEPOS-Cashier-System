/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:12
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_dict_payment_info
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_dict_payment_info";
CREATE TABLE "t_dict_payment_info" 
(
   pay_way              varchar(8)                     not null,
   pay_flag             integer                        not null,
   pay_name             varchar(20)                    not null,
   rate                 decimal(6,2)                   null,
   pay_memo             varchar(100)                   null,
   PRIMARY KEY ("pay_way" ASC,"pay_flag" ASC)
);
