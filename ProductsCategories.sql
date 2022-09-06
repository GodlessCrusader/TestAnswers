SELECT Product.Name, Category.Name FROM Product JOIN ProductCategories  
ON ProductId = Product.Id  LEFT JOIN Category ON CategoryId = Category.Id
