-- TRIGGERS
USE JARDINERIA
GO
CREATE OR ALTER TRIGGER TX_CLIENTES ON CLIENTES
INSTEAD OF INSERT
AS
BEGIN
    SELECT * 
      FROM INSERTED
/*
  DELETE FROM CLIENTES
   WHERE codCliente IN (SELECT codCliente
                          FROM INSERTED) 
*/
END

EXEC SP_HELP CLIENTES
INSERT INTO CLIENTES
VALUES (40, 'Abel Trigger', 'Ape cont', 'Nom cont',
        '613704822', 'abel@abel.com', 'Yapeyu 493',
        null, 'Alicante', 'España', '03007', NULL,
        1000000);

