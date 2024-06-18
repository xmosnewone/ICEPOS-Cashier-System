/*
Navicat SQLite Data Transfer

Source Server         : item
Source Server Version : 30714
Source Host           : :0

Target Server Type    : SQLite
Target Server Version : 30714
File Encoding         : 65001

Date: 2014-04-28 16:59:07
*/

PRAGMA foreign_keys = OFF;

-- ----------------------------
-- Table structure for t_branch_info
-- ----------------------------
DROP TABLE IF EXISTS "main"."t_branch_info";
CREATE TABLE "t_branch_info"(
        com_no numeric(3, 0) NULL,
	branch_no char(6) NOT NULL,
	branch_name varchar(30) NOT NULL,
	property char(1) NULL,
	branch_man varchar(16) NULL,
	address varchar(40) NULL,
	zip varchar(10) NULL,
	branch_email varchar(40) NULL,
	branch_tel varchar(18) NULL,
	branch_fax varchar(18) NULL,
	display_flag char(1) NOT NULL,
	other1 varchar(20) NULL,
	other2 varchar(20) NULL,
	other3 varchar(20) NULL,
	sheet_tag char(2) NULL,
	area numeric(10, 2) NULL,
	trade_type char(1) NULL,
	com_grant char(1) NULL,
	account char(1) NULL,
	com_init char(1) NULL,
	init_date datetime NULL,
	indep_bal char(1) NULL,
	dc_no char(6) NULL,
	com_date_up datetime NULL,
	com_date_down datetime NULL,
	com_oper_up char(4) NULL,
	com_oper_down char(4) NULL,
	check_flag char(1) NULL,
	check_sheet_no char(20) NULL,
	check_branch_no char(6) NULL,
	price_type char(1) NULL,
	price_rate numeric(8, 4) NULL,
	tran_flag char(20) NULL,
	oper_flag char(1) NULL,
	allow_cz char(1) NULL,
	order_num decimal(16, 4) NULL,
	branch_mj numeric(16, 4) NULL,
                         CONSTRAINT PK_T_BD_BRANCH_INFO PRIMARY KEY (branch_no)
                        );
