USE [master]
GO

/****** Object:  Database [StudentDb]    Script Date: 30-03-2020 21:18:20 ******/
CREATE DATABASE [StudentDb] ON  PRIMARY 
( NAME = N'StudentDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\StudentDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StudentDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\StudentDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [StudentDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [StudentDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [StudentDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [StudentDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [StudentDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [StudentDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [StudentDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [StudentDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [StudentDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [StudentDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [StudentDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [StudentDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [StudentDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [StudentDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [StudentDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [StudentDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [StudentDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [StudentDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [StudentDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [StudentDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [StudentDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [StudentDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [StudentDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [StudentDb] SET  MULTI_USER 
GO

ALTER DATABASE [StudentDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [StudentDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [StudentDb] SET  READ_WRITE 
GO

