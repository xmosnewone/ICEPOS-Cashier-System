<div align="center">
    <p align="center">
        <img src="icepos.jpg" height="150" alt="logo"/>
    </p>
</div>

### ICEPOS开源收银系统


#### 软件介绍
国内为数不多的全代码开源收银软件，支持多门店，支持各种扫码设备和打印设备、钱箱等。支持微信刷卡支付（扫码收款接口）、支付宝刷卡支付（扫码收款接口）并支持更多自定义收款接口对接

#### 开源协议
开源协议遵循 Apache2.0。

版权所有 (c) 佛山市顺德区方程软件开发工作室 ，保留所有权利。

开源并不代表没版权，请个人、个体户、企业等机构组织使用本软件或用于其他商业用途，请保留"佛山市顺德区方程软件开发工作室"的版权，即保留license.txt，并写上含有"版权所有 (c)佛山市顺德区方程软件开发工作室"的字样。

允许在指定版本的源码基础上发展任何派生版本、修改版本或第三方版本用于重新分发，但必须遵守上面提到的版权信息标注！保留"佛山市顺德区方程软件开发工作室"的版权！

本软件或源代码不得用于开发违反国家有关政策的相关软件和应用，否则要自付法律责任！


#### 运行架构
PC端运行架构是C+S，C端（客户端）使用C#语言，移动端是VUE前端框架，S端(管理后台)使用PHP(Thinkphp框架)语言


#### 运行环境+安装教程

PC客户端， C# 运行环境: 至少安装有 Microsoft .NET Framework 2.0 或 4.5以上
（源代码编译时候可选.NET版本，请注意部分dll文件需要根据您选择运行的的.NET版本进行升级,例如:Lib文件夹下面的System.Data.SQLite.dll  SQLLite库）

移动端:自动适配Android或IOS各版本浏览器。适配微信小程序、百度小程序等

服务端:
       PHP >= 7.2 且 <= 7.4 (推荐PHP7.4版本)
       MySQL >= 5.6 且 <= 8.0 (需支持innodb引擎)
       Apache 或 Nginx

详细可参考官网安装文档地址:[环境安装](https://doc.icepos.cn/enviorment.html)

#### 使用说明
ICEPOS收银系统对服务器或电脑硬件要求不高,可以使用单台电脑/自建服务器/云服务器/虚拟主机做服务器。
资源有限个人或企业推荐单台收银机即可安装C#收银客户端+PHP服务端+管理后台。特别适合个体户小卖部/中小型超市的高性价比部署安装和使用！
不限操作人数，不限门店数量，不限安装数量，自由开发，数据安全。
用户操作手册请到官网下载:[用户手册Manu.pdf](https://doc.icepos.cn/userdocument.html)

#### 参考文档

ThinkPHP框架：http://www.thinkphp.cn

ThinkPHP 5.1手册：https://www.kancloud.cn/manual/thinkphp5_1/353946

C# 官方 https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp

Pear Admin （layui项目）http://www.pearadmin.com/

Layui 镜像站: https://layui.wc-os.com/

Layui 插件站: https://layui.wc-os.com/fly.layui.com/extend/index.html

jQuery https://jquery.com

Ueditor https://github.com/fex-team/ueditor


### 客户端运行截图

C# / PC端 营业员登录界面
<div align="center">
    <p align="center">
        <img src="asset/login.jpg" height="auto" alt="logo"/>
    </p>
</div>

营业员录入客户商品界面
<div align="center">
    <p align="center">
        <img src="asset/front1.jpg" height="auto" alt="logo"/>
    </p>
</div>
双屏显示模式--客户屏幕
<div align="center">
    <p align="center">
        <img src="asset/front2.jpg" height="auto" alt="logo"/>
    </p>
</div>
![Uploading front1.jpg…]()
