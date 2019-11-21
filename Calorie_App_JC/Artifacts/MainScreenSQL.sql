-- Line Chart SQL - Overall - Last 7 Days
SELECT
CAST(meals_ref.created_at AS DATE) AS meal_date
,SUM(foods.calories * meals_ref.quantity) AS total_calories
FROM
meals_ref
LEFT JOIN foods ON (foods.id = meals_ref.food_id)
WHERE
user_id = 1
GROUP BY
CAST(meals_ref.created_at AS DATE);

-- Line Chart SQL - By Meal - Last 7 Days
SELECT
CAST(meals_ref.created_at AS DATE) AS meal_date
,meal_type.meal_type
,SUM(foods.calories * meals_ref.quantity) AS total_calories
FROM
meals_ref
LEFT JOIN foods ON (foods.id = meals_ref.food_id)
LEFT JOIN meal_type ON (meal_type.id = meals_ref.meal_type_id)
WHERE
user_id = 1
GROUP BY
CAST(meals_ref.created_at AS DATE)
,meal_type.meal_type
ORDER  BY
CAST(meals_ref.created_at AS DATE);

-- Current date total calories
SELECT
SUM(foods.calories * meals_ref.quantity) AS total_calories
FROM
meals_ref
LEFT JOIN foods ON (foods.id = meals_ref.food_id)
WHERE
user_id = 1
AND CAST(meals_ref.created_at AS DATE) = CAST(GETDATE() AS DATE);

-- Consumption Detail
SELECT
CAST(meals_ref.created_at AS DATE) AS meal_date
,meal_type.meal_type
,foods.category
,foods.name
,foods.calories
,meals_ref.quantity
,foods.calories * meals_ref.quantity AS total_calories
FROM
meals_ref
LEFT JOIN foods ON (foods.id = meals_ref.food_id)
LEFT JOIN meal_type ON (meal_type.id = meals_ref.meal_type_id)
WHERE
user_id = 1
ORDER BY
meals_ref.created_at,
CASE
WHEN meal_type.meal_type = 'Breakfast' THEN 1
WHEN meal_type.meal_type = 'Lunch' THEN 2
ELSE 3 END;
