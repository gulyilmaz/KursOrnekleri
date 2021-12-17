--ddl triggerlar
--create alter ve drop iþlemleri sonucunda devreye girecek olan yapýlardýr

create trigger ddl_trigger
on database
for drop_table,alter_table,create_procedure,drop_procedure
as
print 'bu iþlemler gerçekleþtirilemez'
rollback

drop table logtablosu

--Dikkat ddl triggerlar ilgili veri tabanýnýn programmability -database-triggers sekmesi altýndan eriþilebilr



--triggerý devredýþý býrakma
disable trigger ornektrigger on personel

--aktif etmek
enable trigger ornektrigger on personel



--tablo üzerindeki triggerlarý görmek istersem
exec sp_helptrigger '[dbo].[personel]'