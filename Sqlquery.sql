select Product_Name,Category_Name from products
LEFT JOIN categories
ON products.id = categories.id;