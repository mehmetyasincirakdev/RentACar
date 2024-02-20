INSERT INTO Brands (BrandName) VALUES
('Mercedes-Benz'),
('BMW'),
('Audi'),
('Volkswagen'),
('Ford'),
('Opel'),
('Renault'),
('Hyundai'),
('Fiat'),
('Toyota');

INSERT INTO Cars (BrandId, ColorId, CarName, ModelYear, DailyPrice, Description) VALUES

-- Mercedes-Benz
(1, 1, 'E 200', 2023, 750.00, 'Lüks sedan, yüksek performans ve konfor'),
(1, 2, 'C 220d', 2022, 600.00, 'Dizel motorlu, ekonomik ve konforlu sedan'),

-- BMW
(2, 3, '3 Serisi', 2021, 650.00, 'Sportif sedan, sürüş keyfi ve prestij'),
(2, 4, 'X3', 2020, 800.00, 'SUV, konforlu ve geniş iç mekan'),

-- Audi
(3, 5, 'A4', 2023, 700.00, 'Premium sedan, teknoloji ve konfor'),
(3, 6, 'Q5', 2022, 850.00, 'SUV, dinamik ve güçlü performans'),

-- Volkswagen
(4, 7, 'Golf', 2021, 450.00, 'Hatchback, ekonomik ve pratik'),
(4, 8, 'Tiguan', 2020, 600.00, 'SUV, geniş aile aracı'),

-- Ford
(5, 9, 'Focus', 2023, 400.00, 'Hatchback, sportif ve dinamik'),
(5, 10, 'Kuga', 2022, 550.00, 'SUV, modern ve fonksiyonel')

INSERT INTO Colors(ColorName) VALUES
('Siyah'),
('Beyaz'),
('Gri'),
('Gümüş'),
('Kırmızı'),
('Mavi'),
('Lacivert'),
('Yeşil'),
('Bej'),
('Kahverengi');

INSERT INTO Rentals (CarId, CustomerId, RentDate, ReturnDate) VALUES
(1, 1, '2023-02-20', NULL),
(2, 2, '2023-02-19', '2023-02-21'),
(3, 3, '2023-02-18', '2023-02-20'),
(4, 4, '2023-02-17', NULL),
(5, 5, '2023-02-16', '2023-02-19'),
(6, 6, '2023-02-15', NULL),
(7, 7, '2023-02-14', '2023-02-18'),
(8, 8, '2023-02-13', NULL),
(9, 9, '2023-02-12', '2023-02-17'),
(10, 10, '2023-02-11', NULL);
