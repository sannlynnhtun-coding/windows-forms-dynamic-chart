# PosReport.WindowsForms

```sql

CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 10/15/2024 4:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[SaleDate] [datetime] NULL,
	[TotalAmount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetail]    Script Date: 10/15/2024 4:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NULL,
	[ProductName] [nvarchar](max) NULL,
	[Quantity] [int] NULL,
	[PricePerUnit] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([Id], [Name], [Email]) VALUES (1, N'John Doe', N'john@example.com')
GO
INSERT [dbo].[Customer] ([Id], [Name], [Email]) VALUES (2, N'Jane Smith', N'jane@example.com')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Sale] ON 
GO
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (1, 1, CAST(N'2023-10-01T00:00:00.000' AS DateTime), CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (2, 1, CAST(N'2023-10-02T00:00:00.000' AS DateTime), CAST(150.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (3, 2, CAST(N'2023-10-03T00:00:00.000' AS DateTime), CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (4, 2, CAST(N'2024-02-05T00:00:00.000' AS DateTime), CAST(310.20 AS Decimal(18, 2)))
GO
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (5, 1, CAST(N'2024-02-15T00:00:00.000' AS DateTime), CAST(90.40 AS Decimal(18, 2)))
GO
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (6, 2, CAST(N'2024-02-25T00:00:00.000' AS DateTime), CAST(220.80 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Sale] OFF
GO
SET IDENTITY_INSERT [dbo].[SaleDetail] ON 
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (1, 1, N'Product A', 2, CAST(50.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (2, 2, N'Product B', 3, CAST(50.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (3, 3, N'Product C', 4, CAST(50.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (4, 1, N'Product A', 2, CAST(60.25 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (5, 2, N'Product B', 5, CAST(50.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (6, 3, N'Product C', 3, CAST(60.25 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (7, 4, N'Product D', 6, CAST(51.70 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (8, 5, N'Product E', 3, CAST(30.13 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (9, 6, N'Product F', 4, CAST(55.20 AS Decimal(18, 2)))
GO

```