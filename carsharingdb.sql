-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 13. Dez 2018 um 13:46
-- Server-Version: 10.1.35-MariaDB
-- PHP-Version: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES cp1257 */;

--
-- Datenbank: `carsharingdb`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur f�r Tabelle `fahrt`
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
-- Tabellenstruktur f�r Tabelle `fahrzeug`
--

CREATE TABLE `fahrzeug` (
  `FahrzeugID` int(11) NOT NULL,
  `Modell` text COLLATE latin1_german1_ci NOT NULL,
  `Hersteller` text COLLATE latin1_german1_ci NOT NULL,
  `Preis` double NOT NULL,
  `Standort` text COLLATE latin1_german1_ci NOT NULL,
  `Kennzeichen` text COLLATE latin1_german1_ci NOT NULL,
  `Tankgr��e` double NOT NULL,
  `Tankstand` double NOT NULL,
  `Verbrauch` double NOT NULL,
  `Kraftstoff` text COLLATE latin1_german1_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten f�r Tabelle `fahrzeug`
--

INSERT INTO `fahrzeug` (`FahrzeugID`, `Modell`, `Hersteller`, `Preis`, `Standort`, `Kennzeichen`, `Tankgr��e`, `Tankstand`, `Verbrauch`, `Kraftstoff`) VALUES
(1, 'Golf', 'VW', 12, '!23 K�ln', 'KSS33', 40, 20, 3, 'Elektro');

-- --------------------------------------------------------

--
-- Tabellenstruktur f�r Tabelle `kreditkarte`
--

CREATE TABLE `kreditkarte` (
  `KreditkarteID` int(11) NOT NULL,
  `Kontoinhaber` int(11) NOT NULL,
  `KartenNr` int(11) NOT NULL,
  `ZahlungID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur f�r Tabelle `paypal`
--

CREATE TABLE `paypal` (
  `PaypalAccountID` int(11) NOT NULL,
  `LoginMail` text COLLATE latin1_german1_ci NOT NULL,
  `ZahlungID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur f�r Tabelle `rechte`
--

CREATE TABLE `rechte` (
  `RechteID` int(11) NOT NULL,
  `Name` text COLLATE latin1_german1_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten f�r Tabelle `rechte`
--

INSERT INTO `rechte` (`RechteID`, `Name`) VALUES
(1, 'User'),
(2, 'Admin');

-- --------------------------------------------------------

--
-- Tabellenstruktur f�r Tabelle `user`
--

CREATE TABLE `user` (
  `AccountID` int(11) NOT NULL,
  `RechteID` int(11) NOT NULL,
  `Name` char(100) COLLATE latin1_german1_ci NOT NULL,
  `TelefonNr` int(11) NOT NULL,
  `EMail` char(100) COLLATE latin1_german1_ci NOT NULL,
  `Hausnummer` int(11) NOT NULL,
  `ORT` varchar(100) COLLATE latin1_german1_ci NOT NULL,
  `PLZ` int(11) NOT NULL,
  `Strasse` char(100) COLLATE latin1_german1_ci NOT NULL,
  `ZahlungsID` int(11) NOT NULL,
  `Passwort` char(100) COLLATE latin1_german1_ci NOT NULL,
  `LoginName` varchar(100) COLLATE latin1_german1_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten f�r Tabelle `user`
--

INSERT INTO `user` (`AccountID`, `RechteID`, `Name`, `TelefonNr`, `EMail`, `Hausnummer`, `ORT`, `PLZ`, `Strasse`, `ZahlungsID`, `Passwort`, `LoginName`) VALUES
(1, 2, '1', 1, '1', 1, '1', 1, '1', 0, '1', '1');

-- --------------------------------------------------------

--
-- Tabellenstruktur f�r Tabelle `zahlung`
--

CREATE TABLE `zahlung` (
  `ZahlungID` int(11) NOT NULL,
  `TypName` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes f�r die Tabelle `fahrt`
--
ALTER TABLE `fahrt`
  ADD PRIMARY KEY (`FahrtID`),
  ADD UNIQUE KEY `AccountID` (`AccountID`,`FahrzeugID`),
  ADD KEY `FahrzeugID` (`FahrzeugID`);

--
-- Indizes f�r die Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  ADD PRIMARY KEY (`FahrzeugID`);

--
-- Indizes f�r die Tabelle `kreditkarte`
--
ALTER TABLE `kreditkarte`
  ADD PRIMARY KEY (`KreditkarteID`),
  ADD UNIQUE KEY `ZahlungID` (`ZahlungID`);

--
-- Indizes f�r die Tabelle `paypal`
--
ALTER TABLE `paypal`
  ADD PRIMARY KEY (`PaypalAccountID`),
  ADD UNIQUE KEY `ZahlungID` (`ZahlungID`);

--
-- Indizes f�r die Tabelle `rechte`
--
ALTER TABLE `rechte`
  ADD PRIMARY KEY (`RechteID`);

--
-- Indizes f�r die Tabelle `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`AccountID`),
  ADD UNIQUE KEY `RechteID` (`RechteID`),
  ADD UNIQUE KEY `ZahlungsID` (`ZahlungsID`),
  ADD UNIQUE KEY `RechteID_2` (`RechteID`,`ZahlungsID`),
  ADD UNIQUE KEY `RechteID_3` (`RechteID`,`ZahlungsID`),
  ADD UNIQUE KEY `LoginName` (`LoginName`);

--
-- Indizes f�r die Tabelle `zahlung`
--
ALTER TABLE `zahlung`
  ADD PRIMARY KEY (`ZahlungID`);

--
-- AUTO_INCREMENT f�r exportierte Tabellen
--

--
-- AUTO_INCREMENT f�r Tabelle `fahrt`
--
ALTER TABLE `fahrt`
  MODIFY `FahrtID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT f�r Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  MODIFY `FahrzeugID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT f�r Tabelle `kreditkarte`
--
ALTER TABLE `kreditkarte`
  MODIFY `KreditkarteID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT f�r Tabelle `paypal`
--
ALTER TABLE `paypal`
  MODIFY `PaypalAccountID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT f�r Tabelle `rechte`
--
ALTER TABLE `rechte`
  MODIFY `RechteID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT f�r Tabelle `user`
--
ALTER TABLE `user`
  MODIFY `AccountID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

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
-- Constraints der Tabelle `paypal`
--
ALTER TABLE `paypal`
  ADD CONSTRAINT `paypal_ibfk_1` FOREIGN KEY (`ZahlungID`) REFERENCES `zahlung` (`ZahlungID`);

--
-- Constraints der Tabelle `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_3` FOREIGN KEY (`RechteID`) REFERENCES `rechte` (`RechteID`);

--
-- Constraints der Tabelle `zahlung`
--
ALTER TABLE `zahlung`
  ADD CONSTRAINT `zahlung_ibfk_1` FOREIGN KEY (`ZahlungID`) REFERENCES `kreditkarte` (`ZahlungID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
