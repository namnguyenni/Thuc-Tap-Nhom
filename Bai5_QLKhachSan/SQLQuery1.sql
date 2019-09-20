USE QL_KhachSan
GO

--them khach
CREATE PROC ADDKhachThuePhong (@TenKH nvarchar(50), @GT nvarchar(3), @NgaySinh date, @CMND varchar(20))
AS
BEGIN
	DECLARE @MaKH nchar(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaKH FROM tblKhachThuePhong
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @MaKH
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@MaKH, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@MaKH, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaKH
END

DECLARE @cdai int
DECLARE @i int
SET @MaKH = CAST((@sott + 1) as nchar(8))
SET @cdai = LEN(@MaKH)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaKH = '0' + @MaKH
	SET @i = @i + 1
END
SET @MaKH = 'KH' + @MaKH

INSERT INTO tblKhachThuePhong values ( @MaKH, @TenKH, @GT, @NgaySinh, @CMND)
SELECT @MaKH
CLOSE contro
DEALLOCATE contro
END

-- sua khach
CREATE PROC SuaKhachThuePhong (@MaKH nvarchar(10), @TenKH nvarchar(50), @GT nvarchar(3), @NgaySinh date, @CMND varchar(20))
AS
BEGIN
	UPDATE tblKhachThuePhong SET TenKH = @TenKH,GT = @GT, NgaySinh = @NgaySinh, CMND = @CMND WHERE MaKH = @MaKH
END

-- xoa khach
CREATE PROC Xoa_KhachThuePhong (@MaKH nvarchar(10))
AS
BEGIN
	DELETE FROM tblKhachThuePhong WHERE MaKH = @MaKH
END