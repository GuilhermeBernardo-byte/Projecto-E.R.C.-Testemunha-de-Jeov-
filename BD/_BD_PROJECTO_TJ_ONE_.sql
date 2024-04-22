-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 17/04/2024 às 12:46
-- Versão do servidor: 5.7.14
-- Versão do PHP: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `uniao_tj`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `categoria`
--

CREATE TABLE `categoria` (
  `id_categoria` int(11) NOT NULL,
  `publicador_batizdo` tinyint(1) NOT NULL,
  `publicador_nao_batizdo` tinyint(1) NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura para tabela `estado`
--

CREATE TABLE `estado` (
  `id_estado` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `ativo` tinyint(1) NOT NULL,
  `inativo` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura para tabela `grupo`
--

CREATE TABLE `grupo` (
  `id_grupo` int(11) NOT NULL,
  `nome_grupo` varchar(50) NOT NULL,
  `superentendente` varchar(100) NOT NULL,
  `ajudante` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura para tabela `pre_relatorio`
--

CREATE TABLE `pre_relatorio` (
  `id_pre_relatorio` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `data_relatorio` date NOT NULL,
  `hora_relatorio` time DEFAULT NULL,
  `estudos` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura para tabela `relatorio_final`
--

CREATE TABLE `relatorio_final` (
  `id_relatorio_final` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `data_relatorio` date NOT NULL,
  `hora_relatorio` time DEFAULT NULL,
  `estudos` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura para tabela `servico`
--

CREATE TABLE `servico` (
  `id_servico` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `anciao` tinyint(1) NOT NULL,
  `servo_ministerial` tinyint(1) NOT NULL,
  `missionario` tinyint(1) NOT NULL,
  `pioneiro_regular` tinyint(1) NOT NULL,
  `pioneiro_auxiliar` tinyint(1) NOT NULL,
  `pioneiro_especial` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura para tabela `user`
--

CREATE TABLE `user` (
  `id_user` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `palavra_passe` varchar(100) NOT NULL,
  `user_tipo` enum('regular','administrador') NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `id_servico` int(11) NOT NULL,
  `id_grupo` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Índices de tabelas apagadas
--

--
-- Índices de tabela `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_categoria`),
  ADD KEY `id_user` (`id_user`);

--
-- Índices de tabela `estado`
--
ALTER TABLE `estado`
  ADD PRIMARY KEY (`id_estado`),
  ADD KEY `id_user` (`id_user`);

--
-- Índices de tabela `grupo`
--
ALTER TABLE `grupo`
  ADD PRIMARY KEY (`id_grupo`);

--
-- Índices de tabela `pre_relatorio`
--
ALTER TABLE `pre_relatorio`
  ADD PRIMARY KEY (`id_pre_relatorio`),
  ADD KEY `id_user` (`id_user`);

--
-- Índices de tabela `relatorio_final`
--
ALTER TABLE `relatorio_final`
  ADD PRIMARY KEY (`id_relatorio_final`),
  ADD KEY `id_user` (`id_user`);

--
-- Índices de tabela `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`id_servico`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- Índices de tabela `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `palavra_passe` (`palavra_passe`),
  ADD KEY `id_grupo` (`id_grupo`),
  ADD KEY `id_categoria` (`id_categoria`),
  ADD KEY `id_servico` (`id_servico`);

--
-- AUTO_INCREMENT de tabelas apagadas
--

--
-- AUTO_INCREMENT de tabela `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de tabela `estado`
--
ALTER TABLE `estado`
  MODIFY `id_estado` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de tabela `grupo`
--
ALTER TABLE `grupo`
  MODIFY `id_grupo` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de tabela `pre_relatorio`
--
ALTER TABLE `pre_relatorio`
  MODIFY `id_pre_relatorio` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de tabela `relatorio_final`
--
ALTER TABLE `relatorio_final`
  MODIFY `id_relatorio_final` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de tabela `servico`
--
ALTER TABLE `servico`
  MODIFY `id_servico` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de tabela `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
