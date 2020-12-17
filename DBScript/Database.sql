SET IDENTITY_INSERT [dbo].[Customer_Detail] ON
INSERT INTO [dbo].[Customer_Detail] ([Id], [Customer_Name], [Email], [Phone], [Address]) VALUES (1, N'sukhjeet kaur', N'kaursukh099@gmail.com', N'0223456787', N'13 philip street, papatoetoe')
INSERT INTO [dbo].[Customer_Detail] ([Id], [Customer_Name], [Email], [Phone], [Address]) VALUES (2, N'Manu', N'manu97768@gmail.com', N'076688668876', N'44 gore street, britomart')
INSERT INTO [dbo].[Customer_Detail] ([Id], [Customer_Name], [Email], [Phone], [Address]) VALUES (3, N'John', N'john5566@yahoo.com', N'68977856577', N'1/2 holly street, Auckland')
INSERT INTO [dbo].[Customer_Detail] ([Id], [Customer_Name], [Email], [Phone], [Address]) VALUES (4, N'Samar', N'Samar7789@hotmail.com', N'35567722', N'3, holly street, Auckland')
INSERT INTO [dbo].[Customer_Detail] ([Id], [Customer_Name], [Email], [Phone], [Address]) VALUES (5, N'Symon', N'Symon9002@gmail.com', N'22346767', N'12 philip street, Papatoetoe')
INSERT INTO [dbo].[Customer_Detail] ([Id], [Customer_Name], [Email], [Phone], [Address]) VALUES (6, N'Ritu', N'Rituritu988@gmail.com', N'32288799', N'4 holly street, Avondale')
INSERT INTO [dbo].[Customer_Detail] ([Id], [Customer_Name], [Email], [Phone], [Address]) VALUES (7, N'Gagan ', N'gagan5002@hotmail.com', N'20098765', N'10 holly ave, Avondale')
INSERT INTO [dbo].[Customer_Detail] ([Id], [Customer_Name], [Email], [Phone], [Address]) VALUES (8, N'Raj', N'rajaraj1997@gmail.com', N'277688900', N'1 coronation road, mangere')
SET IDENTITY_INSERT [dbo].[Customer_Detail] OFF
SET IDENTITY_INSERT [dbo].[Dealer_Detail] ON
INSERT INTO [dbo].[Dealer_Detail] ([Id], [Dealer_Name], [Dealer_Address], [Mobile], [Email]) VALUES (1, N'Vishal', N'25, shirley street, papatoetoe', N'022564783', N'Vishal2000@yahoo.com')
INSERT INTO [dbo].[Dealer_Detail] ([Id], [Dealer_Name], [Dealer_Address], [Mobile], [Email]) VALUES (2, N'Wiliam', N'11, Great south road', N'2338899666', N'william2005@gmail.com')
INSERT INTO [dbo].[Dealer_Detail] ([Id], [Dealer_Name], [Dealer_Address], [Mobile], [Email]) VALUES (3, N'Shilpa', N'202 shirley road', N'3777899777', N'shilpashilpa222@gmail.com')
INSERT INTO [dbo].[Dealer_Detail] ([Id], [Dealer_Name], [Dealer_Address], [Mobile], [Email]) VALUES (4, N'Rishabh', N'404, holly street, Avondale', N'2335566778', N'rishabhrishabh333@yahoo.com')
INSERT INTO [dbo].[Dealer_Detail] ([Id], [Dealer_Name], [Dealer_Address], [Mobile], [Email]) VALUES (5, N'Nitin Verma', N'55, holly street, Avondale', N'200088776', N'nitinverma9000@hotmail.com')
SET IDENTITY_INSERT [dbo].[Dealer_Detail] OFF
SET IDENTITY_INSERT [dbo].[Property_Detail] ON
INSERT INTO [dbo].[Property_Detail] ([Id], [Property_Type], [Area], [Price], [Facilities]) VALUES (1, N'Flat ', N'city', CAST(23000.00 AS Decimal(18, 2)), N'Including pool and gym')
INSERT INTO [dbo].[Property_Detail] ([Id], [Property_Type], [Area], [Price], [Facilities]) VALUES (2, N'Banglow', N'Hill side, Papatoetoe', CAST(35050.00 AS Decimal(18, 2)), N'park including')
INSERT INTO [dbo].[Property_Detail] ([Id], [Property_Type], [Area], [Price], [Facilities]) VALUES (3, N'Studio house', N'Britomart', CAST(50000.00 AS Decimal(18, 2)), N'Fully furnished')
INSERT INTO [dbo].[Property_Detail] ([Id], [Property_Type], [Area], [Price], [Facilities]) VALUES (4, N'House', N'Avondale, Auckland', CAST(80000.00 AS Decimal(18, 2)), N'Fully furnished including personal gym')
INSERT INTO [dbo].[Property_Detail] ([Id], [Property_Type], [Area], [Price], [Facilities]) VALUES (5, N'Studio house', N'Queens street', CAST(45500.00 AS Decimal(18, 2)), N'Fully furnished')
INSERT INTO [dbo].[Property_Detail] ([Id], [Property_Type], [Area], [Price], [Facilities]) VALUES (6, N'Flat', N'Manukau', CAST(70000.00 AS Decimal(18, 2)), N'Park and fully furnished')
SET IDENTITY_INSERT [dbo].[Property_Detail] OFF
SET IDENTITY_INSERT [dbo].[Property_Oction] ON
INSERT INTO [dbo].[Property_Oction] ([Id], [Bid_Price], [Property_DetailId], [Customer_DetailId], [Dealer_DetailId]) VALUES (1, CAST(32000.00 AS Decimal(18, 2)), 1, 1, 1)
INSERT INTO [dbo].[Property_Oction] ([Id], [Bid_Price], [Property_DetailId], [Customer_DetailId], [Dealer_DetailId]) VALUES (2, CAST(47000.00 AS Decimal(18, 2)), 2, 4, 3)
INSERT INTO [dbo].[Property_Oction] ([Id], [Bid_Price], [Property_DetailId], [Customer_DetailId], [Dealer_DetailId]) VALUES (3, CAST(50050.00 AS Decimal(18, 2)), 4, 6, 2)
INSERT INTO [dbo].[Property_Oction] ([Id], [Bid_Price], [Property_DetailId], [Customer_DetailId], [Dealer_DetailId]) VALUES (4, CAST(50055.00 AS Decimal(18, 2)), 5, 5, 1)
INSERT INTO [dbo].[Property_Oction] ([Id], [Bid_Price], [Property_DetailId], [Customer_DetailId], [Dealer_DetailId]) VALUES (5, CAST(65000.00 AS Decimal(18, 2)), 6, 3, 5)
SET IDENTITY_INSERT [dbo].[Property_Oction] OFF