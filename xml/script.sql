USE [master]
GO
/****** Object:  Database [FACULTAD]    Script Date: 07/10/2019 11:43:31 ******/
CREATE DATABASE [FACULTAD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FACULTAD', FILENAME = N'D:\FACULTAD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FACULTAD_log', FILENAME = N'D:\FACULTAD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FACULTAD] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FACULTAD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FACULTAD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FACULTAD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FACULTAD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FACULTAD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FACULTAD] SET ARITHABORT OFF 
GO
ALTER DATABASE [FACULTAD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FACULTAD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FACULTAD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FACULTAD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FACULTAD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FACULTAD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FACULTAD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FACULTAD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FACULTAD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FACULTAD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FACULTAD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FACULTAD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FACULTAD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FACULTAD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FACULTAD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FACULTAD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FACULTAD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FACULTAD] SET RECOVERY FULL 
GO
ALTER DATABASE [FACULTAD] SET  MULTI_USER 
GO
ALTER DATABASE [FACULTAD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FACULTAD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FACULTAD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FACULTAD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FACULTAD] SET DELAYED_DURABILITY = DISABLED 
GO
USE [FACULTAD]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[IDAlumno] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[IDAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Instancia]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instancia](
	[IDInstancia] [int] NOT NULL,
	[NombreInstancia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Instancia] PRIMARY KEY CLUSTERED 
(
	[IDInstancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Materia]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[IDMateria] [int] NOT NULL,
	[NombreMateria] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[IDMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Materia-Profesor]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia-Profesor](
	[IDMateria] [int] NOT NULL,
	[IDProfesor] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nota]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nota](
	[IDNota] [int] NOT NULL,
	[IDAlumno] [int] NOT NULL,
	[IDMateria] [int] NOT NULL,
	[IDInstancia] [int] NOT NULL,
	[Nota] [int] NOT NULL,
 CONSTRAINT [PK_Nota] PRIMARY KEY CLUSTERED 
(
	[IDNota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[IDProfesor] [int] NOT NULL,
	[NombreProfesor] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[IDProfesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IDusuario] [int] NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IDusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (1, N'loli', N'trapito', 11)
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (3, N'julian', N'perez', 19)
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (4, N'martina', N'Perez', 13)
ALTER TABLE [dbo].[Nota]  WITH CHECK ADD  CONSTRAINT [FK_Nota_Alumno] FOREIGN KEY([IDAlumno])
REFERENCES [dbo].[Alumno] ([IDAlumno])
GO
ALTER TABLE [dbo].[Nota] CHECK CONSTRAINT [FK_Nota_Alumno]
GO
ALTER TABLE [dbo].[Nota]  WITH CHECK ADD  CONSTRAINT [FK_Nota_Instancia1] FOREIGN KEY([IDInstancia])
REFERENCES [dbo].[Instancia] ([IDInstancia])
GO
ALTER TABLE [dbo].[Nota] CHECK CONSTRAINT [FK_Nota_Instancia1]
GO
ALTER TABLE [dbo].[Nota]  WITH CHECK ADD  CONSTRAINT [FK_Nota_Materia1] FOREIGN KEY([IDMateria])
REFERENCES [dbo].[Materia] ([IDMateria])
GO
ALTER TABLE [dbo].[Nota] CHECK CONSTRAINT [FK_Nota_Materia1]
GO
/****** Object:  StoredProcedure [dbo].[agregarAlumno]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarAlumno]
@Leg int,@Nom nvarchar(50), @Ape nvarchar(50), @edad int
as
begin
insert into Alumno(IDAlumno,Nombre,Apellido,Edad) values(@Leg,@Nom,@Ape,@edad)
end

GO
/****** Object:  StoredProcedure [dbo].[eliminarAlumno]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminarAlumno]
@Leg int
as
begin
delete from Alumno where IDAlumno =@Leg
end

GO
/****** Object:  StoredProcedure [dbo].[ListarALUMNO]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarALUMNO]
as begin
select * from Alumno
end

GO
/****** Object:  StoredProcedure [dbo].[MaxEdad]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MaxEdad]
as begin
select max(Edad) as 'MaxEdad' from Alumno
end
GO
/****** Object:  StoredProcedure [dbo].[MinEdad]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MinEdad]
as begin
select min(Edad) as 'MinEdad' from Alumno
end
GO
/****** Object:  StoredProcedure [dbo].[modificarAlumno]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarAlumno]
@Leg int, @Nom nvarchar(50), @Ape nvarchar(50), @edad int
as begin
update Alumno set IDAlumno=@Leg, Nombre=@Nom,Apellido=@Ape,Edad=@edad where IDAlumno=@Leg
end

GO
/****** Object:  StoredProcedure [dbo].[PromedioEdad]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PromedioEdad]
as begin
select avg(Edad) as 'PromEdad' from Alumno
end
GO
/****** Object:  StoredProcedure [dbo].[ValidarUsuario]    Script Date: 07/10/2019 11:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ValidarUsuario]
@usuario nvarchar(50),@contraseña nvarchar(50)
as begin
select * from Usuario where NombreUsuario=@usuario and Contraseña=@contraseña
end
GO
USE [master]
GO
ALTER DATABASE [FACULTAD] SET  READ_WRITE 
GO
