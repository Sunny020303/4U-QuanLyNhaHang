create database QuanLyNhaHang
go
use QuanLyNhaHang
go

--ACCOUNT
--FOOD CATEGORY
--FOOD
--TABLE
--BILL
--BILL INFO

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	status nvarchar(100) not null default N'Trống', --trống||có người-- 
	isHidden int not null default 0,
)
go
create table Account
(
	id int identity primary key,
	name nvarchar(100) not null default N'chưa đặt tên',
	UserName  nvarchar(100) not null default N'admin',
	PassWord nvarchar(100) not null default 1,
	Type int not null default 0, --admin:1,emloyee:0--
)
go


create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên', 
	isHidden int not null default 0,
)
go
 
GO
CREATE TABLE Food
(
	id int identity primary key,
	Name nvarchar(100) not null default N'chưa đặt tên',
	idCategory INT NOT NULL ,
	price float not NULL,
	FOREIGN KEY (idCategory) REFERENCES FoodCategory(id),
	isHidden int not null default 0,
)
GO
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, 
	discount INT NOT NULL DEFAULT 0,
	TotalPrice FLOAT NOT NULL DEFAULT 0,
	
	FOREIGN KEY (idTable) REFERENCES tablefood(id),
)
	--có:1 || không:0--
CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0,
	FOREIGN KEY (idBill) REFERENCES bill(id),
	FOREIGN KEY (idFood) REFERENCES food(id),
)
go
insert into account (name,UserName,PassWord,Type) values(N'staff123',N'staff',1,0)
insert into account (name,UserName,PassWord,Type) values(N'admin123',N'admin',1,1)
insert into account (name,UserName,PassWord,Type) values(N'Dương',N'Duong',1,0)
insert into account (name,UserName,PassWord,Type) values(N'Bảo',N'Bao',1,0)
insert into account (name,UserName,PassWord,Type) values(N'Mạnh',N'Manh',1,0)
insert into account (name,UserName,PassWord,Type) values(N'Anh',N'Anh',1,0)
insert into account (name,UserName,PassWord,Type) values(N'Duy',N'Duy',1,0)
insert into account (name,UserName,PassWord,Type) values(N'Phước',N'Phuoc',1,0)
insert into account (name,UserName,PassWord,Type) values(N'Doanxem123',N'Doanxem',1,1)
go
insert into TableFood (name,status) values(N'Bàn 1',N'Trống')
insert into TableFood (name,status) values(N'Bàn 2',N'Trống')
insert into TableFood (name,status) values(N'Bàn 3',N'Trống')
insert into TableFood (name,status) values(N'Bàn 4',N'Trống')
insert into TableFood (name,status) values(N'Bàn 5',N'Trống')
insert into TableFood (name,status) values(N'Bàn 6',N'Trống')
insert into TableFood (name,status) values(N'Bàn 7',N'Trống')
insert into TableFood (name,status) values(N'Bàn 8',N'Trống')
insert into TableFood (name,status) values(N'Bàn 9',N'Trống')
insert into TableFood (name,status) values(N'Bàn 10',N'Trống')
go
INSERT INTO FoodCategory (name) VALUES (N'Hải sản/Seafood')
INSERT INTO FoodCategory (name) VALUES (N'Gỏi/Salad')
INSERT INTO FoodCategory (name) VALUES (N'Mì/Noodle')
INSERT INTO FoodCategory (name) VALUES (N'Cơm/Rice')
INSERT INTO FoodCategory (name) VALUES (N'Nước giải khát/Drinks')
INSERT INTO FoodCategory (name) VALUES (N'Nước ép')
go
INSERT INTO Food (name, idCategory, price) VALUES (N'Hàu sữa nướng muối ớt', 1 , 150000 )
INSERT INTO Food (name, idCategory, price) VALUES (N'Sò huyết hấp', 1 , 150000 )
INSERT INTO Food (name, idCategory, price) VALUES (N'Mực hấp bia', 1 , 150000 )
INSERT INTO Food (name, idCategory, price) VALUES (N'Canh ngao chua', 1 , 150000 )
INSERT INTO Food (name, idCategory, price) VALUES (N'Cua nướng muối ớt', 1 , 130000 )
INSERT INTO Food (name, idCategory, price) VALUES (N'Tôm hùm nướng phô mai', 1 , 250000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Canh cá chua', 1, 150000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Cá thu sốt cà chua', 1 , 200000 )
INSERT INTO Food (name, idCategory, price) VALUES (N'Canh cua cà pháo', 1 , 70000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Gỏi xoài tôm khô', 2, 100000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Gỏi ngó sen tôm thịt', 2, 100000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Gỏi đu đủ trộn tai heo', 2, 100000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Gỏi xoài khô mực', 2, 100000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Gỏi cá trích', 2, 120000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Mì xào bò', 3, 75000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Mì xào trứng', 3, 65000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Mì xào tóp mỡ', 3, 75000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Mì xào hải sản', 3, 80000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Cơm chiên dương châu', 4, 90000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Cơm chiên thập cẩm', 4, 85000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Cơm chiên cua tôm', 4, 95000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Cơm chiên bọc trứng', 4, 85000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Cơm trắng', 4, 20000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Coca Cola', 5, 15000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Sữa đậu nành', 5, 12000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Fanta', 5, 15000)
INSERT INTO Food (name, idCategory, price) VALUES (N'7Up', 5, 15000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Nước lọc', 5, 10000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Xá xị', 5, 15000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Pepsi', 5, 15000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Nước tăng lực', 5, 15000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Nước cam', 6, 20000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Nước dưa hấu', 6, 20000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Nước ổi', 6, 20000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Nước tắc', 6, 10000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Nước chanh', 6, 20000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Chanh dây', 6, 15000)
INSERT INTO Food (name, idCategory, price) VALUES (N'Test', 6, 15000)


go
-------------------------------------------------------USP--------------------------------------------------------------------
--Tìm the user name
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE UserName=@userName
END
GO

GO 
--login
create PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE UserName=@userName and PassWord=@passWord
END
GO
--hiển thị bàn 
CREATE PROC USP_GetTableList
AS SELECT* FROM TableFood
GO

GO
CREATE PROC USP_CreateBill
@idTable int
AS
BEGIN
	INSERT INTO Bill(DateCheckIn,DateCheckOut,idTable,status) VALUES (GETDATE(),NULL,@idTable,0)
END
GO
--Tạo, chỉnh và xóa bill
create PROC USP_CreateBillInfo
@idBill int, @idFood int,@count int
AS
	DECLARE @isExistBillInfo int
	DECLARE @FoodCount int

	SELECT @isExistBillInfo = ID FROM BillInfo WHERE idBill=@idBill AND idFood=@idFood
	
	IF(@isExistBillInfo>0)
	BEGIN
		if(@count>0)
		UPDATE BillInfo SET count=@count WHERE idBill=@idBill AND idFood=@idFood 
		else
		DELETE BillInfo WHERE idBill=@idBill AND idFood=@idFood 
	
	END

	ELSE
	BEGIN
		if(@count>0)
		INSERT INTO BillInfo (idBill,idFood,count) VALUES(@idBill,@idFood,@count)
	END
GO
--Xóa bill và tất cả billinfo của bill đó
create PROC USP_DELETEBILL
@idBill int
AS
BEGIN
	DELETE BillInfo WHERE idBill=@idBill
	DELETE Bill WHERE id=@idBill
END

-----
GO
CREATE PROC USP_ChangeTableState
@idTable int , @status int
AS
BEGIN
	IF (@status>0)
		UPDATE TableFood SET status=N'Có người' WHERE id=@idTable
	ELSE
		UPDATE TableFood SET status=N'Trống' WHERE id=@idTable
END
GO
CREATE PROC USP_AddTable
@TableName Nvarchar(100)
AS
BEGIN
	INSERT INTO TableFood (name,status) VALUES(@TableName,N'Trống')
END
GO
Create PROC USP_ChangeTableName
@idTable int,@name Nvarchar(100)
AS
BEGIN
	UPDATE TableFood SET name=@name WHERE id=@idTable
END
GO

CREATE PROC USP_UpdateTotalBill
@idBill int, @TotalPrice float, @Discount int
as
begin
	UPDATE Bill SET TotalPrice=@TotalPrice, discount=@Discount where id=@idBill
end
go
Create proc USP_UpdateBillTable
@idBill int, @idTable int
as
begin
	update Bill set idTable=@idTable where id=@idBill
end
go
create proc USP_UpdateAccount
@UserName nvarchar(100),@name Nvarchar(100),@PassWord nvarchar(100)
as
begin
	if(@name<>N'')
	begin
		update Account set name=@name where UserName=@UserName
	end
	if(@PassWord<>N'')
	begin
		update Account set PassWord=@PassWord where UserName=@UserName
	end
	
end
go

CREATE PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS
BEGIN
	SELECT b.id AS [Mã đơn], t.name AS [Tên bàn], discount AS [Giảm giá], b.totalPrice AS [Tổng tiền], DateCheckOut AS [Ngày]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckOut >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

create Proc USP_CreateAccount
@username nvarchar(100), @type int
as
begin
	insert into Account (UserName,type) values(@username,@type)
end

Go

create Proc USP_CreateFood
@FoodName nvarchar(100),@idCategory int,@price float
as
begin
	insert into food (name,idCategory,price) values(@FoodName, @idCategory, @price)
end
go


create proc USP_UpdateFood
@id int, @FoodName nvarchar(100),@idCategory int,@price float
as
begin
	update food set name=@FoodName , idCategory=@idCategory , price=@price where id=@id
end
go
--TEST-----------------------------------------------------
Select id as[Mã số] , name as[Tên hiển thị] , UserName as[Tên tài khoản] from Account
select food.id , food.name as [Tên món ăn] , Foodcategory.name as [Danh mục] ,price as [Giá tiền]  from Food,foodcategory where  food.name like N'%%' and idCategory=foodcategory.id
EXEC USP_DELETEBILL 8
EXEC USP_GetTableList
EXEC USP_GetAccountByUserName  @userName='Duong'
EXEC USP_ChangeTableName 20,N'VIP' 
exec USP_UpdateAccount N'Duong', N'Thái Dương', 'letshimcook'
select * from TableFood
select * from account
select * from FoodCategory
select * from Food
select * from Bill
select * from BillInfo
SELECT GETDATE()
Select id from Bill where idTable=3 and status=0;
select * from BillInfo where idBill=1
select * from Food where  name like N'%Tôm%'
Select * from Account where UserName='admin'
Select * from Bill where id=39
Update Bill set status=1 where id=39
update food set ishidden=1 where id=
delete BillInfo
go
delete Bill
go
delete TableFood
go
select Food.Name, BillInfo.count ,Food.price, Food.price*BillInfo.count as total
from BillInfo,Bill,Food 
where Bill.id=BillInfo.idBill and BillInfo.idFood=Food.id and Bill.idTable='1'
go
EXEC USP_ChangeTableState 20 , 0
GO
SELECT Type FROM Account WHERE UserName=N'admin' and PassWord='1'
select getdate()
DELETE tableFood WHERE id=24

