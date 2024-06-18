/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:29
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_product_food_type
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_product_food_type";
CREATE TABLE "t_product_food_type" ("typeno" VARCHAR(10) NOT NULL,
"typename" VARCHAR(50),
"parent" VARCHAR(10),
"last_refresh_time" VARCHAR(20),
"images_ios" VARCHAR(200),
"iosopen" NUMERIC(5) DEFAULT 1,
"pifaopen" NUMERIC(5) DEFAULT 0,
PRIMARY KEY("typeno"));

-- ----------------------------
-- Indexes structure for table t_product_food_type
-- ----------------------------
CREATE INDEX "main"."esales_product_food_type_parent"
ON "t_product_food_type" ("parent" ASC);
