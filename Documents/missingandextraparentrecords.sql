

select * from [vwStudentContactsPivot] p  left 
join vwStudentContactCurrentYear c on p.parentid= c.parentid
where c.parentid =10788 



select * from [vwStudentContactsPivot] where parentid = 10788

select * from [KorowaData].[dbo].[parents22072015] c right join  [vwStudentContactsPivot] p on  p.parentid= c.[external id]
where c.[external id] is null


select * from [KorowaData].[dbo].[parents22072015] c  join  [vwStudentContactsPivot] p on  p.parentid= c.[external id]


select * from [KorowaData].[dbo].[parents22072015] c  left join  [vwStudentContactsPivot] p on  p.parentid= c.[external id]
where p.parentid is null