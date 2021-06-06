GO
SET IDENTITY_INSERT [dbo].[CountryInfos] ON 
GO
INSERT [dbo].[CountryInfos] ([Id], [CountryName]) VALUES (1, N'Spain')
GO
INSERT [dbo].[CountryInfos] ([Id], [CountryName]) VALUES (2, N'Germany')
GO
INSERT [dbo].[CountryInfos] ([Id], [CountryName]) VALUES (3, N'England')
GO
INSERT [dbo].[CountryInfos] ([Id], [CountryName]) VALUES (4, N'France')
GO
INSERT [dbo].[CountryInfos] ([Id], [CountryName]) VALUES (5, N'Italy')
GO
INSERT [dbo].[CountryInfos] ([Id], [CountryName]) VALUES (6, N'Netherlands')
GO
SET IDENTITY_INSERT [dbo].[CountryInfos] OFF
GO
SET IDENTITY_INSERT [dbo].[TeamInfos] ON 
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (1, N'Atlético Madrid', 1, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (2, N'Real Madrid', 1, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (3, N'FC Barcelona', 1, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (4, N'Bayern Munich', 2, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (5, N'Borussia Dortmund', 2, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (6, N'Manchester United', 3, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (7, N'Liverpool', 3, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (8, N'Manchester City', 3, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (9, N'Chelsea', 3, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (10, N'Arsenal', 3, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (11, N'Tottenham Hotspur', 3, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (12, N'Juventus', 5, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (13, N'Paris Saint-Germain', 4, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (14, N'Internazionale', 5, NULL)
GO
INSERT [dbo].[TeamInfos] ([Id], [TeamName], [CountryID], [CountryInfoId]) VALUES (15, N'Ajax', 6, NULL)
GO
SET IDENTITY_INSERT [dbo].[TeamInfos] OFF
GO
SET IDENTITY_INSERT [dbo].[YearInfos] ON 
GO
INSERT [dbo].[YearInfos] ([Id], [YearName]) VALUES (1, N'2019')
GO
INSERT [dbo].[YearInfos] ([Id], [YearName]) VALUES (2, N'2018')
GO
SET IDENTITY_INSERT [dbo].[YearInfos] OFF
GO
SET IDENTITY_INSERT [dbo].[Rankings] ON 
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (1, 4239, 43, 2, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (2, 4205, 40, 3, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (3, 3808, 38, 6, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (4, 3024, 30, 4, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (5, 2688, 26, 8, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (6, 2576, 25, 9, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (7, 2183, 21, 7, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (8, 1512, 15, 12, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (9, 1092, 10, 13, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (10, 953, 9, 1, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (11, 896, 8, 5, NULL, 1, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (12, 1000, 62, 1, NULL, 2, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (13, 4750, 92, 2, NULL, 2, NULL)
GO
INSERT [dbo].[Rankings] ([Id], [ValueInMillions], [OperatingIncome], [TeamID], [TeamInfoId], [YearID], [YearInfoId]) VALUES (14, 4760, 62, 3, NULL, 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[Rankings] OFF
GO
