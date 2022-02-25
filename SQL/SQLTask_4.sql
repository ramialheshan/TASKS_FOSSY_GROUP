IF Object_id('tempdb..#test_table') IS NOT NULL
	DROP TABLE #test_table
IF Object_id('tempdb..#test_table_temp') IS NOT NULL
	DROP TABLE #test_table_temp

CREATE TABLE #test_table
(
	id INT
)

CREATE TABLE #test_table_temp
(
	id INT
)


INSERT INTO #test_table
VALUES (1), (2), (8), (4), (9), (7), (3), (10), (99) --&lt;-- Отсутствуют числа 5 и 6

DECLARE @index int = 1
DECLARE @max int = 100

WHILE(@index <= @max)
BEGIN
IF ((select count(*) from #test_table where id = @index) = 0)
	INSERT INTO #test_table_temp VALUES (@index)
SET @index = @index + 1
END;

select *
from #test_table_temp