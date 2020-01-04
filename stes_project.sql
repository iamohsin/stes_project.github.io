-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2019 at 02:31 PM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.1.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `stes_project`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `user` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `user`, `pass`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `depid` int(11) NOT NULL,
  `dep` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`depid`, `dep`) VALUES
(1, 'Computer Science'),
(2, 'business'),
(3, 'electrical'),
(4, 'Math'),
(5, 'English'),
(6, 'Psychology'),
(7, 'mechanical'),
(9, 'Civil');

-- --------------------------------------------------------

--
-- Table structure for table `evaluation`
--

CREATE TABLE `evaluation` (
  `eval_id` int(11) NOT NULL,
  `stdid` int(11) NOT NULL,
  `tid` int(11) NOT NULL,
  `sub_id` int(11) NOT NULL,
  `quesid` int(250) NOT NULL,
  `optid` int(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `evaluation`
--

INSERT INTO `evaluation` (`eval_id`, `stdid`, `tid`, `sub_id`, `quesid`, `optid`) VALUES
(5160, 62, 7, 9, 1, 3),
(5161, 62, 7, 9, 2, 3),
(5162, 62, 7, 9, 3, 3),
(5163, 62, 7, 9, 4, 3),
(5164, 62, 7, 9, 5, 1),
(5165, 62, 7, 9, 6, 1),
(5166, 62, 7, 9, 7, 1),
(5167, 62, 7, 9, 8, 1),
(5168, 62, 7, 9, 9, 1),
(5169, 62, 7, 9, 10, 3),
(5170, 62, 7, 9, 11, 1),
(5171, 62, 7, 9, 12, 1),
(5172, 62, 7, 9, 13, 1);

-- --------------------------------------------------------

--
-- Table structure for table `hod`
--

CREATE TABLE `hod` (
  `hodid` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `depid` int(50) NOT NULL,
  `user` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hod`
--

INSERT INTO `hod` (`hodid`, `name`, `depid`, `user`, `pass`) VALUES
(1, 'Dr.hussain', 1, 'husssac', '123'),
(2, 'Ali Ahsan', 2, 'ali', '123'),
(3, 'Dr.habib', 5, 'mohsin', '123');

-- --------------------------------------------------------

--
-- Table structure for table `options`
--

CREATE TABLE `options` (
  `optid` int(11) NOT NULL,
  `opt` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `options`
--

INSERT INTO `options` (`optid`, `opt`) VALUES
(1, 'Strongly Agree '),
(2, 'Agree '),
(3, 'Uncertain'),
(4, 'Disagree'),
(5, 'Strongly Disagree');

-- --------------------------------------------------------

--
-- Table structure for table `program`
--

CREATE TABLE `program` (
  `proid` int(11) NOT NULL,
  `pro` varchar(60) NOT NULL,
  `depid` int(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `program`
--

INSERT INTO `program` (`proid`, `pro`, `depid`) VALUES
(1, 'bscs', 1),
(2, 'bsit', 1),
(3, 'mcs', 1),
(4, 'bba', 2),
(5, 'bs math', 4),
(6, 'MS Math', 4),
(7, 'MBA', 2);

-- --------------------------------------------------------

--
-- Table structure for table `question`
--

CREATE TABLE `question` (
  `qid` int(11) NOT NULL,
  `ques` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `question`
--

INSERT INTO `question` (`qid`, `ques`) VALUES
(1, 'The Instructor is prepared for each class'),
(2, 'The Instructor demonstrates knowledge of the subject'),
(3, 'The Instructor has completed the whole course'),
(4, 'The Instructor provides additional material apart from the textbook'),
(5, 'The Instructor gives citations regarding current situations with reference to Pakistani context'),
(6, 'The Instructor communicates the subject matter effectively'),
(7, 'The Instructor shows respect towards students and encourages class participation'),
(8, 'The Instructor maintains an environment that is conducive to learning'),
(9, 'The Instructor arrives on time '),
(10, 'The Instructor leaves on time'),
(11, 'The Instructor is fair in examination'),
(12, 'The Instructor returns the graded scripts etc. in  a reasonable amount of time'),
(13, 'The Instructor was available during the specified office hours and for after class consultations');

-- --------------------------------------------------------

--
-- Table structure for table `semester`
--

CREATE TABLE `semester` (
  `semid` int(8) NOT NULL,
  `sem` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `semester`
--

INSERT INTO `semester` (`semid`, `sem`) VALUES
(1, '1st'),
(2, '2nd'),
(3, '3rd'),
(4, '4th'),
(5, '5th'),
(6, '6th'),
(7, '7th'),
(8, '8th');

-- --------------------------------------------------------

--
-- Table structure for table `session`
--

CREATE TABLE `session` (
  `sesid` int(11) NOT NULL,
  `ses` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `session`
--

INSERT INTO `session` (`sesid`, `ses`) VALUES
(1, 'Main-Fall'),
(2, 'Spring-Fall');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `Studentid` int(225) NOT NULL,
  `name` varchar(20) NOT NULL,
  `user` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `depid` int(20) NOT NULL,
  `proid` int(11) DEFAULT NULL,
  `sesid` int(11) DEFAULT NULL,
  `semid` int(11) DEFAULT NULL,
  `fname` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`Studentid`, `name`, `user`, `pass`, `depid`, `proid`, `sesid`, `semid`, `fname`, `email`) VALUES
(1, 'asad', 'asad', '123', 2, 4, 2, 5, 'Ali', 'aaali1@gmail.com'),
(2, 'haris', 'haris', '12', 1, 1, 1, 2, 'saleem', 'hhsm58@gmail.com'),
(57, 'Ali', 'ali', '123', 3, 5, 2, 2, 'raza', 'ali543@gmail.com'),
(59, 'hussain', 'sdfgh', 'dfg', 2, 4, 1, 2, 'Ahmad', 'hussain561@gmail.com'),
(62, 'Muhammad', 'mohsin60', '123', 1, 1, 1, 8, 'Mohsin', 'mohsinameen60@gmail.com'),
(63, 'Awais', 'rjawais', '123', 1, 1, 1, 8, 'Saleem', 'rjawis@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `subid` int(11) NOT NULL,
  `sub_code` varchar(50) NOT NULL,
  `sub_name` varchar(50) NOT NULL,
  `semid` int(15) NOT NULL,
  `proid` int(16) NOT NULL,
  `depid` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`subid`, `sub_code`, `sub_name`, `semid`, `proid`, `depid`) VALUES
(1, 'cs-208', 'C Programming', 1, 1, 1),
(3, 'cs-305', 'Intro to Database', 3, 1, 1),
(5, 'cs-35', 'Marketing', 1, 4, 2),
(6, 'db-302', 'Advance DataBase', 5, 1, 1),
(7, 'ai-213', 'Artificial intelligence', 8, 1, 1),
(8, 'cs-208', 'Compiler Construction', 8, 1, 1),
(9, 'cs-223', 'Legal and Ethical Issues', 8, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `teacherid` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `user` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `depid` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`teacherid`, `name`, `user`, `pass`, `depid`) VALUES
(1, 'Bilal', 'bilal', '123', 2),
(3, 'Awais Ahmad', 'as', 'sd12', 6),
(5, 'Noman Farooq', 'Far4', '156', 1),
(7, 'Shezla Raiz', 'shela', '123', 1),
(8, 'Dr.Sehar', 'sehar', '123', 1),
(9, 'Ahmad Raza', 'ahmad', '123', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tea_sub`
--

CREATE TABLE `tea_sub` (
  `tbid` int(11) NOT NULL,
  `teacherid` int(11) NOT NULL,
  `subid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tea_sub`
--

INSERT INTO `tea_sub` (`tbid`, `teacherid`, `subid`) VALUES
(3, 1, 5),
(4, 5, 6),
(11, 7, 9);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`depid`);

--
-- Indexes for table `evaluation`
--
ALTER TABLE `evaluation`
  ADD PRIMARY KEY (`eval_id`),
  ADD KEY `esubid` (`sub_id`),
  ADD KEY `eteacid` (`tid`),
  ADD KEY `estdid` (`stdid`),
  ADD KEY `opid` (`optid`),
  ADD KEY `quid` (`quesid`);

--
-- Indexes for table `hod`
--
ALTER TABLE `hod`
  ADD PRIMARY KEY (`hodid`),
  ADD KEY `deptid` (`depid`);

--
-- Indexes for table `options`
--
ALTER TABLE `options`
  ADD PRIMARY KEY (`optid`);

--
-- Indexes for table `program`
--
ALTER TABLE `program`
  ADD PRIMARY KEY (`proid`),
  ADD KEY `pdepid` (`depid`);

--
-- Indexes for table `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`qid`);

--
-- Indexes for table `semester`
--
ALTER TABLE `semester`
  ADD PRIMARY KEY (`semid`);

--
-- Indexes for table `session`
--
ALTER TABLE `session`
  ADD PRIMARY KEY (`sesid`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`Studentid`),
  ADD KEY `sdeptid` (`depid`),
  ADD KEY `ssesid` (`sesid`),
  ADD KEY `ssem` (`semid`),
  ADD KEY `prog` (`proid`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`subid`),
  ADD KEY `semid` (`semid`),
  ADD KEY `proid` (`proid`),
  ADD KEY `sdepid` (`depid`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`teacherid`),
  ADD KEY `depid` (`depid`);

--
-- Indexes for table `tea_sub`
--
ALTER TABLE `tea_sub`
  ADD PRIMARY KEY (`tbid`),
  ADD KEY `subid` (`subid`),
  ADD KEY `teacid1` (`teacherid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `depid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `evaluation`
--
ALTER TABLE `evaluation`
  MODIFY `eval_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5173;

--
-- AUTO_INCREMENT for table `hod`
--
ALTER TABLE `hod`
  MODIFY `hodid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `options`
--
ALTER TABLE `options`
  MODIFY `optid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `program`
--
ALTER TABLE `program`
  MODIFY `proid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `question`
--
ALTER TABLE `question`
  MODIFY `qid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `semester`
--
ALTER TABLE `semester`
  MODIFY `semid` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `session`
--
ALTER TABLE `session`
  MODIFY `sesid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `Studentid` int(225) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=67;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `subid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `teacher`
--
ALTER TABLE `teacher`
  MODIFY `teacherid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tea_sub`
--
ALTER TABLE `tea_sub`
  MODIFY `tbid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `evaluation`
--
ALTER TABLE `evaluation`
  ADD CONSTRAINT `estdid` FOREIGN KEY (`stdid`) REFERENCES `student` (`Studentid`),
  ADD CONSTRAINT `esubid` FOREIGN KEY (`sub_id`) REFERENCES `subject` (`subid`),
  ADD CONSTRAINT `eteacid` FOREIGN KEY (`tid`) REFERENCES `teacher` (`teacherid`),
  ADD CONSTRAINT `opid` FOREIGN KEY (`optid`) REFERENCES `options` (`optid`),
  ADD CONSTRAINT `quid` FOREIGN KEY (`quesid`) REFERENCES `question` (`qid`);

--
-- Constraints for table `hod`
--
ALTER TABLE `hod`
  ADD CONSTRAINT `deptid` FOREIGN KEY (`depid`) REFERENCES `department` (`depid`);

--
-- Constraints for table `program`
--
ALTER TABLE `program`
  ADD CONSTRAINT `pdepid` FOREIGN KEY (`depid`) REFERENCES `department` (`depid`);

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `depiid` FOREIGN KEY (`depid`) REFERENCES `department` (`depid`),
  ADD CONSTRAINT `prog` FOREIGN KEY (`proid`) REFERENCES `program` (`proid`),
  ADD CONSTRAINT `ssem` FOREIGN KEY (`semid`) REFERENCES `semester` (`semid`),
  ADD CONSTRAINT `ssesid` FOREIGN KEY (`sesid`) REFERENCES `session` (`sesid`);

--
-- Constraints for table `subject`
--
ALTER TABLE `subject`
  ADD CONSTRAINT `proid` FOREIGN KEY (`proid`) REFERENCES `program` (`proid`),
  ADD CONSTRAINT `sdepid` FOREIGN KEY (`depid`) REFERENCES `department` (`depid`),
  ADD CONSTRAINT `semid` FOREIGN KEY (`semid`) REFERENCES `semester` (`semid`);

--
-- Constraints for table `teacher`
--
ALTER TABLE `teacher`
  ADD CONSTRAINT `depid` FOREIGN KEY (`depid`) REFERENCES `department` (`depid`);

--
-- Constraints for table `tea_sub`
--
ALTER TABLE `tea_sub`
  ADD CONSTRAINT `subid` FOREIGN KEY (`subid`) REFERENCES `subject` (`subid`),
  ADD CONSTRAINT `teacid1` FOREIGN KEY (`teacherid`) REFERENCES `teacher` (`teacherid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
