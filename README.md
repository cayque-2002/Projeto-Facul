# Projeto-Facul
Projeto de sistema de gerenciamento para provedores de internet
DOCUMENTAÇÃO AGGE
(MVP 1)
SUMÁRIO
- MÓDULO ADMINISTRATIVO:
 Cadastramento e alterações de funcionários, programações, ordem de serviços
que serão utilizados no sistema.
- MÓDULO DE ATENDIMENTO:
 Cadastramento e alterações de cliente, contratos(venda) e lançamento de
boletos.
- MÓDULO TÉCNICO:
 Registro de atendimentos de chamados lançados pelo vendedor (primeira
instalação, manutenção, alteração de programação, etc).
- VISÃO GERAL/CONCLUSÃO DO MVP 1
 Itens que podem ser melhorados, visão da usabilidade do sistema,
planejamentos futuros. 
INÍCIO
Temos uma tela de login bem básica e superficial para nossos respectivos
funcionários usar o sistema.
MÓDULO ADMINISTRATIVO
Na parte de funcionários você conseguirá pesquisar os mesmos pelo nome e
também cadastrar novos. A parte de perfil está em planejamento do próximo
MVP, onde utilizaremos um método de permissionamento de telas ao qual o
respectivo perfil poderá acessar ou não.
Também é previsto que nessa tela do administrativo seja incluso relatórios para a
empresa ter controle e noção de seu desempenho, como relatório de vendas,
faturamento, ordens de serviços.
A parte de programações é bem básica de início, pois ainda não temos um
controle de equipamentos ou envio de velocidade e se equipamento do cliente
está ativo, isso requer uma integração de engenharia de software e equipamentos. 
Mas aqui fazemos a gestão de dados contratuais inicialmente podendo pesquisar
a programação já cadastrada e cadastrar uma nova.
O cadastramento dos serviços serve para se ter uma base somente do serviço que
agendará para o cliente, então precisa ter Nome, função e descrição.
MÓDULO ATENDIMENTO
A tela de venda baseia se em ter as informações básicas de cliente, endereço
programação, valor e contrato.
Você pode pesquisar o cliente e os contratos vinculados a ele caso queira alterar
algum dado ou programação. Separamos endereço residencial e contratual. O
residencial pode ser alterado no cadastro do cliente.
A parte de boletos por não ter integração de contas créditos e remessa bancária,
as informações são preenchidas a mão, como se realmente fosse um registro.
MÓDULO TÉCNICO
A parte técnica é onde o técnico vai pesquisar os chamados e atendê-los, tanto
externamente quanto internamente.
VISÃO GERAL
Para nosso mvp 1 acredito que o essencial e necessário está pronto para
usabilidade, assim tentando alcançar um sistema simples e prático para as
empresas não perderem muito tempo com treinamento de novos funcionários e
causando assim um giro positivo de funcionários e muito agregador ao
desempenho da empresa.
Melhorias de automatização de processos estão previstas e também usabilidade
de recursos através de API’s e Integrações.
 
 
 
 
 TECNOLOGIAS USADAS : C# POSTGRESQL 
