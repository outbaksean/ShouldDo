select * from Priority
select * from Schedule
select * from Recurrence
select * from PerType
--select * from ShouldDo where id = 13

--declare @ShouldDoID bigint
--set @ShouldDoID = 13
--select * from priority where ID = 3
--select s.id, s.name, s.description, p.name, sch.name, r.timesper, rt.name 
--from shouldDo as s
--left join priority as p
--	on (p.id = s.priority)
--left join schedule as sch
--	on (sch.id = s.schedule)
--left join recurrence as r
--	on (s.recurrence = r.id)
--left join PerType as rt
--	on (r.pertype = rt.id)
--where s.id = @ShouldDoID