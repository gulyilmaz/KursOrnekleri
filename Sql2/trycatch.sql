----Try Catch
--begin try
--i�lem veya i�lemler
--end try
--begin catch
---hata oldu�u zaman yapmak istedi�imiz i�lemler
--end catch

select*from Production.product
begin try
insert into Production.Product(safetystocklevel) values ('g�l')
end try
begin catch
print 'hata olu�tu'
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
--genel olarak yakalanmayan hatalar� yakalay�p kullan�c�ya  bildirmek
--i�in try catch yap�s� i�inde kullanabilece�imiz yap�d�r.
--select 1/0
--exec sp_addmessage @msgnum=50009,@severity=16,@msgtext='hi� bir say� s�f�ra b�l�nemez,hata olu�tu'

----select* from sys.messages

