USE [master]
GO
/****** Object:  Database [dbs_prestamos_deportivos]    Script Date: 12/10/2023 7:48:29 p. m. ******/
CREATE DATABASE [dbs_prestamos_deportivos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbs_prestamos_deportivos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbs_prestamos_deportivos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbs_prestamos_deportivos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbs_prestamos_deportivos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbs_prestamos_deportivos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  MULTI_USER 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbs_prestamos_deportivos]
GO
/****** Object:  Table [dbo].[tbl_det_prestamos]    Script Date: 12/10/2023 7:48:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_det_prestamos](
	[PKItem] [bigint] IDENTITY(1,1) NOT NULL,
	[FKNumero_tbl_prestamos] [bigint] NOT NULL,
	[FKCodigo_tbl_implementos] [varchar](10) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Fecha_devolucion] [date] NULL,
	[Hora_devolucion] [time](7) NULL,
	[Observaciones] [varchar](5000) NULL,
PRIMARY KEY CLUSTERED 
(
	[PKItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_estados]    Script Date: 12/10/2023 7:48:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_estados](
	[PKCodigo] [char](1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PKCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_implementos]    Script Date: 12/10/2023 7:48:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_implementos](
	[PKCodigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Especificaciones] [varchar](5000) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Valor] [float] NOT NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PKCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_personas]    Script Date: 12/10/2023 7:48:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_personas](
	[PKId] [varchar](10) NOT NULL,
	[P_Nombre] [varchar](40) NOT NULL,
	[S_Nombre] [varchar](40) NULL,
	[P_apellido] [varchar](40) NOT NULL,
	[S_apellido] [varchar](40) NULL,
	[Contacto] [varchar](10) NOT NULL,
	[Correo] [varchar](80) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[FKId_tbl_sexo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PKId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_prestamos]    Script Date: 12/10/2023 7:48:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_prestamos](
	[PKNumero] [bigint] IDENTITY(1,1) NOT NULL,
	[FKId_tbl_personas] [varchar](10) NOT NULL,
	[FKUsuario_tbl_usuario] [varchar](100) NOT NULL,
	[Fecha_registro] [date] NULL,
	[Hora_registro] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[PKNumero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_rol]    Script Date: 12/10/2023 7:48:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_rol](
	[PKCodigo] [char](1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PKCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sexo]    Script Date: 12/10/2023 7:48:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sexo](
	[PKId] [char](1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nomenclatura] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PKId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_usuarios]    Script Date: 12/10/2023 7:48:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_usuarios](
	[PKUsuario] [varchar](100) NOT NULL,
	[Contraseña] [varchar](10) NOT NULL,
	[FKId_tbl_personas] [varchar](10) NOT NULL,
	[Fecha] [date] NULL,
	[FKCodigo_tbl_estado] [char](1) NULL,
	[FKCodigo_tbl_rol] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PKUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_det_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_tbl_det_prestamos_tbl_implementos] FOREIGN KEY([FKCodigo_tbl_implementos])
REFERENCES [dbo].[tbl_implementos] ([PKCodigo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_det_prestamos] CHECK CONSTRAINT [FK_tbl_det_prestamos_tbl_implementos]
GO
ALTER TABLE [dbo].[tbl_det_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_tbl_det_prestamos_tbl_prestamos] FOREIGN KEY([FKNumero_tbl_prestamos])
REFERENCES [dbo].[tbl_prestamos] ([PKNumero])
GO
ALTER TABLE [dbo].[tbl_det_prestamos] CHECK CONSTRAINT [FK_tbl_det_prestamos_tbl_prestamos]
GO
ALTER TABLE [dbo].[tbl_personas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_personas_tbl_sexo] FOREIGN KEY([FKId_tbl_sexo])
REFERENCES [dbo].[tbl_sexo] ([PKId])
GO
ALTER TABLE [dbo].[tbl_personas] CHECK CONSTRAINT [FK_tbl_personas_tbl_sexo]
GO
ALTER TABLE [dbo].[tbl_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_tbl_prestamos_tbl_personas] FOREIGN KEY([FKId_tbl_personas])
REFERENCES [dbo].[tbl_personas] ([PKId])
GO
ALTER TABLE [dbo].[tbl_prestamos] CHECK CONSTRAINT [FK_tbl_prestamos_tbl_personas]
GO
ALTER TABLE [dbo].[tbl_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_tbl_prestamos_tbl_usuarios] FOREIGN KEY([FKUsuario_tbl_usuario])
REFERENCES [dbo].[tbl_usuarios] ([PKUsuario])
GO
ALTER TABLE [dbo].[tbl_prestamos] CHECK CONSTRAINT [FK_tbl_prestamos_tbl_usuarios]
GO
ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usuarios_tbl_estados] FOREIGN KEY([FKCodigo_tbl_estado])
REFERENCES [dbo].[tbl_estados] ([PKCodigo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_usuarios] CHECK CONSTRAINT [FK_tbl_usuarios_tbl_estados]
GO
ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usuarios_tbl_personas] FOREIGN KEY([FKId_tbl_personas])
REFERENCES [dbo].[tbl_personas] ([PKId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tbl_usuarios] CHECK CONSTRAINT [FK_tbl_usuarios_tbl_personas]
GO
ALTER TABLE [dbo].[tbl_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usuarios_tbl_rol] FOREIGN KEY([FKCodigo_tbl_rol])
REFERENCES [dbo].[tbl_rol] ([PKCodigo])
GO
ALTER TABLE [dbo].[tbl_usuarios] CHECK CONSTRAINT [FK_tbl_usuarios_tbl_rol]
GO
USE [master]
GO
ALTER DATABASE [dbs_prestamos_deportivos] SET  READ_WRITE 
GO
