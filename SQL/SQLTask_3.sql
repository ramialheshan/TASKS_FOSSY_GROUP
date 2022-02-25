IF Object_id('tempdb..#test_tran') IS NOT NULL
DROP TABLE #test_tran

CREATE TABLE #test_tran
(
	id INT,
	name VARCHAR(255)
)
GO
----------------------------------------

BEGIN TRAN

DECLARE @a FLOAT = 1 / 0.0

IF @@ERROR <> 0
Begin
	RollBack TRAN 
	RETURN 
End

INSERT INTO #test_tran VALUES (1, '�������')
COMMIT TRAN
----------------------------------------
GO
SELECT * FROM #test_tran