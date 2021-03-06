USE [master]
GO
/****** Object:  Database [GestorPacientes]    Script Date: 24/4/2022 11:10:56 a. m. ******/
CREATE DATABASE [GestorPacientes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestorPacientes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GestorPacientes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestorPacientes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GestorPacientes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GestorPacientes] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestorPacientes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestorPacientes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestorPacientes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestorPacientes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestorPacientes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestorPacientes] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestorPacientes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestorPacientes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestorPacientes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestorPacientes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestorPacientes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestorPacientes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestorPacientes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestorPacientes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestorPacientes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestorPacientes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestorPacientes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestorPacientes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestorPacientes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestorPacientes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestorPacientes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestorPacientes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestorPacientes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestorPacientes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestorPacientes] SET  MULTI_USER 
GO
ALTER DATABASE [GestorPacientes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestorPacientes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestorPacientes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestorPacientes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestorPacientes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestorPacientes] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestorPacientes] SET QUERY_STORE = OFF
GO
USE [GestorPacientes]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 24/4/2022 11:10:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Pacientes] [int] NULL,
	[Id_Medico] [int] NULL,
	[FechayHora] [date] NULL,
	[Causa] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 24/4/2022 11:10:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Cedula] [varchar](50) NULL,
	[Foto] [varchar](50) NULL,
 CONSTRAINT [PK_Medicos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 24/4/2022 11:10:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Cedula] [varchar](50) NULL,
	[FechaNacimiento] [date] NULL,
	[Fumador] [bit] NULL,
	[Alergias] [varchar](50) NULL,
	[Foto] [varchar](50) NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pruebas de Laboratorio]    Script Date: 24/4/2022 11:10:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pruebas de Laboratorio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NULL,
 CONSTRAINT [PK_Pruebas de Laboratorio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resultados de Laboratorio]    Script Date: 24/4/2022 11:10:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resultados de Laboratorio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Paciente] [int] NULL,
	[Id_Cita] [int] NULL,
	[Id_PruebaLab] [int] NULL,
	[Id_Medico] [int] NULL,
	[ResultadosPrueba] [varchar](50) NULL,
	[EstadoPrueba] [varchar](50) NULL,
 CONSTRAINT [PK_Resultados de Laboratorio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 24/4/2022 11:10:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 24/4/2022 11:10:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
	[TipoUsuario] [varchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Resultados de Laboratorio]  WITH NOCHECK ADD  CONSTRAINT [FK_Resultados de Laboratorio_Resultados de Laboratorio] FOREIGN KEY([id])
REFERENCES [dbo].[Resultados de Laboratorio] ([id])
GO
ALTER TABLE [dbo].[Resultados de Laboratorio] CHECK CONSTRAINT [FK_Resultados de Laboratorio_Resultados de Laboratorio]
GO
USE [master]
GO
ALTER DATABASE [GestorPacientes] SET  READ_WRITE 
GO
