USE [master]
GO

/****** Object:  Database [BollywoodDb]    Script Date: 24-03-2020 19:09:09 ******/
CREATE DATABASE [BollywoodDb] ON  PRIMARY 
( NAME = N'BollywoodDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BollywoodDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BollywoodDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BollywoodDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BollywoodDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BollywoodDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BollywoodDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BollywoodDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BollywoodDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BollywoodDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [BollywoodDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BollywoodDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BollywoodDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BollywoodDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BollywoodDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BollywoodDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BollywoodDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BollywoodDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BollywoodDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BollywoodDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BollywoodDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BollywoodDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BollywoodDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BollywoodDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BollywoodDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BollywoodDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BollywoodDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BollywoodDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BollywoodDb] SET  MULTI_USER 
GO

ALTER DATABASE [BollywoodDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BollywoodDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BollywoodDb] SET  READ_WRITE 
GO

