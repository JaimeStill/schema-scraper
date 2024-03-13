SELECT DISTINCT
    tr.name [Table]
FROM
    sys.foreign_keys fk
INNER JOIN
    sys.tables tp ON fk.parent_object_id = tp.object_id
INNER JOIN
    sys.tables tr ON fk.referenced_object_id = tr.object_id
INNER JOIN
    sys.foreign_key_columns fkc ON fkc.constraint_object_id = fk.object_id
INNER JOIN
    sys.columns cp ON fkc.parent_column_id = cp.column_id
    AND fkc.parent_object_id = cp.object_id
INNER JOIN
    sys.columns cr ON fkc.referenced_column_id = cr.column_id
    AND fkc.referenced_object_id = cr.object_id
WHERE
    tp.name = '{{tablename}}' -- replace with table name
    AND tr.name != tp.name
    AND tr.name IN (
        -- only include relationships to tables with data
        SELECT
            t.name
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
    )
ORDER BY
    tr.name