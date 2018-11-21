-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 21. Nov 2018 um 17:24
-- Server-Version: 10.1.37-MariaDB
-- PHP-Version: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `carsharingdb`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fahrt`
--

CREATE TABLE `fahrt` (
  `FahrtID` int(11) NOT NULL,
  `AccountID` int(11) NOT NULL,
  `FahrzeugID` int(11) NOT NULL,
  `Preis` double NOT NULL,
  `Strecke` double NOT NULL,
  `Zeit` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fahrzeug`
--

CREATE TABLE `fahrzeug` (
  `FahrzeugID` int(11) NOT NULL,
  `Modell` text COLLATE latin1_german1_ci NOT NULL,
  `Hersteller` text COLLATE latin1_german1_ci NOT NULL,
  `Preis` double NOT NULL,
  `Standort` text COLLATE latin1_german1_ci NOT NULL,
  `Kennzeichen` text COLLATE latin1_german1_ci NOT NULL,
  `Tankgröße` double NOT NULL,
  `Tankstand` double NOT NULL,
  `Verbrauch` double NOT NULL,
  `Kraftstoff` text COLLATE latin1_german1_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `rechte`
--

CREATE TABLE `rechte` (
  `RechteID` int(11) NOT NULL,
  `Name` text COLLATE latin1_german1_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `rechte`
--

INSERT INTO `rechte` (`RechteID`, `Name`) VALUES
(1, 'User');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `user`
--

CREATE TABLE `user` (
  `AccountID` int(11) NOT NULL,
  `RechteID` int(11) NOT NULL,
  `Name` char(100) COLLATE latin1_german1_ci NOT NULL,
  `TelefonNr` int(11) NOT NULL,
  `E-Mail` char(100) COLLATE latin1_german1_ci NOT NULL,
  `Adresse` char(100) COLLATE latin1_german1_ci NOT NULL,
  `Passwort` char(100) COLLATE latin1_german1_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `fahrt`
--
ALTER TABLE `fahrt`
  ADD PRIMARY KEY (`FahrtID`),
  ADD UNIQUE KEY `AccountID` (`AccountID`,`FahrzeugID`),
  ADD KEY `FahrzeugID` (`FahrzeugID`);

--
-- Indizes für die Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  ADD PRIMARY KEY (`FahrzeugID`);

--
-- Indizes für die Tabelle `rechte`
--
ALTER TABLE `rechte`
  ADD PRIMARY KEY (`RechteID`);

--
-- Indizes für die Tabelle `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`AccountID`),
  ADD UNIQUE KEY `RechteID` (`RechteID`),
  ADD UNIQUE KEY `RechteID_2` (`RechteID`),
  ADD UNIQUE KEY `RechteID_3` (`RechteID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `fahrt`
--
ALTER TABLE `fahrt`
  MODIFY `FahrtID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  MODIFY `FahrzeugID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `rechte`
--
ALTER TABLE `rechte`
  MODIFY `RechteID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT für Tabelle `user`
--
ALTER TABLE `user`
  MODIFY `AccountID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `fahrt`
--
ALTER TABLE `fahrt`
  ADD CONSTRAINT `fahrt_ibfk_2` FOREIGN KEY (`AccountID`) REFERENCES `user` (`AccountID`),
  ADD CONSTRAINT `fahrt_ibfk_3` FOREIGN KEY (`FahrzeugID`) REFERENCES `fahrzeug` (`FahrzeugID`);

--
-- Constraints der Tabelle `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_3` FOREIGN KEY (`RechteID`) REFERENCES `rechte` (`RechteID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
