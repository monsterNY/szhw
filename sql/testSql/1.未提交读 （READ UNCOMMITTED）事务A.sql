BEGIN TRANSACTION

	--ִ���޸� ��ȡ������
	UPDATE Product
	SET Price = 10
	WHERE Id = 1

	--�׶�2
	UPDATE Product
	SET Price = Price + 1
	WHERE Id = 1 

	SELECT * FROM Product
	WHERE Id = 1 

	--�׶�3
	UPDATE Product
	SET Price = Price + 5
	WHERE Id = 1 

	SELECT * FROM Product
	WHERE Id = 1 

--�׶�4
COMMIT TRANSACTION