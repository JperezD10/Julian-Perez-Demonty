USE [master]
GO
/****** Object:  Database [PreParcial]    Script Date: 23/09/2019 11:50:00 ******/
CREATE DATABASE [PreParcial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PreParcial', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQL_UAI\MSSQL\DATA\PreParcial.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PreParcial_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQL_UAI\MSSQL\DATA\PreParcial_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PreParcial] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PreParcial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PreParcial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PreParcial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PreParcial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PreParcial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PreParcial] SET ARITHABORT OFF 
GO
ALTER DATABASE [PreParcial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PreParcial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PreParcial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PreParcial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PreParcial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PreParcial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PreParcial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PreParcial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PreParcial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PreParcial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PreParcial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PreParcial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PreParcial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PreParcial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PreParcial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PreParcial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PreParcial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PreParcial] SET RECOVERY FULL 
GO
ALTER DATABASE [PreParcial] SET  MULTI_USER 
GO
ALTER DATABASE [PreParcial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PreParcial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PreParcial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PreParcial] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PreParcial] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PreParcial]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 23/09/2019 11:50:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[CodigoEmpleado] [nvarchar](10) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Puesto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[CodigoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Empleado] ([CodigoEmpleado], [Nombre], [Apellido], [Edad], [Sexo], [Direccion], [Puesto]) VALUES (N'2', N'asdasd', N'asdasd', 21, N'Masculino', N'ssadf', N'Gerente')
INSERT [dbo].[Empleado] ([CodigoEmpleado], [Nombre], [Apellido], [Edad], [Sexo], [Direccion], [Puesto]) VALUES (N'3', N'dasd', N'dasda', 21, N'Masculino', N'sdfas', N'Gerente')
INSERT [dbo].[Empleado] ([CodigoEmpleado], [Nombre], [Apellido], [Edad], [Sexo], [Direccion], [Puesto]) VALUES (N'330GER', N'dasd', N'dasda', 21, N'Masculino', N'sdfas', N'Gerente')
/****** Object:  StoredProcedure [dbo].[agregarEmpleado]    Script Date: 23/09/2019 11:50:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[agregarEmpleado]
@id_empleado nvarchar(50), @nombre nvarchar(50),@apellido nvarchar(50), @edad int, @sexo nvarchar(50), @direccion nvarchar(50), @puesto nvarchar(50)
as 
begin
insert into Empleado values (@id_empleado, @nombre, @apellido,@edad,@sexo,@direccion,@puesto)
end
GO
/****** Object:  StoredProcedure [dbo].[modificarEmpleado]    Script Date: 23/09/2019 11:50:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarEmpleado]
@id_empleado int, @nombre nvarchar(50),@apellido nvarchar(50), @edad int, @sexo nvarchar(50), @direccion nvarchar(50), @puesto nvarchar(50)
as begin
update Empleado set Nombre=@nombre,Apellido=@apellido,Edad=@edad,Sexo=@sexo,Direccion=@direccion,Puesto=@puesto
where CodigoEmpleado=@id_empleado
end
GO
USE [master]
GO
ALTER DATABASE [PreParcial] SET  READ_WRITE 
GO
