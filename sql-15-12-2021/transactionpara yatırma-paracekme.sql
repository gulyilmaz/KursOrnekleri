use sorgu
alter PROCEDURE parayatirma

	@musteriId int,
	@tutar	decimal(18,2)
AS
BEGIN
	
	begin try 
	begin transaction
    
	update musteri set bakiye=bakiye+@tutar where musteriId=@musteriId
	insert into hareket(musteriId,tarih,tutar) values(@musteriId,GETDATE(),@tutar)
	commit tran
	end try
	begin catch 
	rollback tran
	print 'para yatýrýlmadý'
	end catch
END
exec parayatirma @musteriId=2, @tutar=350.00
exec parayatirma @musteriId=4, @tutar=350.00



alter PROCEDURE paracekkk

	@musteriId int,
	@tutar	decimal(18,2)
AS
BEGIN
	begin tran
	declare @bakiye decimal(18,2)
	select @bakiye=bakiye from musteri where MusteriId=@musteriId
	if @tutar<=@bakiye
	begin
	update musteri set bakiye=bakiye-@tutar where musteriId=@musteriId
	insert into hareket(musteriId,tarih,tutar) values(@musteriId,GETDATE(),@tutar)
	commit tran
	end
	else
	begin
	
	rollback tran
	
	end

	
END
 exec paracekkk @musteriId=2, @tutar=30.00