INSERT INTO Usuarios (Email, Senha, PermissaoUsuario)
VALUES ('admin@admin.com','admin','ADMINISTRADOR'),
	   ('cliente@cliente.com','cliente','CLIENTE');
	   
INSERT INTO Estudios(NomeEstudio, PaisOrigem, DataCriacao, UsuarioId)
VALUES ('Blizzard','Alemanha','2009-09-09', 1),
	   ('RockStar Studios','Estados Unidos','2012-12-03', 1),
	   ('Square Enix','Brasil','2016-02-10', 1);
	   
INSERT INTO Jogos(NomeJogo, Descricao, DataLancamento, Valor, EstudioId)
VALUES ('Diablo 3','� um jogo que cont�m  bastante a��o e � viciante, seja voc� um novato ou um f�','2012-05-15','R$99,00', 1),
	   ('Red Dead Redemption II','Jogo eletr�nico de a��o-aventura western','2018-10-26','R$120,00', 2);


