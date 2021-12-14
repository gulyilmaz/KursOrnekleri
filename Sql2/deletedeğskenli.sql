declare @ka int
set @ka=9
delete from Categories where CategoryID=@ka
select * from Categories