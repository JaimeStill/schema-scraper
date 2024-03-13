SELECT
    COLUMN_NAME [Column],
    DATA_TYPE [Type],
    CAST(
        CASE
            WHEN IS_NULLABLE = 'NO' THEN 0
            ELSE 1
        END
    AS BIT) [IsNullable]
FROM
    INFORMATION_SCHEMA.COLUMNS
WHERE
    TABLE_NAME = '{{tablename}}' -- replace with table name
ORDER BY
    ORDINAL_POSITION