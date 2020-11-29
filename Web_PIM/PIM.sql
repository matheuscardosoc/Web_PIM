create table tabUser (
idUser int identity(1,1) not null,
nomUser varchar(100) not null,
senhaUser varchar(16) not null,
telUser varchar(11) not null,
cpfUser int not null,
dataUser date not null,
emailUser varchar(70),
primary key(idUser)
);

create table tabMoedas (
idTipoRegis int identity(1,1) not null,
nomTipo varchar(25) not null,
cotMoeda float not null,
primary key (idTipoRegis)
);


create table tabCarteira (
idCarteira int identity(1,1) not null,
endCarteira varchar(100),
saldoCarteira float null,
idUser int not null,
idTipoRegis int not null,
primary key (idCarteira),
constraint idUser foreign key (idUser)
references tabUser(idUser),
constraint idTipoRegis foreign key (idTipoRegis)
references tabMoedas(idTipoRegis)
);