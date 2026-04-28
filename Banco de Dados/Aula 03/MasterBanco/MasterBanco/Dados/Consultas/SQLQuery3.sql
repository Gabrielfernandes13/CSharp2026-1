-- Operações READ - LER -- 
/*
SELECT * FROM Contas;
GO
*/
/*
--SELECT Id, Titular, Numero_da_conta, Saldo FROM Contas
WHERE Saldo > 1000;
GO 

SELECT * FROM Contas
WHERE Titular LIKE '%Maria%';
GO

SELECT * FROM Contas
WHERE Numero_da_conta = 1002;
GO
*/
--Ordenar por saldo do maior p/ o menor
/*
SELECT * FROM Contas
ORDER BY Saldo DESC;
GO
*/
--Contar quantas contas existe na tabela
SELECT COUNT(*) AS Total_Contas FROM Contas;

-- Ordenar por saldo do MENOR p/ MAIOR
SELECT * FROM Contas
ORDER BY Saldo ASC;

GO

-- Soma todos Saldos das contas na tabela
SELECT SUM(Saldo) AS Total_Saldo FROM Contas;

--
SELECT AVG(Saldo) AS MediaSaldos FROM Contas;
GO
