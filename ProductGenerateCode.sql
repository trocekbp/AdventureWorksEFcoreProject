USE AdventureWorks;
GO

CREATE FUNCTION dbo.GenerateProductCode(@Name NVARCHAR(50))
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @prefix NVARCHAR(3);
    DECLARE @maxNum INT;
    DECLARE @newNum INT;
    DECLARE @result NVARCHAR(20);

    -- 1) Prefiks = pierwsze 3 litery (wielkie litery). Jeśli krótsze, dopełnij 'X'
    IF LEN(@Name) >= 3
        SET @prefix = UPPER(SUBSTRING(@Name, 1, 3));
    ELSE
        SET @prefix = UPPER(@Name + REPLICATE('X', 3 - LEN(@Name)));

    -- 2) Znajdź maksymalny numer ze wszystkich istniejących już kodów
    SELECT @maxNum = MAX(
        TRY_CAST(SUBSTRING(ProductNumber, 4, LEN(ProductNumber) - 3) AS INT)
    )
    FROM Production.Product
    WHERE ProductNumber LIKE @prefix + '%';

    IF @maxNum IS NULL
        SET @maxNum = 0;

    SET @newNum = @maxNum + 1;

    -- 3) Sklej nowy kod: prefix + 4 cyfry (np. '0001')
    SET @result = @prefix + RIGHT('0000' + CAST(@newNum AS NVARCHAR(10)), 4);

    RETURN @result;
END;
GO
