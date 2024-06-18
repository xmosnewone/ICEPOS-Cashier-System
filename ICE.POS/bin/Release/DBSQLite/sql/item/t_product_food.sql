/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-09-10 17:25:12
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_product_food
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_product_food";
CREATE TABLE "t_product_food" (
"item_no"  CHAR(20) NOT NULL,
"item_subno"  VARCHAR(15) NOT NULL,
"item_name"  VARCHAR(100),
"item_subname"  VARCHAR(50),
"item_clsno"  VARCHAR(12),
"item_brand"  VARCHAR(12),
"item_brandname"  CHAR(6),
"unit_no"  CHAR(4),
"item_size"  VARCHAR(20),
"product_area"  VARCHAR(18),
"price"  NUMERIC(9,4),
"sale_price"  NUMERIC(9,4),
"sale_price1"  NUMERIC(9,4),
"build_date"  TIMESTAMP,
"lastchange_time"  TIMESTAMP,
"status"  NUMERIC(5),
"stock"  NUMERIC(16,4) DEFAULT 0,
"stock_lasttime"  TIMESTAMP,
"main_supcust"  VARCHAR(20),
"images_ios"  TEXT,
"content"  TEXT,
"num2"  VARCHAR(5),
"num3"  NUMERIC(6,4),
"pifaopen"  NUMERIC(5) DEFAULT 0,
"images"  TEXT,
"appopen"  NUMERIC(5) DEFAULT 1,
"headimages"  VARCHAR(200),
"score"  VARCHAR(30),
"scorenum"  INTEGER,
"change_price"  char(1) DEFAULT 0,
"vip_acc_flag"  char(1) DEFAULT 0,
"scheme_price"  char(1) DEFAULT 0,
"vip_acc_num"  decimal(16,4),
"min_qty" decimal(16,4),
"max_qty" decimal(16,4),
PRIMARY KEY ("item_no" ASC)
);

-- ----------------------------
-- Indexes structure for table t_product_food
-- ----------------------------
CREATE INDEX "main"."esales_product_food_item_subno"
ON "t_product_food" ("item_subno" ASC);
