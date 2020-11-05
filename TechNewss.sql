USE [TechNews]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[aID] [int] IDENTITY(1,1) NOT NULL,
	[aUsername] [varchar](50) NULL,
	[aPassword] [varchar](32) NULL,
	[aFullname] [varchar](100) NULL,
	[aEmail] [varchar](100) NULL,
	[aStatus] [int] NULL,
	[aDateAdded] [date] NULL,
	[roleID] [int] NULL,
	[countryID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[aID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[cateID] [int] IDENTITY(1,1) NOT NULL,
	[cateName] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[commentID] [int] IDENTITY(1,1) NOT NULL,
	[commentContent] [text] NULL,
	[aID] [int] NULL,
	[postID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[commentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[countryID] [int] IDENTITY(1,1) NOT NULL,
	[countryName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[countryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[hID] [int] IDENTITY(1,1) NOT NULL,
	[dateSubmited] [date] NULL,
	[dateAccepted] [date] NULL,
	[typeAccept] [int] NULL,
	[censorID] [int] NULL,
	[posterID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[hID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Picture]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Picture](
	[picID] [int] IDENTITY(1,1) NOT NULL,
	[picURL] [varchar](100) NULL,
	[postID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[picID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[postID] [int] IDENTITY(1,1) NOT NULL,
	[postTitle] [varchar](255) NULL,
	[postContent] [text] NULL,
	[cateID] [int] NULL,
	[hID] [int] NULL,
	[statusID] [int] NULL,
 CONSTRAINT [PK__Post__DD0C73BA69215256] PRIMARY KEY CLUSTERED 
(
	[postID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[roleID] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statuss]    Script Date: 11/5/2020 11:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuss](
	[statusID] [int] NOT NULL,
	[statusName] [nchar](10) NULL,
 CONSTRAINT [PK_Statuss] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (1, N'phucth', N'13656719b7199a8bc6ca597cf0fcdaf1', N'Tran Hoang Phuc', N'phuc@gmai.com', 0, CAST(N'2020-10-26' AS Date), 1, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (2, N'quith', N'12345', N'Tran Hoang Qui', N'qui@gmai.com', 0, CAST(N'2020-10-26' AS Date), 1, 2)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (3, N'huyndq', N'12345', N'Nguyen Duy Quang Huy', N'huy@gmai.com', 0, CAST(N'2020-10-26' AS Date), 3, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (4, N'thinhbnp', N'12345', N'Bach Nguyen Phuc Thinh', N'thinh@gmai.com', 0, CAST(N'2020-10-26' AS Date), 4, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (5, N'khangnv', N'12345', N'Nguyen Vu Khang', N'khang@gmai.com', 0, CAST(N'2020-10-26' AS Date), 3, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (6, N'huonglh', N'12345', N'Luong Hoang Huong', N'huong@gmai.com', 0, CAST(N'2020-10-26' AS Date), 2, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (7, N'bnv', N'12345', N'Nguyen Van B', N'nam@gmai.com', 0, CAST(N'2020-10-26' AS Date), 2, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (8, N'anv', N'12345', N'Nguyen Van A', N'a@gmai.com', 0, CAST(N'2020-10-26' AS Date), 2, 1)
INSERT [dbo].[Account] ([aID], [aUsername], [aPassword], [aFullname], [aEmail], [aStatus], [aDateAdded], [roleID], [countryID]) VALUES (9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([cateID], [cateName]) VALUES (1, N'Game')
INSERT [dbo].[Category] ([cateID], [cateName]) VALUES (2, N'Technology Product')
INSERT [dbo].[Category] ([cateID], [cateName]) VALUES (3, N'Social Media')
INSERT [dbo].[Category] ([cateID], [cateName]) VALUES (4, N'Event')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (1, N'Good job, it''s give me much knowledge', 2, 1)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (2, N'This post is verygood!', 2, 2)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (3, N'Nice! I have ever read a great post like this before', 6, 3)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (4, N'Good job, it''s give me much knowledge', 7, 4)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (5, N'Wonderfull!', 8, 5)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (6, N'Good job, it''s give me much knowledge', 6, 6)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (7, N'Good job, it''s give me much knowledge', 8, 7)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (8, N'I like IPhone 12', 7, 8)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (9, N'Verygood', 6, 9)
INSERT [dbo].[Comment] ([commentID], [commentContent], [aID], [postID]) VALUES (10, N'Thanks, it''s give me much knowledge', 2, 10)
SET IDENTITY_INSERT [dbo].[Comment] OFF
GO
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([countryID], [countryName]) VALUES (1, N'Viet Nam')
INSERT [dbo].[Country] ([countryID], [countryName]) VALUES (2, N'My')
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
SET IDENTITY_INSERT [dbo].[History] ON 

INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (1, CAST(N'2020-10-28' AS Date), CAST(N'2020-10-28' AS Date), 0, 4, 3)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (2, CAST(N'2020-10-15' AS Date), CAST(N'2020-10-16' AS Date), 0, 4, 5)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (3, CAST(N'2020-10-10' AS Date), CAST(N'2020-10-11' AS Date), 0, 4, 3)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (4, CAST(N'2020-10-05' AS Date), CAST(N'2020-10-07' AS Date), 0, 4, 5)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (5, CAST(N'2020-10-07' AS Date), CAST(N'2020-10-09' AS Date), 0, 4, 3)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (6, CAST(N'2020-09-28' AS Date), CAST(N'2020-09-30' AS Date), 0, 4, 5)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (7, CAST(N'2020-09-12' AS Date), CAST(N'2020-09-15' AS Date), 0, 4, 3)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (8, CAST(N'2020-09-18' AS Date), CAST(N'2020-09-20' AS Date), 0, 4, 5)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (9, CAST(N'2020-08-02' AS Date), CAST(N'2020-08-05' AS Date), 0, 4, 3)
INSERT [dbo].[History] ([hID], [dateSubmited], [dateAccepted], [typeAccept], [censorID], [posterID]) VALUES (10, CAST(N'2020-08-28' AS Date), CAST(N'2020-09-01' AS Date), 0, 4, 5)
SET IDENTITY_INSERT [dbo].[History] OFF
GO
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (1, N'Apple iCloud services experience outages', N'On Sunday, some services were slow, while others were inaccessible.
A number of iCloud services were experiencing outages Sunday morning, including Calendar, Contacts and iCloud Drive, according to Apples System Status webpage. The service disruptions began around 6 a.m. PT, according to the page.

By midafternoon Sunday, the problems seemed to have been resolved. As of Monday morning, the System Status page showed green lights across the board, and services that had experienced problems showed a "resolved issue" notation.
Services affected by the outages included Find My, iCloud Account & Sign In, iCloud Backup, iCloud Bookmarks & Tabs, iCloud Calendar, iCloud Contacts, iCloud Drive, iCloud Keychain, iCloud Mail, iCloud Storage Upgrades, Photos and Screen Time.

During the outage, some messages on the status board said the service may be slow or unresponsive, while others said users were unable to login.

Apple didnt respond to a request for comment.', 4, 1, 0)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (2, N'Apple One bundle plans compared: How much money you could save with each', N'Apple''s new subscription bundles for iCloud, Apple Music and more are here. Here''s what you get and how much you''ll save with the individual, family and premier plans.
Apple''s new subscription bundle Apple One began rolling out to Apple users last week, and could save you money by tying together different combinations of the tech giant''s services, including Apple Music, Apple TV Plus, Apple Arcade, Apple News Plus, storage service iCloud and the newly unveiled Apple Fitness Plus. At the very least, the new offering is designed to entice you with a tidy package of Apple''s top services.

The introduction of Apple One is another move toward deepening Apple''s services business, which looks to earn regular subscription income from owners of its hardware, such as the iPhone ($699 at Amazon) and iPad. 

Read more: Apple One: Everything included in Apple''s new services bundle

You''l nowl be able to choose from three different plans and prices that range from $15 to $30 a month: Individual, Family or Premier. Which one is right for you depends on exactly how many of these services you already pay for, and how interested you are in the ones you don''t. 

Here''s how the three different Apple One plans break down, in terms of price, services and iCloud storage space included. ', 2, 2, 0)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (3, N'iPhone 12 vs. iPhone 8: How to decide whether you should upgrade now', N'Out of the four iPhone 12 models that Apple announced in October, the iPhone 12 is best suited for most people, and it''s also one of our highest-rated phones ever. But if you''ve held back from upgrading since 2017''s iPhone 8, you''re probably wondering whether now is the time to do so. After all, the iPhone 12 boasts a string of significant new features like 5G, a ceramic-hardened display and MagSafe charging. While these updates and others are welcome additions to the iPhone 12, not all of them will materially affect your daily life, at least for now. 

Here''s everything you need to know about how the iPhone 12 compares with the iPhone 8 before you make that decision to upgrade -- or wait another year.
iPhone 8''s single rear camera vs. the iPhone 12''s two 
The camera systems on the iPhone 8 and iPhone 12 are one of the biggest differences between the two devices, and it''s something that will noticeably affect your experience and buying decision. During the three years since Apple launched the iPhone 8, the company has made impressive strides in improving camera technology 

With the iPhone 12, you''ll see big gains in image quality and more flexibility around the kinds of photographs you can capture. For instance, the iPhone 8 only has one camera. It doesn''t have Portrait Mode nor does it feature a second, ultrawide camera, which is for capturing sweeping landscapes. Both those things are found in all four iPhone 12 models. 

Combined with Apple''s powerful computational photography software, like Apple''s impressive low-light feature called Night Mode, the iPhone 12 takes some of the best smartphone photos no matter what time of day. And if you want even more camera upgrades, the iPhone 12 Pro and iPhone 12 Pro Max has a third telephoto lens, as well as lidar. (If you want to learn more about lidar, read this.)
iPhone 12 has 5G
The iPhone 12 models are the first iPhones to offer next-generation 5G cellular connectivity. Carriers have claimed that 5G speeds are almost twice as fast as 4G, and Apple spent a considerable amount of time during its launch event hyping up the new tech. But 5G coverage is patchy across the US, and your experience will vary depending on where you live. Some areas have absolutely zero coverage, while other parts (mainly big cities) have 5G networks from all major US carriers. The bottom line is: There is no universal 5G experience, so it''s important to research the 5G coverage in your area. If you do upgrade, at the very least you can take comfort in knowing your device is future-proof as 5G continues to expand this year and the next.

Decidedly different displays
The displays of the iPhone 12 and iPhone 8 are very different -- they vary in size, type, resolution and even material. The iPhone 12 line has one of the best displays you can get on a phone today. All four phones use a premium OLED panel, while the iPhone 8 has an LCD display. OLED panels usually have better contrast and deeper black levels than their LCD counterparts. 

The iPhone 8 has a 4.7-inch screen, while the iPhone 12 has a 6.1-inch display. Because there are several iPhone 12 models, you can also choose the smaller 5.4-inch iPhone 12 Mini and the larger 6.7-inch iPhone 12 Pro Max. 

Apple debuts its MagSafe-branded charging system alongside the iPhone 12.

Apple
New to the iPhone line is the iPhone 12''s ceramic-hardened glass known as Ceramic Shield, which Apple says offers four times more drop protection. During our drop tests, CNET''s Vanessa Hand Orellana concluded that the Ceramic Shield is "as tough as it sounds." The iPhone 12''s screen survived without a crack after it was dropped six times on a sidewalk, including three back-to-back drops from a height of nine feet. 

The iPhone 8 uses a type of glass made specifically for Apple by Corning, but it''s not Gorilla Glass. When we conducted drop tests, we discovered that at 3 feet (0.9 meters), it survived. At 5 feet (1.5 meters), however, the iPhone 8 shattered. 

Bring your own charger with the iPhone 12
Apple confirmed the fears of some iPhone fans when it announced that the iPhone 12 box wouldn''t come with either a wall adapter or wired earphones. The company is betting most people already own these accessories, but if you do need them you''ll have to buy them separately. 

Apple''s reasoning to leave behind the wall adapter may also have something to do with its introduction of MagSafe. It''s a proprietary wireless charging system on the iPhone 12 that uses magnets. In addition to charging pads though, other nifty accessories can snap onto the back of the device too, and are sold separately. As for the iPhone 8, it comes with a Lightning cable and plug, and it also works with the existing Qi wireless charging standard. ', 2, 3, NULL)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (4, N'The Raspberry Pi 400 is a compact keyboard with a built-in computer', N'The Raspberry Pi Foundation has announced the Raspberry Pi 400, a compact keyboard with an ARM-based computer built in. Just plug it into a TV or monitor using one of its two micro HDMI ports, insert a microSD card, attach a power cord and mouse, and you’ve got yourself a basic computer for day-to-day tasks, coding, or media playback. It’s available starting today as a standalone machine for $70 or in a bundle including a mouse, power supply, microSD card, HDMI cable, and beginner’s guide for $100.

The hope is the Pi 400’s form factor, plus these optional bundled items, makes it more approachable and user-friendly. That’s important when you’re selling an affordable computer, and it’s especially important when you’re selling an accessible device to help children learn to code. It looks more like a piece of consumer electronics than the basis for a DIY project.

“It can sit under your Christmas tree and… if you open your presents at 9 o’clock, by 10 o’clock you can be sitting in front of your television with a computer,” Raspberry Pi’s founder, Eben Upton, tells me in an interview ahead of the announcement.

“THE DREAM ALWAYS WITH RASPBERRY PI IS TO LURE PEOPLE INTO BUYING A PC AND THEN TRICK THEM INTO BECOMING COMPUTER PROGRAMMERS”
The Raspberry Pi 400’s form factor immediately brings to mind early home computers like the BBC Micro or ZX Spectrum, and that’s no accident. Although Raspberry Pi’s small computers have become a popular tool for hobbyists to do everything from building inexpensive AirPlay receivers to automating smart homes, at their core they’re designed as accessible computers to help children learn to code.

“The dream always with Raspberry Pi is to lure people into buying a PC and then trick them into becoming computer programmers,” Upton says. “That’s what happened to me, I was lured into buying a BBC Micro and then suddenly I became a software engineer.”

Aside from its keyboard and form factor, the Raspberry Pi 400 is a very similar computer to last year’s Raspberry Pi 4. It’s got a slightly faster quad-core 1.8GHz ARM Cortex-A72 CPU, up from 1.5GHz in the Pi 4, 4GB of RAM, Gigabit Ethernet, Bluetooth 5.0, and 802.11ac Wi-Fi. There are a pair of micro HDMI ports that can each output up to 4K / 60Hz, two USB 3.0 ports, and a single USB 2.0 port. Power is provided via a USB-C port, there’s a microSD card slot for storage, and there’s a GPIO header for attaching a variety of more niche devices.
While the internals are similar to previous Raspberry Pi devices, the external appearance of the Pi 400 is anything but. Depending on which region you buy it in, the computer is built into either a 78- or 79-key keyboard, which has a similar design to most compact laptop keyboards. At launch, there are six different keyboard layouts — UK, US, German, French, Italian, and Spanish — and Upton tells me there are additional variants for the Norwegian, Swedish, Danish, Portuguese, and Japanese markets on the way soon.
Thankfully, this isn’t Raspberry Pi’s first keyboard — it released a standard one without a computer built into it last year. I say thankfully because many of those early ‘80s home computers had absolutely awful keyboards, and producing a practice keyboard should help Raspberry Pi avoid any serious mishaps. Upton tells me the company’s approach was inspired by how PC manufacturer Acorn Computers used its standalone keyboard as a basis for the Acorn Atom computer. In fact, Upton says that keen-eyed observers would have seen hints about the Pi 400’s development hidden inside its standalone keyboard, which has a slightly unnecessary amount of empty space inside it where the Pi 400’s computer innards now sit.
It’s not just children learning to code to whom the company wants to sell Pi 400s. “Who’s it supposed to help? It’s supposed to help anyone who needs a computer,” Upton says. Interestingly, that also includes businesses, with Upton telling me that the company sees the Raspberry Pi 400 being used as corporate desktop machines or for call center agents. Interestingly, that’s one of the reasons why the Raspberry Pi 4 and Pi 400 have two HDMI outputs, because two monitors is the default for a lot of business users.

That said, Upton admits that the Pi 400’s pink and white color scheme won’t be to every business’s tastes. “We’re going to need to make it in gray and black and it’s going to break our hearts,” he jokes, “We make our products in pink and white and we think it’s the right color and then we are dragged kicking and screaming to gray and black.”

It may have sounded unrealistic a few years ago to dream of an office filled with ARM-based computers when the processors were largely considered too low-power for anything beyond phones and tablets, but in a year when Apple is starting to switch its Mac computers to the architecture, that future doesn’t look so preposterous.', 2, 4, NULL)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (5, N'Samsung’s fast, small T7 USB-C SSDs are cheaper than ever at several retailers', N'Samsung’s pocket-sized T7 USB-C SSD is steeply discounted at a few retailers. The price cut applies to the 1TB and 2TB models, both of which could make for speedy external add-ons for the PS5 or Xbox Series X / S consoles, in addition to the more obvious use case of connecting it your PC. The 1TB SSD is down to $160 (usually $200). As far as the color options of the T7, Amazon, Best Buy, and B&H Photo have them in red, blue, or black. If you want to double the storage to 2TB, that version of the T7 is $250 (usually $370) at Amazon. That’s a particularly good value.

I reviewed Samsung’s T7 Touch, a variant that includes a fingerprint sensor for added security. Some real-world benchmarking tasks proved it to be significantly faster at transferring data than its predecessor, the T5. In my testing of the standard T7, it seems to be just as speedy.
SanDisk’s 400GB microSD card is near its lowest price at Amazon and B&H Photo, making it a good time to pick up this must-have Nintendo Switch accessory. Normally around $60, it’s $50 at either retailer. This card figuratively pays for itself if you want the space to download a lot of games, since Switch games are rarely more than 15GB or so.', 2, 5, 0)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (6, N'The first laptops with Intel’s Iris Xe Max graphics are now available to order', N'Earlier this month, the public got its first glimpse of Iris Xe Max, Intel’s new discrete GPU for thin-and-light laptops, at an Acer press event. Today, Intel revealed the full first wave of laptops that will include this GPU, some of which are available for purchase now in certain countries.

The laptops include the Acer Swift 3X, the Dell Inspiron 15 7000 2-in-1, and the Asus VivoBook Flip TP470. The Inspiron 15 is available in the US at Best Buy; Acer has previously said to expect the 3X in the US in December. Both the Swift 3X and the Inspiron 15 are also available in China through JD.com. Intel says the Asus VivoBook is coming “shortly” to both the US and China.
Intel’s Iris Xe Max graphics are primarily intended for portable systems for content creators. “We set out to redefine the role of discrete graphics in thin-and-light laptops and address a growing segment of creators who want more portability,” said Roger Chandler, Intel vice president and general manager of Client XPU Product and Solutions, in a statement.

The three new laptops also include Intel’s 11th Gen “Tiger Lake” mobile processors, as well as Intel’s Deep Link technology, which allows certain applications to leverage both discrete and integrated graphics for creative work. Intel claims that Tiger Lake systems paired with Iris Xe Max graphics can provide “seven times faster AI-based creation” than similar laptops with third-party GPUs.
The company also claims its GPU can deliver “great thin-and-light 1080p gaming on popular games.” We shouldn’t get too excited about this until benchmarks come out — it would certainly be surprising to see laptops of this size running Microsoft Flight Simulator. But Iris Xe integrated graphics do a decent job with stuff like Overwatch, so you may very well be able to run lighter fare if Acer, Dell, and Asus can keep cooling under control.
I got some hands-on time with the Acer Swift 3X, which starts at $899.99. It’s a slim and portable machine, with a decent port selection and a nice-looking screen. But our test unit wasn’t finalized, so I couldn’t put the graphics to the test. Much of whether that system (and others like it) are worth their price tags for creators will depend on GPU performance, battery life, and display quality — so keep an eye out for our upcoming reviews.', 2, 6, 0)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (7, N'Google Meet will now let you use custom backgrounds on video calls', N'Google is introducing custom backgrounds for its Meet videoconferencing platform, the company announced in a blog post. If you use Meet in Google’s Chrome browser you should be able to access the feature in Chrome OS as well as on Windows and Mac laptops and desktops. The feature is “coming soon” to mobile, Google says.

There’s no browser extension needed to activate custom backgrounds; you should be able to add a background image from your own photo collection or from a library of images provided by Google that includes landscapes, abstract art and (for some reason) offices.
It may take up to a week before all Google Meet users can access the new custom background option, the company says.

Rival videoconferencing services Microsoft Teams and Zoom both already allow the use of custom images for meeting backgrounds. The three have been adding new features as more people depend on video calls working and schooling from home during the pandemic; in recent months Meet added a blur effect for meeting backgrounds, and introducing real-time captioning, low-light mode, hand-raising and a tile view (the giant Brady Bunch screen) that displays up to 49 people.

Google integrated Meet into Gmail in May, adding a sidebar link and making meetings of up to 100 people with no time limits available to anyone with a Google account.

In its third-quarter earnings call Thursday, Google CEO Sundar Pichai said Meet had had 235 million daily meetings and more than 7.5 billion daily video calls.', 3, 7, 0)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (8, N'iPhone 12 camera replacement issues could hint at further restrictions on third-party Apple repairs', N'Apple’s latest iPhone 12 smartphone appears to be even more difficult for third-party companies to repair, according to a report from iFixit. Specifically, the new phone appears to run into issues if a user replaces the camera module, which renders the cameras almost totally unusable.

The issue — first spotted by YouTuber Hugh Jeffreys — doesn’t appear to be a strictly hardware-related problem. As iFixit’s teardown notes, the iPhone 12 is actually a relatively good device when it comes to disassembly and replacement of various key parts.
But should you actually swap a camera module from one iPhone 12 to another, it appears that the phone will reject the replacement part, with iFixit describing issues with the ultrawide camera and general issues of unresponsiveness.

The iPhone 12 marks the first iPhone to have these problems — previous models allowed for replacement cameras with no issues, and even the iPhone 12 Pro appears to work completely fine. It’s not clear whether this is a one-off glitch or some specific quirk of the iPhone 12’s cameras. Previous iPhone models have had related issues, like the iPhone 7 and 8 Plus, where Apple used three different display manufacturers that weren’t fully interchangeable.

But even if the camera issue is just a temporary one, iFixit notes that it seems clear that Apple is looking to maintain a stricter control over iPhone repairs. The DIY repair site also claims to have gotten ahold of Apple’s new internal training guides for iPhone 12 support, which note that repairing a camera or display will now require Apple’s own, in-house System Configuration app, something that had previously only been required for a battery swap.
And Apple has long since limited some aspects of iPhone repairs, like its Touch ID and Face ID sensors, which it’s barred third-party repairs from in the name of security. But even if those components — which are critical parts of unlocking an iPhone — really do have those additional security requirements that would necessitate Apple-only repairs, it’s hard to see how the camera or battery would require similar restrictions.

It’s possible that this is all just a glitch in the system, especially given Apple’s past history with slightly wonky part swapping and the fact that the issue appears to only impact that iPhone 12 and not the 12 Pro. But given Apple’s past history with things like its attempt to lock down “unauthorized” third-party battery or display repairs with ominous warnings, it’s possible the camera issue here is just the start of even further part restrictions.

In a statement, Apple didn’t address the compatibility issue for iPhone 12 camera parts. The company instead commented that “We are committed to giving our customers more options and locations for safe and reliable repairs. Our new independent repair provider program is designed to give repair businesses of all sizes access to genuine parts, training and tools needed to perform the most common iPhone repairs. These service providers have access to the same tools and repair manuals used by Apple and Authorized Service Providers (AASPs).”', 2, 8, 0)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (9, N'
Instagram nixes the ‘recent’ tab from hashtag pages ahead of election', N'With only four days until the US presidential election, Instagram is cracking down on hashtags. The company announced yesterday that it would temporarily get rid of the “recent” tab on hashtag pages to potentially stop the spread of “harmful content” around the election. Typically when you search a hashtag on Instagram, you can choose between browsing the “top” posts or the most recent. Now, it seems you can only view the top ones.

Both Instagram and its parent company Facebook have taken steps to try to prevent misinformation across various platforms ahead of and during the election. Facebook said earlier this month it took down 120,000 posts across both Facebook proper and Instagram that violated its voter interference policies. The company also added warnings to 150 million posts debunked by fact-checkers and rejected 2.2 million ad submissions for targeting the US without completing its authorization process.
Facebook also says it will ban ads that wrongly claim victory in the US presidential race or ads that claim rampant voter fraud could alter the results of the election. It’ll also reject ads from the campaigns of President Donald Trump and Democratic nominee Joe Biden if either tries to claim a win prematurely. In September, Facebook announced a ban on new political ads the week before the election, and earlier this month, the company said it would stop accepting US-based political ads after the election “indefinitely” to avoid confusion and chaos stemming from potential misinformation and premature announcements about the results of the race.', 3, 9, 0)
INSERT [dbo].[Post] ([postID], [postTitle], [postContent], [cateID], [hID], [statusID]) VALUES (10, N'Watch the AR concert that opened up the 2020 League of Legends World Championship', N'Once again Riot has turned the opening ceremonies of the League of Legends World Championship final into a technological showcase. This year at Pudong Football Stadium in Shanghai, the ceremony was split into a few different parts: it opened with virtual K-pop group K/DA performed via augmented reality, which was followed by a melody of anthems from past Worlds events. At the end, as the players were introduced, a virtual, towering version of League character Galio — known as the stone colossus — appeared on stage.

While the event wasn’t as visually impressive as last year’s holographic showcase, it was still an impressive feat considering the restraints created by the ongoing pandemic. The main cast of performers were virtual, but they were accompanied by a few dozen real-world dancers and musicians, including Chinese pop star Lexie Liu. (There was also a very cyberpunk-looking AR Ducati motorcycle that helped kick things off.)

Perhaps the most noticeable feature, especially in comparison to other esports events in 2020, was the presence of fans: around 6,000 people were in attendance to watch Korea’s Damwon Gaming defeat Suning Gaming of China in the championship match. Later on, after the games actually started, Riot also announced a release window for the first League spinoff, which launches next year.
Ahead of the finals, the early stages of this year’s edition of Worlds looked a bit different due to the pandemic. Prior to the finals, the month-long tournament was played out of a high-tech studio in Shanghai, one that utilized an Unreal Engine-powered backdrop to create some astonishing mixed reality effects. The technology was similar to what Disney used to create The Mandalorian.', 1, 10, 0)
SET IDENTITY_INSERT [dbo].[Post] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (2, N'User')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (3, N'Poster')
INSERT [dbo].[Role] ([roleID], [roleName]) VALUES (4, N'Censor')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[Statuss] ([statusID], [statusName]) VALUES (0, N'Active    ')
INSERT [dbo].[Statuss] ([statusID], [statusName]) VALUES (1, N'Inactive  ')
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([countryID])
REFERENCES [dbo].[Country] ([countryID])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([roleID])
REFERENCES [dbo].[Role] ([roleID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([aID])
REFERENCES [dbo].[Account] ([aID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK__Comment__postID__398D8EEE] FOREIGN KEY([postID])
REFERENCES [dbo].[Post] ([postID])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK__Comment__postID__398D8EEE]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD FOREIGN KEY([censorID])
REFERENCES [dbo].[Account] ([aID])
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD FOREIGN KEY([posterID])
REFERENCES [dbo].[Account] ([aID])
GO
ALTER TABLE [dbo].[Picture]  WITH CHECK ADD  CONSTRAINT [FK__Picture__postID__35BCFE0A] FOREIGN KEY([postID])
REFERENCES [dbo].[Post] ([postID])
GO
ALTER TABLE [dbo].[Picture] CHECK CONSTRAINT [FK__Picture__postID__35BCFE0A]
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD  CONSTRAINT [FK__Post__cateID__31EC6D26] FOREIGN KEY([cateID])
REFERENCES [dbo].[Category] ([cateID])
GO
ALTER TABLE [dbo].[Post] CHECK CONSTRAINT [FK__Post__cateID__31EC6D26]
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD  CONSTRAINT [FK__Post__hID__32E0915F] FOREIGN KEY([hID])
REFERENCES [dbo].[History] ([hID])
GO
ALTER TABLE [dbo].[Post] CHECK CONSTRAINT [FK__Post__hID__32E0915F]
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD FOREIGN KEY([statusID])
REFERENCES [dbo].[Statuss] ([statusID])
GO
