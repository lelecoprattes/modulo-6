drop database if exists agencia;
create database if not exists agencia;
use agencia;

CREATE TABLE cliente (
    id_cliente INT not null auto_increment PRIMARY KEY,
    nome VARCHAR(40),
    contato VARCHAR(40),
    pedido_Id int
);

create table pedido (
    id_pedido INT not null auto_increment PRIMARY KEY,
    dataPedido int,
    numPedido int,
    id_cliente int,
    id_Passagem int
);

CREATE TABLE passagem (
    id_passagem INT not null auto_increment PRIMARY KEY,
    destino VARCHAR(40),
    dataPassagem int
);

alter table pedido add foreign key(id_cliente) references cliente (id_cliente);
alter table pedido add foreign key(id_passagem) references passagem(id_passagem);

insert into cliente (nome, contato) values 
('denise', 'denise@email.com'),
('Carlos', 'Carlos@email.com'),
('maria', 'maria@email.com');

insert into pedido (numPedido, dataPedido) values 
('789','20-10-23'),
('456', '30-12-23'),
('321', '30-12-24');

insert into passagem (destino, dataPassagem) values 
('fortaleza', '02-01-24'),
('bahia', '03-03-24'),
('ceara', '30-12-23');

select * from cliente;
select * from pedido;
select * from passagem;
select c.id_cliente, p.id_passagem, pa.id_passagem
from cliente as c
right join pedido as p on c.id_pedido = p.id_pedido
left join passagem as pa on c.id_pedido = pa.id_passagem;


update cliente set nome = 'denise', contato = 'denise@email.com' where id_cliente = 1;
update pedido set numPedido= '789', dataPedido = '20-10-23' where id_pedido = 1;
update passagem set destino = 'fortaleza', dataViagem = '02-01-24' where id_passagem = 1;

delete from cliente where cliente_Id = 3;
delete from pedido where pedido_Id = 3;
delete from passagem where passagem = 3;




