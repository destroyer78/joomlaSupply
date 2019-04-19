CREATE TABLE `suppliers` (
  `id` int(11) NOT NULL COMMENT 'Ключ',
  `name` varchar(100) NOT NULL COMMENT 'Наименование',
  `ogrn` varchar(13) NOT NULL COMMENT 'ОГРН',
  `inn` varchar(13) NOT NULL COMMENT 'ИНН',
  `tel` varchar(30) NOT NULL COMMENT 'Телефон',
  `email` varchar(70) NOT NULL DEFAULT 'Нет данных' COMMENT 'E-mail'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------
CREATE TABLE `supply` (
  `id` int(11) NOT NULL,
  `supplier` int(11) NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------
CREATE TABLE `supply_elements` (
  `id` int(11) NOT NULL,
  `supply` int(11) NOT NULL,
  `product` int(11) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Элементы поставки';

ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `supply`
  ADD PRIMARY KEY (`id`),
  ADD KEY `supplier` (`supplier`);

ALTER TABLE `supply_elements`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product` (`product`),
  ADD KEY `supply` (`supply`);
 
ALTER TABLE `suppliers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Ключ';

ALTER TABLE `supply`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `supply_elements`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `supply`
  ADD CONSTRAINT `supply_ibfk_1` FOREIGN KEY (`supplier`) REFERENCES `suppliers` (`id`);

ALTER TABLE `supply_elements`
  ADD CONSTRAINT `supply_elements_ibfk_2` FOREIGN KEY (`product`) REFERENCES `ishp_jshopping_products` (`product_id`),
  ADD CONSTRAINT `supply_elements_ibfk_3` FOREIGN KEY (`supply`) REFERENCES `supply` (`id`);
