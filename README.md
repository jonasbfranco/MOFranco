# 🔥 Sistema de Aquecimento Inteligente (Simulador de Micro-ondas)

Aplicação desktop desenvolvida em C# que simula o funcionamento de um micro-ondas, com suporte a programas pré-definidos e customizados, incluindo persistência de dados e validações robustas.

---

## 🧰 Tecnologias Utilizadas

* **C#**
* **.NET (Windows Forms)**
* **System.Text.Json** (persistência em JSON)
* **Programação Assíncrona (async/await)**
* **Manipulação de UI com Invoke (thread-safe)**

---

## ⚙️ Funcionalidades

### 🔹 Controle de Aquecimento

* Início rápido (30 segundos / potência padrão)
* Definição manual de tempo e potência
* Exibição em tempo real:

  * Tempo restante
  * Status do processo
  * Barra de progresso
* Representação visual do aquecimento com caracteres

---

### 🔹 Controle de Estados

* Parado
* Aquecendo
* Pausado

✔ Permite:

* Pausar
* Retomar do ponto exato
* Cancelar operação

---

### 🔹 Programas Pré-definidos

* Pipoca
* Leite
* Carnes de boi
* Frango
* Feijão

Cada programa possui:

* Tempo e potência definidos automaticamente
* Caractere exclusivo de aquecimento
* Instruções de uso

📌 Regras:

* Não podem ser editados ou removidos
* Não permitem acréscimo de tempo
* Bloqueio de edição de campos

---

### 🔹 Programas Customizados

* Cadastro de novos programas pelo usuário

✔ Campos obrigatórios:

* Nome
* Alimento
* Tempo
* Potência
* Caractere

✔ Campo opcional:

* Instruções

✔ Validações:

* Apenas números para tempo e potência
* Caractere único
* Proibição de caracteres já utilizados:

  ```
  *, ~, #, @, %, .
  ```
* Não permite duplicidade entre programas

---

### 🔹 Persistência de Dados

* Armazenamento em arquivo JSON (`programas.json`)
* Carregamento automático ao iniciar o sistema
* Atualização após cadastro e edição

---

### 🔹 Interface e UX

* Listagem unificada de programas (pré-definidos + customizados)
* Programas customizados exibidos em **itálico**
* Mensagens de validação claras
* Foco automático no campo com erro
* Prevenção de fechamento indevido do formulário

---

## 🚀 Como Executar o Projeto

### 🔹 Pré-requisitos

* Visual Studio 2022 ou superior
* .NET Desktop Development instalado

---

### 🔹 Passos

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/seu-repositorio.git

# Acesse a pasta
cd seu-repositorio
```

1. Abra o projeto no Visual Studio
2. Compile a solução (`Ctrl + Shift + B`)
3. Execute (`F5`)

---

## 📁 Estrutura do Projeto

```
MOFranco/
│
├── FrmPrincipal.cs          # Interface principal e lógica de aquecimento
├── FrmCadastroPrograma.cs   # Cadastro e edição de programas
├── ProgramaAquecimento.cs   # Modelo de dados
├── programas.json           # Persistência dos dados
```

---

## 📸 Demonstrações

## 🖥️ Tela - Programa Principal
![Tela - Programa Principal](https://raw.githubusercontent.com/jonasbfranco/MOFranco/master/Imagens/Tela%20-%20Programa%20Principal.png)

## 🧾 Tela - Cadastro de Programas de Aquecimento
![Tela - Cadastro de Programas de Aquecimento](https://raw.githubusercontent.com/jonasbfranco/MOFranco/master/Imagens/Tela%20-%20Programa%20Cadastro%20de%20Programas%20de%20Aquecimento.png)

## ⚠️ Tela - Validação de Cadastro de Programa
![Tela - Validação de Cadastro de Programa](https://raw.githubusercontent.com/jonasbfranco/MOFranco/master/Imagens/Tela%20-%20Programa%20Cadastro%20de%20Programas%20de%20Aquecimento%20-%20Mensagem.png)

---

## 📌 Observações

* O sistema foi desenvolvido com foco em **boas práticas, clareza de código e robustez de validação**
* Estrutura preparada para evolução futura (ex: banco de dados ou API)

---

## 🧪 Sobre o Challenge

This is a challenge by [Coodesh](https://coodesh.com/)

---

## 👨‍💻 Autor

**Jonas Franco**
Analista de Sistemas | Especialista em Integração e Inovação


---

## 🧠 Explicação Técnica do Projeto

Este projeto foi desenvolvido com o objetivo de simular o funcionamento de um micro-ondas, aplicando princípios sólidos de **orientação a objetos**, **separação de responsabilidades** e **boas práticas de desenvolvimento em .NET**.

A solução foi estruturada para evoluir progressivamente em complexidade, acompanhando requisitos funcionais crescentes (níveis 1, 2 e 3), o que demonstra capacidade de construção incremental e organização de código.

---

## 🏗️ Arquitetura e Organização

A aplicação foi organizada em três pilares principais:

### 🔹 1. Camada de Interface (Forms)

Responsável pela interação com o usuário:

- `FrmPrincipal`
- `FrmCadastroPrograma`

Essa camada contém apenas lógica de UI, como:

- Exibição de dados  
- Captura de eventos (cliques, seleção, etc.)  
- Atualização visual (labels, progressbar, listbox)  

---

### 🔹 2. Camada de Domínio (Entidades)

Representada pela classe:

- `ProgramaAquecimento`

Responsável por encapsular os dados do negócio:

- Nome  
- Alimento  
- Tempo  
- Potência  
- Caractere de aquecimento  
- Instruções  

Essa separação garante:

- ✔ Reutilização  
- ✔ Clareza  
- ✔ Facilidade de manutenção  

---

### 🔹 3. Camada de Regras de Negócio

Implementada principalmente dentro do `FrmPrincipal`, mas organizada em métodos específicos:

- `ValidarTempo`  
- `ValidarPotencia`  
- `ValidarCaractere`  
- `CadastrarProgramaCustomizado`  
- `EditarPrograma`  
- `ExcluirPrograma`  

Esses métodos centralizam regras como:

- Limites de tempo e potência  
- Proibição de caracteres duplicados  
- Restrições de programas pré-definidos  
- Controle de estados (Parado, Aquecendo, Pausado)  

---

## 🔄 Máquina de Estados

O comportamento do micro-ondas foi modelado com um `enum`:

```csharp
enum EstadoAquecimento
{
    Parado,
    Aquecendo,
    Pausado
}
````

Essa abordagem evita inconsistências e permite controlar com precisão:

* Início do aquecimento
* Pausa
* Retomada
* Cancelamento

---

## ⚙️ Funcionalidades Implementadas

### ✅ Aquecimento Manual

* Definição de tempo e potência
* Incremento de +30 segundos
* Barra de progresso em tempo real

---

### ✅ Programas Pré-definidos

* 5 programas fixos (não editáveis)
* Preenchimento automático de dados
* Bloqueio de edição
* Strings de aquecimento únicas

---

### ✅ Programas Customizados

* Cadastro completo via formulário
* Validações robustas (campos obrigatórios e regras)
* Diferenciação visual (itálico no ListBox)
* Persistência em JSON

---

### ✅ Persistência de Dados

Utilização de:

* `System.Text.Json`

Permite:

* Salvar programas customizados em arquivo local
* Recarregar automaticamente ao iniciar o sistema

---

### ✅ Edição e Exclusão

* Edição controlada (sem duplicidade de caractere)
* Exclusão restrita a programas customizados

---

## ⚠️ Tratamento de Erros e Validações

O sistema possui validações distribuídas estrategicamente:

* **UI (Formulário)** → feedback imediato ao usuário
* **Regra de negócio** → garantia de integridade

Exemplos:

* `TryParse` para evitar falhas de conversão
* `MessageBox` com foco automático no campo inválido
* Bloqueio de fechamento do formulário em caso de erro

---

## 🚀 Diferenciais Técnicos

* Uso de `async/await` para simulação de aquecimento sem travar a UI
* Atualização de UI com `Invoke` (thread-safe)
* Uso de `StringBuilder` para performance na montagem do progresso
* Customização de `ListBox` com `DrawItem` (itálico para customizados)
* Sobrescrita de `ToString()` para integração limpa com UI

---
