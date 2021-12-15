----transaction
--Birden çok iþlemin bir arada yapýldýðý durumlarda eðer parçayý oluþturan islemlerden herhangi birinde sorun olursa tüm iþlemi iptal ettirmeye yarar


--Örneðin kredi kartý ile alýþveriþ iþlemlerinde transaction iþlemi vardýr.Siz marketten ürün alýrken sizin hesabýnýzdan para düþülecek marketin hesabýna para aktarýlacaktýr. bu iþlemde hata olmamamsý gerekir ve bundan dolayý iþlemler transaction bloðunda gerçekleþtirilmelidir.Bu esnada bir sorun olursa tüm iþlem geri alýnmalýdýr.

--Begin Tran veya Begin transaction : Transaction iþlemini baþlatýr.

--Commit tran: Transaction iþlemi baþarýyla sona erdirir.Ýþlemleri gerçekleþtirir.

--Rollback tran: Transaction iþlemini iptal eder.Ýþlemleri geri alýr.

--Commit tarn yerine commit rollback tran yerine rollback yazýlabilir


--transaction tanýmlama 
--begin tran  transaction adý(vermeseniz de olur)
--iþlemler

insert personel values('sema','mutlu')--varsayýlan olarak transaction kontrolünde bir iþlemdir.Baþarýlýysa commit tran olrak bitmektedir

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
print 'kayýt silindi'
commit --ya da commit tran
end

else
begin
print 'iþlemler geri alýndý'
rollback
end


