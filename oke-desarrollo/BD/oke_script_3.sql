USE [master]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [oke].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [oke] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [oke] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [oke] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [oke] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [oke] SET ARITHABORT OFF 
GO
ALTER DATABASE [oke] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [oke] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [oke] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [oke] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [oke] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [oke] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [oke] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [oke] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [oke] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [oke] SET  DISABLE_BROKER 
GO
ALTER DATABASE [oke] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [oke] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [oke] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [oke] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [oke] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [oke] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [oke] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [oke] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [oke] SET  MULTI_USER 
GO
ALTER DATABASE [oke] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [oke] SET DB_CHAINING OFF 
GO
ALTER DATABASE [oke] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [oke] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [oke] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [oke] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [oke] SET QUERY_STORE = OFF
GO
USE [oke]
GO
/****** Object:  Table [dbo].[Canciones]    Script Date: 21/2/2022 15:20:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estaciones]    Script Date: 21/2/2022 15:20:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesas]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesas](
	[idMesa] [int] IDENTITY(1,1) NOT NULL,
	[Mesa] [varchar](50) NULL,
 CONSTRAINT [PK_Mesas] PRIMARY KEY CLUSTERED 
(
	[idMesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[idPedido] [int] IDENTITY(1,1) NOT NULL,
	[idMesa] [int] NULL,
	[idCancion] [int] NULL,
	[Estado] [varchar](50) NULL,
	[Mensaje] [varchar](max) NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](max) NULL,
	[Pass] [varchar](max) NULL,
	[Icono] [image] NULL,
	[Estado] [varchar](max) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Canciones] FOREIGN KEY([idCancion])
REFERENCES [dbo].[Canciones] ([IdCancion])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Canciones]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Mesas] FOREIGN KEY([idMesa])
REFERENCES [dbo].[Mesas] ([idMesa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Mesas]
GO
/****** Object:  StoredProcedure [dbo].[buscar_canciones]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_canciones]
@letra varchar(50)
as
select top 50 * from Canciones
where Nombre Like '%' + @letra + '%'

GO
/****** Object:  StoredProcedure [dbo].[buscar_usuario]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_usuario]
@buscador varchar(50)
as
select * from Usuarios
where Usuario LIKE '%' + @buscador + '%'

GO
/****** Object:  StoredProcedure [dbo].[editar_mesa]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_mesa]
@pMesa varchar(50),
@pIdMesa int
as
if Exists(select Mesa from Mesas where (Mesa=@pMesa and idMesa <> @pIdMesa))
	RaisError('Ya existe una mesa con ese nombre',16,1)
else
update Mesas Set Mesa=@pMesa
where idMesa=@pIdMesa

GO
/****** Object:  StoredProcedure [dbo].[editar_usuarios]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_usuarios]
@IdUsuario int,
@Usuario as varchar(max),
@Pass varchar(max),
@Icono image,
@Estado varchar(max)
as
/*if Exists (Select Usuario from Usuarios Where Usuario=@Usuario AND IdUsuario = @IdUsuario)
	Raiserror('Usuario en uso, use otro nombre de usuario',16,1)
else*/
update Usuarios set Usuario=@Usuario, Pass=@Pass,Icono=@Icono, Estado=@Estado
where idusuario = @IdUsuario

GO
/****** Object:  StoredProcedure [dbo].[eliminar_canciones]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_canciones]
@IdCancion int
as
delete from Canciones
where IdCancion=@IdCancion

GO
/****** Object:  StoredProcedure [dbo].[eliminar_mesa]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_mesa]
@idMesa int
as
delete from Mesas where idMesa=idMesa

GO
/****** Object:  StoredProcedure [dbo].[eliminar_pedido]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_pedido]
@IdPedido int
as
delete from Pedidos where idPedido = @IdPedido

GO
/****** Object:  StoredProcedure [dbo].[eliminar_todos_pedido]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_todos_pedido]
as
delete from Pedidos

GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuarios]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_usuarios]
@Id_usuario int
as
delete from Usuarios where idusuario = @Id_Usuario

GO
/****** Object:  StoredProcedure [dbo].[insertar_canciones]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_canciones]
@Nombre as varchar(max)
as
if Exists(Select Nombre from Canciones where Nombre=@Nombre)
(select top 1 Nombre from Canciones)
else
insert into Canciones
values(@Nombre)

GO
/****** Object:  StoredProcedure [dbo].[insertar_mesa]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_mesa]
@Mesa varchar(50)
as
if Exists(select Mesa from Mesas where Mesa=@Mesa)
	RaisError('Ya existe una mesa con ese nombre',16,1)
else
insert into Mesas values(@Mesa)

GO
/****** Object:  StoredProcedure [dbo].[insertar_pedidos]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_pedidos]
@IdMesa as int,
@IdCancion as int,
@Mensaje as varchar(max)
as

declare @Estado varchar(50)
set @Estado = 'Pendiente'

declare @contador int

set @contador = (select count(IdPedido) from Pedidos where IdMesa=@IdMesa)

if(@contador=2)
RaisError('Ya existen 2 pedidos para esta mesa, espera a que de despachen',16,1)
else
insert into Pedidos
values(@IdMesa,@IdCancion,@Estado,@Mensaje)

GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_usuario]
@Usuario as varchar(max),
@Pass varchar(max),
@Icono image,
@Estado varchar(max)
as
if Exists (Select Usuario from Usuarios Where Usuario=@Usuario)
Raiserror('Usuario ya registrado',16,1)
else
insert into Usuarios 
values(@Usuario,@Pass,@Icono,@Estado)

GO
/****** Object:  StoredProcedure [dbo].[InsertarEstaciones]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarEstaciones]
as
declare @Ruta varchar(max)
declare @Ip varchar(max)

set @Ip='-'
set @Ruta = '-'
insert into Estaciones
values(@Ruta,@Ip)

GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuarios]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_usuarios]
as
select * from Usuarios;

GO
/****** Object:  StoredProcedure [dbo].[mostrarCumpleanios]    Script Date: 21/2/2022 15:20:38 ******/
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
/****** Object:  StoredProcedure [dbo].[mostrarPedidos]    Script Date: 21/2/2022 15:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarPedidos]
as
select Pedidos.IdPedido,Canciones.Nombre as Cancion,Mesas.Mesa,Pedidos.Estado
from Pedidos inner join Mesas on Mesas.IdMesa=Pedidos.IdMesa
inner join Canciones on Canciones.IdCancion=Pedidos.IdCancion

GO
USE [master]
GO
ALTER DATABASE [oke] SET  READ_WRITE 
GO
