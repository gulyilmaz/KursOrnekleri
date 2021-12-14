----Try Catch
--begin try
--iþlem veya iþlemler
--end try
--begin catch
---hata olduðu zaman yapmak istediðimiz iþlemler
--end catch

select*from Production.product
begin try
insert into Production.Product(safetystocklevel) values ('gül')
end try
begin catch
print 'hata oluþtu'
end catch









begin try
select 1/1,@@error as error
end try
begin catch


end catch

begin try
select 1/0;
end try
begin catch
select
@@error as error,
Error_number()  errornumber,
ERROR_SEVERITY() errorseverity,
error_procedure() errorprocedure,
ERROR_LINE() errorline,
ERROR_MESSAGE() errormessage

end catch

---Sql serverde Raiseerror
--genel olarak yakalanmayan hatalarý yakalayýp kullanýcýya  bildirmek
--için try catch yapýsý içinde kullanabileceðimiz yapýdýr.
--select 1/0
--exec sp_addmessage @msgnum=50009,@severity=16,@msgtext='hiç bir sayý sýfýra bölünemez,hata oluþtu'

----select* from sys.messages

