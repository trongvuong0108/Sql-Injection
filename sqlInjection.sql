select * from [SqlInjection].[dbo].[user] where username = 'admin' and password = '' or '1'='1'
select * from [SqlInjection].[dbo].[user] where username = 'admin' and password = 'admin'
select * from [SqlInjection].[dbo].[user] where username = 'admin' and password = '12313'