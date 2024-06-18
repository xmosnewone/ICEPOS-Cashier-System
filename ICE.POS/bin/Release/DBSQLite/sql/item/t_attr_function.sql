/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:57:38
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_attr_function
-- ----------------------------
DROP TABLE IF EXISTS t_attr_function;
CREATE TABLE "t_attr_function" (
"func_id"  varchar(4) NOT NULL,
"func_name"  varchar(20),
"func_udname"  varchar(20),
"pos_key"  varchar(10),
"flag"  varchar(1),
"type"  varchar(1),
"memo"  varchar(255),
"branch_no"  varchar(20),
"other1"  varchar(10),
PRIMARY KEY ("func_id" ASC)
);
