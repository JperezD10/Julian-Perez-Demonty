USE [master]
GO
/****** Object:  Database [Parcial2LUG]    Script Date: 14/12/2019 16:19:29 ******/
CREATE DATABASE [Parcial2LUG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Parcial2LUG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Parcial2LUG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Parcial2LUG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Parcial2LUG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Parcial2LUG] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Parcial2LUG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Parcial2LUG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Parcial2LUG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Parcial2LUG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Parcial2LUG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Parcial2LUG] SET ARITHABORT OFF 
GO
ALTER DATABASE [Parcial2LUG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Parcial2LUG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Parcial2LUG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Parcial2LUG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Parcial2LUG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Parcial2LUG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Parcial2LUG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Parcial2LUG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Parcial2LUG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Parcial2LUG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Parcial2LUG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Parcial2LUG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Parcial2LUG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Parcial2LUG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Parcial2LUG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Parcial2LUG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Parcial2LUG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Parcial2LUG] SET RECOVERY FULL 
GO
ALTER DATABASE [Parcial2LUG] SET  MULTI_USER 
GO
ALTER DATABASE [Parcial2LUG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Parcial2LUG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Parcial2LUG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Parcial2LUG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Parcial2LUG] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Parcial2LUG', N'ON'
GO
ALTER DATABASE [Parcial2LUG] SET QUERY_STORE = OFF
GO
USE [Parcial2LUG]
GO
/****** Object:  Table [dbo].[Pasajero]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajero](
	[IDPasajero] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Pasajero] PRIMARY KEY CLUSTERED 
(
	[IDPasajero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[IDvehiculo] [int] NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[Modelo] [nvarchar](50) NOT NULL,
	[Patente] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[IDvehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viaje](
	[IDViaje] [int] NOT NULL,
	[IDvehiculo] [int] NOT NULL,
	[IDpasajero] [int] NOT NULL,
	[Destino] [nvarchar](50) NOT NULL,
	[Kilometro] [int] NOT NULL,
	[Importe] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Viaje] PRIMARY KEY CLUSTERED 
(
	[IDViaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Pasajero] ([IDPasajero], [Nombre], [Apellido], [Direccion]) VALUES (1, N'dasda', N'dasda', N'sdads')
INSERT [dbo].[Pasajero] ([IDPasajero], [Nombre], [Apellido], [Direccion]) VALUES (2, N'sdadas', N'ddddddddddd', N'ddddd')
INSERT [dbo].[Vehiculo] ([IDvehiculo], [Marca], [Modelo], [Patente]) VALUES (1, N'nissan', N'sentra', N'ABC232')
INSERT [dbo].[Vehiculo] ([IDvehiculo], [Marca], [Modelo], [Patente]) VALUES (2, N'fiat', N'500', N'FDS568')
INSERT [dbo].[Vehiculo] ([IDvehiculo], [Marca], [Modelo], [Patente]) VALUES (3, N'honda', N'civic', N'AB234C3')
INSERT [dbo].[Viaje] ([IDViaje], [IDvehiculo], [IDpasajero], [Destino], [Kilometro], [Importe], [Fecha]) VALUES (1, 3, 2, N'bahia blanca', 21, 840, CAST(N'2019-12-17T16:12:22.000' AS DateTime))
INSERT [dbo].[Viaje] ([IDViaje], [IDvehiculo], [IDpasajero], [Destino], [Kilometro], [Importe], [Fecha]) VALUES (2, 1, 2, N'sdfas', 577, 23080, CAST(N'2019-12-18T16:12:22.000' AS DateTime))
/****** Object:  StoredProcedure [dbo].[CargarViaje]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarViaje]
@id int,@idvehiculo int,@idpasajero int,@destino nvarchar(50),@kilometro int, @importe int,@fechaviaje datetime
as begin
set @id = isnull ((select max (IDViaje) from Viaje ),0)+1
insert into Viaje values(@id,@idvehiculo,@idpasajero,@destino,@kilometro,@importe,@fechaviaje)
end
GO
/****** Object:  StoredProcedure [dbo].[ContarViajes]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ContarViajes]
as begin
select count(IDViaje) as 'cantViajes' from Viaje
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarPasajero]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarPasajero]
@ID int
as begin
delete from Pasajero where IDPasajero=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[IngresarPasajero]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[IngresarPasajero]
@ID int,@nombre nvarchar(50), @apellido nvarchar(50), @direccion nvarchar(50)
as begin
set @ID= isnull((select max(IDPasajero) from Pasajero),0)+1
insert into Pasajero values(@ID,@nombre,@apellido,@direccion)
end
GO
/****** Object:  StoredProcedure [dbo].[listarpasajeros]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listarpasajeros]
as begin
select*from Pasajero
end
GO
/****** Object:  StoredProcedure [dbo].[listarvehiculo]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[listarvehiculo]
as begin
select * from Vehiculo
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarPasajero]    Script Date: 14/12/2019 16:19:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarPasajero]
@ID int, @nombre nvarchar(50), @apellido nvarchar(50), @direccion nvarchar(50)
as begin
update Pasajero set Nombre= @nombre, Apellido=@apellido, Direccion=@direccion where IDPasajero=@ID
end
GO
USE [master]
GO
ALTER DATABASE [Parcial2LUG] SET  READ_WRITE 
GO
