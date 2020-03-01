USE [Database_Name]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[YOUR_TABLE_NAME](
	[RecordSerial] [int] IDENTITY(1,1) NOT NULL,
	[tID_file] [nvarchar](max) NULL,
	[Modal_file] [nvarchar](max) NULL,
	[ModalText_file] [nvarchar](max) NULL,
	[dWhen_file] [nvarchar](max) NULL,
	[Display_file] [nvarchar](max) NULL,
	[Interval_file] [nvarchar](max) NULL,
	[MinutesLabel_file] [nvarchar](max) NULL,
	[tIcon_file] [nvarchar](max) NULL,
	[RepeatCheck_file] [bit] NULL,
	[hForever_file] [bit] NULL,
	[Time_file] [nvarchar](max) NULL,
) 

GO


