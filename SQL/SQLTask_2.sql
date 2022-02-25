IF Object_id('tempdb..#test_table') IS NOT NULL
	DROP TABLE #test_table
	
CREATE TABLE #test_table
(
	NUMBER INT,
	NAME VARCHAR(255)
)

GO
INSERT INTO #test_table VALUES (1, 'Red') --&lt;-- Полный дулбикат
INSERT INTO #test_table VALUES (2, 'Yellow')
INSERT INTO #test_table VALUES (3, 'Green')
INSERT INTO #test_table VALUES (1, 'Blue')
INSERT INTO #test_table VALUES (1, 'Red') --&lt;-- Полный дулбикат
INSERT INTO #test_table VALUES (4, 'Black')
INSERT INTO #test_table VALUES (2, 'Red')
GO

with removeDublicate
as 
(
	select *, row_number() over (PARTITION by NUMBER, Name order by Name) as rn 
	from #test_table
)
delete from removeDublicate where rn>1
 
SELECT * FROM #test_table