USE [SHAOCXDB]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*==============================================================*/ 
/* Table: UserInfo				                   */ 
/* Description: �û���									    */ 
/* Author: shaocx												*/ 
/* createTime: 2018-9-10 19:37:42								    */ 
/*==============================================================*/ 
IF NOT EXISTS( SELECT 1 FROM SYSOBJECTS  WHERE ID = OBJECT_ID('UserInfo') AND TYPE = 'U') 
create table UserInfo ( 
   ID			   int       identity(1,1)  not null,-- ����(������) 
    
   Age    INT   NOT NULL , -- ����
   Email    NVARCHAR(50)   NOT NULL , -- ����
   SName    NVARCHAR(50)    NULL , -- ����
  
   constraint PK_UserInfo primary key (id)  
) 
GO 
 



/*==============================================================*/ 
/* Table: OrderInfo				                   */ 
/* Description: �������									    */ 
/* Author: shaocx												*/ 
/* createTime: 2018-11-22 22:33:42								    */ 
/*==============================================================*/ 
IF NOT EXISTS( SELECT 1 FROM SYSOBJECTS  WHERE ID = OBJECT_ID('OrderInfo') AND TYPE = 'U') 
create table OrderInfo ( 
   ID			   int       identity(1,1)  not null,-- ����(������) 
    
   taskNo    NVARCHAR(50)    NOT NULL , -- ����ID
  
   constraint PK_OrderInfo primary key (id)  
) 
GO 
 
