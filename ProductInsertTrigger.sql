USE AdventureWorks;
GO

CREATE TRIGGER trg_Product_Insert_GenerateCode
ON Production.Product
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Production.Product
    (
        Name,
        ProductNumber,
        MakeFlag,
        FinishedGoodsFlag,
        SafetyStockLevel,
        ListPrice,
        ProductSubcategoryID,
        ModifiedDate,
        SellStartDate,
        rowguid,
        ReorderPoint
    )
    SELECT
        i.Name,
        -- jeśli podano ProduktNumber w INSERT, użyj go; w przeciwnym razie generuj
        CASE 
            WHEN i.ProductNumber IS NULL 
                THEN dbo.GenerateProductCode(i.Name)
            ELSE
                i.ProductNumber
        END,
        i.MakeFlag,
        i.FinishedGoodsFlag,
        i.SafetyStockLevel,
        i.ListPrice,
        i.ProductSubcategoryID,
        GETDATE(),               -- ModifiedDate
        GETDATE(),               -- SellStartDate
        NEWID(),                 -- rowguid
        i.ReorderPoint
    FROM inserted i;
END;
GO
