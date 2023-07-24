USE [SqlInjection]
GO
/****** Object:  Table [dbo].[user]    Script Date: 7/23/2023 6:26:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](24) NULL,
	[password] [nchar](24) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [username], [password]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[user] ([id], [username], [password]) VALUES (2, N'user', N'1234')
SET IDENTITY_INSERT [dbo].[user] OFF
GO
