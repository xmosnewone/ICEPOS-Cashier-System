/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:24
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_product_food_barcode
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_product_food_barcode";
CREATE TABLE "t_product_food_barcode" ("item_no" CHAR(20),
"item_barcode" CHAR(20) NOT NULL,
"num1" NUMERIC(14, 4),
"num2" NUMERIC(14, 4),
"num3" NUMERIC(14, 4),
"other1" VARCHAR(20),
"other2" VARCHAR(20),
"other3" VARCHAR(20),
"modify_date" TIMESTAMP,
PRIMARY KEY("item_barcode"));

-- ----------------------------
-- Indexes structure for table t_product_food_barcode
-- ----------------------------
CREATE INDEX "main"."esales_product_food_barcode_item_no"
ON "t_product_food_barcode" ("item_no" ASC);
