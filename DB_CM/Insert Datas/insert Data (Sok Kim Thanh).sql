-- [Ngày]			[Người thực hiện]		[Mô tả thay đổi]
-- 2024-11-06	| Admin				|	Thêm các phòng chiếu mới vào bảng tbl_DM_Theater
-- 2024-11-11	| Admin				|	Cập nhật
-- Cập nhật ngày 2024-11-06
-- Thêm các phòng mới từ Phòng 1 đến Phòng 15 và các phòng chiếu đặc biệt IMAX, 4DX vào bảng tbl_DM_Theater
use CM_Cinema_DB
go
INSERT INTO tbl_DM_AgeRating (AR_NAME, AR_NOTE, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
-- Phân loại MPAA (Hoa Kỳ)
('G', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG_US', N'Khuyến nghị có sự hướng dẫn của cha mẹ', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG-13', N'Khuyến nghị cha mẹ hướng dẫn cho trẻ dưới 13 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('R', N'Cấm người dưới 17 tuổi trừ khi có người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('NC-17', N'Cấm người dưới 17 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại Việt Nam
('P', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('K', N'Khuyến nghị xem có sự hướng dẫn của cha mẹ', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('C13', N'Cấm khán giả dưới 13 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('C16', N'Cấm khán giả dưới 16 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('C18', N'Cấm khán giả dưới 18 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại BBFC (Anh Quốc)
('U', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG_EN', N'Khuyến nghị cha mẹ hướng dẫn, có thể có một số nội dung không phù hợp với trẻ nhỏ', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('12A', N'Trẻ dưới 12 tuổi cần người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('15', N'Cấm khán giả dưới 15 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('18', N'Cấm khán giả dưới 18 tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
 
-- Phân loại CBFC (Ấn Độ)
('U_IN', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('UA', N'Phim phù hợp với người lớn và trẻ em dưới sự giám sát của người lớn', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('A_IN', N'Chỉ dành cho người từ 18 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('S', N'Chỉ dành cho các nhóm khán giả cụ thể', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại ACB (Úc)
('G_AU', N'Phù hợp cho mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG_AU', N'Khuyến nghị trẻ dưới 15 tuổi xem có người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('M', N'Khuyến nghị cho người từ 15 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('MA15+', N'Yêu cầu người dưới 15 tuổi xem có người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('R18+_AU', N'Chỉ dành cho người từ 18 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại KMRB (Hàn Quốc)
('ALL_KR', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('12_KR', N'Khuyến nghị cho người từ 12 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('15_KR', N'Khuyến nghị cho người từ 15 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('18_KR', N'Chỉ dành cho người từ 18 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Restricted_KR', N'Chỉ chiếu tại các địa điểm hoặc sự kiện cụ thể', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại Eirin (Nhật Bản)
('G_JP', N'Phù hợp cho mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG12_JP', N'Khuyến nghị trẻ dưới 12 tuổi có người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('R15+_JP', N'Chỉ dành cho người từ 15 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('R18+_JP', N'Chỉ dành cho người từ 18 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại CARA (Canada)
('G_CA', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('PG_CA', N'Khuyến nghị trẻ nhỏ xem có người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('14A', N'Trẻ dưới 14 tuổi cần người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('18A', N'Trẻ dưới 18 tuổi cần người lớn đi kèm', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('R_CA', N'Chỉ dành cho người từ 18 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('A_CA', N'Chỉ dành cho người từ 18 tuổi trở lên, thường là nội dung người lớn', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phân loại FSK (Đức)
('FSK_0', N'Phù hợp với mọi lứa tuổi', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('FSK_6', N'Phù hợp cho người từ 6 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('FSK_12', N'Phù hợp cho người từ 12 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('FSK_16', N'Phù hợp cho người từ 16 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('FSK_18', N'Chỉ dành cho người từ 18 tuổi trở lên', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

go
INSERT INTO tbl_DM_Movie (MV_NAME, MV_PRICE, MV_DURATION, MV_POSTERURL, MV_DESCRIPTION, MV_AGERATING_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
-- Các bộ phim mới được thêm
('Inception', 100000, 120, 'inception.jpg', 'A sci-fi thriller about dreams within dreams', 1,  (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Matrix', 90000, 120, 'matrix.jpg', 'A hacker discovers reality is a simulation', 2, (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Interstellar', 120000, 120, 'interstellar.jpg', 'A journey through space and time to save humanity', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Inglourious Basterds', 95000, 120, 'inglourious_basterds.jpg', 'A group of Jewish soldiers plan to assassinate Nazi leaders', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Saving Private Ryan', 90000, 120, 'saving_private_ryan.jpg', 'A group of soldiers go behind enemy lines to retrieve a paratrooper', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),


-- Thêm một số bộ phim nổi tiếng khác
('Avatar', 110000, 120, 'avatar.jpg', 'A marine on an alien planet becomes part of the native culture', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Titanic', 80000, 120, 'titanic.jpg', 'A tragic love story set on the ill-fated Titanic', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Godfather', 95000, 120, 'godfather.jpg', 'The story of a mafia family and their struggle for power', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Dark Knight', 105000, 120, 'dark_knight.jpg', 'Batman faces the Joker in a battle for Gotham City', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Forrest Gump', 75000, 120, 'forrest_gump.jpg', 'A simple man witnesses historic events in America', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Pulp Fiction', 85000, 120, 'pulp_fiction.jpg', 'Intersecting stories of crime and redemption', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Jurassic Park', 95000, 120, 'jurassic_park.jpg', 'Dinosaurs come to life in a theme park', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Các bộ phim khác
('Gladiator', 90000, 120, 'gladiator.jpg', 'A betrayed Roman general seeks revenge in the arena', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Shawshank Redemption', 85000, 120, 'shawshank_redemption.jpg', 'The story of hope and resilience in a prison', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Lion King', 80000, 88, 'lion_king.jpg', 'A lion cub becomes king of the jungle', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Harry Potter and the Sorcerers Stone', 95000, 120, 'harry_potter1.jpg', 'A young wizard discovers his magical heritage', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Lord of the Rings: The Fellowship of the Ring', 120000, 120, 'lotr_fellowship.jpg', 'A hobbit sets out on a journey to destroy a powerful ring', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Pirates of the Caribbean: The Curse of the Black Pearl', 90000, 120, 'pirates_caribbean.jpg', 'A pirate and a blacksmith search for a cursed treasure', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Avengers: Endgame', 130000, 120, 'avengers_endgame.jpg', 'The Avengers assemble to defeat Thanos and restore the universe', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Star Wars: A New Hope', 85000, 120, 'star_wars_new_hope.jpg', 'A young farm boy joins the Rebellion to fight the evil Empire', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Toy Story', 75000, 120, 'toy_story.jpg', 'A story of toys that come to life when humans arent looking', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Finding Nemo', 80000, 120, 'finding_nemo.jpg', 'A clownfish searches for his lost son across the ocean', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
 
-- Phim với đánh giá độ tuổi cho mọi lứa tuổi
('Toy Story 3', 80000, 120, 'toy_story_3.jpg', 'Toys band together on an adventure', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Finding Dory', 85000, 120, 'finding_dory.jpg', 'A fish searches for her family', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phim với đánh giá PG
('Jumanji: Welcome to the Jungle', 90000, 120, 'jumanji.jpg', 'Teens find themselves trapped in a game', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG_US'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Spider-Man: Into the Spider-Verse', 95000, 120, 'spiderverse.jpg', 'A young hero learns to harness his powers', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG_US'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phim với đánh giá PG-13
('Jurassic World', 100000, 120, 'jurassic_world.jpg', 'Dinosaurs roam the theme park once again', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Hunger Games', 95000, 120, 'hunger_games.jpg', 'A girl fights for survival in a brutal tournament', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phim với đánh giá R
('The Matrix Reloaded', 105000, 120, 'matrix_reloaded.jpg', 'The fight against the machines continues', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Mad Max: Fury Road', 110000, 120, 'mad_max.jpg', 'In a post-apocalyptic world, a drifter and a woman rebel against a tyrant', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Phim với đánh giá NC-17
('Blue is the Warmest Color', 95000, 120, 'blue_warmest_color.jpg', 'A young woman discovers her first love', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'NC-17'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Showgirls', 90000, 120, 'showgirls.jpg', 'A girl navigates the entertainment industry in Las Vegas', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'NC-17'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm 10 bộ phim mới

('La La Land', 90000, 120, 'la_la_land.jpg', 'A jazz musician and an actress fall in love in Los Angeles', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Grand Budapest Hotel', 95000, 120, 'grand_budapest.jpg', 'The adventures of a legendary concierge at a famous hotel', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Coco', 80000, 120, 'coco.jpg', 'A young boy travels to the Land of the Dead to discover his familys secrets', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Django Unchained', 100000, 120, 'django_unchained.jpg', 'A freed slave sets out to rescue his wife from a brutal plantation owner', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Zootopia', 85000, 120, 'zootopia.jpg', 'A bunny cop and a sly fox work together to solve a mystery', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Guardians of the Galaxy', 95000, 120, 'guardians_of_galaxy.jpg', 'A group of intergalactic criminals must pull together to stop a fanatical warrior', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Logan', 110000, 120, 'logan.jpg', 'In the near future, a weary Logan cares for an ailing Professor X', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Inside Out', 80000, 120, 'inside_out.jpg', 'Young girls emotions come to life and guide her through change', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Avengers', 100000, 120, 'avengers.jpg', 'Earths mightiest heroes must come together to stop an alien invasion', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Frozen', 85000, 120, 'frozen.jpg', 'Two sisters, Anna and Elsa, go on an adventure to save their kingdom', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
-- Thêm 10 bộ phim khác

('Black Panther', 100000, 120, 'black_panther.jpg', 'T Challa returns home to take his place as king of Wakanda but faces challenges', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Moonlight', 95000, 120, 'moonlight.jpg', 'A young African-American man grapples with his identity and sexuality', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Moana', 85000, 120, 'moana.jpg', 'A young girl sets sail to save her island with the help of a demigod', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Social Network', 95000, 120, 'social_network.jpg', 'The story of Facebooks creation and the resulting lawsuits', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Incredibles', 80000, 120, 'the_incredibles.jpg', 'A family of undercover superheroes must save the world', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Whiplash', 90000, 120, 'whiplash.jpg', 'A young drummer enrolls in a cutthroat music conservatory', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Her', 95000, 120, 'her.jpg', 'A lonely writer develops an unlikely relationship with an operating system', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Frozen II', 85000, 120, 'frozen_ii.jpg', 'Elsa and Anna embark on a journey to uncover the origin of Elsas powers', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Blade Runner 2049', 100000, 120, 'blade_runner.jpg', 'A young blade runner discovers a long-buried secret', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Wonder Woman', 110000, 120, 'wonder_woman.jpg', 'Diana, an Amazonian warrior, comes to the world of men to stop a war', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm 20 bộ phim mới
('Parasite', 95000, 132, 'parasite.jpg', 'A poor family schemes to become employed by a wealthy family', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Bohemian Rhapsody', 90000, 134, 'bohemian_rhapsody.jpg', 'The story of the legendary rock band Queen', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Lion King (2019)', 85000, 118, 'lion_king_2019.jpg', 'A young lion cub learns about responsibility and bravery', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('A Star is Born', 90000, 136, 'star_is_born.jpg', 'A musician helps a young singer find fame', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Spider-Man: Far From Home', 95000, 129, 'spiderman_far_from_home.jpg', 'Peter Parker goes on a school trip to Europe, but trouble follows him', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Shazam!', 85000, 132, 'shazam.jpg', 'A young boy can transform into an adult superhero', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Aladdin (2019)', 80000, 128, 'aladdin_2019.jpg', 'A young man discovers a magical lamp that grants him three wishes', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Toy Story 4', 85000, 100, 'toy_story_4.jpg', 'The toys embark on a road trip adventure', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'G'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Joker', 90000, 122, 'joker.jpg', 'The origin story of the infamous Batman villain', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Knives Out', 90000, 130, 'knives_out.jpg', 'A detective investigates the death of a wealthy patriarch', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('1917', 95000, 119, '1917.jpg', 'Two British soldiers are given a mission to deliver a message during World War I', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Once Upon a Time in Hollywood', 90000, 161, 'once_upon_hollywood.jpg', 'A faded TV actor and his stunt double strive for fame in 1969 Los Angeles', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('The Irishman', 100000, 209, 'the_irishman.jpg', 'A mob hitman recalls his involvement with the Bufalino crime family', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Ford v Ferrari', 85000, 152, 'ford_v_ferrari.jpg', 'The story of the rivalry between Ford and Ferrari at the 24 Hours of Le Mans', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Star Wars: The Rise of Skywalker', 95000, 142, 'star_wars_rise_skywalker.jpg', 'The Resistance faces the First Order once more in the final chapter of the saga', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Jojo Rabbit', 85000, 108, 'jojo_rabbit.jpg', 'A young boy in Nazi Germany discovers that his mother is hiding a Jewish girl in their home', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG-13'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Little Women', 90000, 135, 'little_women.jpg', 'The lives of the March sisters as they navigate through the ups and downs of life', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'PG'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Doctor Sleep', 95000, 152, 'doctor_sleep.jpg', 'A sequel to The Shining where an adult Danny Torrance must protect a girl with similar powers', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Marriage Story', 90000, 137, 'marriage_story.jpg', 'A stage director and his actor wife struggle through a grueling divorce', (SELECT AR_AutoID FROM tbl_DM_AgeRating WHERE AR_NAME = 'R'), 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

go
INSERT INTO tbl_DM_Theater 
    (TT_NAME, TT_STATUS, TT_ROWS, TT_COLS, TT_COUPLES, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
    (N'Phòng 1', 1, 10, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 2', 1, 12, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 3', 1, 10, 20, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 4', 1, 10, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 5', 1, 12, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 6', 1, 10, 20, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 7', 1, 10, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 8', 1, 12, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 9', 1, 10, 20, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 10', 1, 10, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 11', 1, 12, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 12', 1, 10, 20, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 13', 1, 10, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 14', 1, 12, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'Phòng 15', 1, 10, 20, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'phòng chiếu IMAX', 1, 10, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert'),
    (N'phòng chiếu 4DX', 1, 12, 15, 2, 0, GETDATE(), 'Admin', 'insert', GETDATE(), 'Admin', 'insert');

go
INSERT INTO tbl_DM_MovieSchedule (MS_MOVIE_AutoID, MS_THEATER_AutoID, MS_START, MS_END, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
    (1, 1, '2024-11-08 10:00:00', '2024-11-08 12:00:00' , 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Inception tại Theater 1
    (2, 2, '2024-11-08 13:00:00', '2024-11-08 15:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- The Matrix tại Theater 2
    (3, 1, '2024-11-08 16:00:00', '2024-11-08 18:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Interstellar tại Theater 1
    (4, 3, '2024-11-09 10:00:00', '2024-11-09 12:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Avatar tại Theater 3
    (5, 2, '2024-11-09 13:00:00', '2024-11-09 15:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Titanic tại Theater 2
    (6, 1, '2024-11-09 16:00:00', '2024-11-09 18:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Joker tại Theater 1
    (7, 3, '2024-11-10 10:00:00', '2024-11-10 12:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- The Godfather tại Theater 3
    (8, 2, '2024-11-10 13:00:00', '2024-11-10 15:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Star Wars tại Theater 2
    (9, 1, '2024-11-10 16:00:00', '2024-11-10 18:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Gladiator tại Theater 1
    (10, 3, '2024-11-11 10:00:00', '2024-11-11 12:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Lord of the Rings tại Theater 3
    (11, 2, '2024-11-11 13:00:00', '2024-11-11 15:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Schindler's List tại Theater 2
    (12, 1, '2024-11-11 16:00:00', '2024-11-11 18:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- The Dark Knight tại Theater 1
    (13, 3, '2024-11-12 10:00:00', '2024-11-12 12:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Forrest Gump tại Theater 3
    (14, 2, '2024-11-12 13:00:00', '2024-11-12 15:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- The Avengers tại Theater 2
    (15, 1, '2024-11-12 16:00:00', '2024-11-12 18:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Black Panther tại Theater 1
    (16, 3, '2024-11-13 10:00:00', '2024-11-13 12:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Frozen tại Theater 3
    (17, 2, '2024-11-13 13:00:00', '2024-11-13 15:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Finding Nemo tại Theater 2
    (18, 1, '2024-11-13 16:00:00', '2024-11-13 18:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Shrek tại Theater 1
    (19, 3, '2024-11-14 10:00:00', '2024-11-14 12:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Toy Story tại Theater 3
    (20, 2, '2024-11-14 13:00:00', '2024-11-14 15:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');  -- Monsters, Inc. tại Theater 2

-- Thêm dữ liệu vào bảng tbl_DM_Staff (nhân viên)
go
INSERT INTO [dbo].[tbl_DM_Staff] ([ST_USERNAME], [ST_PASSWORD], [ST_NAME], [ST_PHONE], [ST_CIC], [ST_NOTE], [ST_LEVEL], [DELETED], [CREATED], [CREATED_BY], [CREATED_BY_FUNCTION], [UPDATED], [UPDATED_BY], [UPDATED_BY_FUNCTION])
VALUES 
-- Nhân viên quản lý và nhân viên bán vé
('admin', 'c4ca4238a0b923820dcc509a6f75849b', N'Admin User', '0123456789', '123456789012', N'Admin account', -5, 0, GETDATE(), 'admin', 'System', GETDATE(), 'admin', 'System'),
('staff1', 'c4ca4238a0b923820dcc509a6f75849b', N'Sok Kim Thanh', '0123456789', '123456789012', N'Nhân viên bán vé', -5, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff2', 'c4ca4238a0b923820dcc509a6f75849b', N'Lê Duy Anh Tú', '0987654321', '987654321012', N'Nhân viên bán vé', -5, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff3', 'c4ca4238a0b923820dcc509a6f75849b', N'Trần Minh Tuấn', '0987654321', '987654321012', N'Nhân viên bán vé', -5, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Nhân viên khác
('staff4', 'c4ca4238a0b923820dcc509a6f75849b', N'Nguyễn Văn Bình', '0912345678', '456789123456', N'Nhân viên quầy thực phẩm', -3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff5', 'c4ca4238a0b923820dcc509a6f75849b', N'Phạm Thị Hồng', '0938765432', '654321789654', N'Nhân viên vệ sinh', -2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff6', 'c4ca4238a0b923820dcc509a6f75849b', N'Đặng Hoài Nam', '0972348765', '789456123789', N'Nhân viên bảo trì', -4, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff7', 'c4ca4238a0b923820dcc509a6f75849b', N'Lý Bảo Trân', '0909876543', '321654987321', N'Nhân viên pha chế', -3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff8', 'c4ca4238a0b923820dcc509a6f75849b', N'Trương Văn Hiếu', '0934567890', '567123456789', N'Nhân viên bảo vệ', -4, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff9', 'c4ca4238a0b923820dcc509a6f75849b', N'Hoàng Minh Anh', '0923456789', '789321654123', N'Nhân viên điều phối', -3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm nhân viên mới với các vai trò khác nhau
('staff10', 'c4ca4238a0b923820dcc509a6f75849b', N'Nguyễn Thị Lan', '0934554321', '111223334455', N'Nhân viên quầy thực phẩm', -3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff11', 'c4ca4238a0b923820dcc509a6f75849b', N'Vũ Văn Thành', '0974556768', '234556789012', N'Nhân viên quản lý lịch chiếu', -1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff12', 'c4ca4238a0b923820dcc509a6f75849b', N'Trần Thanh Huyền', '0912345678', '998877665544', N'Nhân viên điều phối khách hàng', -2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff13', 'c4ca4238a0b923820dcc509a6f75849b', N'Lê Quốc Bảo', '0945567889', '223344556677', N'Nhân viên vệ sinh', -2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff14', 'c4ca4238a0b923820dcc509a6f75849b', N'Nguyễn Hải Đăng', '0964433221', '334455667788', N'Nhân viên quầy vé', -5, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff15', 'c4ca4238a0b923820dcc509a6f75849b', N'Phạm Văn Hùng', '0903232456', '445566778899', N'Nhân viên bảo trì thiết bị', -4, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff16', 'c4ca4238a0b923820dcc509a6f75849b', N'Trương Nhật Minh', '0986754321', '556677889900', N'Nhân viên pha chế', -3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff17', 'c4ca4238a0b923820dcc509a6f75849b', N'Lê Thu Trang', '0932445566', '667788990011', N'Nhân viên bán hàng lưu niệm', -3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff18', 'c4ca4238a0b923820dcc509a6f75849b', N'Hoàng Bảo Linh', '0971234567', '778899001122', N'Nhân viên quầy thực phẩm', -3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('staff19', 'c4ca4238a0b923820dcc509a6f75849b', N'Phan Quang Huy', '0923344556', '889900112233', N'Nhân viên quản lý kho hàng', -1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

go
-- Thêm dữ liệu vào bảng tbl_DM_Shift
INSERT INTO tbl_DM_Shift (SF_NAME, SF_START, SF_END, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
('Shift 1', '08:00:00', '16:00:00', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Shift 2', '16:00:00', '23:59:59', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

go
-- Thêm dữ liệu vào bảng tbl_DM_StaffSchedule
INSERT INTO tbl_DM_StaffSchedule (SS_STAFF_AutoID, SS_SHIFT_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
(1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

go
-- Thêm dữ liệu vào bảng tbl_Sys_Language
INSERT INTO tbl_Sys_Language (Eng_Lang, VN_Lang, JP_Lang, KR_Lang, CN_Lang, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
(N'Hello', N'Xin chào', N'こんにちは', N'안녕하세요', N'你好', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Goodbye', N'Tạm biệt', N'さようなら', N'안녕히 가세요', N'再见', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

go
-- Thêm dữ liệu vào bảng tbl_DM_Product
INSERT INTO tbl_DM_Product (PD_NAME, PD_QUANTITY, PD_PRICE, PD_IMAGEURL, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES 
(N'Bắp', 100, 50.0, 'url_to_popcorn_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Coca-Cola', 200, 20.0, 'url_to_coke_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Fanta', 200, 20.0, 'url_to_fanta_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Sprite', 200, 20.0, 'url_to_sprite_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
-- Thêm một số loại snack
('Potato Chips', 150, 25.0, 'url_to_chips_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Chocolate Bar', 100, 30.0, 'url_to_chocolate_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Candy', 180, 15.0, 'url_to_candy_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm các loại nước ép và đồ uống khác
('Orange Juice', 120, 25.0, 'url_to_orange_juice_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Apple Juice', 100, 30.0, 'url_to_apple_juice_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Mineral Water', 250, 15.0, 'url_to_water_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm một số sản phẩm đồ uống khác
('Lemon Tea', 150, 25.0, 'url_to_lemon_tea_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Green Tea', 130, 28.0, 'url_to_green_tea_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Milk Tea', 140, 35.0, 'url_to_milk_tea_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Espresso', 100, 40.0, 'url_to_espresso_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Latte', 90, 45.0, 'url_to_latte_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm một số loại snack khác
('Nachos', 100, 30.0, 'url_to_nachos_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Pretzels', 80, 25.0, 'url_to_pretzels_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('French Fries', 120, 20.0, 'url_to_french_fries_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Chicken Nuggets', 100, 35.0, 'url_to_chicken_nuggets_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Mini Pizza', 70, 50.0, 'url_to_mini_pizza_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Thêm một số loại nước ép trái cây
('Grape Juice', 100, 30.0, 'url_to_grape_juice_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Pineapple Juice', 110, 30.0, 'url_to_pineapple_juice_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Mango Juice', 90, 35.0, 'url_to_mango_juice_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Strawberry Smoothie', 80, 40.0, 'url_to_strawberry_smoothie_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
('Banana Smoothie', 85, 40.0, 'url_to_banana_smoothie_image', 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');
 
-- Thêm dữ liệu vào bảng tbl_DM_Ticket (vé)
-- TK_STATUS giả định là trạng thái vé (ví dụ: 1 là vé đã bán).
-- DELETED là cột đánh dấu xóa (0 là chưa xóa).
go
INSERT INTO tbl_DM_Ticket 
    (TK_SEATNAME, TK_MOVIESCHEDULE_AutoID, TK_STAFF_AutoID, TK_STATUS, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
    ('A1', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Vé cho phim Inception
    ('A2', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Vé cho phim Inception
    ('B1', 2, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Vé cho phim The Matrix
    ('C1', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Vé cho phim Interstellar
    ('A3', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('A4', 2, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('B2', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('B3', 2, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('B4', 3, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('C2', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('C3', 2, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('C4', 3, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('D1', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('D2', 2, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('D3', 3, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('D4', 4, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('E1', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('E2', 2, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('E3', 3, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('E4', 4, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('A5', 1, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('B5', 2, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('C5', 3, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
    ('D5', 4, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');
go
-- Thêm dữ liệu vào bảng tbl_DM_Bill khớp với các vé trong tbl_DM_Ticket
INSERT INTO tbl_DM_Bill (BL_TICKET_AutoID, BL_STAFF_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
    (1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'A1'
    (2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'A2'
    (3, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'B1'
    (4, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'C1'
    (5, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'A3'
    (6, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'A4'
    (7, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'B2'
    (8, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'B3'
    (9, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Khớp với vé 'B4'
    (10, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'C2'
    (11, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'C3'
    (12, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'C4'
    (13, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'D1'
    (14, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'D2'
    (15, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'D3'
    (16, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'D4'
    (17, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'E1'
    (18, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'E2'
    (19, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'E3'
    (20, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'E4'
    (21, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'A5'
    (22, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'B5'
    (23, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'), -- Khớp với vé 'C5'
    (24, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');  -- Khớp với vé 'D5'

go
-- Thêm dữ liệu vào bảng tbl_DM_BillDetail khớp với các hóa đơn trong tbl_DM_Bill
INSERT INTO tbl_DM_BillDetail (BD_BILL_AutoID, BD_PRODUCT_AutoID, BD_QUANTITY, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
    (1, 1, 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 1
    (2, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 2
    (3, 2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 3
    (4, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 4
    (5, 3, 3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 5
    (6, 2, 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 6
    (7, 3, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 7
    (8, 1, 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 8
    (9, 2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),   -- Chi tiết cho Bill 9
    (10, 3, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 10
    (11, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 11
    (12, 2, 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 12
    (13, 1, 3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 13
    (14, 3, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 14
    (15, 2, 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 15
    (16, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 16
    (17, 2, 3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 17
    (18, 3, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 18
    (19, 1, 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 19
    (20, 2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 20
    (21, 3, 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 21
    (22, 1, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 22
    (23, 2, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),  -- Chi tiết cho Bill 23
    (24, 3, 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');  -- Chi tiết cho Bill 24


go
-- Thêm loại chi phí cho từng sản phẩm
INSERT INTO tbl_DM_ExpenseType (ET_NAME, ET_PRODUCT_AutoID, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION) 
VALUES 
(N'Nhập: Bắp', 1, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Coca-Cola', 2, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Fanta', 3, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Sprite', 4, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Potato Chips', 5, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Chocolate Bar', 6, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Candy', 7, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Orange Juice', 8, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Apple Juice', 9, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Mineral Water', 10, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Lemon Tea', 11, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Green Tea', 12, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Milk Tea', 13, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Espresso', 14, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Latte', 15, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Nachos', 16, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Pretzels', 17, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: French Fries', 18, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Chicken Nuggets', 19, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Mini Pizza', 20, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Grape Juice', 21, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Pineapple Juice', 22, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Mango Juice', 23, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Strawberry Smoothie', 24, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Banana Smoothie', 25, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Các loại chi phí hàng tháng
(N'Nhập: Đá viên', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),
(N'Nhập: Ly nhựa tái chế', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System'),

-- Chi phí khác không cụ thể
(N'Chi phí khác', NULL, 0, CURRENT_TIMESTAMP, 'Admin', 'System', CURRENT_TIMESTAMP, 'Admin', 'System');

go
-- Thêm 10 khoản chi phí vào bảng tbl_SYS_Expense
-- Thêm chi phí mặt bằng
INSERT INTO tbl_SYS_Expense (EX_EXTYPE_AutoID, EX_QUANTITY, EX_PRICE, EX_REASON, EX_STATUS, DELETED, CREATED, CREATED_BY, CREATED_BY_FUNCTION, UPDATED, UPDATED_BY, UPDATED_BY_FUNCTION)
VALUES
-- Nhập hàng vào kho trong các ngày cụ thể cho các sản phẩm khác nhau 
(1, 50, 2500000.0, N'Nhập bắp', 1, 0, '2024-08-01', 'Admin', 'System', '2024-08-01', 'Admin', 'System'),
(2, 40, 2000000.0, N'Nhập Coca-Cola', 1, 0, '2024-08-10', 'Admin', 'System', '2024-08-10', 'Admin', 'System'),
(3, 30, 1500000.0, N'Nhập Sprite', 1, 0, '2024-08-15', 'Admin', 'System', '2024-08-15', 'Admin', 'System'),
(4, 20, 1000000.0, N'Nhập Fanta', 1, 0, '2024-08-20', 'Admin', 'System', '2024-08-20', 'Admin', 'System'),
(1, 60, 3000000.0, N'Nhập bắp', 1, 0, '2024-09-01', 'Admin', 'System', '2024-09-01', 'Admin', 'System'),
(2, 55, 2750000.0, N'Nhập Coca-Cola', 1, 0, '2024-09-10', 'Admin', 'System', '2024-09-10', 'Admin', 'System'),
(3, 45, 2250000.0, N'Nhập Sprite', 1, 0, '2024-09-15', 'Admin', 'System', '2024-09-15', 'Admin', 'System'),
(4, 35, 1750000.0, N'Nhập Fanta', 1, 0, '2024-09-20', 'Admin', 'System', '2024-09-20', 'Admin', 'System'),
(1, 75, 3750000.0, N'Nhập bắp', 1, 0, '2024-10-01', 'Admin', 'System', '2024-10-01', 'Admin', 'System'),
(2, 65, 3250000.0, N'Nhập Coca-Cola', 1, 0, '2024-10-10', 'Admin', 'System', '2024-10-10', 'Admin', 'System'),
(3, 50, 2500000.0, N'Nhập Sprite', 1, 0, '2024-10-15', 'Admin', 'System', '2024-10-15', 'Admin', 'System'),
(4, 45, 2250000.0, N'Nhập Fanta', 1, 0, '2024-10-20', 'Admin', 'System', '2024-10-20', 'Admin', 'System'),
(1, 80, 4000000.0, N'Nhập bắp', 1, 0, '2024-11-01', 'Admin', 'System', '2024-11-01', 'Admin', 'System'),
(2, 70, 3500000.0, N'Nhập Coca-Cola', 1, 0, '2024-11-05', 'Admin', 'System', '2024-11-05', 'Admin', 'System'),
(3, 55, 2750000.0, N'Nhập Sprite', 1, 0, '2024-11-10', 'Admin', 'System', '2024-11-10', 'Admin', 'System'),
(4, 40, 2000000.0, N'Nhập Fanta', 1, 0, '2024-11-15', 'Admin', 'System', '2024-11-15', 'Admin', 'System'),

-- Nhập kho cho sản phẩm bắp nhưng với số lượng nhỏ để phản ánh tình trạng cạn kiệt do cháy hàng
(1, 10, 250000.0, N'Nhập bắp số lượng nhỏ', 1, 0, '2024-08-25', 'Admin', 'System', '2024-08-25', 'Admin', 'System'),
(1, 5, 125000.0, N'Nhập bắp số lượng rất nhỏ', 1, 0, '2024-09-18', 'Admin', 'System', '2024-09-18', 'Admin', 'System'),
(1, 8, 200000.0, N'Nhập bắp số lượng nhỏ lẻ', 1, 0, '2024-10-01', 'Admin', 'System', '2024-10-01', 'Admin', 'System'),
 

-- Nhập hàng cho sản phẩm "Bắp" để đạt trạng thái có sẵn hoặc quá tải
 
(1, 15, 100000.0, N'Nhập bắp', 1, 0, '2024-09-01', 'Admin', 'System', '2024-09-01', 'Admin', 'System'),
(1, 12, 100000.0, N'Nhập bắp', 1, 0, '2024-09-07', 'Admin', 'System', '2024-09-07', 'Admin', 'System'),
(1, 18, 100000.0, N'Nhập bắp', 1, 0, '2024-09-14', 'Admin', 'System', '2024-09-14', 'Admin', 'System'),
(1, 9, 100000.0, N'Nhập bắp', 1, 0, '2024-09-20', 'Admin', 'System', '2024-09-20', 'Admin', 'System'),
(1, 5, 100000.0, N'Nhập bắp', 1, 0, '2024-09-25', 'Admin', 'System', '2024-09-25', 'Admin', 'System'),

-- Nhập hàng cho sản phẩm "Coca-Cola" để duy trì trạng thái tồn kho
(2, 15, 100000.0, N'Nhập Coca-Cola', 1, 0, '2024-09-02', 'Admin', 'System', '2024-09-02', 'Admin', 'System'),
(2, 12, 100000.0, N'Nhập Coca-Cola', 1, 0, '2024-09-08', 'Admin', 'System', '2024-09-08', 'Admin', 'System'),
(2, 10, 100000.0, N'Nhập Coca-Cola', 1, 0, '2024-09-15', 'Admin', 'System', '2024-09-15', 'Admin', 'System'),
(2, 9, 100000.0, N'Nhập Coca-Cola', 1, 0, '2024-09-22', 'Admin', 'System', '2024-09-22', 'Admin', 'System'),
(2, 7, 100000.0, N'Nhập Coca-Cola', 1, 0, '2024-09-28', 'Admin', 'System', '2024-09-28', 'Admin', 'System'),

-- Nhập hàng cho sản phẩm "Sprite" để đạt trạng thái khuyến mãi bán chậm
(3, 8, 100000.0, N'Nhập Sprite', 1, 0, '2024-09-03', 'Admin', 'System', '2024-09-03', 'Admin', 'System'),
(3, 6, 100000.0, N'Nhập Sprite', 1, 0, '2024-09-09', 'Admin', 'System', '2024-09-09', 'Admin', 'System'),
(3, 10, 100000.0, N'Nhập Sprite', 1, 0, '2024-09-16', 'Admin', 'System', '2024-09-16', 'Admin', 'System'),
(3, 5, 100000.0, N'Nhập Sprite', 1, 0, '2024-09-23', 'Admin', 'System', '2024-09-23', 'Admin', 'System'),
(3, 7, 100000.0, N'Nhập Sprite', 1, 0, '2024-09-29', 'Admin', 'System', '2024-09-29', 'Admin', 'System');
