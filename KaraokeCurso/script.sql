USE [master]
GO
/****** Object:  Database [KARAOKECURSO]    Script Date: 19/11/2020 04:34:25 p.m. ******/
CREATE DATABASE [KARAOKECURSO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KARAOKECURSO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\KARAOKECURSO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KARAOKECURSO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\KARAOKECURSO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KARAOKECURSO] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KARAOKECURSO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KARAOKECURSO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET ARITHABORT OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KARAOKECURSO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KARAOKECURSO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KARAOKECURSO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KARAOKECURSO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KARAOKECURSO] SET  MULTI_USER 
GO
ALTER DATABASE [KARAOKECURSO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KARAOKECURSO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KARAOKECURSO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KARAOKECURSO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KARAOKECURSO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KARAOKECURSO] SET QUERY_STORE = OFF
GO
USE [KARAOKECURSO]
GO
/****** Object:  Table [dbo].[Canciones]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canciones](
	[IdCancion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
 CONSTRAINT [PK_Canciones] PRIMARY KEY CLUSTERED 
(
	[IdCancion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estaciones]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estaciones](
	[Id_Estacion] [int] IDENTITY(1,1) NOT NULL,
	[Ruta] [varchar](max) NULL,
	[Ip] [varchar](max) NULL,
 CONSTRAINT [PK_Estaciones] PRIMARY KEY CLUSTERED 
(
	[Id_Estacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesas]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesas](
	[IdMesa] [int] IDENTITY(1,1) NOT NULL,
	[Mesa] [varchar](50) NULL,
 CONSTRAINT [PK_Mesas] PRIMARY KEY CLUSTERED 
(
	[IdMesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
	[IdMesa] [int] NULL,
	[IdCancion] [int] NULL,
	[Estado] [varchar](50) NULL,
	[Mensaje] [varchar](max) NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Canciones] FOREIGN KEY([IdCancion])
REFERENCES [dbo].[Canciones] ([IdCancion])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Canciones]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Mesas] FOREIGN KEY([IdMesa])
REFERENCES [dbo].[Mesas] ([IdMesa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Mesas]
GO
/****** Object:  StoredProcedure [dbo].[buscarCanciones]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarCanciones]
@letra varchar(50)
as
select top 50 * from Canciones
where Nombre Like '%' + @letra + '%' and Nombre <>'!Happy Birthday!'
GO
/****** Object:  StoredProcedure [dbo].[editar_mesa]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_mesa]
@Mesa varchar(50),
@Id_Mesa int 
as
if Exists( select Mesa from Mesas where (Mesa=@Mesa and IdMesa <>@Id_mesa))
RaisError('Ya existe una mesa con ese nombre',16,1)
else
Update Mesas Set Mesa=@Mesa
where IdMesa=@Id_Mesa
GO
/****** Object:  StoredProcedure [dbo].[editarEstadoPedido]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editarEstadoPedido]
@Idpedido int
as
Delete from Pedidos where Estado='Sonando...'
update Pedidos set Estado='Sonando...'
Where IdPedido = @Idpedido 
GO
/****** Object:  StoredProcedure [dbo].[EditarIp]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarIp]
@Ip varchar(max)
as
update Estaciones set Ip=@Ip 
GO
/****** Object:  StoredProcedure [dbo].[eliminar_Canciones]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_Canciones]
@IdCancion int 
as
delete from Canciones 
Where IdCancion=@IdCancion 
GO
/****** Object:  StoredProcedure [dbo].[eliminarMesa]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarMesa]
@Idmesa int
as
delete from Mesas  where IdMesa=@Idmesa
GO
/****** Object:  StoredProcedure [dbo].[eliminarPedidos]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarPedidos]
@Idpedido int
as
delete from Pedidos
where IdPedido =@Idpedido 
GO
/****** Object:  StoredProcedure [dbo].[eliminarPedidosTodos]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarPedidosTodos]
as
delete from Pedidos
GO
/****** Object:  StoredProcedure [dbo].[insertar_Canciones]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_Canciones]
@Nombre as varchar(max)
as
if Exists(Select Nombre from Canciones where Nombre=@Nombre)
(select top 1 Nombre  from Canciones )
else
insert into Canciones
values(@Nombre)
GO
/****** Object:  StoredProcedure [dbo].[insertar_cumpleanios]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_cumpleanios]
@IdMesa As int,
@Mensaje varchar(max)
as
declare @Estado varchar(50)
declare @IdCancion int

set @Estado='PENDIENTE'
set @IdCancion=(select IdCancion from Canciones where Nombre='!Happy Birthday!')
INSERT INTO Pedidos
Values (
@IdMesa,
@IdCancion,
@Estado,
@Mensaje)

GO
/****** Object:  StoredProcedure [dbo].[Insertar_mesa]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insertar_mesa]
@Mesa varchar(50)
as
if Exists(select Mesa from Mesas where Mesa=@Mesa)
RaisError('Ya existe una mesa con ese nombre',16,1)
else
insert into Mesas values (@Mesa)
GO
/****** Object:  StoredProcedure [dbo].[insertar_Pedidos]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Pedidos]
@IdMesa As int,
@IdCancion As int,
@Mensaje varchar(max)
as

declare @Estado varchar(50)
declare @IdFc int
set @IdFc= (select IdCancion from Canciones where Nombre='!Happy Birthday!')
set @Estado = 'PENDIENTE'
declare @contador int
SET @contador= (select count(IdPedido) from Pedidos where IdMesa=@IdMesa and IdCancion <>@IdFc)
if(@contador=2)
Raiserror('Ya existen 2 pedidos para esta mesa, espere a que se despachen...',16,1)
else
Insert into Pedidos
Values(@IdMesa,@IdCancion,@Estado,@Mensaje )
GO
/****** Object:  StoredProcedure [dbo].[mostrarCodigoQR]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarCodigoQR]
as
select '|' + convert(varchar(max), Mesas.IdMesa)+'|'+Estaciones.Ip+'|' as IdmesaIp,Mesas.Mesa 
from Mesas cross join Estaciones
GO
/****** Object:  StoredProcedure [dbo].[mostrarCumpleanios]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarCumpleanios]
as
select Pedidos.IdPedido,Pedidos.Mensaje, Mesas.Mesa,Pedidos.Estado
from Pedidos inner join Mesas on Mesas.IdMesa=Pedidos.IdMesa
inner join Canciones on Canciones.IdCancion=Pedidos.IdCancion
 where Canciones.Nombre='!Happy Birthday!'
GO
/****** Object:  StoredProcedure [dbo].[mostrarPedidos]    Script Date: 19/11/2020 04:34:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarPedidos]
as
select top 10 Pedidos.IdPedido,Canciones.Nombre as Cancion, Mesas.Mesa,Pedidos.Estado
from Pedidos inner join Mesas on Mesas.IdMesa=Pedidos.IdMesa
inner join Canciones on Canciones.IdCancion=Pedidos.IdCancion
 where Canciones.Nombre<>'!Happy Birthday!'
GO
USE [master]
GO
ALTER DATABASE [KARAOKECURSO] SET  READ_WRITE 
GO
