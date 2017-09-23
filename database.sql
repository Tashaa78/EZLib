-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 23, 2017 at 03:14 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ezlib`
--

-- --------------------------------------------------------

--
-- Table structure for table `program_ids`
--

CREATE TABLE `program_ids` (
  `program_id` int(11) NOT NULL,
  `program_name` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `program_token` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `program_max_slots` varchar(255) COLLATE utf8_unicode_ci NOT NULL DEFAULT '25',
  `program_used_slots` varchar(255) COLLATE utf8_unicode_ci NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `program_licenses`
--

CREATE TABLE `program_licenses` (
  `license_id` int(111) NOT NULL,
  `program_id` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `license_holder` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `program_license` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `license_active` varchar(1) COLLATE utf8_unicode_ci NOT NULL DEFAULT '1',
  `license_expires` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `ip_address` varchar(255) COLLATE utf8_unicode_ci NOT NULL DEFAULT '0.0.0.0',
  `hardware_id` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `is_banned` int(1) NOT NULL DEFAULT '0',
  `max_programs` varchar(255) COLLATE utf8_unicode_ci NOT NULL DEFAULT '3',
  `used_programs` varchar(255) COLLATE utf8_unicode_ci NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `program_ids`
--
ALTER TABLE `program_ids`
  ADD PRIMARY KEY (`program_id`);

--
-- Indexes for table `program_licenses`
--
ALTER TABLE `program_licenses`
  ADD PRIMARY KEY (`license_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `program_ids`
--
ALTER TABLE `program_ids`
  MODIFY `program_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `program_licenses`
--
ALTER TABLE `program_licenses`
  MODIFY `license_id` int(111) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
