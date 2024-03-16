SELECT DISTINCT
	s.name [Schema],
	t.name [Table],
	SUM(p.rows) [RecordCount]
FROM
	sys.tables t
INNER JOIN
	sys.schemas s ON t.schema_id = s.schema_id
INNER JOIN
	sys.indexes i ON t.object_id = i.object_id
INNER JOIN
	sys.partitions p ON i.object_id = p.object_id
	AND i.index_id = p.index_id
WHERE
	i.index_id <= 1
	AND p.rows > 0
GROUP BY
	s.name, t.name, i.name, i.object_id, i.index_id
ORDER BY
	s.name, t.name