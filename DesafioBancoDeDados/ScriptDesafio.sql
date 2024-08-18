select * from Atores
select * from ElencoFilme
select * from Filmes
select * from FilmesGenero
select * from Generos

--1
select Nome, Ano from Filmes
--2
select Nome, Ano, Duracao from Filmes order by Ano asc
--3
select Nome, Ano, Duracao from Filmes where Nome='De Volta para o Futuro'
--4
select Nome, Ano, Duracao from Filmes where Ano = 1997
--5
select Nome, Ano, Duracao from Filmes where Ano > 2000
--6
select Nome, Ano, Duracao from Filmes where duracao > 100 AND duracao < 150 order by duracao asc
--7
select Ano, count(*) Quantidade from Filmes group by Ano order by SUM(duracao) desc
--8
select id, PrimeiroNome, UltimoNome, Genero from Atores where genero = 'M'
--9
select id, PrimeiroNome, UltimoNome, Genero from Atores where genero ='F' order by PrimeiroNome
--10
SELECT a.Nome as NomeFilme, b.Genero as Gênero from Filmes a INNER JOIN FilmesGenero c ON a.Id = c.IdFilme INNER JOIN Generos b ON c.IdGenero = b.Id;
--11
select a.Nome, b.Genero from Filmes a INNER JOIN FilmesGenero c ON c.IdFilme = a.Id INNER JOIN Generos b ON c.IdGenero = b.Id where  genero ='Mistério'
--12
select a.Nome ,b.PrimeiroNome, b.UltimoNome, c.Papel from Filmes as a INNER JOIN  ElencoFilme c ON c.IdFilme = a.Id INNER JOIN Atores b ON c.IdAtor = b.Id 

