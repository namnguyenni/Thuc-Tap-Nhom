USE TruongTHPT
GO

--update student
CREATE PROCEDURE Sua_HS (@MaHS nchar(10), @HovaTen nvarchar(50), @GT nchar(3), @NgaySinh date,
				@DiaChi nvarchar(50), @PhuHuynh nvarchar(50), @MaLop nchar(10))
AS
BEGIN
 UPDATE tblHocSinh
 SET HovaTen = @HovaTen, GT = @GT, NgaySinh = @NgaySinh, DiaChi = @DiaChi, PhuHuynh = @PhuHuynh, MaLop = @MaLop
 WHERE MaHS = @MaHS
END

--delete student
CREATE PROCEDURE Xoa_HS (@MaHS nchar(10))
AS
BEGIN
 DELETE FROM tblHocSinh WHERE MaHS = @MaHS
END

-- update teacher
CREATE PROCEDURE Sua_GV (@MaGV nchar(10), @HoTen nvarchar(50), @GT nchar(3), @NgaySinh date, @DiaChi nvarchar(50),
				@SDT int, @Luong bigint, @MaMon nchar(10))
AS
BEGIN
 UPDATE tblGiaoVien
 SET HoTen = @HoTen, GT = @GT, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT, Luong = @Luong, MaMon = @MaMon
 WHERE MaGV = @MaGV
END

--delete teacher
CREATE PROCEDURE Xoa_GV (@MaGV nchar(10))
AS
BEGIN
 DELETE FROM tblGiaoVien WHERE MaGV = @MaGV
END

--add student
ALTER PROC ADD_HocSinh (@HovaTen nvarchar(50), @GT nchar(3), @NgaySinh date, @DiaChi nvarchar(50), @PhuHuynh nvarchar(50), @MaLop nchar(10))
AS 
BEGIN
	DECLARE @MaHS nchar(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaHS FROM tblHocSinh
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @MaHS
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@MaHS, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@MaHS, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaHS
END

DECLARE @cdai int
DECLARE @i int
SET @MaHS = CAST((@sott + 1) as nchar(8))
SET @cdai = LEN(@MaHS)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaHS = '0' + @MaHS
	SET @i = @i + 1
END
SET @MaHS = 'HS' + @MaHS

INSERT INTO tblHocSinh values (@MaHS, @HovaTen, @GT, @NgaySinh, @DiaChi, @PhuHuynh, @MaLop )
SELECT @MaHS
CLOSE contro
DEALLOCATE contro
END

--add Teacher
CREATE PROC ADD_GV (@HoTen nvarchar(50), @GT nchar(3), @NgaySinh date, @DiaChi nvarchar(50), @SDT int, @Luong bigint, @MaMon nchar(10))
AS 
BEGIN
	DECLARE @MaGV nchar(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaGV FROM tblGiaoVien
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @MaGV
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@MaGV, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@MaGV, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaGV
END

DECLARE @cdai int
DECLARE @i int
SET @MaGV = CAST((@sott + 1) as nchar(8))
SET @cdai = LEN(@MaGV)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaGV = '0' + @MaGV
	SET @i = @i + 1
END
SET @MaGV = 'GV' + @MaGV

INSERT INTO tblGiaoVien values ( @MaGV, @HoTen, @GT, @NgaySinh, @DiaChi, @SDT, @Luong, @MaMon)
SELECT @MaGV
CLOSE contro
DEALLOCATE contro
END

--tim hoc sinh theo ma
CREATE PROC TK_HS_Ma (@MaHS nchar(10))
AS
BEGIN
	SELECT * FROM tblHocSinh WHERE MaHS like N'%' + @MaHS + '%'
END

--tim hoc sinh theo ten
CREATE PROC TK_HS_HoTen (@HoTen nvarchar(50))
AS
BEGIN
	SELECT * FROM tblHocSinh WHERE HovaTen like N'%' + @HoTen + '%'
END

--tim giao vien theo ma
CREATE PROC TK_GV_Ma (@MaGV nchar(10))
AS
BEGIN
	SELECT * FROM tblGiaoVien WHERE MaGV like N'%' + @MaGV + '%'
END

--tim giao vien theo ten
CREATE PROC TK_GV_HoTen (@HoTen nvarchar(50))
AS
BEGIN
	SELECT * FROM tblGiaoVien WHERE HoTen like N'%' + @HoTen + '%'
END
