--2.���뼶��ķ���
--��1��δ�ύ�� ��READ UNCOMMITTED��

--��2�����ύ����READ COMMITTED����Ĭ��ֵ��

--��3�����ظ�����REPEATABLE READ��

--��4�������л���SERIALIZABLE��

--��5�����գ�SNAPSHOT��

--��6���Ѿ��ύ�����գ�READ_COMMITTED_SNAPSHOT��

--BEGIN TRANSACTION

--	--δ�ύ��
--	SET TRAN ISOLATION LEVEL READ UNCOMMITTED

--	SELECT * FROM Product--������A���׶���ʾ��ͬ
--	WHERE Id = 1 

--COMMIT TRANSACTION

BEGIN TRANSACTION

	--���ύ����Ĭ�ϼ���
	SET TRAN ISOLATION LEVEL READ COMMITTED

	--��ȡ��ȡ������  
	--����ѯ��Ϣ���������� ��ȴ�������������
	SELECT * FROM Product--������A���׶���ʾ��ͬ
	WHERE Id = 1 

COMMIT TRANSACTION