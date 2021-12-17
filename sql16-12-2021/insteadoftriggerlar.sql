--instead of triggerlar
--þu ana kadar insert ,delete,update iþlemleri yapýlýrken su iþlemleri yap mantýðýyla çalýþtýk(yanýnda þunu yap)
--instead of triggerlar ise onlarýn yerine þu iþlemleri yap mantýðýyla çalýþýr

--create trigger trigger adý
--on tablo adý
--instead of delete,insert,update
--as
--komutlar

--Örnek 5
--personel tablosunda update gerçekleþtiði anda yapýalacak güncelleþtirme yerine log tablosuna "Adý....olan personel  .... yeni adýyla deðiþtirilerek ...kullanýcý tarafýndan ... tarihinde güncllenmek istedi. yazsýn iþelmi yapmasýn

create trigger triggerpersonelRaporinstead
on personel
instead of update
as
declare @adi nvarchar(max),@eskiadi nvarchar(max)
select @eskiadi=isim from deleted
select @adi=isim from inserted
insert into logtablosu values('adý '+@eskiadi +'olan personel'+@adi+'yeni adýyla deðiþtirilerek'+ SUSER_NAME()+'tarafýndan '+cast(getdate() as nvarchar)+'tarihinde güncellenek istedi')
update personel set isim='zeynep' where id=1


--Örnek 6 
--personel tablosunda adý "Andrew " olan kaydýn silinmesini engelleyen ama diðerlerine izin veren triggerý yazalým

create trigger andrewtrigger
on personel
after delete 
as
declare @adi nvarchar(max)
select @adi=isim from deleted
if @adi='andrew'
begin 
print 'bu kayýt silinemedi'
rollback
end
delete personel where id=13
delete personel where id=12
