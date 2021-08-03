# MODIFICADO

O projeto foi clonado e alterado com base nas orientações previstas abaixo.

Seguindo a linha de raciocinio, a proposta de utilização da Asp Net Web API foi aceita e então a criação do Back-end partiu da utilização de Vue.JS integrado ao C#, além de utilizar também o Front End para o desenvolvimento do Projeto.

Algumas funcionalidades previstas no User stories foram implementadas como: 

Ver todas as transações
Ver todas as transações de saque
Ver todas as transações de deposito

As demais funcionalidades se tornaram estáticas, não sendo possível conclui-las com êxito.

Em relação ao Front End houve pequenas alterações partindo do protótipo de criação de telas para o usuário.

O projeto e Api foram executados no Localhost em portas diferentes. Os métodos Get e Post retornam e enviam as informações respectivamente;

Na página design, é possivel encontrar todas as novas imagens da parte visual implementada(Views);

# Teste Desenvolvedor Liga Contra o Câncer

Se você chegou até aqui, é provável que esteja fazendo parte do processo seletivo para desenvolvedor na Liga contra o câncer, ficamos felizes por tê-lo aqui.

O principal objetivo desse teste é avaliar seus skills técnicos no uso de tecnologias para Backend e Frontend. 
Para isso, nós gostariámos de conhecer sua abordagem para resolver os seguintes problemas:

- Implementar as funcionalidades para os User stories apresentados em formato de Web API na tecnologia que desejar, porem recomendamos a utilização [AspNet Web API](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio).

- Prover a melhor experiência possível para os usuários utilizando a tecnologia [Vue JS](https://vuejs.org/v2/guide/). 

## Instruções

Clone o repositório com sua conta no github, faça suas alterações e nos envie o link do seu repositório do github. 

# Table of Contents
- [User stories](#user-stories)
- [Protótipos](#design)
- [API](#api)

## User stories

- [ ] Como um usuário quero poder fazer log in.
- [ ] Como um usuário quero poder fazer log out.
- [ ] Como um usuário quero poder ver todas a minhas transações.
- [ ] Como um usuário quero poder ver todos as minhas transações de saques 
- [ ] Como um usuário quero poder ver todas as minhas transações de deposito 
- [ ] Como um usuário quero poder ver situação atual da minha carteira

### Design

No diretório `/design` você encontrará alguns wireframes base para auxilia-lo na criação das interfaces do usuário

### Login 

Proposta da tela de login.

![Login](./design/login.png?raw=true)

### Transações

Proposta da tela de visualização da carteira.

![Transacoes](./design/transacoes.png?raw=true)

![Nova transcacao]() para implementar.

# API

- [Transacoes](#transacoes)
	- [GET transacoes](#get-transacoes)
	- [POST transacao](#post-transacao)

- [Sessao](#sessoes)
	- [Autenticar](#autenticar)
	- [Sair](#sair)

# Transação

## GET Transacoes

Obter todas transações

	GET /transacoes

### Headers

| Name          | Type   | Description     |
| :------------ | :----- | :-------------- |
| Authorization | Bearer | Token da sessão |


### Success 200

| Name             | Type     | Description                       |
| :--------------- | :------- | :-------------------------------- |
| transacao        | Object[] | Lista de todas as transações      |
| transacao.name   | String   | Nome da transação                 |
| transacao.amount | Number   | Valor da transação saque/deposito |


# Sessão

## Autenticar

Autenticar um usuário

	POST /sessoes/autenticar

### Success 201

| Name         | Type   | Description     |
| :----------- | :----- | :-------------- |
| sessao       | Object | -               |
| sessao.token | string | Token da sessão |

## Sair

Efetuar login

	DELETE /sessoes/:token

### Success 204

| Name | Type | Description |
| :--- | :--- | :---------- |
| -    | -    | -           |

## Aviso

Isso se trata de um teste para recrutamento, não usaremos para outro fim.
