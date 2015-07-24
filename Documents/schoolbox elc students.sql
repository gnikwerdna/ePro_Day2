select

case when StudentYearLevel=30 then left(StudentPreferred,1)+ studentSurname+'14'
     when StudentYearLevel=40 then left(StudentPreferred,1)+ studentSurname+'13'
end  as Username,
StudentTitle as Title,
StudentPreferred as Firstname,
studentSurname as Lastname,
studentid as [School Id],
'Students' as Role,
'ELC' as Campus1,
'' as Campus2,
'' as Campus3,
'' as Campus4,
StudentYearLevel as [Year],
'' as Password,
0 as [Email Address from Username],
1 as [Use External Mail Client],
0 as [Alternate Email],
0 as [Webmail Tab],
0 as [E-Portfolio]

 
 from vStudents
where fileyear =2015
and studentyearlevel in (30,40)

group by studentid, StudentNameInternal, StudentNameExternal, StudentYearLevel,StudentPreferred,studentSurname,StudentTitle