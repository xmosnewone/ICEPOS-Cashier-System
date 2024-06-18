/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-11-06 13:07:11
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_handle
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_handle";
CREATE TABLE "t_handle" (
"handle_id"  INTEGER NOT NULL DEFAULT 0,
"t_base_code"  decimal(10) NOT NULL,
"t_base_code_type"  decimal(10) NOT NULL,
"t_bd_item_combsplit"  decimal(10) NOT NULL,
"t_operator"  decimal(10) NOT NULL,
"t_product_food"  decimal(10) NOT NULL,
"t_product_food_jg"  decimal(10) NOT NULL,
"t_product_food_kc"  decimal(10) NOT NULL,
"t_product_food_barcode"  decimal(10) NOT NULL,
"t_product_food_type"  decimal(10) NOT NULL,
"t_rm_plan_detail"  decimal(10) NOT NULL,
"t_rm_plan_master"  decimal(10) NOT NULL,
PRIMARY KEY ("handle_id")
);

-- ----------------------------
-- Records of t_handle
-- ----------------------------
INSERT INTO "main"."t_handle" VALUES (1, -1, -1, -1, -1, -1, -1,-1, -1,-1, -1, -1);
