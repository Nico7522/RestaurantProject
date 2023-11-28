
-- Catégories
SET IDENTITY_INSERT [DishCategory] ON;
INSERT INTO DishCategory (Id_DishCategory, [Name]) VALUES (1, 'Apéro'), (2, 'Entrée'), (3, 'Plat'), (4, 'Dessert'), (5, 'Enfant')
SET IDENTITY_INSERT [DishCategory] OFF;


-- Plâts
SET IDENTITY_INSERT [Dish] ON;
INSERT INTO [Dish] ([Id_Dish], [Name], [Description], [Price], [Id_Category]) VALUES
(1,'Bruschetta', 'Pain grillé frotté à l''ail, garni de tomates fraîches, de basilic et d''huile d''olive.', 5.99, 1),
(2,'Mini-saucisses cocktail', 'Petites saucisses fumées servies avec une sauce barbecue.', 4.99, 1),
(3,'Salade César', 'Laitue romaine, croûtons, parmesan et vinaigrette César.', 7.99, 2),
(4,'Soupe à l''oignon', 'Soupe à base d''oignons caramélisés, gratinée avec du fromage et du pain.', 6.99, 2),
(5,'Steak frites', 'Steak de bœuf grillé servi avec des frites croustillantes.', 15.99, 3),
(6,'Poulet rôti', 'Poulet entier rôti au four avec des herbes et des épices.', 12.99, 3),
(7,'Tarte aux pommes', 'Tarte sucrée remplie de tranches de pommes et de cannelle.', 6.99, 4),
(8,'Crème brûlée', 'Crème vanille cuite au four avec une couche de sucre caramélisé.', 7.99, 4),
(9,'Nuggets de poulet', 'Morceaux de poulet panés et frits, servis avec une sauce au choix.', 4.99, 5),
(10,'Spaghetti bolognaise', 'Spaghetti servis avec une sauce à la viande et du fromage râpé.', 4.99, 5);
SET IDENTITY_INSERT [Dish] OFF;
