USE [sc_Default_v1]
GO

/****** Object:  Table [dbo].[Textbooks]    Script Date: 24/05/2018 13:43:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Textbooks](
	[TextBookId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialId] [int] NOT NULL,
	[MaterialKind] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Author] [varchar](50) NOT NULL,
	[Version] [int] NOT NULL,
	[Revision] [int] NOT NULL,
	[LastRevision] [date] NOT NULL,
	[RevisorName] [varchar](50) NOT NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[TextbookContent](
	[TextbookContentId] [int] IDENTITY(1,1) NOT NULL,
	[TextbookId] [int] NOT NULL,
	[LanguageId] [varchar](10) NOT NULL,
	[ParentId] [int] NULL,
	[ElementTypeId] [int] NOT NULL,
	[Content] [varchar](max) NOT NULL,
 CONSTRAINT [PK_TextbookContent] PRIMARY KEY CLUSTERED 
(
	[TextbookContentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[Materials](
	[MaterialId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialKindId] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](144) NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[MaterialKinds](
	[MaterialKindId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialKind] [varchar](50) NOT NULL
) ON [PRIMARY]

GO


