SELECT *
FROM INFORMATION_SCHEMA.TABLES

select *
from Products

select *
from OrderDetails

select *
from Orders

select *
from Categories

select *
from AspNetUsers

-- categories
insert into categories values('Nam','Dành cho nam')
insert into categories values('Nu','Dành cho nữ')
insert into categories values('Unisex','Dành cho nam lẫn nữ')

-- product
insert into Products values('Parfums De Marly', 
'Sedley Parfums de Marly được ra mắt năm 2019 bởi Olivier Cresp để mang đến mùi hương tươi sáng có sức hấp dẫn đầy tính unisex mà bất kỳ ai cũng có thể khoác lên làn da của mình. Thiết kế của Sedley được mô phỏng theo thành phần của nó, tinh tế, nhưng không kém phần mạnh mẽ và tươi mát. Nguyên liệu được lựa chọn tỉ mỉ với chất lượng vượt trội, mang đậm phong cách Hoàng Gia mà vẫn đượm tinh thần hiện đại.',
5841000,10, 'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1639981170.7112.png',5500000, 1)

insert into Products values('Lacoste Match Point','Lacoste Match Point For Men EDP - siêu phẩm mới đến từ Lacoste đã chính thức gia nhập đại gia đình Thế Giới Nước Hoa. Khám phá ngay hương gỗ mạnh mẽ tương phản với sự bùng nổ của vị tươi đắng mang dến cảm giác hồi hộp như thể mọi giấc mơ của quý ông đang trở thành hiện thực. Hương đầu với năng lượng chua và cay của trái cây họ cam quýt kết hợp cùng hạt tiêu hồng hoàn toàn tương phản với hương giữa mang chút vị đắng đầy gây nghiện của cây khổ sâm và trở nên bùng nổ với hương cuối đầy sự thoải mái của hoắc hương được nhấn mạnh bởi các nốt hương gỗ, từ đó mở ra cơn địa chấn tràn đầy năng lượng & sức mạnh, sự hoà quyện các tầng hương được đẩy lên cực độ mang đến một loại nước hoa hứa hẹn sẽ trở thành dấu ấn đặc biệt của mọi quý ông. ',
2700000, 5,'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1640183171.4715.png', 2160000, 1)

insert into Products values('Parfums De Marly Sedley', 'Sedley Parfums de Marly được ra mắt năm 2019 bởi Olivier Cresp để mang đến mùi hương tươi sáng có sức hấp dẫn đầy tính unisex mà bất kỳ ai cũng có thể khoác lên làn da của mình. Thiết kế của Sedley được mô phỏng theo thành phần của nó, tinh tế, nhưng không kém phần mạnh mẽ và tươi mát. Nguyên liệu được lựa chọn tỉ mỉ với chất lượng vượt trội, mang đậm phong cách Hoàng Gia mà vẫn đượm tinh thần hiện đại.',
5841000,5, 'https://www.thegioinuochoa.com.vn/uploads/products/2020/12/image/1607509287.5897.png', 6500000, 1)

insert into products values('Jean Paul Gaultier', 'Lần đầu tiên dòng nước Hoa Scandal với biểu tượng đôi chân thon dài đã xuất hiện phiên bản dành cho phái mạnh. Jean Paul Gaultier Scandal Pour Homme EDT đã gây sốt địa phận mùi hương với hình ảnh chàng trai sở hữu cơ bắp đầy mạnh mẽ, quyến rũ nhưng không kém phần thanh lịch bên cạnh đôi găng tay đấm bốc mang sắc đỏ nổi bật.',
2550000, 5, 'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1638983212.5729.png', 3000000, 1)

insert into Products values('Versace Pour Femme Dylan Turquoise EDT', 
'Versace Pour Femme Dylan Turquoise là một hương thơm mới cho nữ giới được thương hiệu Versace cho ra mắt năm 2020. Mùi hương là sự kết hợp giữa truyền thống và hiện đại, tạo cho ta cảm giác như được chạy trốn đến những hòn đảo xa xôi với trời xanh và làn nước trong vắt lấp lánh. Nó cũng được lấy cảm hứng từ làn gió biển nhẹ nhàng mơn trớn trên da và đánh thức các giác quan, tái tạo tâm hồn. Đó là một hương thơm gợi nhớ đến nắng ấm và những ngày hè sôi động.',
2790000, 7, 'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1639976154.8785.png',
2232000, 2)

insert into products values('Carolina Herrera Good Girl Superstars EDP',
'Nắm bắt sự táo bạo của quý cô rock chick, Good Girl Superstars EDP ra đời như một lời tôn vinh ngôi sao tự tin bên trong bạn. Phiên bản mùi hương Good Girl đầy huyền thoại và chói lọi của nhà Carolina Herrera hứa hẹn sẽ đã đánh cắp trái tim của mọi quý cô nhờ vào sắc bạc lấp lánh của "giày gót nhọn" mang tính biểu tượng.',
3650000,2, 'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1638981818.6462.png',
3102000, 2)

insert into products values('Coach Dreams Sunset EDP',
'Nước hoa nữ Coach Dreams Sunset EDP - dòng nước hoa mới nhất của thương hiệu Coach đã mô tả về những cô gái trẻ tự do khám phá, trải nghiệm những điều mới lạ, khác biệt xung quanh mình. Dreams Sunset mang hương thơm nhẹ nhàng, trẻ trung, phóng khoáng.',
2800000, 5,'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1638960399.6963.png',
2380000, 2)

insert into products values ('Oceani Di Seta EDP',
'OCEANI DI SETA là hương thơm mới ra mắt trong năm 2021 của thương hiệu đình đám Salvatore Ferragamo. Thuộc bộ sưu tập Storie di Seta - bộ sưu tập mang đến trải nghiệm đầy sức gợi hình, sáng tạo và đa khía cạnh, thu hút mọi giác quan trong khi những hương thơm đưa chúng ta đến những cảnh quan độc đáo và cảm giác lôi cuốn được lấy cảm hứng từ những sáng tạo từ lụa mang tính biểu tượng của Salvatore Ferragamo.',
2890000, 20, 'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1639984696.8648.png',
2312000, 3)

insert into Products values ('Savane Di Seta EDP',
'SAVANE DI SETA là hương thơm mới ra mắt trong năm 2021 của thương hiệu đình đám Salvatore Ferragamo. Thuộc bộ sưu tập Storie di Seta - bộ sưu tập mang đến trải nghiệm đầy sức gợi hình, sáng tạo và đa khía cạnh, thu hút mọi giác quan trong khi những hương thơm đưa chúng ta đến những cảnh quan độc đáo và cảm giác lôi cuốn được lấy cảm hứng từ những sáng tạo từ lụa mang tính biểu tượng của Salvatore Ferragamo.',
2890000, 20, 'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1639984313.5504.png',
2312000, 3)

insert into products values ('Giungle Di Seta EDP',
'GIUNGLE DI SETA là hương thơm mới ra mắt trong năm 2021 của thương hiệu đình đám Salvatore Ferragamo. Thuộc bộ sưu tập Storie di Seta - bộ sưu tập mang đến trải nghiệm đầy sức gợi hình, sáng tạo và đa khía cạnh, thu hút mọi giác quan trong khi những hương thơm đưa chúng ta đến những cảnh quan độc đáo và cảm giác lôi cuốn được lấy cảm hứng từ những sáng tạo từ lụa mang tính biểu tượng của Salvatore Ferragamo.',
2890000, 20, 'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1639983957.9041.png',
2312000, 3)

insert into Products values ('Giardini Di Seta EDP',
'GIARDINI DI SETA là hương thơm mới ra mắt trong năm 2021 của thương hiệu đình đám Salvatore Ferragamo. Thuộc bộ sưu tập Storie di Seta - bộ sưu tập mang đến trải nghiệm đầy sức gợi hình, sáng tạo và đa khía cạnh, thu hút mọi giác quan trong khi những hương thơm đưa chúng ta đến những cảnh quan độc đáo và cảm giác lôi cuốn được lấy cảm hứng từ những sáng tạo từ lụa mang tính biểu tượng của Salvatore Ferragamo.',
2890000,20, 'https://www.thegioinuochoa.com.vn/uploads/products/2021/12/image/1639983176.7157.png',
2312000, 3)
