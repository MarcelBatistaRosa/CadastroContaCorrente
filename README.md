Projeto Cadastro Conta Corrente 

Curso Completo Programação C# - 16/08/2024 

 

Contexto: 

 

Criar um cadastro de Conta Corrente Bancário onde seja informado o número da conta, o nome do cliente e caso tenha um depósito inicial, informar o valor, se não houver o depósito, informar valor 0. 

 

Requisitos: 

 

Questionar ao cliente se haverá um depósito para compor o saldo inicial. 

O número da conta não poderá sofrer alteração. 

Demais informações podem ser alteradas. 

A movimentação do saldo da conta deverá ocorrer somente através das operações de depósito e saque, não podendo ocorrer alterações diretamente no campo de saldo perdendo a rastreabilidade do fluxo de movimentações. 

Haverá uma cobrança de 5 reais para cada saque realizado. 

A cada movimentação deverá ser apresentado todos os campos do cadastro atualizados.  

O saldo poderá ser negativo. 

Realizar um depósito de 200,00 

Realizar um saque de 300,00			 

 

Refinamento técnico: 

 

Entradas: 

Entre com o número da conta: 8532 

Entre com o titular da conta: Alex Green 

Haverá depósito inicial: s ou n 

Entre com o valor do depósito inicial: 500,00 

Entre com o valor para depósito: 200,00 

Entre com o valor para saque: 300,00 

 

 

 

Saídas: 

Dados da conta: 

Conta: 8532; Titular: Alex Green; Saldo: $ 500,00 

Dados da conta atualizados: (para o depósito e para o saque) 

Conta: 8532; Titular: Alex Green; Saldo: $ 700,00 

 

Classes: 

 

Conta Corrente 

Atributos privados 

Saldo 

Propriedades auto implementadas 

Conta 

Nome 

Construtores 

ContaCorrente (conta, nome, deposito) para aceitar todos os campos. Obs.: Deverá ser chamado o método Deposito porque o construtor atenderá uma a visão para o deposito inicial e o campo saldo já será alimentado pelo método Deposito. Assim garante que se houver uma alteração no método do deposito irá refletir na visão do deposito inicial que utiliza este método. 

Propriedades customizadas 

  

Outros métodos da classe 

Deposito 

Saque 

Override ToString 

 

 

 

 

 
