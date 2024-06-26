create database Pharmacy
USE [Pharmacy]
GO
/****** Object:  Table [dbo].[BranchInformation]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BranchInformation](
	[BranchID] [int] IDENTITY(1,1) NOT NULL,
	[Budget] [float] NOT NULL,
	[Location] [nchar](30) NOT NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_BranchInformation] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComplaintsAndReviews]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComplaintsAndReviews](
	[ReviewID] [int] NOT NULL,
	[Description] [nchar](100) NOT NULL,
	[Rating] [float] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[BranchID] [int] NOT NULL,
 CONSTRAINT [PK_ComplaintsAndReviews] PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [nchar](30) NOT NULL,
	[Address] [nchar](300) NULL,
	[PhoneNumber] [nchar](11) NULL,
	[Tier] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discounts]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discounts](
	[Tier] [int] NOT NULL,
	[DiscountPercentage] [float] NOT NULL,
 CONSTRAINT [PK_Discounts] PRIMARY KEY CLUSTERED 
(
	[Tier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] NOT NULL,
	[EmployeeName] [nchar](30) NOT NULL,
	[Salary] [float] NOT NULL,
	[Role] [nchar](10) NOT NULL,
	[PhoneNumber] [nchar](11) NOT NULL,
	[Address] [nchar](300) NULL,
	[Password] [nchar](10) NOT NULL,
	[BranchID] [int] NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InBody]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InBody](
	[InBodyID] [int] NOT NULL,
	[Weight] [float] NOT NULL,
	[Height] [float] NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [nchar](1) NOT NULL,
	[MuscleMass] [float] NOT NULL,
	[Date] [date] NOT NULL,
	[FatPercentage] [float] NOT NULL,
	[CustomerID] [int] NOT NULL,
 CONSTRAINT [PK_InBody] PRIMARY KEY CLUSTERED 
(
	[InBodyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[BatchID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[ExpiryDate] [date] NOT NULL,
	[OfferPercentage] [float] NULL,
	[BranchID] [int] NOT NULL,
	[PID] [int] NOT NULL,
	[RestockDate] [date] NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[BatchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[EmployeeID] [int] NULL,
	[CustomerID] [int] NOT NULL,
	[TotalPrice] [float] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[PID] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Prescription] [bit] NOT NULL,
	[Pname] [nchar](10) NOT NULL,
	[SupplierID] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductsInOrder]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsInOrder](
	[OrderID] [int] NOT NULL,
	[BatchID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ProductsInOrder] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[BatchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductsInSubscriptions]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsInSubscriptions](
	[PID] [int] NOT NULL,
	[SubscriptionID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ProductsInSubscriptions] PRIMARY KEY CLUSTERED 
(
	[PID] ASC,
	[SubscriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Refunds]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Refunds](
	[OrderID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Description] [nchar](500) NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_Refunds] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscriptions]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscriptions](
	[SubscriptionID] [int] NOT NULL,
	[Interval] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Subscriptions] PRIMARY KEY CLUSTERED 
(
	[SubscriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[SupplierName] [nchar](30) NOT NULL,
	[City] [nchar](10) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BranchInformation] ON 

INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (1, 100000, N'221 Baker Street              ', 1)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (2, 60000, N'543 Maple Avenue              ', 2)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (3, 50000, N'876 Oak Lane                  ', 3)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (4, 70000, N'234 Cedar Road                ', 4)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (5, 65000, N'789 Pine Place                ', 5)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (6, 31000, N'134 West Avenue               ', 11)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (7, 10000, N'276 King Street               ', 12)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (8, 75000, N'398 Gravity Falls             ', 13)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (9, 70000, N'691 willow creek              ', 14)
INSERT [dbo].[BranchInformation] ([BranchID], [Budget], [Location], [EmployeeID]) VALUES (10, 42000, N'785 pacifica city             ', 15)
SET IDENTITY_INSERT [dbo].[BranchInformation] OFF
GO
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (1, N'Counterfit products                                                                                 ', 2, 1, 1)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (2, N'Quick service, good quality                                                                         ', 4.5, 2, 2)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (3, N'Missing items                                                                                       ', 1, 3, 3)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (4, N'Friendly staff                                                                                      ', 5, 4, 4)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (5, N'Late delivery                                                                                       ', 2.5, 5, 5)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (6, N'Rude employees                                                                                      ', 1.5, 4, 4)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (7, N'Limited products                                                                                    ', 3, 2, 2)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (8, N'Accessible location                                                                                 ', 4, 3, 3)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (9, N'Open 24 hours                                                                                       ', 3.5, 1, 1)
INSERT [dbo].[ComplaintsAndReviews] ([ReviewID], [Description], [Rating], [CustomerID], [BranchID]) VALUES (10, N'Great service                                                                                       ', 45, 5, 5)
GO
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [PhoneNumber], [Tier], [Date]) VALUES (1, N'Eva Miller                    ', N'987 Elm Street                                                                                                                                                                                                                                                                                              ', N'15551111222', 6, CAST(N'2020-03-01' AS Date))
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [PhoneNumber], [Tier], [Date]) VALUES (2, N'Sam Wilson                    ', N'543 Maple Avenue                                                                                                                                                                                                                                                                                            ', N'75552222333', 6, CAST(N'2021-06-01' AS Date))
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [PhoneNumber], [Tier], [Date]) VALUES (3, N'Olivia Taylor                 ', N'876 Oak Lane                                                                                                                                                                                                                                                                                                ', N'55533334442', 6, CAST(N'2022-07-11' AS Date))
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [PhoneNumber], [Tier], [Date]) VALUES (4, N'Daniel Brown                  ', N'234 Cedar Road                                                                                                                                                                                                                                                                                              ', N'55544443555', 6, CAST(N'2023-01-23' AS Date))
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [PhoneNumber], [Tier], [Date]) VALUES (5, N'Grace Davis                   ', N'789 Pine Place                                                                                                                                                                                                                                                                                              ', N'55554555666', 6, CAST(N'2023-12-25' AS Date))
GO
INSERT [dbo].[Discounts] ([Tier], [DiscountPercentage]) VALUES (6, 0.12)
INSERT [dbo].[Discounts] ([Tier], [DiscountPercentage]) VALUES (7, 0.18)
INSERT [dbo].[Discounts] ([Tier], [DiscountPercentage]) VALUES (8, 0.2)
INSERT [dbo].[Discounts] ([Tier], [DiscountPercentage]) VALUES (9, 0.15)
INSERT [dbo].[Discounts] ([Tier], [DiscountPercentage]) VALUES (10, 0.25)
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (1, N'Manager2                      ', 62000, N'Manager   ', N'5556666777 ', N'987 Elm Street                                                                                                                                                                                                                                                                                              ', N'password6 ', 2, CAST(N'2019-07-14' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (2, N'Cashier2                      ', 42000, N'Cashier   ', N'5557777888 ', N'543 Maple Avenue                                                                                                                                                                                                                                                                                            ', N'password7 ', 2, CAST(N'2020-06-01' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (3, N'Salesperson2                  ', 47000, N'Sales     ', N'5558888999 ', N'876 Oak Lane                                                                                                                                                                                                                                                                                                ', N'password8 ', 3, CAST(N'2021-11-13' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (4, N'StockClerk2                   ', 36000, N'Stock     ', N'5559999000 ', N'234 Cedar Road                                                                                                                                                                                                                                                                                              ', N'password9 ', 4, CAST(N'2021-01-02' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (5, N'Assistant2                    ', 51000, N'Assistant ', N'5550001111 ', N'789 Pine Place                                                                                                                                                                                                                                                                                              ', N'password10', 5, CAST(N'2022-08-23' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (6, N'Assistant4                    ', 500, N'Assistant ', N'15550001111', N'7 east sussex                                                                                                                                                                                                                                                                                               ', N'password  ', 5, CAST(N'2022-08-23' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (7, N'Clerk3                        ', 80931, N'Manager   ', N'01234567891', N'2 west road                                                                                                                                                                                                                                                                                                 ', N'12345678  ', 2, CAST(N'2022-08-09' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (11, N'ana                           ', 10931, N'TopManager', N'0111111111 ', N'11 giza street                                                                                                                                                                                                                                                                                              ', N'12345678  ', 6, CAST(N'2022-08-09' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (12, N'Manager3                      ', 612300, N'Manager   ', N'3456666777 ', N'312 Maple Avenue                                                                                                                                                                                                                                                                                            ', N'asdfghjkl ', 7, CAST(N'2022-07-14' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (13, N'Cashier1                      ', 4200, N'Cashier   ', N'55577177888', N'543 Elm street                                                                                                                                                                                                                                                                                              ', N'pass2077  ', 8, CAST(N'2017-06-01' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (14, N'Salesperson5                  ', 47320, N'Sales     ', N'55588889992', N'876 willow Lane                                                                                                                                                                                                                                                                                             ', N'12345678  ', 9, CAST(N'2023-12-01' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [Salary], [Role], [PhoneNumber], [Address], [Password], [BranchID], [Date]) VALUES (15, N'StockClerk4                   ', 3600, N'Stock     ', N'55599990003', N'23 hollywood street                                                                                                                                                                                                                                                                                         ', N'passpass  ', 10, CAST(N'2021-11-12' AS Date))
GO
INSERT [dbo].[InBody] ([InBodyID], [Weight], [Height], [Age], [Gender], [MuscleMass], [Date], [FatPercentage], [CustomerID]) VALUES (1, 72, 178, 27, N'F', 62, CAST(N'2023-06-01' AS Date), 14, 1)
INSERT [dbo].[InBody] ([InBodyID], [Weight], [Height], [Age], [Gender], [MuscleMass], [Date], [FatPercentage], [CustomerID]) VALUES (2, 67.5, 165, 31, N'M', 57.5, CAST(N'2023-07-01' AS Date), 19.5, 2)
INSERT [dbo].[InBody] ([InBodyID], [Weight], [Height], [Age], [Gender], [MuscleMass], [Date], [FatPercentage], [CustomerID]) VALUES (3, 82, 183, 29, N'F', 72, CAST(N'2022-08-01' AS Date), 17, 3)
INSERT [dbo].[InBody] ([InBodyID], [Weight], [Height], [Age], [Gender], [MuscleMass], [Date], [FatPercentage], [CustomerID]) VALUES (4, 77.5, 173, 36, N'M', 67.5, CAST(N'2023-09-01' AS Date), 21.5, 3)
INSERT [dbo].[InBody] ([InBodyID], [Weight], [Height], [Age], [Gender], [MuscleMass], [Date], [FatPercentage], [CustomerID]) VALUES (5, 92, 188, 23, N'M', 82, CAST(N'2023-10-01' AS Date), 11, 4)
GO
INSERT [dbo].[Inventory] ([BatchID], [Quantity], [ExpiryDate], [OfferPercentage], [BranchID], [PID], [RestockDate]) VALUES (1, 10, CAST(N'2024-01-15' AS Date), 0.40000000000000008, 2, 2, CAST(N'2022-12-15' AS Date))
INSERT [dbo].[Inventory] ([BatchID], [Quantity], [ExpiryDate], [OfferPercentage], [BranchID], [PID], [RestockDate]) VALUES (2, 80, CAST(N'2025-12-15' AS Date), 0.30000000000000004, 2, 2, CAST(N'2022-12-15' AS Date))
INSERT [dbo].[Inventory] ([BatchID], [Quantity], [ExpiryDate], [OfferPercentage], [BranchID], [PID], [RestockDate]) VALUES (3, 120, CAST(N'2023-12-31' AS Date), 0.30000000000000004, 3, 3, CAST(N'2022-12-10' AS Date))
INSERT [dbo].[Inventory] ([BatchID], [Quantity], [ExpiryDate], [OfferPercentage], [BranchID], [PID], [RestockDate]) VALUES (4, 90, CAST(N'2024-12-05' AS Date), 0.28, 4, 4, CAST(N'2023-02-05' AS Date))
INSERT [dbo].[Inventory] ([BatchID], [Quantity], [ExpiryDate], [OfferPercentage], [BranchID], [PID], [RestockDate]) VALUES (5, 110, CAST(N'2025-12-20' AS Date), 0.22, 5, 5, CAST(N'2023-01-20' AS Date))
INSERT [dbo].[Inventory] ([BatchID], [Quantity], [ExpiryDate], [OfferPercentage], [BranchID], [PID], [RestockDate]) VALUES (6, 4, CAST(N'2024-12-05' AS Date), 0.28, 6, 11, CAST(N'2023-02-05' AS Date))
INSERT [dbo].[Inventory] ([BatchID], [Quantity], [ExpiryDate], [OfferPercentage], [BranchID], [PID], [RestockDate]) VALUES (71, 230, CAST(N'2025-12-20' AS Date), 0.22, 7, 12, CAST(N'2023-01-20' AS Date))
GO
INSERT [dbo].[Orders] ([OrderID], [Date], [EmployeeID], [CustomerID], [TotalPrice]) VALUES (1, CAST(N'2023-12-02' AS Date), 1, 1, 4215)
INSERT [dbo].[Orders] ([OrderID], [Date], [EmployeeID], [CustomerID], [TotalPrice]) VALUES (2, CAST(N'2023-12-12' AS Date), 2, 2, 231.3)
INSERT [dbo].[Orders] ([OrderID], [Date], [EmployeeID], [CustomerID], [TotalPrice]) VALUES (3, CAST(N'2023-12-08' AS Date), 3, 3, 638.1)
INSERT [dbo].[Orders] ([OrderID], [Date], [EmployeeID], [CustomerID], [TotalPrice]) VALUES (4, CAST(N'2023-12-04' AS Date), 4, 4, 11.23)
INSERT [dbo].[Orders] ([OrderID], [Date], [EmployeeID], [CustomerID], [TotalPrice]) VALUES (5, CAST(N'2023-12-18' AS Date), 5, 5, 632)
GO
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (1, 25.99, 0, N'Product1  ', 1)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (2, 12.5, 1, N'Product2  ', 2)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (3, 19.95, 0, N'Product3  ', 3)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (4, 15, 1, N'Product4  ', 4)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (5, 30.75, 0, N'Product5  ', 5)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (6, 111.01, 0, N'Product1  ', 1)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (7, 13.85, 1, N'Product11 ', 2)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (8, 5.23, 0, N'Product32 ', 3)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (9, 15, 1, N'Product43 ', 4)
INSERT [dbo].[Products] ([PID], [Price], [Prescription], [Pname], [SupplierID]) VALUES (10, 365, 0, N'Product54 ', 5)
GO
INSERT [dbo].[ProductsInOrder] ([OrderID], [BatchID], [Quantity]) VALUES (1, 3, 26)
INSERT [dbo].[ProductsInOrder] ([OrderID], [BatchID], [Quantity]) VALUES (1, 4, 5)
INSERT [dbo].[ProductsInOrder] ([OrderID], [BatchID], [Quantity]) VALUES (2, 2, 15)
INSERT [dbo].[ProductsInOrder] ([OrderID], [BatchID], [Quantity]) VALUES (3, 3, 25)
INSERT [dbo].[ProductsInOrder] ([OrderID], [BatchID], [Quantity]) VALUES (4, 4, 18)
INSERT [dbo].[ProductsInOrder] ([OrderID], [BatchID], [Quantity]) VALUES (5, 5, 22)
GO
INSERT [dbo].[ProductsInSubscriptions] ([PID], [SubscriptionID], [Quantity]) VALUES (1, 1, 20)
INSERT [dbo].[ProductsInSubscriptions] ([PID], [SubscriptionID], [Quantity]) VALUES (2, 2, 15)
INSERT [dbo].[ProductsInSubscriptions] ([PID], [SubscriptionID], [Quantity]) VALUES (3, 3, 20)
INSERT [dbo].[ProductsInSubscriptions] ([PID], [SubscriptionID], [Quantity]) VALUES (4, 4, 5)
INSERT [dbo].[ProductsInSubscriptions] ([PID], [SubscriptionID], [Quantity]) VALUES (4, 5, 3)
INSERT [dbo].[ProductsInSubscriptions] ([PID], [SubscriptionID], [Quantity]) VALUES (5, 4, 1)
INSERT [dbo].[ProductsInSubscriptions] ([PID], [SubscriptionID], [Quantity]) VALUES (5, 5, 2)
GO
INSERT [dbo].[Refunds] ([OrderID], [Date], [Description], [EmployeeID]) VALUES (1, CAST(N'2023-12-05' AS Date), N'Wrong product delivered                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             ', 1)
INSERT [dbo].[Refunds] ([OrderID], [Date], [Description], [EmployeeID]) VALUES (2, CAST(N'2023-12-15' AS Date), N'Customer changed mind                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ', 2)
INSERT [dbo].[Refunds] ([OrderID], [Date], [Description], [EmployeeID]) VALUES (3, CAST(N'2023-12-10' AS Date), N'Defective product                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', 3)
INSERT [dbo].[Refunds] ([OrderID], [Date], [Description], [EmployeeID]) VALUES (4, CAST(N'2023-12-06' AS Date), N'Ordered by mistake                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ', 4)
INSERT [dbo].[Refunds] ([OrderID], [Date], [Description], [EmployeeID]) VALUES (5, CAST(N'2023-12-20' AS Date), N'Product not as expected                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             ', 5)
GO
INSERT [dbo].[Subscriptions] ([SubscriptionID], [Interval], [Active], [CustomerID], [Date]) VALUES (1, 1, 1, 1, CAST(N'2023-12-26' AS Date))
INSERT [dbo].[Subscriptions] ([SubscriptionID], [Interval], [Active], [CustomerID], [Date]) VALUES (2, 2, 1, 2, CAST(N'2023-12-27' AS Date))
INSERT [dbo].[Subscriptions] ([SubscriptionID], [Interval], [Active], [CustomerID], [Date]) VALUES (3, 2, 0, 3, CAST(N'2023-12-27' AS Date))
INSERT [dbo].[Subscriptions] ([SubscriptionID], [Interval], [Active], [CustomerID], [Date]) VALUES (4, 3, 1, 4, CAST(N'2023-12-28' AS Date))
INSERT [dbo].[Subscriptions] ([SubscriptionID], [Interval], [Active], [CustomerID], [Date]) VALUES (5, 1, 0, 5, CAST(N'2023-12-29' AS Date))
GO
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [City]) VALUES (1, N'Supplier1                     ', N'City1     ')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [City]) VALUES (2, N'Supplier2                     ', N'City2     ')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [City]) VALUES (3, N'Supplier3                     ', N'City3     ')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [City]) VALUES (4, N'Supplier4                     ', N'City4     ')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [City]) VALUES (5, N'Supplier5                     ', N'City5     ')
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[InBody] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Inventory] ADD  DEFAULT (getdate()) FOR [RestockDate]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Refunds] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Subscriptions] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[BranchInformation]  WITH CHECK ADD  CONSTRAINT [FK_BranchInformation_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeId])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[BranchInformation] CHECK CONSTRAINT [FK_BranchInformation_Employee]
GO
ALTER TABLE [dbo].[ComplaintsAndReviews]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintsAndReviews_BranchInformation] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BranchInformation] ([BranchID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ComplaintsAndReviews] CHECK CONSTRAINT [FK_ComplaintsAndReviews_BranchInformation]
GO
ALTER TABLE [dbo].[ComplaintsAndReviews]  WITH CHECK ADD  CONSTRAINT [FK_ComplaintsAndReviews_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ComplaintsAndReviews] CHECK CONSTRAINT [FK_ComplaintsAndReviews_Customers]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Discounts] FOREIGN KEY([Tier])
REFERENCES [dbo].[Discounts] ([Tier])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Discounts]
GO
ALTER TABLE [dbo].[Employee]  WITH NOCHECK ADD  CONSTRAINT [FK_Employee_BranchInformation] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BranchInformation] ([BranchID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_BranchInformation]
GO
ALTER TABLE [dbo].[InBody]  WITH CHECK ADD  CONSTRAINT [FK_InBody_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InBody] CHECK CONSTRAINT [FK_InBody_Customers]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_BranchInformation] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BranchInformation] ([BranchID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_BranchInformation]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customer]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeId])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employee]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
ALTER TABLE [dbo].[ProductsInOrder]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInOrder_Inventory] FOREIGN KEY([BatchID])
REFERENCES [dbo].[Inventory] ([BatchID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductsInOrder] CHECK CONSTRAINT [FK_ProductsInOrder_Inventory]
GO
ALTER TABLE [dbo].[ProductsInOrder]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInOrder_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductsInOrder] CHECK CONSTRAINT [FK_ProductsInOrder_Orders]
GO
ALTER TABLE [dbo].[ProductsInSubscriptions]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInSubscriptions_Products] FOREIGN KEY([PID])
REFERENCES [dbo].[Products] ([PID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductsInSubscriptions] CHECK CONSTRAINT [FK_ProductsInSubscriptions_Products]
GO
ALTER TABLE [dbo].[ProductsInSubscriptions]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInSubscriptions_Subscriptions] FOREIGN KEY([SubscriptionID])
REFERENCES [dbo].[Subscriptions] ([SubscriptionID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductsInSubscriptions] CHECK CONSTRAINT [FK_ProductsInSubscriptions_Subscriptions]
GO
ALTER TABLE [dbo].[Refunds]  WITH CHECK ADD  CONSTRAINT [FK_Refunds_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Refunds] CHECK CONSTRAINT [FK_Refunds_Employee]
GO
ALTER TABLE [dbo].[Refunds]  WITH CHECK ADD  CONSTRAINT [FK_Refunds_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Refunds] CHECK CONSTRAINT [FK_Refunds_Orders]
GO
ALTER TABLE [dbo].[Subscriptions]  WITH CHECK ADD  CONSTRAINT [FK_Subscriptions_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Subscriptions] CHECK CONSTRAINT [FK_Subscriptions_Customers]
GO
ALTER TABLE [dbo].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Suppliers_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Suppliers] CHECK CONSTRAINT [FK_Suppliers_Suppliers]
GO
/****** Object:  StoredProcedure [dbo].[ACTIVATESUBS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTIVATESUBS] @SUBSCRIPTIONID INT
AS
UPDATE Subscriptions
SET Active=1
WHERE SubscriptionID=@SUBSCRIPTIONID
GO
/****** Object:  StoredProcedure [dbo].[AddBranch]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[AddBranch]
@Budget		float,
@Location	nchar(50),
@EmployeeID	int

AS
INSERT INTO BranchInformation
values(@Budget, @Location, @EmployeeID)


GO
/****** Object:  StoredProcedure [dbo].[AddComplaintOrReview]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddComplaintOrReview]
@ReviewID	int,
@Description	nchar(100),
@Rating	float,
@CustomerID	int,
@BranchId	int
AS
Insert into ComplaintsAndReviews
values(@ReviewID, @Description, @Rating, @CustomerID, @BranchId)
GO
/****** Object:  StoredProcedure [dbo].[ADDCUSTOMER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ADDCUSTOMER] @CUSID INT,@CUSTOMERNAME NCHAR(30),@ADDRESS NCHAR(300),@PHONENUMBER NCHAR(11)
AS
INSERT INTO Customers(CustomerID,CustomerName,Address,PhoneNumber,Tier,Date)
VALUES (@CUSID, @CUSTOMERNAME,@ADDRESS,@PHONENUMBER, 6,GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[ADDEMPLOYEE]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ADDEMPLOYEE] @EMPLOYEEID INT,@EMPLOYEENAME NCHAR(30), @SALARY FLOAT, @ROLE NCHAR(10),@PHONENUMBER NCHAR(11),@ADDRESS NCHAR(300),@PASSWORD NCHAR(10), @BRANCHID INT
AS
INSERT INTO Employee(EmployeeId,EmployeeName,Salary,Role,PhoneNumber,Address,Password,BranchID,Date)
VALUES (@EMPLOYEEID,@EMPLOYEENAME, @SALARY, @ROLE,@PHONENUMBER,@ADDRESS,@PASSWORD, @BRANCHID,GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[AddInBody]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[AddInBody]
@InBodyID	int,
@Weight	Float, 
@Height	float,
@Age	int,
@Gender nchar(1), 
@MuscleMass	float,
@FatPercent float,
@CustomerID	int
AS
Insert INTO InBody(InBodyID ,Weight, Height, Age, Gender, MuscleMass, FatPercentage, CustomerID) 
Values(@InBodyID ,@Weight, @Height, @Age, @Gender, @MuscleMass, @FatPercent, @CustomerID)




GO
/****** Object:  StoredProcedure [dbo].[ADDMANAGER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ADDMANAGER] @EMPLOYEEID INT,@EMPLOYEENAME NCHAR(30), @SALARY FLOAT, @ROLE NCHAR(10),@PHONENUMBER NCHAR(11),@ADDRESS NCHAR(300),@PASSWORD NCHAR(10), @BRANCHID INT
AS
INSERT INTO Employee(EmployeeId,EmployeeName,Salary,Role,PhoneNumber,Address,Password,BranchID,Date)
VALUES (@EMPLOYEEID,@EMPLOYEENAME, @SALARY, @ROLE,@PHONENUMBER,@ADDRESS,@PASSWORD, @BRANCHID,GETDATE())
UPDATE BranchInformation
SET EmployeeID=(SELECT TOP 1 EmployeeId FROM Employee
                ORDER BY EmployeeId DESC)
WHERE BranchID=@BRANCHID
GO
/****** Object:  StoredProcedure [dbo].[AddNewUser]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddNewUser]
    @EmployeeID INT = NULL,
    @EmployeeName NCHAR(30),
    @Salary FLOAT,
    @Role NCHAR(10),
    @PhoneNumber NCHAR(11),
    @Address NCHAR(300),
    @Password NCHAR(10),
    @BranchID INT,
    @Date DATE,
    @Result INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Check if the password length is between 8 and 10 characters
        IF LEN(@Password) BETWEEN 8 AND 10
        BEGIN
            -- Insert new user into Employee table
            INSERT INTO Employee (EmployeeId, EmployeeName, Salary, Role, PhoneNumber, Address, Password, BranchID, Date)
            VALUES (@EmployeeID, @EmployeeName, @Salary, @Role, @PhoneNumber, @Address, @Password, @BranchID, @Date);

            -- Set success result
            SET @Result = 1;
        END
        ELSE
        BEGIN
            -- Set failure result due to invalid password length
            SET @Result = 0;
        END
    END TRY
    BEGIN CATCH
        -- Set failure result for any other errors
        SET @Result = 0;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[ADDORDER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ADDORDER] @ORDERID INT,@EMPLOYEEID INT, @CUSTOMERID INT
AS
INSERT INTO Orders(OrderID,Date,EmployeeID,CustomerID,TotalPrice)
VALUES (@ORDERID,GETDATE(),@EMPLOYEEID,@CUSTOMERID,NULL)
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddProduct] @pid int ,@pname nchar(10),@price float, @pres bit, @sid int
AS
BEGIN TRY
IF(SELECT Pname FROM Products WHERE Pname = @pname) IS NULL
BEGIN
INSERT INTO Products
Values(@pid,@price,@pres,@pname,@sid)
SELECT 1
END
ELSE
SELECT 0
END TRY
BEGIN CATCH
DECLARE @ErrorNumber INT = ERROR_NUMBER()
IF @ErrorNumber = 547
BEGIN
SELECT -1
END
ELSE IF @ErrorNumber = 2627
BEGIN
SELECT -2
END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[ADDPRODUCTINORDER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ADDPRODUCTINORDER] @ORDERID INT, @BATCHID INT, @QUANTITY INT
AS
IF(SELECT Quantity FROM Inventory WHERE BatchID=@BATCHID )>@QUANTITY
BEGIN
	INSERT INTO ProductsInOrder(OrderID,BatchID,Quantity)
	VALUES (@ORDERID,@BATCHID,@QUANTITY)
	UPDATE Inventory
	SET Quantity-=@QUANTITY
	WHERE BatchID=@BATCHID
END
ELSE RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[ADDPRODUCTINORDERSUBS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADDPRODUCTINORDERSUBS] @ORDERID INT, @PID INT, @QUANTITY INT
AS
DECLARE @BATCHID INT
SET @BATCHID=(SELECT TOP 1 BatchID FROM Inventory WHERE PID=@PID ORDER BY ABS(DATEDIFF(day, ExpiryDate, GETDATE())))  
IF(SELECT Quantity FROM Inventory WHERE BatchID=@BATCHID )>@QUANTITY
BEGIN
	INSERT INTO ProductsInOrder(OrderID,BatchID,Quantity)
	VALUES (@ORDERID,@BATCHID,@QUANTITY)
	UPDATE Inventory
	SET Quantity-=@QUANTITY
	WHERE BatchID=@BATCHID
END
ELSE RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[ADDPRODUCTINSUBSCRIPTION]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ADDPRODUCTINSUBSCRIPTION] @PID INT, @SUBSCRIPTIONID INT, @QUANTITY INT
AS
INSERT INTO ProductsInSubscriptions(PID,SubscriptionID,Quantity)
VALUES (@PID,@SUBSCRIPTIONID,@QUANTITY)
GO
/****** Object:  StoredProcedure [dbo].[ADDSUBSCRIPTION]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ADDSUBSCRIPTION] @SUBSCRIPTIONID INT,@INTERVAL int,@ACTIVE BIT, @CUSTOMERID INT
AS
INSERT INTO Subscriptions(SubscriptionID,Interval,Active,CustomerID,Date)
VALUES (@SUBSCRIPTIONID,@INTERVAL,@ACTIVE,@CUSTOMERID,GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[AddSup]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddSup] @supid int, @supname nchar(30), @supcity nchar(10) 
AS
BEGIN TRY
IF(SELECT SupplierName FROM Suppliers WHERE SupplierName = @supname) IS NULL
BEGIN
INSERT INTO Suppliers 
VALUES (@supid,@supname,@supcity)
SELECT 1
END
ELSE
SELECT 0
END TRY
BEGIN CATCH
DECLARE @ErrorNumber INT = ERROR_NUMBER()
IF @ErrorNumber = 2627
SELECT -1
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[ApproveRefund]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[ApproveRefund]
@OrderID	int,
@Description	nchar(100),
@EmployeeID	int
as
Declare @InsertSuccess BIT = 0;
Begin Try
	Insert into Refunds(OrderID, Description, EmployeeID)
	values(@OrderID, @Description, @EmployeeID)

	SET @InsertSuccess =1;
END Try

Begin Catch
	Throw;
END Catch

IF @InsertSuccess =1
Begin 
	exec UpdateBatchQuantity @OrderID
End
GO
/****** Object:  StoredProcedure [dbo].[BranchPerformance]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[BranchPerformance]
As
Select BranchID as Branch_ID, AVG(Rating) as Average_Rating
From ComplaintsAndReviews
Group By BranchID
GO
/****** Object:  StoredProcedure [dbo].[BudgetvSpent]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BudgetvSpent]
AS
BEGIN
    SELECT
        B.BranchID,B.Budget,
        (ISNULL(E.SalaryTotal, 0) + ISNULL(I.RestockTotal, 0)) AS Spent
    FROM
        BranchInformation B
    LEFT JOIN (
        SELECT
            BranchID,
            SUM(Salary) AS SalaryTotal
        FROM
            Employee
        GROUP BY
            BranchID
    ) E ON B.BranchID = E.BranchID
    LEFT JOIN (
        SELECT
            BranchID,
            SUM(Quantity * Price) AS RestockTotal
        FROM
            Inventory I
        INNER JOIN
            Products P ON I.PID = P.PID
        WHERE
            YEAR(RestockDate) = YEAR(GETDATE()) AND MONTH(RestockDate) = MONTH(GETDATE()) - 1
			OR
			YEAR(RestockDate) = YEAR(GETDATE()) - 1 AND MONTH(RestockDate) = 12 AND MONTH(GETDATE()) = 1
        GROUP BY
            BranchID
    ) I ON B.BranchID = I.BranchID;
END;

GO
/****** Object:  StoredProcedure [dbo].[CALCULATETOTAL]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CALCULATETOTAL] @ORDERID INT,@CUSTOMERID INT, @BEFOREDISCOUNTSANDOFFER FLOAT OUTPUT,@BEFOREDISCOUNTS FLOAT OUTPUT,@AFTER FLOAT OUTPUT
AS
SET @BEFOREDISCOUNTSANDOFFER=(SELECT SUM(PIO.Quantity*P.Price) FROM ProductsInOrder as PIO,Products AS P,Inventory AS I
				WHERE PIO.OrderID=@ORDERID AND PIO.BatchID=I.BatchID AND I.PID=P.PID)
SET @BEFOREDISCOUNTS=(SELECT SUM(PIO.Quantity*(1-I.OfferPercentage)*P.Price) FROM ProductsInOrder AS PIO,Products AS P,Inventory AS I
				WHERE PIO.OrderID=@ORDERID AND PIO.BatchID=I.BatchID AND I.PID=P.PID)
SET @AFTER=@BEFOREDISCOUNTS*(1-(SELECT DiscountPercentage FROM Discounts AS D,Customers AS C WHERE D.Tier=C.Tier AND C.CustomerID=@CUSTOMERID))

UPDATE Orders
SET TotalPrice=@AFTER
WHERE OrderID=@ORDERID
GO
/****** Object:  StoredProcedure [dbo].[ChangeBranchBudget]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChangeBranchBudget]
    @BranchID INT,
    @NewBudget DECIMAL(18, 2)
AS
BEGIN
    -- Check if the branch exists
    IF EXISTS (SELECT 1 FROM BranchInformation WHERE BranchID = @BranchID)
    BEGIN
        -- Update the branch budget
        UPDATE BranchInformation
        SET Budget = @NewBudget
        WHERE BranchID = @BranchID;
    END
    -- You may choose to handle cases where the branch does not exist
END;
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChangePassword]
    @EmployeeID INT,
    @OldPassword NVARCHAR(10),
    @NewPassword NVARCHAR(10)
AS
BEGIN
    -- Check if the old password is correct
    IF EXISTS (SELECT 1 FROM Employee WHERE EmployeeID = @EmployeeID AND Password = @OldPassword)
    BEGIN
        -- Update the password
        UPDATE Employee
        SET Password = @NewPassword
        WHERE EmployeeID = @EmployeeID;
    END
   
END;
GO
/****** Object:  StoredProcedure [dbo].[DailyReport]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DailyReport] @date date
AS
BEGIN
    SELECT
	    FORMAT(@date, 'dd/MM/yyyy') AS [date],
        COUNT(OrderID) AS NumberOfOrders,
        SUM(TotalPrice) AS TotalOfOrders,
        AVG(CAST(TotalPrice AS float)) AS AverageOfOrders
    FROM Orders
    WHERE Date = @date

END
GO
/****** Object:  StoredProcedure [dbo].[DEACTIVATESUBS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DEACTIVATESUBS] @SUBSCRIPTIONID INT
AS
UPDATE Subscriptions
SET Active=0
WHERE SubscriptionID=@SUBSCRIPTIONID
GO
/****** Object:  StoredProcedure [dbo].[DeleteBranch]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[DeleteBranch]
@BranchID	int
AS
Delete From BranchInformation WHERE BranchID = @BranchID;


GO
/****** Object:  StoredProcedure [dbo].[DelSup]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DelSup] @supname nchar(30)
AS
IF(SELECT SupplierName FROM Suppliers WHERE SupplierName = @supname) IS NOT NULL
BEGIN
DELETE FROM Suppliers WHERE SupplierName = @supname
SELECT 1
END
ELSE
SELECT 0
GO
/****** Object:  StoredProcedure [dbo].[ExpiryDiscounts]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[ExpiryDiscounts]
as
Update Inventory 
set OfferPercentage = OfferPercentage + 0.1
Where DATEADD(MONTH, 1, GETDATE()) > ExpiryDate and OfferPercentage < 0.21
GO
/****** Object:  StoredProcedure [dbo].[FindProduct]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindProduct]
@ProductID	INT
AS
Select dbo.BranchInformation.BranchID, dbo.BranchInformation.Location from BranchInformation JOIN Inventory ON BranchInformation.BranchID = Inventory.BranchID
Where Inventory.PID = @ProductID

GO
/****** Object:  StoredProcedure [dbo].[FIREEMPLOYEE]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FIREEMPLOYEE] @SSN INT
AS
DELETE FROM Employee
WHERE EmployeeId=@SSN
GO
/****** Object:  StoredProcedure [dbo].[FIREMANAGER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FIREMANAGER] @SSN INT
AS
DELETE FROM Employee
WHERE EmployeeId=@SSN
GO
/****** Object:  StoredProcedure [dbo].[GET0SUBS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET0SUBS]
AS 
SELECT SubscriptionID
FROM Subscriptions
WHERE Active=0
GO
/****** Object:  StoredProcedure [dbo].[GET1SUBS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET1SUBS]
AS 
SELECT SubscriptionID
FROM Subscriptions
WHERE Active=1
GO
/****** Object:  StoredProcedure [dbo].[GETBATCHIDS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETBATCHIDS] @BRANCHID INT
AS
SELECT BatchID,Quantity
FROM Inventory
WHERE @BRANCHID=BranchID AND Quantity>0
GO
/****** Object:  StoredProcedure [dbo].[GETBD]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETBD] @ORDERID INT
AS
SELECT SUM(PIO.Quantity*(1-I.OfferPercentage)*P.Price) FROM ProductsInOrder AS PIO,Products AS P,Inventory AS I
				WHERE PIO.OrderID=@ORDERID AND PIO.BatchID=I.BatchID AND I.PID=P.PID
GO
/****** Object:  StoredProcedure [dbo].[GETBDAO]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETBDAO] @ORDERID INT
AS
SELECT SUM(PIO.Quantity*P.Price) FROM ProductsInOrder as PIO,Products AS P,Inventory AS I
				WHERE PIO.OrderID=@ORDERID AND PIO.BatchID=I.BatchID AND I.PID=P.PID

GO
/****** Object:  StoredProcedure [dbo].[GetBranches]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBranches]
AS
BEGIN
SELECT * FROM BranchInformation
END
GO
/****** Object:  StoredProcedure [dbo].[GetBranchID]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetBranchID]
    @EmployeeID INT

AS
BEGIN
    SELECT BranchID
    FROM Employee
    WHERE EmployeeID = @EmployeeID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GETBRANCHIDS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GETBRANCHIDS]
AS
SELECT BranchID
FROM BranchInformation
GO
/****** Object:  StoredProcedure [dbo].[GETCUSOFAUBS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETCUSOFAUBS] @SUBSCRIPTIONID INT
AS 
SELECT CustomerID
FROM Subscriptions
WHERE SubscriptionID=@SUBSCRIPTIONID
GO
/****** Object:  StoredProcedure [dbo].[GETCUSTOMERIDS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETCUSTOMERIDS]
AS
SELECT CustomerID
FROM Customers
GO
/****** Object:  StoredProcedure [dbo].[GetCustomers]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomers]
AS
BEGIN
SELECT * FROM Customers
END
GO
/****** Object:  StoredProcedure [dbo].[GETEMPLOYEEID]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETEMPLOYEEID]
AS
SELECT EmployeeId
FROM Employee
GO
/****** Object:  StoredProcedure [dbo].[GETEMPLOYEES]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETEMPLOYEES]
AS
SELECT EmployeeId
FROM Employee
WHERE EmployeeId NOT IN (SELECT EmployeeID
FROM BranchInformation) 
GO
/****** Object:  StoredProcedure [dbo].[GetLoginRole]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetLoginRole]
    @EmployeeID INT,
    @Password NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Job NVARCHAR(10);

    -- Check if the provided EmployeeID and Password match a record in the Employee table
    SELECT @Job = Role
    FROM Employee
    WHERE EmployeeID = @EmployeeID AND Password = @Password;

    -- Return the job if a matching record is found
    IF @@ROWCOUNT > 0
    BEGIN
        SELECT @Job AS 'Job';
    END
    ELSE
    BEGIN
        -- Return NULL if credentials are invalid
        SELECT NULL AS 'Job';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[GETMANAGERS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETMANAGERS]
AS
SELECT EmployeeID
FROM BranchInformation
GO
/****** Object:  StoredProcedure [dbo].[GETPIDS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETPIDS]
AS 
SELECT PID
FROM Products
GO
/****** Object:  StoredProcedure [dbo].[GETPRODUCTIDS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETPRODUCTIDS]
AS
SELECT PID
FROM Products
GO
/****** Object:  StoredProcedure [dbo].[GetProducts]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProducts]
AS
BEGIN
SELECT Pname,PID FROM Products
END
GO
/****** Object:  StoredProcedure [dbo].[GETPRODUCTSINSUBS]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETPRODUCTSINSUBS] @SUBSCRIPTIONID INT
AS
SELECT PID, Quantity
FROM ProductsInSubscriptions
WHERE SubscriptionID=@SUBSCRIPTIONID
GO
/****** Object:  StoredProcedure [dbo].[GETQUANTITY]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETQUANTITY] @BATCHID INT
AS
SELECT DISTINCT(Quantity)
FROM Inventory
WHERE @BATCHID=BatchID
GO
/****** Object:  StoredProcedure [dbo].[GETSBATCHID]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GETSBATCHID] @PID INT
AS
SELECT TOP 1 BatchID FROM Inventory WHERE PID=@PID ORDER BY ABS(DATEDIFF(day, ExpiryDate, GETDATE()))






GO
/****** Object:  StoredProcedure [dbo].[GetSup]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSup]
AS
BEGIN
SELECT * FROM Suppliers
END
GO
/****** Object:  StoredProcedure [dbo].[GETTIER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GETTIER] @CUSTOMERID INT
AS
SELECT DISTINCT(Tier)
FROM Customers
WHERE CustomerID=@CUSTOMERID
GO
/****** Object:  StoredProcedure [dbo].[GETTODAYSUBSCRIPTION]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETTODAYSUBSCRIPTION] 
AS
DECLARE @CUDATE DATE
SET @CUDATE = GETDATE()
SELECT SubscriptionID
FROM Subscriptions
WHERE DATEDIFF(day, Date, @CUDATE) > 0 AND Interval % DATEDIFF(day, Date, @CUDATE) = 0 AND Active=1;
GO
/****** Object:  StoredProcedure [dbo].[GETTOTAL]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETTOTAL] @ORDERID INT
AS 
SELECT DISTINCT(TotalPrice)
FROM Orders
WHERE OrderID=@ORDERID
GO
/****** Object:  StoredProcedure [dbo].[NewCustomers]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[NewCustomers]
as
Select FORMAT(Date, 'yyyy-MM') AS month, COUNT(CustomerID) AS New_Customers
From Customers 
Group By FORMAT(Date, 'yyyy-MM')

GO
/****** Object:  StoredProcedure [dbo].[NewSubscribers]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[NewSubscribers]
as
Select FORMAT(Date, 'yyyy-MM') AS month, COUNT(SubscriptionID) AS New_Subscribers
From Subscriptions 
Group By FORMAT(Date, 'yyyy-MM')

GO
/****** Object:  StoredProcedure [dbo].[Restock]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Restock] @id int, @pid int, @qty int, @off float, @bid int, @expdate date
AS
BEGIN TRY
IF(@expdate > GETDATE())
BEGIN
INSERT INTO Inventory (BatchID,Quantity,ExpiryDate,OfferPercentage,BranchID,PID)
Values(@id,@qty,@expdate,@off,@bid,@pid)
SELECT 1
END
ELSE
SELECT 0
END TRY
BEGIN CATCH
DECLARE @ErrorNumber INT = ERROR_NUMBER()
IF @ErrorNumber = 547
BEGIN
SELECT -1
END
ELSE IF @ErrorNumber = 2627
BEGIN
SELECT -2
END
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[Revenue]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Revenue] @year int
AS
SELECT BranchID, SUM(TotalPrice) FROM Orders, Employee WHERE Orders.EmployeeID = Employee.EmployeeId  AND YEAR(Orders.Date) = @year AND OrderID NOT IN (SELECT OrderID FROM Refunds) GROUP BY BranchID
GO
/****** Object:  StoredProcedure [dbo].[Reviews]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Reviews] @bid int, @rating1 float, @rating2 float
AS
Select * FROM ComplaintsAndReviews WHERE BranchID = @bid AND Rating >= @rating1 and Rating <= @rating2
GO
/****** Object:  StoredProcedure [dbo].[TotalEmployees]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[TotalEmployees]
As
With EmployeeCount AS(
SELECT 
    FORMAT(Date, 'yyyy-MM') AS month,
    COUNT(EmployeeId) AS new_Employees
FROM 
    Employee
GROUP BY 
    FORMAT(Date, 'yyyy-MM')

)

Select
	month,
	SUM(new_Employees) OVER (ORDER BY month ROWS UNBOUNDED PRECEDING) as total_employees
From EmployeeCount
Order By month;
GO
/****** Object:  StoredProcedure [dbo].[UpdateBatchQuantity]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UpdateBatchQuantity]
    @OrderID INT
AS
BEGIN
    UPDATE I
    SET I.Quantity = I.Quantity + P.Quantity
    FROM Inventory I
    INNER JOIN ProductsInOrder P ON I.BatchID = P.BatchID
    WHERE P.OrderID = @OrderID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UPDATEMANAGER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATEMANAGER] @SSN INT, @BRANCHID INT
AS
UPDATE BranchInformation
SET EmployeeID=@SSN
WHERE BranchID=@BRANCHID
GO
/****** Object:  StoredProcedure [dbo].[UPDATEOFFER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATEOFFER] @BATCHID INT,@NEWOFFER FLOAT
AS
UPDATE Inventory
SET OfferPercentage=@NEWOFFER
WHERE BatchID=@BATCHID
GO
/****** Object:  StoredProcedure [dbo].[UPDATEPRICE]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATEPRICE] @PID INT,@NEWPRICE FLOAT
AS
UPDATE Products
SET Price=@NEWPRICE
WHERE PID=@PID
GO
/****** Object:  StoredProcedure [dbo].[UPGRADETIER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPGRADETIER] @CUSTOMERID INT
AS
	IF(SELECT SUM(TotalPrice) FROM Orders
	WHERE CustomerID=@CUSTOMERID)<1000 AND (SELECT Tier FROM Customers WHERE CustomerID=@CUSTOMERID)=6
	BEGIN
	Update Customers
	SET Tier=7
	WHERE CustomerID=@CUSTOMERID
	END
	ELSE
		IF(SELECT SUM(TotalPrice) FROM Orders
		WHERE CustomerID=@CUSTOMERID)<2000 AND (SELECT Tier FROM Customers WHERE CustomerID=@CUSTOMERID)=7
		BEGIN
		Update Customers
		SET Tier=8
		WHERE CustomerID=@CUSTOMERID
		END
		ELSE
			IF(SELECT SUM(TotalPrice) FROM Orders
			WHERE CustomerID=@CUSTOMERID)<3000 AND (SELECT Tier FROM Customers WHERE CustomerID=@CUSTOMERID)=8
			BEGIN
			Update Customers
			SET Tier=9
			WHERE CustomerID=@CUSTOMERID
			END

GO
/****** Object:  StoredProcedure [dbo].[ViewInBody]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewInBody] @cid int
AS
Select * FROM InBody WHERE CustomerID = @cid
GO
/****** Object:  StoredProcedure [dbo].[VIEWPRODUCTSINORDER]    Script Date: 12/28/2023 7:46:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[VIEWPRODUCTSINORDER] @ORDERID INT
AS 
SELECT P.PID,P.Pname,P.Price,PIO.Quantity,(P.Price*PIO.Quantity) AS Total,I.OfferPercentage
FROM Products AS P, Inventory AS I,ProductsInOrder AS PIO
WHERE P.PID=I.PID AND I.BatchID=PIO.BatchID AND PIO.OrderID IN(SELECT OrderID FROM ProductsInOrder WHERE OrderID=@ORDERID)
GO
