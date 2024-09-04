# Proyecto Multitienda

## Descripción del Proyecto

Este proyecto es una aplicación ASP.NET desarrollada con el framework .NET utilizando una arquitectura en capas. La aplicación está diseñada para gestionar productos y categorías de una base de datos denominada "Multitienda". La solución incluye:

- **Capa de Acceso a Datos**: Implementada como una biblioteca de clases utilizando Entity Framework.
- **Capa de Negocio**: Biblioteca de clases con métodos para gestionar operaciones CRUD (Guardar, Modificar, Eliminar, Buscar, TraerTodo) para las entidades de Producto y Categoría.
- **Capa de Presentación**: Contiene tres formularios web:
  - `Index.aspx`: Página de inicio con botones para acceder a los mantenedores de categorías y productos.
  - `Categoria.aspx`: Permite añadir nuevas categorías y muestra un `GridView` con las categorías existentes.
  - `Producto.aspx`: Permite añadir nuevos productos y muestra un `GridView` con los productos existentes. Además, verifica que el producto esté asociado a una categoría existente.

## Requisitos

- **Visual Studio** con soporte para desarrollo en ASP.NET.
- **SQL Server** para la base de datos.

## Configuración del Proyecto

1. **Clonar el Repositorio**

   Clona este repositorio en tu máquina local utilizando Git:

   ```bash
   git clone https://github.com/<usuario>/<repositorio>.git

2. **Restaurar Paquetes**

Navega a la carpeta del proyecto en la línea de comandos y restaura los paquetes NuGet necesarios:
```bash
    nuget restore
```

3. **Configurar la Base de Datos**

Utiliza el siguiente script para crear la base de datos y las tablas en SQL Server. Puedes ejecutar este script en SQL Server Management Studio (SSMS):

```bash
    USE [master]
GO
/****** Object:  Database [Multitienda]    Script Date: 26-02-2019 18:20:13 ******/
CREATE DATABASE [Multitienda]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Multitienda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Multitienda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Multitienda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Multitienda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Multitienda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Multitienda] SET ARITHABORT OFF 
GO
ALTER DATABASE [Multitienda] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Multitienda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Multitienda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Multitienda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Multitienda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Multitienda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Multitienda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Multitienda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Multitienda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Multitienda] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Multitienda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Multitienda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Multitienda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Multitienda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Multitienda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Multitienda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Multitienda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Multitienda] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Multitienda] SET  MULTI_USER 
GO
ALTER DATABASE [Multitienda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Multitienda] SET DB_CHAINING OFF 
GO
USE [Multitienda]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 26-02-2019 18:20:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] NOT NULL,
	  NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 26-02-2019 18:20:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] NOT NULL,
	  NOT NULL,
	  NOT NULL,
	[idCategoria] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categoria] ([IdCategoria], [nombre]) VALUES (345, N'Juguetes                       ')
INSERT [dbo].[Categoria] ([IdCategoria], [nombre]) VALUES (890, N'Deporte                       ')
INSERT [dbo].[Categoria] ([IdCategoria], [nombre]) VALUES (9876, N'Vestuario                              ')
INSERT [dbo].[Producto] ([idProducto], [Nombre], [Descripcion], [idCategoria]) VALUES (456, N'Auto Carrera                  ', N'Auto de Carrera de color Rojo con franjas negras a fricción                                                                                                                                             ', 345)
INSERT [dbo].[Producto] ([idProducto], [Nombre], [Descripcion], [idCategoria]) VALUES (678, N'Jeans hombre                  ', N'Jeans para hombre de tiro largo y corte recto                                                                                                                                                           ', 9876)
INSERT [dbo].[Producto] ([idProducto], [Nombre], [Descripcion], [idCategoria]) VALUES (789, N'Muñeca                        ', N'Muñeca de trapo con ojos de vidrio y relleno de algodón                                                                                                                                                 ', 345)
INSERT [dbo].[Producto] ([idProducto], [Nombre], [Descripcion], [idCategoria]) VALUES (5678, N'Pelota de Beisbol             ', N'Pelota de Beisbol liga oficial                                                                                                                              ', 890)
INSERT [dbo].[Producto] ([idProducto], [Nombre], [Descripcion], [idCategoria]) VALUES (54632, N'Raqueta de Tenis              ', N'Raqueta de Tenis fibra de carbono                                                                                                                                       ', 890)
INSERT [dbo].[Producto] ([idProducto], [Nombre], [Descripcion], [idCategoria]) VALUES (87654, N'Yoga mat               ', N'Colchoneta para yoga PVC 170x60cm                                                                                                                                                       ', 890)
INSERT [dbo].[Producto] ([idProducto], [Nombre], [Descripcion], [idCategoria]) VALUES (554433, N'Avión radio control           ', N'Avión con motor a combustión y radio control                                                                                                                                                           ', 345)
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
USE [master]
GO
ALTER DATABASE [Multitienda] SET  READ_WRITE 
GO
```

## Ejecución del Proyecto
1. Abrir el Proyecto en Visual Studio

2. Abre el archivo de solución Multitienda.sln en Visual Studio.

3. Configurar la Conexión a la Base de Datos

4. Asegúrate de que la cadena de conexión en tu archivo de configuración (e.g., web.config) esté correctamente configurada para apuntar a la base de datos "Multitienda" en tu servidor SQL.

5. Ejecutar la Aplicación

Ejecuta la aplicación en Visual Studio para comprobar que todo funciona correctamente. La página de inicio te permitirá navegar a los formularios para gestionar categorías y productos.



