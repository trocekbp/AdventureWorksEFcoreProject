Select * from Production.Product p
	join Production.ProductSubcategory sc on p.ProductSubcategoryID = sc.ProductSubcategoryID
	join Production.ProductCategory c on sc.ProductCategoryID = c.ProductCategoryID	
	WHERE ProductID = 1004;