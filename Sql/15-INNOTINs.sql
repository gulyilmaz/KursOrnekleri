select * from Production.Product
where 
ProductNumber = 'AR-5381' or 
ProductNumber = 'BA-8327'

'AR-5381',
'BA-8327',
'BE-2349',
'BE-2908',
'BL-2036',
'CA-596225',
'CA-6738',
'CA-7457',
'CB-2903',
'CN-6137'


'AR-5381',
'BA-8327',
'BE-2349',
'BE-2908',
'BL-2036',
'CA-6738',
'CA-7457',
'CB-2903',
'CN-6137'

-- IN veya Not In 

select * from Production.Product
where 
ProductNumber 
In  -- içeren kayıtlar 
(
'AR-5381',
'BA-8327',
'BE-2349',
'BE-2908',
'BL-2036',
'CA-596225',
'CA-6738',
'CA-7457',
'CB-2903',
'CN-6137'
)

select * from Production.Product
where 
ProductNumber 
Not In  -- içermeyen kayıtlar 
(
'AR-5381',
'BA-8327',
'BE-2349',
'BE-2908',
'BL-2036',
'CA-6738',
'CA-7457',
'CB-2903',
'CN-6137'
)
