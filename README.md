# Gerador de Testes

## 1 - Módulo de Disciplinas

**Requisito 1.1: Cadastrar Novas Disciplinas**
- O registro de disciplina é composto por nome
- O campo nome é obrigatório
- Não pode registrar uma disciplina com o mesmo nome
- A disciplina deve armazenar informações sobre as matérias que serão relacionadas à ela posteriormente

**Protótipo:**

![image](https://github.com/Nick-E-Judy/gerador-de-testes-2024/assets/159103506/db34aee4-665d-442a-a2b2-797438f83712)


**Requisito 1.2: Editar Disciplinas**
- Os critérios de validação são os mesmos do Requisito 1.1

**Requisito 1.3: Excluir Disciplinas**
- Não deve ser possível excluir disciplinas com matérias e testes relacionados.

**Requisito 1.4 Visualizar Todas as Disciplinas.**
- Deve exibir: Id e Nome


## 2 - Módulo de Matérias

**Requisito 2.1: Cadastrar Matérias.**
- O registro de matéria é composto por nome, disciplina e série
- Todos os campos são obrigatórios
- Não pode registrar uma matéria com o mesmo nome

**Protótipo:**

![image](https://github.com/Nick-E-Judy/gerador-de-testes-2024/assets/159103506/4837d794-b0fc-4181-b38b-9f0bd1318b7c)


**Requisito 2.2: Editar Matérias.**
- Os critérios de validação são os mesmos do do Requisito 2.1

**Requisito 2.3: Excluir Matérias.**
- Não deve ser possível excluir matérias sendo utilizadas em questões.

**Requisito 2.4: Visualizar Todas as Matérias.**
- Deve exibir: Id, Nome, Disciplina e Série


## 3 - Módulo de Questões

**Requisito 3.1: Cadastrar Questões.**
- O registro de questão é composto por matéria, enunciado e alternativas.
- Todos os campos são obrigatórios
- Cada questão deve ter um mínimo e máximo de alternativas (máximo sugerido: 4)

**Protótipo:**

![image](https://github.com/Nick-E-Judy/gerador-de-testes-2024/assets/159103506/57f74ce6-49fb-4121-affa-c732a70100fa)


**Requisito 3.2: Editar Questões.**
- Os critérios de validação são os mesmos do Requisito 3.1

**Requisito 3.3: Excluir Questões.**
- Não deve ser possível excluir uma questão relacionada a um teste.

**Requisito 3.4: Visualizar Todas as Questões.**
- Deve exibir: Id, Enunciado, Matéria e Resposta Correta

**Requisito 3.5: Configurar Alternativas da Questão.**
- Deve permitir adicionar alternativas à questão
- Deve permitir remover alternativas à questão
- Não permitir o cadastro de questões sem uma alternativa correta
- Não deve permitir o cadastro de mais de uma alternativa correta
- No mínimo duas alternativas devem ser configuradas


## 4 - Módulo de Testes

**Requisito 4.1: Gerar Testes.**
- O registro de teste é composto por título, disciplina, matéria*, série e quantidade de questões
- Deve ser informado a quantidade de questões que deverão ser geradas
- Não pode registrar um teste com o mesmo nome
- A quantidade de questões informada deve ser menor ou igual a quantidade de questões cadastradas
- As matérias devem ser carregadas a partir da disciplina selecionada
- Não deve permitir selecionar uma matéria que não pertença a disciplina selecionada.
- Caso a disciplina seja alterada, o campo matéria deve ficar em branco
- Caso seja “Prova de Recuperação” deve considerar as questões de todas as matérias da disciplina selecionada
- Todos os campos são obrigatórios.
- As questões devem ser selecionadas de forma aleatória

**Protótipo:**

![image](https://github.com/Nick-E-Judy/gerador-de-testes-2024/assets/159103506/b322ce93-9c53-4ee9-bb1f-d9f9a61976aa)


**Requisito 4.2: Duplicar Testes.**
- Deve permitir duplicar testes
- Na duplicação do teste o título, disciplina, quantidade de questões, série, prova de recuperação e matéria deverão vir preenchidos
- Não pode duplicar um teste com o mesmo nome
- Na duplicação do teste, as questões devem vir em branco

**Protótipo:**

![image](https://github.com/Nick-E-Judy/gerador-de-testes-2024/assets/159103506/097d1435-d06e-4373-be81-863774141806)


**Requisito 4.3: Excluir Testes.**
- Deve permitir excluir testes existentes

**Requisito 4.4: Visualizar Todos os Testes.**
- Deve exibir: Id, Título, Disciplina, Matéria (ou informar se é recuperação) e Quantidade de Questões

**Requisito 4.5: Visualizar Detalhes sobre Testes.**
- Deve ser possível visualizar os testes individualmente, com informações detalhadas incluindo as questões.

**Protótipo:**

![image](https://github.com/Nick-E-Judy/gerador-de-testes-2024/assets/159103506/391ff324-e845-4d0d-aada-afea966e1b4c)


**Requisito 4.6: Gerar PDF dos Testes.**
- O arquivo PDF do Teste deve apresentar: Título, Disciplina, Matéria, as questões e suas as alternativas

**Requisito 4.7: Gerar PDF do Gabarito dos Testes.**
- O arquivo PDF do Gabarito do Teste deve apresentar: Título, Disciplina, Matéria, as questões e suas alternativas (com a alternativa correta assinalada)
