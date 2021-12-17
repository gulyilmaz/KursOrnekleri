--ddl triggerlar
--create alter ve drop i�lemleri sonucunda devreye girecek olan yap�lard�r

create trigger ddl_trigger
on database
for drop_table,alter_table,create_procedure,drop_procedure
as
print 'bu i�lemler ger�ekle�tirilemez'
rollback

drop table logtablosu

--Dikkat ddl triggerlar ilgili veri taban�n�n programmability -database-triggers sekmesi alt�ndan eri�ilebilr



--trigger� devred��� b�rakma
disable trigger ornektrigger on personel

--aktif etmek
enable trigger ornektrigger on personel



--tablo �zerindeki triggerlar� g�rmek istersem
exec sp_helptrigger '[dbo].[personel]'