-- C1: Hiển thị tất cả các mặt hàng có giảm giá <= 10%
SELECT * FROM [dbo].[Products]
WHERE
	([Discount] <= 10);

-- C2: Hiện thị tất cả các mặt hàng không có giảm giá
SELECT * FROM [dbo].[Products]
WHERE
	([Discount] IS NULL OR [Discount] = 0);

-- C4: Hiển thị tất cả các mặt hàng có giá bán sau khi đã giảm giá <= 100.000
SELECT *, ([Price] * (100 - [Discount]) / 100) AS [SalePrice] FROM [dbo].[Products]
WHERE 
	(([Price] * (100 - [Discount]) / 100) <= 100000);


-- C5: Hiện thị tất cả các mặt hàng thuộc danh mục CPU, RAM
SELECT * 
FROM 
	[dbo].[Products] AS P INNER JOIN [dbo].[Categories] AS C
		ON P.CategoryId = C.Id
WHERE
	(C.[Name] LIKE N'%RAM%' OR C.[Name] LIKE N'%CPU%');

-- C8: Hiển thị tất cả các khách hàng có năm sinh 1990.
SELECT * FROM [dbo].[Customers]
WHERE 
	(YEAR([Birthday]) = 1990)

-- C9: Hiển thị tất cả các khách hàng có tuổi trên 60
SELECT * FROM [dbo].[Customers]
WHERE 
	(DATEDIFF(day, [Birthday], GETDATE()) / 365 >= 60)

-- C9: Hiển thị tất cả các khách hàng có tuổi trên 60
SELECT * FROM [dbo].[Customers]
WHERE 
	(DATEDIFF(year, [Birthday], GETDATE()) >= 60)

-- C10: Hiển thị tất cả các khách hàng có tuổi từ 20 đến 30.
SELECT * FROM [dbo].[Customers]
WHERE 
	(DATEDIFF(year, [Birthday], GETDATE()) >= 20) 
	AND (DATEDIFF(year, [Birthday], GETDATE()) <= 30)

-- C10: Hiển thị tất cả các khách hàng có tuổi từ 20 đến 30.
SELECT * FROM [dbo].[Customers]
WHERE 
	(DATEDIFF(year, [Birthday], GETDATE()) BETWEEN 20 AND 30)
	
-- C11: Hiển thị tất cả các khách hàng có sinh nhật là hôm nay
SELECT * FROM [dbo].[Customers]
WHERE 
	(DAY([Birthday]) = DAY(GETDATE()))
	AND (MONTH([Birthday]) = MONTH(GETDATE()))

-- C13: Hiển thị tất cả các đơn hàng có trạng thái là COMPLETED trong ngày hôm nay
SELECT * FROM [dbo].[Orders]
WHERE 
	([Status] = 'COMPLETED')
	AND (CAST([CreatedDate] AS date) = CAST(GETDATE() AS date))



-- C14: Hiển thị tất cả các đơn hàng chưa hoàn thành trong tháng này
SELECT * FROM [dbo].[Orders]
WHERE 
	([Status] != 'COMPLETED')
	AND (YEAR([CreatedDate]) = YEAR(GETDATE()))
	AND (MONTH([CreatedDate]) = MONTH(GETDATE()))

