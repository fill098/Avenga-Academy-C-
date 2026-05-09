select Name 
from BusinessEntities
UNION ALL
select Name
from Customers


select Region
from BusinessEntities
UNION
select RegionName
from Customers


select Region
from BusinessEntities
EXCEPT
--INTERSECT
select RegionName
from Customers