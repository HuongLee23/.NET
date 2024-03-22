USE master;
ALTER DATABASE ProjectRestaurant SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
drop DATABASE ProjectRestaurant


create database ProjectRestaurant
go
use ProjectRestaurant
go


-- Account
create table Account
(
	username nvarchar(100) primary key,
	displayname nvarchar(100) not null,
	[password] nvarchar(1000) not null default N'0',
	[role] int not null default 0 --1 là admin || 0 là staff
)
go

ALTER TABLE Account
ADD CONSTRAINT DF_Account_Password DEFAULT N'0' FOR [password];


ALTER TABLE Account
ALTER COLUMN [password] NVARCHAR(100) NOT NULL;


-- Table
create table TableFood
(
	id int identity primary key,
	[name] nvarchar(100) not null default N'Bàn chưa đặt tên',
	[status] nvarchar(100) not null default N'Trống',  -- trống || có người
)
go

-- Category
create table FoodCategory
(
	id int identity primary key,
	[name] nvarchar(100) not null default N'Chưa đặt tên'
)
go

-- Food
create table Food
(
	id int identity primary key,
	[name] nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0
	foreign key (idCategory) references dbo.FoodCategory(id)
)
go

-- Bill
create table Bill
(
	id int identity primary key,
	DateCheckIn date not null,
	DateCheckOut date not null,
	idTable int not null,
	[status] int not null default 0, --1 đã thanh toán || 0 chưa thanh toán
	totalPrice float not null default 0
	foreign key (idTable) references dbo.TableFood(id)
)
go

-- BillInfor
create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	[count] int not null default 0
	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
go


----------------- Insert database ----------------

-- Insert Account
GO
INSERT INTO [dbo].[Account]
           ([username]
           ,[displayname]
           ,[password]
           ,[role])
     VALUES
           (N'Huong', N'Huong', N'123', 1),
		   (N'Le', N'Le', N'123', 0);
GO

-- Insert TableFood
GO
INSERT INTO [dbo].[TableFood]
           ([name]
           ,[status])
     VALUES
           (N'Bàn 1'),(N'Bàn 2'), (N'Bàn 3');
GO

Declare @i int = 21
while @i <= 40
begin 
	insert dbo.TableFood (name, status) values (N'Bàn '+ cast(@i as nvarchar(100)), N'Có người')
	set @i = @i + 1
end

-- Insert Category
GO
INSERT INTO [dbo].FoodCategory
           ([name])
     VALUES
           (N'Hải sản'),
		   (N'Nông sản'),
		   (N'Lâm sản'),
		   (N'Trái cây'),
		   (N'Nước');
GO

-- Insert Food
GO
INSERT INTO [dbo].[Food]
           ([name]
           ,[idCategory]
           ,[price])
     VALUES
           (N'Mực nắng nước sa tế', 1,120000),
		   (N'Ngêu hấp xả', 1,50000),

		   (N'Cơm cháy kho quẹt', 2,100000),
		   (N'Cơm giang dưa bò', 2,40000),

		   (N'Heo rừng nướng lu', 3,220000),
		   (N'Thịt dê tái chanh', 3,120000),

		   (N'Dưa hấu', 4,50000),
		   (N'Xoài', 4,22000),

		   (N'Bia Hà Nội', 5,10000),
		   (N'Cocacola', 5,10000);
GO

-- Insert Bill
GO
INSERT INTO [dbo].[Bill]
           ([DateCheckIn]
           ,[DateCheckOut]
           ,[idTable]
           ,[status])
     VALUES(GETDATE(), GETDATE(), 1, 0),
			(GETDATE(), GETDATE(), 2, 0),
			(GETDATE(), GETDATE(), 2, 1);
GO

-- Insert Bill Infor
GO
INSERT INTO [dbo].[BillInfo]
           ([idBill]
           ,[idFood]
           ,[count])
     VALUES (1, 1, 2),
			(1, 3, 4),
			(2, 5, 1),
			(2, 1, 2),
			(3, 6, 2),
			(3, 5, 2);
GO



CREATE PROC USP_Login
@username nvarchar(100), @password nvarchar(1000)
as
begin 
	select * from dbo.Account where username = @username and password = @password
end
go


CREATE PROC USP_GetTableList
as
	select * from dbo.TableFood
go
EXEC dbo.USP_GetTableList


select f.[name], bi.[count], f.price, f.price* bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f
where bi.idBill = b.id and bi.idFood = f.id and b.idTable = 1


select * from Food
select * from TableFood
select * from BillInfo where idTable = 3 and status = 0

Update TableFood set status = N'Trống' where id = 6
Update TableFood set status = N'Trống' where id = 7
Update TableFood set status = N'Trống' where id = 8
Update TableFood set status = N'Trống' where id = 9
Update TableFood set status = N'Trống' where id = 10



----------------------proc của Insert Bill-----------------------------
go
create proc USP_InsertBill
@idTable int
as
begin 
	INSERT INTO [dbo].[Bill]
           ([DateCheckIn]
           ,[DateCheckOut]
           ,[idTable]
           ,[status]
		   , discount)
     VALUES
           (getdate()
           ,null
           ,@idTable
           ,0
		   ,0)
end
go


---------------------proc của Insert BillInfor---------------------------
go
alter proc USP_InsertBillInfo
@idBill int, @idFood int, @count int
as
begin 
	declare @isExitsBillInfo int;
	declare @foodCount int = 1;

	select @isExitsBillInfo = id, @foodCount = b.count from BillInfo as b 
	where idBill = @idBill and idFood = @idFood

	if(@isExitsBillInfo > 0)
		Begin
			declare @newCount int = @foodCount + @count
			
			if(@newCount > 0)
				Update BillInfo set count = @foodCount + @count where idFood = @idFood
			else
				delete BillInfo where idBill = @idBill and idFood = @idFood

		end
	else
		begin
			INSERT INTO [dbo].[BillInfo]
           ([idBill]
           ,[idFood]
           ,count)
			VALUES
           (@idBill
           ,@idFood
           ,@count)
		end
end
go


--------------------proc của Insert BillInfor---------------------
go
create proc USP_InsertBillInfo
@idBill int, @idFood int, @count int
as
	INSERT INTO [dbo].[BillInfo]
           ([idBill]
           ,[idFood]
           ,[count])
     VALUES
           (@idBill
           ,@idFood
           ,@count)
end
go



---------------------Trigger BillInfo----------------------
alter trigger UTG_UpdateBillInfo
on dbo.BillInfo for insert , update
as 
begin
	declare @idBill int

	select @idBill = idBill from Inserted

	declare @idTable int

	select @idTable = idTable from dbo.Bill where id = @idBill and status = 0

	declare @count int

	select @count = count(*) from BillInfo where idBill = @idBill

	if(@count > 0)
		begin
		print @idTable
		print @idBill
		print @count
		update TableFood set [status] = N'Có người' where id = @idTable
		end
	else
		begin
		print @idTable
		print @idBill
		print @count
		update TableFood set [status] = N'Trống' where id = @idTable
		end
end
go

---------------------Trigger BillInfo----------------------
select * from TableFood


---------------------UTG_UpdateTable-----------------
go
create trigger UTG_UpdateTable
on TableFood for UPDATE
AS
BEGIN	
	declare @idTable int
	declare @status nvarchar(100)

	select @idTable = id, @status = inserted.status from Inserted

	declare @idBill int
	select @idBill = id from Bill where idTable = @idTable and [status] = 0

	declare @countBillInfo int
	select @countBillInfo = count(*) from BillInfo where idBill = @idBill

	if(@countBillInfo > 0 )--and @status <> N'Có người')
		update TableFood set [status] = N'Có người' where id = @idTable
	else --if(@countBillInfo <= 0 and @status <> N'Trống')
		update TableFood set [status] = N'Trống' where id = @idTable
		
END
go


delete dbo.BillInfo
delete dbo.Bill




----------------------Trigger Update Bill---------------------
create trigger UTG_UpdateBill
on dbo.Bill for Update
as
begin
	declare @idBill int

	select @idBill = id from inserted

	declare @idTable int

	select @idTable = idTable from dbo.Bill where id = @idBill

	declare @count int = 0

	select @count = count(*) from dbo.Bill where idTable = @idTable and status = 0

	if(@count = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable
	
end
go

------------------------------create proc USP_SwitchTable-----------------------
go
alter proc USP_SwitchTable
@idTable1 int, @idTable2 int
as
begin
	declare @idFirstBill int
	declare @idSecondBill int

	declare @isFirstTableEmpty int  = 1
	declare @isSecondTableEmpty int  = 1

	select @idSecondBill = id from Bill where idTable = @idTable2 and [status] = 0
	select @idFirstBill = id from Bill where idTable = @idTable1 and [status] = 0
	--select id from Bill where idTable = @idTable1 and [status] = 0

	print @idFirstBill
	print @idSecondBill
	print '-------------'

	if(@idFirstBill is null)
	begin
		INSERT INTO [dbo].[Bill]
           ([DateCheckIn]
           ,[DateCheckOut]
           ,[idTable]
           ,[status])
     VALUES(GETDATE(), null, @idTable1, 0);

	 select @idFirstBill = max(id) from Bill where idTable = @idTable1 and [status] = 0
		
		--set @isFirstTableEmpty = 1
		--update TableFood set [status] = N'Trống' where id = @idTable2
	end

	select @isFirstTableEmpty = count(*) from BillInfo where idBill = @idFirstBill


	print @idFirstBill
	print @idSecondBill
	print '-------------'

	if(@idSecondBill is null)
	begin
		INSERT INTO [dbo].[Bill]
           ([DateCheckIn]
           ,[DateCheckOut]
           ,[idTable]
           ,[status])
     VALUES(GETDATE(), null, @idTable2, 0);

	 select @idSecondBill = max(id) from Bill where idTable = @idTable2 and [status] = 0
	
		--set @isSecondTableEmpty = 1
		--update TableFood set [status] = N'Trống' where id = @idTable1
		
	end

	select @isSecondTableEmpty = count(*) from BillInfo where idBill = @idSecondBill


	select id into IdBillInfoTable from  BillInfo where idBill = @idSecondBill

	Update BillInfo set idBill = @idSecondBill where idBill = @idFirstBill

	Update BillInfo set idBill = @idFirstBill where id in (select * from IdBillInfoTable)

	drop table IdBillInfoTable

	if(@isFirstTableEmpty = 0)
		update TableFood set [status] = N'Trống' where id = @idTable2

	if(@isSecondTableEmpty = 0)
		update TableFood set [status] = N'Trống' where id = @idTable1

end
go

------------------------------USP_GetListBillByDate-----------------------
go
create proc USP_GetListBillByDate
@checkIn date, @checkOut date
as
begin
	select t.[name] as [Tên bàn], DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra], discount as [Giảm giá], b.totalPrice as [Tổng tiền]
	from Bill as b , TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.[status] = 1
	and t.id = b.idTable
end
go

------------------------------USP_UpdateAccount-----------------------
create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
as
begin
	declare @isRightPass int = 0
	
	select @isRightPass = count(*) from Account where username = @userName and [password] = @password 

	if(@isRightPass = 1)
	begin
		if(@newPassword = null or @newPassword = '')
		begin
			update Account set displayname = @displayName where username = @userName
		end
		else
			update Account set displayname = @displayName, password = @newPassword where username = @userName


	end
end
go

------------------------------UTG_DeleteBillInfo-----------------------
create trigger UTG_DeleteBillInfo
on BillInfo for delete
as
begin
	declare @idBillInfo int
	declare @idBill int

	select @idBillInfo = id, @idBill = deleted.idBill from deleted
	
	declare @idTable int
	select @idTable = idTable from Bill where id = @idBill
	
	declare @count int = 0
	select @count = count(*) from BillInfo as bi, Bill as b where b.id = bi.idBill and b.id = @idBill and b.status = 0

	if(@count = 0)
		update TableFood set [status] = N'Trống' where id = @idTable

end
go


------------------------------USP_GetListBillByDateAndPage-----------------------
go
create proc USP_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows
	declare @exceptRows int = (@page - 1) * @pageRows

	;with BillShow as (select b.id, t.[name] as [Tên bàn], DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra], discount as [Giảm giá], b.totalPrice as [Tổng tiền]
	from Bill as b , TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.[status] = 1
	and t.id = b.idTable)

	select top (@selectRows) * from BillShow where id not in (select top(@exceptRows) id from BillShow)

end
go



exec USP_GetListBillByDateAndPage @checkIn = '2024-03-19', @checkOut = '2024-03-19',  @page = 2


------------------------------USP_GetNumBillByDate-----------------------
go
create proc USP_GetNumBillByDate
@checkIn date, @checkOut date
as
begin
	select count(*)
	from Bill as b , TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.[status] = 1
	and t.id = b.idTable
end
go




SELECT * FROM [dbo].Account

SELECT * FROM [dbo].[Food] where name like N'%ưa%'

insert Food ([name], idCategory, price) values(N'', 0, 0.0)

UPDATE [dbo].[Food]
   SET [name] = N''
      ,[idCategory] = 5
      ,[price] = 0
 WHERE id = 4


alter table Bill add totalPrice float

delete BillInfo
delete Bill



EXEC USP_SwitchTable @idTable1 = 5, @idTable2 = 6


select max(id) from Bill
exec USP_InsertBill @idTable

ALTER TABLE Bill
ADD discount int
update Bill set discount = 0

select * from Bill

declare @idBillNew int = 19
select id into IdBillInfoTable from BillInfo where idBill = @idBillNew

declare @idBillOld int = 4
update BillInfo set idBill = @idBillOld where id in (select * from IdBillInfoTable)
update BillInfo set idBill = @idBillOld where id in (select id from BillInfo where idBill = @idBillNew)


select * from Account

update TableFood set status = N'Trống'


ALTER COLUMN DateCheckOut date NULL;

	update TableFood set status = N'Trống' where id = 20
