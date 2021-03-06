USE [master]
GO
/****** Object:  Database [FACULTAD]    Script Date: 28/04/2020 20:54:32 ******/
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
EXEC sys.sp_db_vardecimal_storage_format N'FACULTAD', N'ON'
GO
ALTER DATABASE [FACULTAD] SET QUERY_STORE = OFF
GO
USE [FACULTAD]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 28/04/2020 20:54:32 ******/
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
/****** Object:  Table [dbo].[Instancia]    Script Date: 28/04/2020 20:54:32 ******/
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
/****** Object:  Table [dbo].[Materia]    Script Date: 28/04/2020 20:54:32 ******/
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
/****** Object:  Table [dbo].[MateriaProfesor]    Script Date: 28/04/2020 20:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaProfesor](
	[IDMateria] [int] NOT NULL,
	[IDProfesor] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nota]    Script Date: 28/04/2020 20:54:32 ******/
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
/****** Object:  Table [dbo].[Profesor]    Script Date: 28/04/2020 20:54:32 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 28/04/2020 20:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[IDReferente] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (3, N'julian', N'perez', 19)
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (4, N'martina', N'Perez', 13)
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (5, N'martina', N'donadio', 19)
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (6, N'eduardo', N'donadio', 49)
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (7, N'valeria', N'demonty', 20)
INSERT [dbo].[Alumno] ([IDAlumno], [Nombre], [Apellido], [Edad]) VALUES (9, N'marcos', N'marin', 20)
INSERT [dbo].[Instancia] ([IDInstancia], [NombreInstancia]) VALUES (1, N'Parcial_1')
INSERT [dbo].[Instancia] ([IDInstancia], [NombreInstancia]) VALUES (2, N'Parcial_2')
INSERT [dbo].[Instancia] ([IDInstancia], [NombreInstancia]) VALUES (3, N'TP')
INSERT [dbo].[Materia] ([IDMateria], [NombreMateria]) VALUES (1, N'programacion')
INSERT [dbo].[Materia] ([IDMateria], [NombreMateria]) VALUES (2, N'matematica')
INSERT [dbo].[Materia] ([IDMateria], [NombreMateria]) VALUES (3, N'fisica 2')
INSERT [dbo].[Nota] ([IDNota], [IDAlumno], [IDMateria], [IDInstancia], [Nota]) VALUES (1, 5, 2, 3, 6)
INSERT [dbo].[Nota] ([IDNota], [IDAlumno], [IDMateria], [IDInstancia], [Nota]) VALUES (2, 4, 2, 1, 2)
INSERT [dbo].[Nota] ([IDNota], [IDAlumno], [IDMateria], [IDInstancia], [Nota]) VALUES (3, 4, 2, 1, 2)
INSERT [dbo].[Nota] ([IDNota], [IDAlumno], [IDMateria], [IDInstancia], [Nota]) VALUES (4, 5, 2, 1, 5)
INSERT [dbo].[Nota] ([IDNota], [IDAlumno], [IDMateria], [IDInstancia], [Nota]) VALUES (5, 9, 2, 1, 2)
INSERT [dbo].[Nota] ([IDNota], [IDAlumno], [IDMateria], [IDInstancia], [Nota]) VALUES (6, 9, 2, 2, 4)
INSERT [dbo].[Profesor] ([IDProfesor], [NombreProfesor]) VALUES (1, N'el veiga')
INSERT [dbo].[Profesor] ([IDProfesor], [NombreProfesor]) VALUES (2, N'el muerto')
INSERT [dbo].[Profesor] ([IDProfesor], [NombreProfesor]) VALUES (3, N'el roda')
INSERT [dbo].[Usuario] ([NombreUsuario], [Contraseña], [IDReferente]) VALUES (N'afdsifadsi', N'2cc0c742c464948ab598cbf6f8ac295a0ea74507ae16fccb35', 1)
INSERT [dbo].[Usuario] ([NombreUsuario], [Contraseña], [IDReferente]) VALUES (N'ddasd', N'19c451aedfb24c338a9a2a5c31d553ed77e7cdefc655035f39', 1)
ALTER TABLE [dbo].[MateriaProfesor]  WITH CHECK ADD  CONSTRAINT [FK_Materia-Profesor_Materia] FOREIGN KEY([IDMateria])
REFERENCES [dbo].[Materia] ([IDMateria])
GO
ALTER TABLE [dbo].[MateriaProfesor] CHECK CONSTRAINT [FK_Materia-Profesor_Materia]
GO
ALTER TABLE [dbo].[MateriaProfesor]  WITH CHECK ADD  CONSTRAINT [FK_Materia-Profesor_Profesor] FOREIGN KEY([IDProfesor])
REFERENCES [dbo].[Profesor] ([IDProfesor])
GO
ALTER TABLE [dbo].[MateriaProfesor] CHECK CONSTRAINT [FK_Materia-Profesor_Profesor]
GO
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
/****** Object:  StoredProcedure [dbo].[agregarAlumno]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarAlumno]
@Leg int,@Nom nvarchar(50), @Ape nvarchar(50), @edad int
as
begin
set @Leg= ISNULL((select max (IDAlumno) from Alumno),0)+1
insert into Alumno(IDAlumno,Nombre,Apellido,Edad) values(@Leg,@Nom,@Ape,@edad)
end

GO
/****** Object:  StoredProcedure [dbo].[AgregarMateria]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarMateria]
@id int, @Nombre nvarchar(50)
as begin
set @id= ISNULL((select max (IDMateria) from Materia),0)+1
insert into Materia values (@id,@Nombre)
end
GO
/****** Object:  StoredProcedure [dbo].[AgregarNotas]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgregarNotas]
@idn int, @idm int, @ida int, @idi int, @nota int
as begin
set @idn= ISNULL((select max(IDNota) from Nota),0)+1
insert into Nota values(@idn,@ida,@idm,@idi,@nota)
end
GO
/****** Object:  StoredProcedure [dbo].[AgregarProfesor]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgregarProfesor]
@id int, @Nombre nvarchar(50)
as begin
set @id= ISNULL((select max (IDProfesor) from Profesor),0)+1
insert into Profesor values (@id,@Nombre)
end
GO
/****** Object:  StoredProcedure [dbo].[CrearProfeMateria]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CrearProfeMateria]
@idp int, @idm int
as begin
insert into [Materia-Profesor] values (@idp,@idm)
end
GO
/****** Object:  StoredProcedure [dbo].[eliminarAlumno]    Script Date: 28/04/2020 20:54:33 ******/
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
/****** Object:  StoredProcedure [dbo].[EliminarMateria]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EliminarMateria]
@id int
as begin
delete from Nota where IDMateria=@id
delete Materia where IDMateria=@id
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarProfesor]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarProfesor]
@id int
as begin
delete Profesor where IDProfesor=@id
end
GO
/****** Object:  StoredProcedure [dbo].[iniciarSesion]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[iniciarSesion]
@nombreusuario nvarchar(50),@contraseña nvarchar(50)
as begin
select IDusuario from Usuario where Usuario.Contraseña=@contraseña and Usuario.NombreUsuario=@nombreusuario
end
GO
/****** Object:  StoredProcedure [dbo].[ListarALUMNO]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarALUMNO]
as begin
select * from Alumno
end

GO
/****** Object:  StoredProcedure [dbo].[ListarMateria]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarMateria]
as begin
select * from Materia
end
GO
/****** Object:  StoredProcedure [dbo].[ListarProfesor]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarProfesor]
as begin
select * from Profesor
end
GO
/****** Object:  StoredProcedure [dbo].[MaxEdad]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MaxEdad]
as begin
select max(Edad) as 'MaxEdad' from Alumno
end
GO
/****** Object:  StoredProcedure [dbo].[MinEdad]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MinEdad]
as begin
select min(Edad) as 'MinEdad' from Alumno
end
GO
/****** Object:  StoredProcedure [dbo].[modificarAlumno]    Script Date: 28/04/2020 20:54:33 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarMateria]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarMateria]
@id int, @Nombre nvarchar(50)
as begin
update Materia set NombreMateria=@Nombre where IDMateria=@id
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarProfesor]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarProfesor]
@id int, @Nombre nvarchar(50)
as begin
update Profesor set NombreProfesor=@Nombre where IDProfesor=@id
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerIDUsuario]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ObtenerIDUsuario]
@nombreusuario nvarchar(50)
as begin 
select Usuario.IDReferente from Usuario where NombreUsuario=@nombreusuario
end
GO
/****** Object:  StoredProcedure [dbo].[PromedioEdad]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PromedioEdad]
as begin
select avg(Edad) as 'PromEdad' from Alumno
end
GO
/****** Object:  StoredProcedure [dbo].[RegistrarUsuario]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RegistrarUsuario]
@nombreUsuario nvarchar(50), @Contraseña nvarchar(50),@IDReferente int
as begin
insert into Usuario values (@nombreUsuario,@Contraseña,@IDReferente)
end
GO
/****** Object:  StoredProcedure [dbo].[ValidarUsuario]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ValidarUsuario]
@usuario nvarchar(50),@contraseña nvarchar(50),@idusuario int
as begin
select * from Usuario where NombreUsuario=@usuario and Contraseña=@contraseña
end
GO
/****** Object:  StoredProcedure [dbo].[VerNotasMateria]    Script Date: 28/04/2020 20:54:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VerNotasMateria]
@idmateria int
as begin
select * from Nota where IDMateria=@idmateria
end
GO
USE [master]
GO
ALTER DATABASE [FACULTAD] SET  READ_WRITE 
GO
