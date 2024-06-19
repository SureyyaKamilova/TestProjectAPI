--Constraints
--Alter Table Books
--Add Unique(SerialNo)

--View
--Create View AvailableBooks As
--Select Id, BookName
--From Books
--Where IsAvailable=1

--Select *from AvailableBooks

--Index
--Create Index idx_booktopic On Books(BookTopic)

--Procedure
--Create Procedure BookInsert
--@CreatorId int,
--@ModifierId int,
--@BookName nvarchar(100),
--@AuthorName nvarchar(100),
--@BookTopic nvarchar(50),
--@CoverNumber int,
--@SerialNo char(11),
--@IsAvailable bit,
--@ArrivalDate datetime2(7),
--@EndDate datetime2(7)
--As Insert Into Books(CreatorId,ModifierId,BookName,AuthorName,BookTopic,CoverNumber,SerialNo, IsAvailable,ArrivalDate,Enddate)
--Values(@CreatorId,@ModifierId,@BookName,@AuthorName,@BookTopic,@CoverNumber,@SerialNo,@IsAvailable,@ArrivalDate,@EndDate)

--Exec BookInsert @CreatorId=1,@ModifierId=1,@BookName=N'1984',@AuthorName=N'George Orwell',@BookTopic=N'Dystopian',@CoverNumber=1,@SerialNo='11002349873',@IsAvailable=1,@ArrivalDate='2024-06-10',@EndDate='2024-06-28';

--Trigger
--Create Trigger triggerMessage
--On Books
--After Insert
--As
--Begin 
--     Print 'New book successfully added!';
--End;

--Insert Into Books Values(1,1,N'Bakıdan Gələn Xəfiyyə',N'Elxan Elatlı',N'Dedektiv',1,'20016548931',1,'2024-04-20','2024-05-05')

--Function
--Create Function ShowBooks(@BookTopic nvarchar(50))
--Returns Nvarchar(200)
--As 
--Begin
--Declare @Books Nvarchar(200);
--Select @Books=BookName+'-'+AuthorName From Books where BookTopic=@BookTopic;
--Return @Books;
--End;

--Select dbo.ShowBooks(N'Dedektiv') As Books;