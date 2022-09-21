create database livraria;
use livraria;

create table usuario(
codigo int primary key,
login varchar(50),
senha varchar(50),
nivel varchar(30)
);
insert into usuario
values(1,'silas','kando','cliente');

insert into usuario
values(2,'cauan','cauan1','cliente');

insert into usuario
values(3,'cleyton','cleyton1','cliente');

insert into usuario
values(4,'sara','sara1','cliente');

insert into usuario
values(5,'leandro','leandro','cliente');

insert into usuario
values(6,'jose','jose12','cliente');

insert into usuario
values(7,'evylin','evylin1d hbcmjnndhf ','cliente');

insert into usuario
values(8,'thaiane','thaiane3','cliente');

insert into usuario
values(9,'pedro','pedro1','cliente');

insert into usuario
values(10,'rodrigo','rodrigo1','cliente');

insert into usuario
values(11,'gabriel','gabriel1','cliente');

insert into usuario
values(12,'beatriz','beatriz1','cliente');

insert into usuario
values(13,'gabrielsiqueira','gabriel siqueira','cliente');

insert into usuario
values(14,'paula','pauyla1','cliente');

insert into usuario
values(15,'felipe','kando','cliente');

insert into usuario
values(16,'natalia','12321','cliente');

insert into usuario
values(17,'pablo','jsdqasa','cliente');

insert into usuario
values(18,'genio','uber','cliente');

insert into usuario
values(19,'gabriela','fgvsdrd','cliente');

insert into usuario
values(20,'arthur','rei','cliente');

insert into usuario
values(21,'pedro','caveira','cliente');

insert into usuario
values(22,'nichelli','nielu','cliente');

insert into usuario
values(23,'sofia','casd','cliente');

insert into usuario
values(24,'motorola','lixo','cliente');

insert into usuario
values(25,'samsung','carregando','cliente');

insert into usuario
values(26,'inphone','descarregando','Funcionario');

insert into usuario
values(27,'google da silva','surveillancecaptalism','funcionario');

insert into usuario
values(28,'karl marx','comunismo','funcionario');

insert into usuario
values(29,'josef stalin','1945','funcionario');

insert into usuario
values(30,'adolf','hieroglifo','funcionario');

insert into usuario
values(31,'h 2 odio','tabelaperiodica','funcionario');

insert into usuario
values(32,'darte veider silva','sith','funcionario');

insert into usuario
values(33,'dante','rebellion','funcionario');

insert into usuario
values(34,'vergil','yamato','funcionario');

insert into usuario
values(35,'sonic','speed','funcionario');

insert into usuario
values(36,'tails','milesprower','funcionario');

insert into usuario
values(37,'andknuckles','pumpkinhill','funcionario');

insert into usuario
values(38,'jc denton','bionicman','funcionario');

insert into usuario
values(39,'bob page','brighteststar','funcionario');

insert into usuario
values(40,'shadow','hottopic','funcionario');

insert into usuario
values(41,'memphis tenesse','alphagamer','funcionario');

insert into usuario
values(42,'silver','pissrock','funcionario');

insert into usuario
values(43,'hector','bellerin','funcionario');

insert into usuario
values(44,'roberto','carlos96','funcionario');

insert into usuario
values(45,'michael jordan','puma','funcionario');

insert into usuario
values(46,'curry','casabranca','funcionario');

insert into usuario
values(47,'milo','ekse','funcionario');

insert into usuario
values(48,'lana del rey','ultraviolence','funcionario');

insert into usuario
values(49,'kilo kish','niceout','funcionario');

insert into usuario
values(50,'danielle haim','goslow','funcionario');

delete from usuario 
where codigo = 7;

delete from usuario 
where codigo = 8;

delete from usuario 
where codigo = 9;

delete from usuario 
where codigo = 10;

delete from usuario 
where codigo = 11;

delete from usuario 
where codigo = 7;

select * from usuario;

create table cliente(
codcliente int,
usuario_codigo int,
nmcliente varchar(70),
telefone varchar(20),
cpf char(11),
email varchar(80),
dsendereco varchar(300)
);
select * from cliente;

insert into cliente 
values(1, 1, 'Silas Kando', '99999999999', '11111111111', 'silas@kando', 'se aproximando rapidamente');

insert into cliente 
values(2, 2, 'Lulas Kando', '99999999999', '11111111111', 'soneguei@imposto', 'brasilia');

insert into cliente 
values(3, 3, 'Michael Douglas', '99999999999', '11111111111', 'simba@sbacando', 'ali');

insert into cliente 
values(4, 4, 'Geraldo Alquimista', '99999999999', '11111111111', 'pedra@fisolofal', 'hogwarts');

insert into cliente 
values(5, 5, 'Numero Cinco', '99999999999', '11111111111', 'feel@good2', 'ilha flutuante');

insert into cliente 
values(6, 6, 'Levi Alckmin', '99999999999', '11111111111', 'politicas@haha', 'dentro da sua casa');

insert into cliente 
values(7, 7, 'Fujiwara', '99999999999', '11111111111', 'chika@kando', 'nipon');

insert into cliente 
values(8, 8, 'Karma Santos', '99999999999', '11111111111', 'entp@8w7', '7 universos a frente de você');

insert into cliente 
values(9, 9, 'Franklin Clinton', '99999999999', '11111111111', 'ni@aaaaa', 'grove street?');

insert into cliente 
values(10, 10, 'Carl Johnson', '99999999999', '11111111111', 'bionic@manson', 'sanders');

insert into cliente 
values(11, 11, 'Monarkson', '99999999999', '11111111111', 'nsdaas@sdadsadasd', 'berlim');

insert into cliente 
values(12, 12, 'Silas Kando', '99999999999', '11111111111', 'silas@kando', 'se aproximando rapidamente');

insert into cliente 
values(13, 13, 'Silas Kando', '99999999999', '11111111111', 'silas@kando', 'se aproximando rapidamente');

insert into cliente 
values(14, 14, 'kauan', '99999999999', '11111111111', 'kauan@cleyton', 'se apx rapidamente');

insert into cliente 
values(15, 15, 'sofia', '99999999999', '11111111111', '@kando', 'se aproximando rapidamente');

insert into cliente 
values(1, 1, 'Silas Kando', '99999999999', '11111111111', 'silas@kando', 'se aproximando rapidamente');

insert into cliente 
values(1, 1, 'Silas Kando', '99999999999', '11111111111', 'silas@kando', 'se aproximando rapidamente');

insert into cliente 
values(1, 1, 'Silas Kando', '99999999999', '11111111111', 'silas@kando', 'se aproximando rapidamente');

insert into cliente 
values(1, 1, 'Silas Kando', '99999999999', '11111111111', 'silas@kando', 'se aproximando rapidamente');

insert into cliente 
values(1, 1, 'Silas Kando', '99999999999', '11111111111', 'silas@kando', 'se aproximando rapidamente');

create table funcionarios(
codfuncionario int,
usuario_codigo varchar(50),
nmfuncionario varchar(50),
telefone int,
cpf char(11),
email varchar(80)
);
select * from funcionarios;
insert into funcionarios
values (1, 26, 'Homer Simpson', '2834623', '666666666', 'thisonecalledmea@redditor');

insert into funcionarios
values (2, 27, 'Marge Simpson', '2854781', '888988888', 'shesa@maniac');

insert into funcionarios
values (3, 28, 'Assassino da Pista', '2834623', '121212112', 'bonda3@gemaplys');

insert into funcionarios
values (4, 29, 'Biffe', '2834623', '1111111111', 'maxor@videos');

insert into funcionarios
values (5, 30, 'Antedeguemon', '2834623', '111111111', 'bigcrack@bonda9');

insert into funcionarios
values (6, 31, 'Junessa', '2834623', '111111111', 'hahahahahah@hehehehe');

insert into funcionarios
values (7, 32, 'Sans', '2834623', '111111111', 'comic@sans');

insert into funcionarios
values (8, 33, 'Papyrus', '2834623', '111111111', 'fontes@microsoft');

insert into funcionarios
values (9, 34, 'King Minos', '2834623', '111111111', 'ultra@kill');

insert into funcionarios
values (10, 35, 'Super Claudio', '2834623', '111111111', 'super@claudio');

insert into funcionarios
values (11, 36, 'Lidia Mante', '2834623', '111111111', 'troca@dilhos');

insert into funcionarios
values (12, 37, 'Socorro', '2834623', '111111111', 'croco@dilhos');

insert into funcionarios
values (13, 38, 'X', '2834623', '111111111', 'odin@valhalla');

insert into funcionarios
values (14, 39, 'Nameless King', '2834623', '111111111', 'dark@souls');

insert into funcionarios
values (15, 40, 'Seath the Scaleless', '2834623', '111111111', 'dark@souls');

insert into funcionarios
values (16, 41, 'Gwyn', '2834623', '111111111', 'dark@souls');

insert into funcionarios
values (17, 42, 'Havel the Rock', '2834623', '111111111', 'dark@souls');

insert into funcionarios
values (18, 43, 'Taurus', '2834623', '111111111', 'dark@souls');

insert into funcionarios
values (19, 44, 'Capra', '2834623', '111111111', 'dark@souls');

insert into funcionarios
values (20, 45, 'Cavalo', '2834623', '111111111', 'oqueeum@cavalo');

insert into funcionarios
values (21, 46, 'Sapo dos Santos', '2834623', '111111111', 'cata@pimbas');

insert into funcionarios
values (22, 47, 'Yoshiagira', '2834623', '111111111', 'seu@madruga');

insert into funcionarios
values (23, 48, 'Windows Nunes', '2834623', '111111111', 'windows@souls');

insert into funcionarios
values (24, 49, 'CAPS LOCK DOS SANTOS', '2834623', '111111111', 'CAPS@LOCK');

insert into funcionarios
values (25, 50, 'homem minusculo', '2834623', '111111111', 'ant@man');

create table livros(
codlivro int,
nmtitulo varchar(80),
nmautor varchar(80),
generos varchar(200),
quantidade int,
valor float
);

create table pedidos(
codpedido int,
codlivro int,
valorpedido float,
dtpedido date
);