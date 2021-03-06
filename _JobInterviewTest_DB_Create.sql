USE [master]
GO

CREATE DATABASE [JobInterviewTest]
GO

USE [JobInterviewTest]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 05/21/2013 11:23:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL PRIMARY KEY,
	[OrderNumber] [varchar](50) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Total] [decimal](16, 2) NOT NULL,
	[Date] [datetime] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Orders] ([OrderId], [OrderNumber], [CustomerId], [Total], [Date]) VALUES (1, N'00001', 3, CAST(500.00 AS Decimal(16, 2)), CAST(0x0000A1B000000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [OrderNumber], [CustomerId], [Total], [Date]) VALUES (2, N'00002', 3, CAST(600.00 AS Decimal(16, 2)), CAST(0x0000A1BA00000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [OrderNumber], [CustomerId], [Total], [Date]) VALUES (3, N'00003', 1, CAST(1100.00 AS Decimal(16, 2)), CAST(0x0000A1BA00000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [OrderNumber], [CustomerId], [Total], [Date]) VALUES (4, N'00004', 1, CAST(1100.00 AS Decimal(16, 2)), CAST(0x0000A1BA00000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [OrderNumber], [CustomerId], [Total], [Date]) VALUES (5, N'00005', 3, CAST(700.00 AS Decimal(16, 2)), CAST(0x0000A1BC00000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [OrderNumber], [CustomerId], [Total], [Date]) VALUES (6, N'00006', 2, CAST(100.00 AS Decimal(16, 2)), CAST(0x0000A1C000000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [OrderNumber], [CustomerId], [Total], [Date]) VALUES (7, N'00007', 1, CAST(250.00 AS Decimal(16, 2)), CAST(0x0000A1C000000000 AS DateTime))

/****** Object:  Table [dbo].[Customers]    Script Date: 05/21/2013 11:23:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] NOT NULL PRIMARY KEY,
	[FirstNames] [varchar](255) NOT NULL,
	[Surname] [varchar](255) NOT NULL,
	[IdNumber] [varchar](255) NOT NULL,
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Customers] ([CustomerId], [FirstNames], [Surname], [IdNumber], [CellPhone]) VALUES (1, N'Bill', N'Gates', N'5001025079081', N'0831234567')
INSERT [dbo].[Customers] ([CustomerId], [FirstNames], [Surname], [IdNumber], [CellPhone]) VALUES (2, N'Steve', N'Jobs', N'6505245678012', N'0739876543')
INSERT [dbo].[Customers] ([CustomerId], [FirstNames], [Surname], [IdNumber], [CellPhone]) VALUES (3, N'Mark', N'Zuckerberg', N'8409085098034', N'0828459102')


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactId] [int] NOT NULL PRIMARY KEY,
	[CellPhone] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Address] [varchar](255) NOT NULL,
	[CustomerId] int,
    FOREIGN KEY [CustomerId] REFERENCES [dbo].[Customers] [CustomerId]
) ON [PRIMARY]
GO

CREATE PROCEDURE getCustomerInformation
AS
SELECT *
FROM [dbo].[Customers]  
JOIN [dbo].[Contacts]  
ON [dbo].[Customers].[CustomerId] = [dbo].[Contacts].[CustomerId]
GO;