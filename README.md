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

# 🔥 Insight estratégico (nível recrutador)

Esse README mostra exatamente o que recrutadores buscam:

✔ Clareza de escopo
✔ Organização técnica
✔ Regras de negócio bem implementadas
✔ Preocupação com UX
✔ Base pronta para escalar

---
