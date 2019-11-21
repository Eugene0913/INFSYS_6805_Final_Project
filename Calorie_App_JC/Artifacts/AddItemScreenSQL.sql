-- Distinct Category
SELECT DISTINCT
category
FROM
foods;

-- Load foods based on selected category
SELECT
name
FROM
foods
WHERE
category = 'Protein';
