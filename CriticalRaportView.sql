CREATE VIEW CriticalStockView AS 
SELECT p.ProductID, p.Name, p.ReorderPoint, SUM(i.Quantity) as TotalQuantity FROM 
	Production.ProductInventory i
	join Production.Product p on i.ProductID = p.ProductID
	GROUP BY p.ProductID, p.Name, p.ReorderPoint
	HAVING sum(i.Quantity) < p.ReorderPoint;
-- Zwraca wszystkie produktu w których ³¹czny stan magazynowy jest poni¿ej dopuszczalnego ReorderPoint