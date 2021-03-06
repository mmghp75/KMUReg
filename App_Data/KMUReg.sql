USE [master]
GO
/****** Object:  Database [KMUReg]    Script Date: 7/23/2020 10:02:36 PM ******/
CREATE DATABASE [KMUReg]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KMUReg', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\KMUReg.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KMUReg_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\KMUReg_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KMUReg].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KMUReg] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KMUReg] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KMUReg] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KMUReg] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KMUReg] SET ARITHABORT OFF 
GO
ALTER DATABASE [KMUReg] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KMUReg] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KMUReg] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KMUReg] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KMUReg] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KMUReg] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KMUReg] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KMUReg] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KMUReg] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KMUReg] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KMUReg] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KMUReg] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KMUReg] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KMUReg] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KMUReg] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KMUReg] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KMUReg] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KMUReg] SET RECOVERY FULL 
GO
ALTER DATABASE [KMUReg] SET  MULTI_USER 
GO
ALTER DATABASE [KMUReg] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KMUReg] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KMUReg] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KMUReg] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KMUReg] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'KMUReg', N'ON'
GO
USE [KMUReg]
GO
/****** Object:  UserDefinedFunction [dbo].[MiladiTOShamsi]    Script Date: 7/23/2020 10:02:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[MiladiTOShamsi] (@Date  DateTime)  
RETURNS Varchar(20)
as  --  EHSAN RAVANPOUR 1386-06-31
begin
SET @Date = CAST(CONVERT(VARCHAR(20),@Date,111) AS DATETIME)
DECLARE @Farsi_Date  as Varchar(20) 
DECLARE @StY Varchar(10), @StM Varchar(10),@StD Varchar(10)
declare @y bigint, @m bigint, @d bigint
declare @d1 bigint, @d4 bigint, @d33 bigint

set @d1=365
set @d4=4*@d1 +1
set @d33=33*@d1 +8
set @d=cast(@Date as bigint)+422506
set @y=(@d/@d33)*33+122
set @d=@d % @d33
if(@d>(7*@d4+@d1))
Begin
   set @y=@y+1
   set @d=@d-@d1
End
set @y=@y+(@d/@d4)*4
set @d=@d % @d4
declare @i bigint
set @i=@d/@d1
set @d=@d%@d1;
if(@i=4)
Begin
   set @i=@i-1
   set @d=@d+@d1
End
set @y=@y+@i
if(@d<186)
Begin
   set @m=(@d/31)+1
   set @d=(@d%31)+1
end
Else
Begin
   set @d=@d-186
   set @m=(@d/30)+7
   set @d=(@d%30)+1
End
 SET @StY = CAST (@y as VarChar(5))
 SET @StM = RIGHT('0'+CAST (@m as VarChar(5)),2)
 SET @StD = RIGHT('0'+CAST (@d as VarChar(5)),2)
 SET @Farsi_Date = @StY+'/'+@StM+'/'+@StD
 Return @Farsi_Date
end





GO
/****** Object:  UserDefinedFunction [dbo].[ShamsiToMiladi]    Script Date: 7/23/2020 10:02:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[ShamsiToMiladi](@DATESTR VARCHAR(10))
RETURNS DATETIME
AS
BEGIN
  DECLARE @YEARSTR VARCHAR(4)
  DECLARE @MONSTR  VARCHAR(2)
  DECLARE @DAYSTR  VARCHAR(2)
  DECLARE @ACCPT   BIT
  DECLARE @bt      INT
  DECLARE @Ct      INT
  DECLARE @DT      DATETIME
  DECLARE @Std     INT

  SET @ACCPT=0
  IF LEN(@DATESTR)=8 SET @DATESTR='13'+@DATESTR
  IF LEN(@DATESTR)=10 
  BEGIN
    IF (SUBSTRING(@DATESTR,5,1)='/') AND (SUBSTRING(@DATESTR,8,1)='/') SET @ACCPT=1
    IF (SUBSTRING(@DATESTR,5,1)='-') AND (SUBSTRING(@DATESTR,8,1)='-') SET @ACCPT=1
  END

  IF @ACCPT=1
  BEGIN
    SET @YEARSTR=SUBSTRING(@DATESTR,1,4)
    SET @MONSTR =SUBSTRING(@DATESTR,6,2)
    SET @DAYSTR =SUBSTRING(@DATESTR,9,2)
    SET @YEARSTR=CAST(CAST(@YEARSTR AS INT)+621 AS VARCHAR(4))
    IF CAST(@YEARSTR AS INT)>1995 AND (CAST(@YEARSTR AS INT) % 4=0)
      SET @DT=@YEARSTR+'-03-20'
    ELSE
      SET @DT=@YEARSTR+'-03-21'
    SET @bt=CAST(@MONSTR AS INT);
    SET @ct=CAST(@DAYSTR AS INT);
    IF @bt <= 6 
      SET @std = (@bt-1)*31+@ct
    ELSE
      SET @std = (6*31)+(@bt-7)*30+@ct;
    SET @dt = @dt + CAST((@std - 1) AS DATETIME);
  END
  RETURN(@DT)

END


GO
/****** Object:  UserDefinedFunction [dbo].[UDF_Julian_To_Gregorian]    Script Date: 7/23/2020 10:02:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Secondly, convert Julian calendar date to Gregorian to achieve the target.
create FUNCTION [dbo].[UDF_Julian_To_Gregorian] (@jdn bigint)
Returns nvarchar(11)
as
Begin
    Declare @Jofst  as Numeric(18,2)
    Set @Jofst=2415020.5
    Return Convert(nvarchar(11),Convert(datetime,(@jdn- @Jofst),113),110)
End
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 7/23/2020 10:02:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstNameOf] [nvarchar](50) NOT NULL,
	[LastNameOf] [nvarchar](50) NOT NULL,
	[StartDateOf] [date] NULL,
	[EndDateOf] [date] NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[isInActive] [bit] NOT NULL,
	[AccessTypeOf] [int] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblUser] ON 
GO
INSERT [dbo].[tblUser] ([ID], [FirstNameOf], [LastNameOf], [StartDateOf], [EndDateOf], [UserName], [Password], [isInActive], [AccessTypeOf]) VALUES (1, N'محمدمهدی', N'قائمی', CAST(N'2000-01-01' AS Date), NULL, N'admin', N'100122', 0, 1)
GO
SET IDENTITY_INSERT [dbo].[tblUser] OFF
GO
ALTER TABLE [dbo].[tblUser] ADD  CONSTRAINT [DF_tblUser_isInActive]  DEFAULT ((0)) FOR [isInActive]
GO
ALTER TABLE [dbo].[tblUser] ADD  CONSTRAINT [DF_tblUser_TypeOf]  DEFAULT ((0)) FOR [AccessTypeOf]
GO
USE [master]
GO
ALTER DATABASE [KMUReg] SET  READ_WRITE 
GO
