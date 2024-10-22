### POS Report Generator with Dynamic Charts in C# .NET Framwork 4.8

This is a Windows Forms application designed to generate dynamic sales reports for selected customers using various chart types. The app connects to a SQL Server database, retrieves sales data, and visualizes it through customizable charts such as bar, column, line, pie, doughnut, and more.

**Key Features:**
- Integrates with an MSSQL database to fetch customer and sales data.
- Supports multiple chart types: Bar, Column, Line, Pie, Doughnut, and more.
- Dynamically generates charts based on the customer and chart type selected.
- Customizations for pie/doughnut charts with percentage labels and optional 3D views.
- Dropdown options to allow flexible reporting based on user preferences.

**Tech Stack:**
- C# .NET Framework (Windows Forms)
- MSSQL for database management and querying
- System.Windows.Forms.DataVisualization for chart rendering

**Database Schema**: Below is a sample SQL schema for creating the necessary tables and inserting sample data:

```sql
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Sale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[SaleDate] [datetime] NULL,
	[TotalAmount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[SaleDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NULL,
	[ProductName] [nvarchar](max) NULL,
	[Quantity] [int] NULL,
	[PricePerUnit] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Sample Data Insertion
SET IDENTITY_INSERT [dbo].[Customer] ON;
INSERT [dbo].[Customer] ([Id], [Name], [Email]) VALUES (1, N'John Doe', N'john@example.com');
INSERT [dbo].[Customer] ([Id], [Name], [Email]) VALUES (2, N'Jane Smith', N'jane@example.com');
SET IDENTITY_INSERT [dbo].[Customer] OFF;

SET IDENTITY_INSERT [dbo].[Sale] ON;
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (1, 1, '2023-10-01', 100.00);
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (2, 1, '2023-10-02', 150.00);
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (3, 2, '2023-10-03', 200.00);
INSERT [dbo].[Sale] ([Id], [CustomerId], [SaleDate], [TotalAmount]) VALUES (4, 2, '2024-02-05', 310.20);
SET IDENTITY_INSERT [dbo].[Sale] OFF;

SET IDENTITY_INSERT [dbo].[SaleDetail] ON;
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (1, 1, 'Product A', 2, 50.00);
INSERT [dbo].[SaleDetail] ([Id], [SaleId], [ProductName], [Quantity], [PricePerUnit]) VALUES (2, 2, 'Product B', 3, 50.00);
SET IDENTITY_INSERT [dbo].[SaleDetail] OFF;
```

This schema includes basic `Customer`, `Sale`, and `SaleDetail` tables and sample data to test the application's dynamic report generation features.
