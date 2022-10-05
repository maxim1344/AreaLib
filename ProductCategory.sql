﻿SELECT prod.name, cat.name FROM Products prod
LEFT JOIN ProductsCategories pc ON prod.Id = pc.ProductId
LEFT JOIN Categories cat ON pc.CategoryId = cat.Id
ORDER BY prod.Name;