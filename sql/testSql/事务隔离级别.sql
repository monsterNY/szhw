--2.���뼶��ķ���
--��1��δ�ύ�� ��READ UNCOMMITTED��

--��2�����ύ����READ COMMITTED����Ĭ��ֵ��

--��3�����ظ�����REPEATABLE READ��

--��4�������л���SERIALIZABLE��

--��5�����գ�SNAPSHOT��

--��6���Ѿ��ύ�����գ�READ_COMMITTED_SNAPSHOT��


--5.sys.dm_exec_requests ��ͼ
--ʶ����������漰���ĻỰ�����õ���Դ���������Ự�ȴ��˶೤ʱ��
--SELECT session_id FROM sys.dm_exec_sessions

--�� 1.sys.dm_tran_locks ��ͼ

--��1���ö�̬��ͼ���Բ�ѯ����Щ��Դ���ĸ�����ID����

--��2����ѯ������Դ��������ڵȴ�����ģʽ

--��3����ѯ����������Դ������

--����Ĳ�ѯ���3�Ѿ��õ��������ͼ�����Բο���ͼ�еķ���˵����

SELECT request_session_id AS �Ựid ,
resource_type AS ������������Դ���� ,
resource_description AS ���� ,
request_mode AS ģʽ ,
request_status AS ״̬
FROM sys.dm_tran_locks

--2.sys.dm_exec_connections ��ͼ

--��1����ѯ���ö�̬��ͼ���Բ�ѯ��������ص���Ϣ

--��2����ѯ�����һ�η�����������д������ʱ��last_read,last_write

--��3����ѯ������ִ�е����һ��SQL������Ķ����Ʊ��most_recent_sql_handle

--SELECT  session_id ,
--        connect_time ,
--        last_read ,
--        last_write ,
--        most_recent_sql_handle
--FROM    sys.dm_exec_connections
 

-- dm_exec_sql_text

--��1���ú������Խ������Ʊ��most_recent_sql_handle��Ϊ������Ȼ�󷵻�SQL���롣

--��2�����������ڲ��ϵ����У������ڴ����п��������һ��������һ���ǵ����������䡣�ڱ��������һ��ִ������ǵ�����������䡣 

--SELECT  session_id ,
--        text
--FROM    sys.dm_exec_connections
--        CROSS APPLY sys.dm_exec_sql_text
--        (most_recent_sql_handle) AS ST

--�����Ự
--KILL 52