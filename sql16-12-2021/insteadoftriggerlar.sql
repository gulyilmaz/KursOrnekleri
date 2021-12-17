--instead of triggerlar
--�u ana kadar insert ,delete,update i�lemleri yap�l�rken su i�lemleri yap mant���yla �al��t�k(yan�nda �unu yap)
--instead of triggerlar ise onlar�n yerine �u i�lemleri yap mant���yla �al���r

--create trigger trigger ad�
--on tablo ad�
--instead of delete,insert,update
--as
--komutlar

--�rnek 5
--personel tablosunda update ger�ekle�ti�i anda yap�alacak g�ncelle�tirme yerine log tablosuna "Ad�....olan personel  .... yeni ad�yla de�i�tirilerek ...kullan�c� taraf�ndan ... tarihinde g�ncllenmek istedi. yazs�n i�elmi yapmas�n

create trigger triggerpersonelRaporinstead
on personel
instead of update
as
declare @adi nvarchar(max),@eskiadi nvarchar(max)
select @eskiadi=isim from deleted
select @adi=isim from inserted
insert into logtablosu values('ad� '+@eskiadi +'olan personel'+@adi+'yeni ad�yla de�i�tirilerek'+ SUSER_NAME()+'taraf�ndan '+cast(getdate() as nvarchar)+'tarihinde g�ncellenek istedi')
update personel set isim='zeynep' where id=1


--�rnek 6 
--personel tablosunda ad� "Andrew " olan kayd�n silinmesini engelleyen ama di�erlerine izin veren trigger� yazal�m

create trigger andrewtrigger
on personel
after delete 
as
declare @adi nvarchar(max)
select @adi=isim from deleted
if @adi='andrew'
begin 
print 'bu kay�t silinemedi'
rollback
end
delete personel where id=13
delete personel where id=12
