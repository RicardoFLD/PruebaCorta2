USE [DestTurist]
GO

/****** Object:  Table [dbo].[Destinos]    Script Date: 13/4/2023 11:45:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Destinos]') AND type in (N'U'))
DROP TABLE [dbo].[Destinos]
GO

