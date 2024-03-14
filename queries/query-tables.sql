SELECT
    t.name [Table],
    SUM(p.rows) [RecordCount]
FROM
    sys.tables t
INNER JOIN
    sys.indexes i ON t.object_id = i.object_id
INNER JOIN
    sys.partitions p ON i.object_id = p.object_id
    AND i.index_id = p.index_id
WHERE
    i.index_id <= 1
    AND p.rows > 0
GROUP BY
    t.name, i.object_id, i.index_id, i.name
ORDER BY
    t.name