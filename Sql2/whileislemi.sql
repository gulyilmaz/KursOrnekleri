----While Genel kullan�m�
 ---while �art
 --begin
 --kod veya kodlar
 --end

 declare @isim nvarchar(20) ='g�l Y�lmaz'
 declare @sayac int=0
 while @sayac <=len(@isim)
 begin
 print substring(@isim,1,@sayac)
 set @sayac =@sayac+1
 end
 print 'while i�lmi bitti'