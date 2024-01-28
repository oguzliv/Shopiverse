CREATE TABLE `A`
(
  `id` int NOT NULL,
  `name` varchar
(45) DEFAULT NULL,
  `age` int DEFAULT NULL,
  PRIMARY KEY
(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `B`
(
  `id` int NOT NULL,
  `Name` varchar
(45) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  PRIMARY KEY
(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Basket`
(
  `id` int NOT NULL,
  `OrderId` int DEFAULT NULL,
  `ProductId` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  PRIMARY KEY
(`id`),
  KEY `OrderId_idx`
(`OrderId`),
  KEY `ProductId_idx`
(`ProductId`),
  CONSTRAINT `OrderId` FOREIGN KEY
(`OrderId`) REFERENCES `Orders`
(`id`),
  CONSTRAINT `ProductId` FOREIGN KEY
(`ProductId`) REFERENCES `Products`
(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Orders`
(
  `id` int NOT NULL,
  `CreatedAt` datetime DEFAULT NULL,
  `UserId` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY
(`id`),
  KEY `UserId_idx`
(`UserId`),
  CONSTRAINT `UserId` FOREIGN KEY
(`UserId`) REFERENCES `Users`
(`id`) ON
DELETE CASCADE
) ENGINE=InnoDB
AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Products`
(
  `id` int NOT NULL,
  `Name` varchar
(45) DEFAULT NULL,
  `Price` int DEFAULT NULL,
  `Stock` int DEFAULT NULL,
  PRIMARY KEY
(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Users`
(
  `id` int NOT NULL,
  `FirstName` varchar
(45) DEFAULT NULL,
  `CreatedAt` datetime DEFAULT NULL,
  `LastName` varchar
(45) DEFAULT NULL,
  `Province` varchar
(45) DEFAULT NULL,
  `District` varchar
(45) DEFAULT NULL,
  `Address` varchar
(45) DEFAULT NULL,
  PRIMARY KEY
(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
