----While Genel kullanýmý
 ---while þart
 --begin
 --kod veya kodlar
 --end

 declare @isim nvarchar(20) ='gül Yýlmaz'
 declare @sayac int=0
 while @sayac <=len(@isim)
 begin
 print substring(@isim,1,@sayac)
 set @sayac =@sayac+1
 end
 print 'while iþlmi bitti'