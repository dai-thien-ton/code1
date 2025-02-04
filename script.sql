USE [multichat]
GO
/****** Object:  Table [dbo].[dataTaikhoan]    Script Date: 7/5/2024 6:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dataTaikhoan](
	[Ip] [nchar](20) NOT NULL,
	[Taikhoan] [nchar](10) NULL,
	[Matkhau] [nchar](10) NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[Ip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dataTaikhoan] ([Ip], [Taikhoan], [Matkhau]) VALUES (N'127.0.0.1           ', N'admin     ', N'admin     ')
INSERT [dbo].[dataTaikhoan] ([Ip], [Taikhoan], [Matkhau]) VALUES (N'127.0.0.2           ', N'user      ', N'user      ')
INSERT [dbo].[dataTaikhoan] ([Ip], [Taikhoan], [Matkhau]) VALUES (N'127.0.0.3           ', N'name      ', N'1234      ')
INSERT [dbo].[dataTaikhoan] ([Ip], [Taikhoan], [Matkhau]) VALUES (N'127.0.0.4           ', N'admin1    ', N'1234      ')
INSERT [dbo].[dataTaikhoan] ([Ip], [Taikhoan], [Matkhau]) VALUES (N'127.0.0.5           ', N'admin0    ', N'1234      ')
INSERT [dbo].[dataTaikhoan] ([Ip], [Taikhoan], [Matkhau]) VALUES (N'127.0.0.6           ', N'use       ', N'1234      ')
GO
/****** Object:  StoredProcedure [dbo].[SP_DKTaikhoan]    Script Date: 7/5/2024 6:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DKTaikhoan]
@Ip nchar(20),
@Taikhoan nchar(10),
@Matkhau nchar(10)
as 
begin
 insert into dataTaikhoan values (@Ip, @Taikhoan, @Matkhau)
 end
GO
/****** Object:  StoredProcedure [dbo].[SP_DoiMK]    Script Date: 7/5/2024 6:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DoiMK]
@Taikhoan nchar(10),
@Matkhau nchar(10)
as 
begin
 update dataTaikhoan set
 Matkhau = @Matkhau
 where Taikhoan = @Taikhoan
 end
GO
/****** Object:  StoredProcedure [dbo].[SP_Taikhoan]    Script Date: 7/5/2024 6:27:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_Taikhoan]
@Ip nchar(20),
@Taikhoan nchar(10),
@Matkhau nchar(10)
as 
begin
 insert into Taikhoan values (@Ip, @Taikhoan, @Matkhau)
 end
GO
