-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 20 août 2023 à 13:49
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion de stock metal`
--

-- --------------------------------------------------------

--
-- Structure de la table `table achat mp`
--

CREATE TABLE `table achat mp` (
  `qte_MP` int(11) NOT NULL,
  `prix` double NOT NULL,
  `date_d'achat` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `table client`
--

CREATE TABLE `table client` (
  `cin_client` int(11) NOT NULL,
  `nom_client` varchar(55) NOT NULL,
  `prenom_client` varchar(55) NOT NULL,
  `adresse` varchar(55) NOT NULL,
  `telephone` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `table produit fini`
--

CREATE TABLE `table produit fini` (
  `destingation` varchar(55) NOT NULL,
  `qte` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `table stock mp`
--

CREATE TABLE `table stock mp` (
  `destingation` varchar(55) NOT NULL,
  `qte` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `table stock pf`
--

CREATE TABLE `table stock pf` (
  `destingation` varchar(55) NOT NULL,
  `qte` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `table transformation`
--

CREATE TABLE `table transformation` (
  `MP` varchar(55) NOT NULL,
  `qte MP` varchar(55) NOT NULL,
  `PF` varchar(55) NOT NULL,
  `qte PF` varchar(55) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `table vente pf`
--

CREATE TABLE `table vente pf` (
  `destingation` varchar(55) NOT NULL,
  `qte` varchar(55) NOT NULL,
  `prix` varchar(55) NOT NULL,
  `date_vente` date NOT NULL,
  `client` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `table achat mp`
--
ALTER TABLE `table achat mp`
  ADD PRIMARY KEY (`qte_MP`);

--
-- Index pour la table `table client`
--
ALTER TABLE `table client`
  ADD PRIMARY KEY (`cin_client`);

--
-- Index pour la table `table produit fini`
--
ALTER TABLE `table produit fini`
  ADD PRIMARY KEY (`destingation`);

--
-- Index pour la table `table stock mp`
--
ALTER TABLE `table stock mp`
  ADD PRIMARY KEY (`destingation`);

--
-- Index pour la table `table stock pf`
--
ALTER TABLE `table stock pf`
  ADD PRIMARY KEY (`destingation`);

--
-- Index pour la table `table transformation`
--
ALTER TABLE `table transformation`
  ADD PRIMARY KEY (`MP`);

--
-- Index pour la table `table vente pf`
--
ALTER TABLE `table vente pf`
  ADD PRIMARY KEY (`destingation`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
