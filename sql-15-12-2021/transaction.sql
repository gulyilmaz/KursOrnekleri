----transaction
--Birden �ok i�lemin bir arada yap�ld��� durumlarda e�er par�ay� olu�turan islemlerden herhangi birinde sorun olursa t�m i�lemi iptal ettirmeye yarar


--�rne�in kredi kart� ile al��veri� i�lemlerinde transaction i�lemi vard�r.Siz marketten �r�n al�rken sizin hesab�n�zdan para d���lecek marketin hesab�na para aktar�lacakt�r. bu i�lemde hata olmamams� gerekir ve bundan dolay� i�lemler transaction blo�unda ger�ekle�tirilmelidir.Bu esnada bir sorun olursa t�m i�lem geri al�nmal�d�r.

--Begin Tran veya Begin transaction : Transaction i�lemini ba�lat�r.

--Commit tran: Transaction i�lemi ba�ar�yla sona erdirir.��lemleri ger�ekle�tirir.

--Rollback tran: Transaction i�lemini iptal eder.��lemleri geri al�r.

--Commit tarn yerine commit rollback tran yerine rollback yaz�labilir


--transaction tan�mlama 
--begin tran  transaction ad�(vermeseniz de olur)
--i�lemler

insert personel values('sema','mutlu')--varsay�lan olarak transaction kontrol�nde bir i�lemdir.Ba�ar�l�ysa commit tran olrak bitmektedir

begin tran kontrol
insert personel values('sema','mutlu')
commit tran

select * from personel
Begin tran kontrol
DEclare @i int
Delete from personel where personel.id>3
set @i=@@ROWCOUNT
if @i=1
begin
print 'kay�t silindi'
commit --ya da commit tran
end

else
begin
print 'i�lemler geri al�nd�'
rollback
end


