-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 22, 2024 at 02:55 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bd_forum`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_post`
--

CREATE TABLE `t_post` (
  `id` int(11) NOT NULL,
  `tema` varchar(20) NOT NULL,
  `titulo` varchar(50) NOT NULL,
  `texto` varchar(300) NOT NULL,
  `foto` varchar(300) NOT NULL,
  `id_user` int(11) NOT NULL,
  `apagado` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_post`
--

INSERT INTO `t_post` (`id`, `tema`, `titulo`, `texto`, `foto`, `id_user`, `apagado`) VALUES
(1, 'Espaço', 'Gastronomia Galáctica', 'Honestamente acho que Marte é uma almondega mal cozida', 'https://cdna.artstation.com/p/assets/images/images/016/778/556/large/gleb-burenin-planet.jpg?1553448693', 1, 0),
(2, 'Jardinagem', 'Desabrochar de flores!', 'Finalmente a minha semente desabrochou!', 'https://media.istockphoto.com/id/1139219802/photo/top-view-of-flowering-purple-crocus-in-spring-garden-elective-focus-copy-space.jpg?s=612x612&w=0&k=20&c=Lio-j8hQZhhRw4qnc31i6aNyCmAnioad7Bp29go6Z9Y=', 2, 0),
(3, 'Animação', 'I love to animate in 4s!', 'Honestly I was wilding out I have no clue what I was gonna say!', 'https://cdn.welcometothejungle.co/uploads/article/social_image/9557/157710/large_hangover-1.jpg', 7, 2),
(4, 'Animação', 'I love to animate in 4s!', 'Had to repost, forgot my apostrofy! Mates!', 'https://wineflavorguru.com/wp-content/uploads/2023/12/How-Much-Wine-to-Get-Drunk-Chart.jpg', 7, 6),
(5, 'Espaço', 'A imensidão de tudo', 'Tudo é imenso mesmo!', 'https://images.unsplash.com/photo-1585575141647-c2c436949374?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8Ymx1ZSUyMHNwYWNlfGVufDB8fDB8fHww', 7, 0);

-- --------------------------------------------------------

--
-- Table structure for table `t_resp`
--

CREATE TABLE `t_resp` (
  `id` int(11) NOT NULL,
  `id_post` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `texto` varchar(3000) NOT NULL,
  `foto` varchar(300) NOT NULL,
  `apagado` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_resp`
--

INSERT INTO `t_resp` (`id`, `id_post`, `id_user`, `texto`, `foto`, `apagado`) VALUES
(1, 1, 2, 'Mesmo haha!', 'https://classic.exame.com/wp-content/uploads/2023/03/a-almondega-de-carne-de-mamute-mostrada-no-museu-de-ciencias-nemo-em-amsterda-em-28-de-marco-de-2023-1680093398134_v2_4x3.jpg?quality=70&strip=info&w=1024', 0),
(2, 1, 2, 'Na verdade é estranho mesmo', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT0gOmRQkWyhzdliPDUxSA98X0KBNKgWxoXVoXwVHpH8Q&s', 0);

-- --------------------------------------------------------

--
-- Table structure for table `t_tema`
--

CREATE TABLE `t_tema` (
  `id` int(11) NOT NULL,
  `tema` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_tema`
--

INSERT INTO `t_tema` (`id`, `tema`) VALUES
(1, 'Espaço'),
(2, 'Jardinagem'),
(3, 'Jogos'),
(4, 'Animação');

-- --------------------------------------------------------

--
-- Table structure for table `t_user`
--

CREATE TABLE `t_user` (
  `id` int(11) NOT NULL,
  `nick` varchar(20) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `data_nasc` varchar(10) NOT NULL,
  `pass` varchar(255) NOT NULL,
  `foto` varchar(300) NOT NULL,
  `apagado` int(11) NOT NULL DEFAULT 0,
  `admin` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `t_user`
--

INSERT INTO `t_user` (`id`, `nick`, `nome`, `email`, `data_nasc`, `pass`, `foto`, `apagado`, `admin`) VALUES
(1, 'Nandosito', 'Fernando Montoya', 'nand33@gmail.com', '', '$2y$10$AT9UdLEJ8RUdotbYtIN.3.VEIPyQSMUoMTzWpS618Hp57x5zeHQHC', 'https://cdn.nufarm.com/wp-content/uploads/sites/50/2018/11/01153010/Nando2.jpg', 0, 0),
(2, 'MariMar', 'Maria Santos Pereira', 'mari88@gmail.com', '12/06/1988', '$2y$10$w36ypMsr.u2yaRcRL2FqZe7ID.S8WYsEoviGGicXQwkYH1Vd2bQg2', 'https://bordalo.observador.pt/v2/rs:fill:900/c:770:433:nowe:0:0/q:86/plain/https://s3.observador.pt/wp-content/uploads/2022/09/13153331/770-rubrica-implacavel-maria-gelato.jpg', 0, 0),
(5, 'Prium', 'Prium Lorem Ixium', 'pripri90@gmail.com', '18/02/1992', '$2y$10$Ih9KW7RLOvROOpiiZTxYCev.WmINwl84zNfYWSOG.ok/x9Ibfk1C2', 'https://www.castanet.net/content/2022/5/random_knowledge_stored_in_random_charts_640_22_p3592964.jpg', 0, 0),
(6, 'Morangito', 'Morango Pera', 'moran26@gmail.com', '2012-02-04', '$2y$10$mTOz.hbELMH1vrlSQZJ0fe65qfy6bSUHydB4X9KwIpKC9u4sRxr2q', 'https://images.pexels.com/photos/326900/pexels-photo-326900.jpeg?cs=srgb&dl=pexels-pixabay-326900.jpg&fm=jpg', 0, 0),
(7, 'admin', 'Lexar', 'lexarunlimited@gmail.com', '12/02/1980', '$2y$10$6RWNPJaqVsQ8f39H/ypsqetxNJWJ8KKqbRMqEoA1US4jCl/42ggUO', 'https://i.redd.it/esz8rm0nmhi81.png', 0, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_post`
--
ALTER TABLE `t_post`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_idUser` (`id_user`);

--
-- Indexes for table `t_resp`
--
ALTER TABLE `t_resp`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_idUserResp` (`id_user`),
  ADD KEY `FK_idPost` (`id_post`);

--
-- Indexes for table `t_tema`
--
ALTER TABLE `t_tema`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `t_user`
--
ALTER TABLE `t_user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nick` (`nick`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_post`
--
ALTER TABLE `t_post`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `t_resp`
--
ALTER TABLE `t_resp`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `t_tema`
--
ALTER TABLE `t_tema`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `t_user`
--
ALTER TABLE `t_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_post`
--
ALTER TABLE `t_post`
  ADD CONSTRAINT `FK_idUser` FOREIGN KEY (`id_user`) REFERENCES `t_user` (`id`);

--
-- Constraints for table `t_resp`
--
ALTER TABLE `t_resp`
  ADD CONSTRAINT `FK_idPost` FOREIGN KEY (`id_post`) REFERENCES `t_post` (`id`),
  ADD CONSTRAINT `FK_idUserResp` FOREIGN KEY (`id_user`) REFERENCES `t_user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
