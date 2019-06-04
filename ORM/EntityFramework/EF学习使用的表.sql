USE [SHAOCXDB]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*==============================================================*/ 
/* Table: UserInfo				                   */ 
/* Description: 用户表									    */ 
/* Author: shaocx												*/ 
/* createTime: 2018-9-10 19:37:42								    */ 
/*==============================================================*/ 
IF NOT EXISTS( SELECT 1 FROM SYSOBJECTS  WHERE ID = OBJECT_ID('UserInfo') AND TYPE = 'U') 
create table UserInfo ( 
   ID			   int       identity(1,1)  not null,-- 主键(自增列) 
    
   Age    INT   NOT NULL , -- 年龄
   Email    NVARCHAR(50)   NOT NULL , -- 邮箱
   SName    NVARCHAR(50)    NULL , -- 姓名
  
   constraint PK_UserInfo primary key (id)  
) 
GO 
 



/*==============================================================*/ 
/* Table: OrderInfo				                   */ 
/* Description: 任务管理									    */ 
/* Author: shaocx												*/ 
/* createTime: 2018-11-22 22:33:42								    */ 
/*==============================================================*/ 
IF NOT EXISTS( SELECT 1 FROM SYSOBJECTS  WHERE ID = OBJECT_ID('OrderInfo') AND TYPE = 'U') 
create table OrderInfo ( 
   ID			   int       identity(1,1)  not null,-- 主键(自增列) 
    
   taskNo    NVARCHAR(50)    NOT NULL , -- 任务ID
  
   constraint PK_OrderInfo primary key (id)  
) 
GO 
 
