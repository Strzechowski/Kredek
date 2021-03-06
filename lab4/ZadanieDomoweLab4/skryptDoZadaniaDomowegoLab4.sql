USE [ZadanieDomoweLab3]
GO
/****** Object:  Table [dbo].[Animals]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animals](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[NameOfTheAnimal] [nvarchar](31) NOT NULL,
	[HowManyAnimals] [smallint] NOT NULL,
	[BasicInfoId] [smallint] NOT NULL,
	[EmployeesInfoId] [smallint] NOT NULL,
 CONSTRAINT [PK_Animals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BasicInfos]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BasicInfos](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[TypeOfAnAnimal] [nvarchar](15) NOT NULL,
	[Climate] [nvarchar](31) NOT NULL,
 CONSTRAINT [PK_BasicInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Buildings]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buildings](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[NameOfTheBuilding] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Buildings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](31) NOT NULL,
	[Surname] [nvarchar](31) NOT NULL,
	[PESEL] [nchar](11) NOT NULL,
	[JobId] [smallint] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeesInfos]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeesInfos](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[FoodForAnimal] [nvarchar](31) NOT NULL,
	[HowManyTimesFed] [smallint] NOT NULL,
 CONSTRAINT [PK_EmployeesInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Foods]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foods](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[NameOfFood] [nvarchar](31) NOT NULL,
	[Price] [smallint] NOT NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TicketPrices]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketPrices](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[TypeOfTicket] [nvarchar](31) NOT NULL,
	[Price] [smallint] NOT NULL,
 CONSTRAINT [PK_TicketPrice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Visitors]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitors](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Hour] [nvarchar](15) NOT NULL,
	[HowManyVisitors] [nvarchar](31) NOT NULL,
 CONSTRAINT [PK_Visitors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkSchedules]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkSchedules](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[BuildingId] [smallint] NOT NULL,
	[EmployeeId] [smallint] NULL,
	[AnimalId] [smallint] NOT NULL,
 CONSTRAINT [PK_WorkSchedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkTypes]    Script Date: 03.12.2017 19:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkTypes](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Job] [nvarchar](31) NOT NULL,
	[Salary] [smallint] NOT NULL,
 CONSTRAINT [PK_WorkType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Animals] ON 

INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (1, N'Tygrys', 3, 6, 2)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (2, N'Pingwin', 7, 4, 5)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (3, N'Zebra', 4, 6, 1)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (4, N'Żyrafa', 2, 6, 1)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (5, N'Lew', 3, 6, 2)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (6, N'Paw', 5, 2, 4)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (7, N'Sowa', 7, 2, 4)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (8, N'Bocian', 5, 2, 4)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (9, N'Pawian', 6, 5, 4)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (10, N'Niedźwiedź', 2, 1, 5)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (11, N'Żółw Olbrzymi', 10, 7, 4)
INSERT [dbo].[Animals] ([Id], [NameOfTheAnimal], [HowManyAnimals], [BasicInfoId], [EmployeesInfoId]) VALUES (12, N'Aligator', 4, 7, 3)
SET IDENTITY_INSERT [dbo].[Animals] OFF
SET IDENTITY_INSERT [dbo].[BasicInfos] ON 

INSERT [dbo].[BasicInfos] ([Id], [TypeOfAnAnimal], [Climate]) VALUES (1, N'Ssak', N'Umiarkowany')
INSERT [dbo].[BasicInfos] ([Id], [TypeOfAnAnimal], [Climate]) VALUES (2, N'Ptak', N'Umiarkowany')
INSERT [dbo].[BasicInfos] ([Id], [TypeOfAnAnimal], [Climate]) VALUES (3, N'Gad', N'Umiarkowany')
INSERT [dbo].[BasicInfos] ([Id], [TypeOfAnAnimal], [Climate]) VALUES (4, N'Ptak', N'Polarny')
INSERT [dbo].[BasicInfos] ([Id], [TypeOfAnAnimal], [Climate]) VALUES (5, N'Ssak', N'Tropikalny')
INSERT [dbo].[BasicInfos] ([Id], [TypeOfAnAnimal], [Climate]) VALUES (6, N'Ssak', N'Sawanna')
INSERT [dbo].[BasicInfos] ([Id], [TypeOfAnAnimal], [Climate]) VALUES (7, N'Gad', N'Tropikalny')
SET IDENTITY_INSERT [dbo].[BasicInfos] OFF
SET IDENTITY_INSERT [dbo].[Buildings] ON 

INSERT [dbo].[Buildings] ([Id], [NameOfTheBuilding]) VALUES (1, N'Afrykarium')
INSERT [dbo].[Buildings] ([Id], [NameOfTheBuilding]) VALUES (2, N'Akwarium')
INSERT [dbo].[Buildings] ([Id], [NameOfTheBuilding]) VALUES (3, N'Terrarium')
INSERT [dbo].[Buildings] ([Id], [NameOfTheBuilding]) VALUES (4, N'Małpiarnia')
INSERT [dbo].[Buildings] ([Id], [NameOfTheBuilding]) VALUES (5, N'Wybieg')
INSERT [dbo].[Buildings] ([Id], [NameOfTheBuilding]) VALUES (6, N'Ptaszarnia')
SET IDENTITY_INSERT [dbo].[Buildings] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (2, N'Andrzej', N'Duda', N'52082913196', 3)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (3, N'Ricky', N'Martin', N'45121800094', 3)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (4, N'Jolanta', N'Karwasik', N'40122517394', 2)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (5, N'Dariusz', N'Mariusz', N'67041407537', 2)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (6, N'Tom', N'Mały', N'82072614840', 3)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (7, N'Robin', N'van Persie', N'73737373222', 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (10, N'Tom', N'Hanks', N'73737373777', 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (12, N'Robin', N'Van Persiev2', N'44444455566', 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (13, N'Boby', N'van Persie', N'77777777799', 3)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (14, N'Paweł', N'Luboczkin', N'88883333412', 2)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (15, N'Boby', N'Nowak', N'45123373222', 1)
INSERT [dbo].[Employees] ([Id], [Name], [Surname], [PESEL], [JobId]) VALUES (18, N'Tom', N'Hanks', N'73737373777', 3)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[EmployeesInfos] ON 

INSERT [dbo].[EmployeesInfos] ([Id], [FoodForAnimal], [HowManyTimesFed]) VALUES (1, N'Ziarna i owoce', 3)
INSERT [dbo].[EmployeesInfos] ([Id], [FoodForAnimal], [HowManyTimesFed]) VALUES (2, N'Mięso', 3)
INSERT [dbo].[EmployeesInfos] ([Id], [FoodForAnimal], [HowManyTimesFed]) VALUES (3, N'Mięso', 4)
INSERT [dbo].[EmployeesInfos] ([Id], [FoodForAnimal], [HowManyTimesFed]) VALUES (4, N'Ziarna', 4)
INSERT [dbo].[EmployeesInfos] ([Id], [FoodForAnimal], [HowManyTimesFed]) VALUES (5, N'Ryby', 3)
INSERT [dbo].[EmployeesInfos] ([Id], [FoodForAnimal], [HowManyTimesFed]) VALUES (6, N'Owoce', 4)
SET IDENTITY_INSERT [dbo].[EmployeesInfos] OFF
SET IDENTITY_INSERT [dbo].[Foods] ON 

INSERT [dbo].[Foods] ([Id], [NameOfFood], [Price]) VALUES (1, N'Tost z serem', 6)
INSERT [dbo].[Foods] ([Id], [NameOfFood], [Price]) VALUES (2, N'Kanapka z szynką', 5)
INSERT [dbo].[Foods] ([Id], [NameOfFood], [Price]) VALUES (3, N'Burger', 10)
INSERT [dbo].[Foods] ([Id], [NameOfFood], [Price]) VALUES (4, N'Hot Dog', 7)
INSERT [dbo].[Foods] ([Id], [NameOfFood], [Price]) VALUES (5, N'Pizza dla 2 ', 16)
INSERT [dbo].[Foods] ([Id], [NameOfFood], [Price]) VALUES (6, N'Woda 0,5l', 1)
INSERT [dbo].[Foods] ([Id], [NameOfFood], [Price]) VALUES (7, N'Napój 0,5l', 2)
INSERT [dbo].[Foods] ([Id], [NameOfFood], [Price]) VALUES (8, N'Herbata/Kawa', 2)
SET IDENTITY_INSERT [dbo].[Foods] OFF
SET IDENTITY_INSERT [dbo].[TicketPrices] ON 

INSERT [dbo].[TicketPrices] ([Id], [TypeOfTicket], [Price]) VALUES (1, N'Normalny', 40)
INSERT [dbo].[TicketPrices] ([Id], [TypeOfTicket], [Price]) VALUES (2, N'Ulgowy', 30)
INSERT [dbo].[TicketPrices] ([Id], [TypeOfTicket], [Price]) VALUES (3, N'Studencki', 35)
INSERT [dbo].[TicketPrices] ([Id], [TypeOfTicket], [Price]) VALUES (4, N'Rodzinny (2+2)', 120)
INSERT [dbo].[TicketPrices] ([Id], [TypeOfTicket], [Price]) VALUES (6, N'Grupowy', 30)
INSERT [dbo].[TicketPrices] ([Id], [TypeOfTicket], [Price]) VALUES (7, N'Grupowy ulgowy', 25)
SET IDENTITY_INSERT [dbo].[TicketPrices] OFF
SET IDENTITY_INSERT [dbo].[Visitors] ON 

INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (1, N'8', N'B.Niewielki Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (2, N'9', N'Niewielki Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (3, N'10', N'Niewielki Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (4, N'11', N'Niewielki Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (5, N'12', N'Średni Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (6, N'13', N'Średni Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (7, N'14', N'Średni Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (8, N'15', N'Duży Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (9, N'16', N'Duży Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (10, N'17', N'Duży Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (11, N'18', N'Duży Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (12, N'19', N'Średni Ruch')
INSERT [dbo].[Visitors] ([Id], [Hour], [HowManyVisitors]) VALUES (13, N'20', N'Niewielki Ruch')
SET IDENTITY_INSERT [dbo].[Visitors] OFF
SET IDENTITY_INSERT [dbo].[WorkSchedules] ON 

INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (1, 5, 2, 1)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (2, 2, 6, 2)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (3, 5, 3, 3)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (4, 1, 3, 4)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (5, 5, 7, 5)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (6, 6, 2, 6)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (7, 6, 6, 7)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (8, 6, 7, 8)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (9, 4, 7, 9)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (10, 5, 6, 10)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (11, 3, 3, 11)
INSERT [dbo].[WorkSchedules] ([Id], [BuildingId], [EmployeeId], [AnimalId]) VALUES (12, 3, 2, 12)
SET IDENTITY_INSERT [dbo].[WorkSchedules] OFF
SET IDENTITY_INSERT [dbo].[WorkTypes] ON 

INSERT [dbo].[WorkTypes] ([Id], [Job], [Salary]) VALUES (1, N'Manager', 5000)
INSERT [dbo].[WorkTypes] ([Id], [Job], [Salary]) VALUES (2, N'Ogrodnik', 3000)
INSERT [dbo].[WorkTypes] ([Id], [Job], [Salary]) VALUES (3, N'Opiekun Zwierząt', 3500)
SET IDENTITY_INSERT [dbo].[WorkTypes] OFF
ALTER TABLE [dbo].[Animals]  WITH CHECK ADD  CONSTRAINT [FK_Animals_BasicInfo] FOREIGN KEY([BasicInfoId])
REFERENCES [dbo].[BasicInfos] ([Id])
GO
ALTER TABLE [dbo].[Animals] CHECK CONSTRAINT [FK_Animals_BasicInfo]
GO
ALTER TABLE [dbo].[Animals]  WITH CHECK ADD  CONSTRAINT [FK_Animals_EmployeesInfo] FOREIGN KEY([EmployeesInfoId])
REFERENCES [dbo].[EmployeesInfos] ([Id])
GO
ALTER TABLE [dbo].[Animals] CHECK CONSTRAINT [FK_Animals_EmployeesInfo]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_WorkTypes] FOREIGN KEY([JobId])
REFERENCES [dbo].[WorkTypes] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_WorkTypes]
GO
ALTER TABLE [dbo].[WorkSchedules]  WITH CHECK ADD  CONSTRAINT [FK_WorkSchedule_Animals] FOREIGN KEY([AnimalId])
REFERENCES [dbo].[Animals] ([Id])
GO
ALTER TABLE [dbo].[WorkSchedules] CHECK CONSTRAINT [FK_WorkSchedule_Animals]
GO
ALTER TABLE [dbo].[WorkSchedules]  WITH CHECK ADD  CONSTRAINT [FK_WorkSchedule_Buildings] FOREIGN KEY([BuildingId])
REFERENCES [dbo].[Buildings] ([Id])
GO
ALTER TABLE [dbo].[WorkSchedules] CHECK CONSTRAINT [FK_WorkSchedule_Buildings]
GO
ALTER TABLE [dbo].[WorkSchedules]  WITH CHECK ADD  CONSTRAINT [FK_WorkSchedule_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[WorkSchedules] CHECK CONSTRAINT [FK_WorkSchedule_Employees]
GO
