USE [master]
GO
/****** Object:  Database [Parcial]    Script Date: 30/09/2019 10:51:29 ******/
CREATE DATABASE [Parcial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Parcial', FILENAME = N'D:\Parcial.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Parcial_log', FILENAME = N'D:\Parcial_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Parcial] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Parcial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Parcial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Parcial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Parcial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Parcial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Parcial] SET ARITHABORT OFF 
GO
ALTER DATABASE [Parcial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Parcial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Parcial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Parcial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Parcial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Parcial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Parcial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Parcial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Parcial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Parcial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Parcial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Parcial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Parcial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Parcial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Parcial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Parcial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Parcial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Parcial] SET RECOVERY FULL 
GO
ALTER DATABASE [Parcial] SET  MULTI_USER 
GO
ALTER DATABASE [Parcial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Parcial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Parcial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Parcial] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Parcial] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Parcial]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IDProducto] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Stock] [int] NOT NULL,
	[PrecioUnit] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IDProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[IDSucursal] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[IDSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venta]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IDVenta] [int] NOT NULL,
	[IDSucursal] [int] NOT NULL,
	[IDProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnit] [int] NOT NULL,
	[Importe] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IDVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Stock], [PrecioUnit]) VALUES (1, N'manaos', 99, 22)
INSERT [dbo].[Producto] ([IDProducto], [Descripcion], [Stock], [PrecioUnit]) VALUES (4, N'pepsi', 50, 34)
INSERT [dbo].[Sucursal] ([IDSucursal], [Direccion]) VALUES (23, N'almafuete')
INSERT [dbo].[Sucursal] ([IDSucursal], [Direccion]) VALUES (33, N'avellaneda')
INSERT [dbo].[Venta] ([IDVenta], [IDSucursal], [IDProducto], [Cantidad], [PrecioUnit], [Importe]) VALUES (2, 33, 4, 5, 5, 5)
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([IDProducto])
REFERENCES [dbo].[Producto] ([IDProducto])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Sucursal] FOREIGN KEY([IDSucursal])
REFERENCES [dbo].[Sucursal] ([IDSucursal])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Sucursal]
GO
/****** Object:  StoredProcedure [dbo].[AltaProducto]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AltaProducto]
@ID int,@desc nvarchar(50),@stock int, @precio int
as begin
insert into Producto values(@ID,@desc,@stock,@precio)
end
GO
/****** Object:  StoredProcedure [dbo].[altaSucursal]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[altaSucursal]
@ID int,@direccion nvarchar(50)
as
begin 
insert into Sucursal values (@ID,@direccion)
end
GO
/****** Object:  StoredProcedure [dbo].[altaVenta]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[altaVenta]
@idventa int, @idsucursal int, @idproducto int, @cantidad int, @precio int, @importe int
as begin
insert into Venta values (@idventa,@idsucursal,@idproducto,@cantidad,@precio,@importe)
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarProducto]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarProducto]
@ID int
as begin
delete from Producto where IDProducto=@ID
end

GO
/****** Object:  StoredProcedure [dbo].[listarProductos]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listarProductos]
as begin
select*from Producto
end
GO
/****** Object:  StoredProcedure [dbo].[Mayores]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Mayores]
as begin
select* from Producto where Stock>100
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarProducto]    Script Date: 30/09/2019 10:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ModificarProducto]
@ID int,@desc nvarchar(50),@stock int, @precio int
as begin
update Producto set Descripcion=@desc,Stock=@stock,PrecioUnit=@precio where IDProducto=@ID
end
GO
USE [master]
GO
ALTER DATABASE [Parcial] SET  READ_WRITE 
GO
