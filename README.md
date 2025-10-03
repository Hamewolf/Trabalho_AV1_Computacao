# Projeto Toolkit em C#

Este é um **aplicativo de console desenvolvido em C# (.NET 9)** que funciona como um **toolkit de ferramentas** para a disciplina de Computação Científica. O projeto consolida cinco módulos distintos, cada um abordando um conceito específico de **teoria da computação e lógica**, acessíveis através de um **menu interativo**.

---

## 📋 Módulos Incluídos

### **Item 1 — Verificador de Alfabeto e Cadeia em Σ={a,b}**

**Objetivo:** Verificar se um símbolo individual e uma cadeia completa pertencem ao alfabeto Σ={a,b}.  

**Funcionalidades:**
- Solicita um **símbolo único** e verifica se é `'a'` ou `'b'`.
- Solicita uma **cadeia de caracteres** e valida se todos os caracteres pertencem a Σ* (apenas `'a'` e `'b'`).
- Exibe mensagens claras indicando se o símbolo ou a cadeia são **válidos ou inválidos**.

---

### **Item 2 — Classificador T/I/N por JSON**

**Objetivo:** Ler itens de problemas embutidos em JSON e classificá-los como **Tratável (T)**, **Intratável (I)** ou **Não Computável (N)**.  

**Funcionalidades:**
- Carrega uma lista de problemas computacionais com suas classificações corretas a partir de uma string JSON embutida no código.
- Solicita ao usuário que classifique cada problema.
- Registra **acertos e erros** e exibe um **resumo de desempenho** ao final.

---

### **Item 3 — Programa de Decisão: “Termina com ‘b’?”**

**Objetivo:** Decidir se uma cadeia sobre Σ={a,b} termina com o símbolo `'b'`.  

**Funcionalidades:**
- Recebe uma cadeia sobre Σ={a,b}.
- Verifica de forma finita e garantida se termina com `'b'`.
- Trata o caso de cadeia vazia e retorna `"SIM"` ou `"NAO"`.

---

### **Item 4 — Avaliador Proposicional Básico**

**Objetivo:** Avaliar fórmulas proposicionais predeterminadas sobre as variáveis **P, Q e R**, com opção de gerar tabela-verdade.  

**Funcionalidades:**
- Permite ao usuário definir valores lógicos (**true/false**) para P, Q e R.
- Avalia fórmulas lógicas predefinidas:
  1. `(P ∧ Q) ∨ R`
  2. `(P → ¬Q)`
- Permite exibir a **tabela-verdade completa** para a fórmula escolhida.

---

### **Item 5 — Reconhecedor Σ={a,b}: L_par_a e ab\***

**Objetivo:** Verificar se uma cadeia pertence a duas linguagens formais simples.  

**Funcionalidades:**
- **L_par_a:** cadeias com **número par de `'a'`**.
- **L = { w | w = ab* }:** cadeias que começam com `'a'` seguido de zero ou mais `'b'`.
- Retorna `"ACEITA"` ou `"REJEITA"` para a linguagem selecionada.

---

## ⚙️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Plataforma:** .NET 9  
- **Bibliotecas:** Apenas bibliotecas padrão do .NET (`System.Text.Json`)  
- **Dependências externas:** Nenhuma  

---

## 💻 Pré-requisitos

Para compilar e executar este projeto, você precisará do **SDK do .NET 9 (ou superior)**.

- [Download do .NET](https://dotnet.microsoft.com/en-us/download)

---

## 🚀 Como Executar

### 1. Clone ou baixe o projeto

``bash
git clone https://github.com/SEU-USERNAME/ProjetoToolkit.git
# Projeto Toolkit em C#

Este é um **aplicativo de console desenvolvido em C# (.NET 9)** que funciona como um **toolkit de ferramentas** para a disciplina de Computação Científica. O projeto consolida cinco módulos distintos, cada um abordando um conceito específico de **teoria da computação e lógica**, acessíveis através de um **menu interativo**.

---

## 📋 Módulos Incluídos

### **Item 1 — Verificador de Alfabeto e Cadeia em Σ={a,b}**

**Objetivo:** Verificar se um símbolo individual e uma cadeia completa pertencem ao alfabeto Σ={a,b}.  

# Projeto Toolkit em C#

Este é um **aplicativo de console desenvolvido em C# (.NET 9)** que funciona como um **toolkit de ferramentas** para a disciplina de Computação Científica. O projeto consolida cinco módulos distintos, cada um abordando um conceito específico de **teoria da computação e lógica**, acessíveis através de um **menu interativo**.

---

## 📋 Módulos Incluídos

### **Item 1 — Verificador de Alfabeto e Cadeia em Σ={a,b}**

**Objetivo:** Verificar se um símbolo individual e uma cadeia completa pertencem ao alfabeto Σ={a,b}.  

**Funcionalidades:**
- Solicita um **símbolo único** e verifica se é `'a'` ou `'b'`.
- Solicita uma **cadeia de caracteres** e valida se todos os caracteres pertencem a Σ* (apenas `'a'` e `'b'`).
- Exibe mensagens claras indicando se o símbolo ou a cadeia são **válidos ou inválidos**.

---

### **Item 2 — Classificador T/I/N por JSON**

**Objetivo:** Ler itens de problemas embutidos em JSON e classificá-los como **Tratável (T)**, **Intratável (I)** ou **Não Computável (N)**.  

**Funcionalidades:**
- Carrega uma lista de problemas computacionais com suas classificações corretas a partir de uma string JSON embutida no código.
- Solicita ao usuário que classifique cada problema.
- Registra **acertos e erros** e exibe um **resumo de desempenho** ao final.

---

### **Item 3 — Programa de Decisão: “Termina com ‘b’?”**

**Objetivo:** Decidir se uma cadeia sobre Σ={a,b} termina com o símbolo `'b'`.  

**Funcionalidades:**
- Recebe uma cadeia sobre Σ={a,b}.
- Verifica de forma finita e garantida se termina com `'b'`.
- Trata o caso de cadeia vazia e retorna `"SIM"` ou `"NAO"`.

---

### **Item 4 — Avaliador Proposicional Básico**

**Objetivo:** Avaliar fórmulas proposicionais predeterminadas sobre as variáveis **P, Q e R**, com opção de gerar tabela-verdade.  

**Funcionalidades:**
- Permite ao usuário definir valores lógicos (**true/false**) para P, Q e R.
- Avalia fórmulas lógicas predefinidas:
  1. `(P ∧ Q) ∨ R`
  2. `(P → ¬Q)`
- Permite exibir a **tabela-verdade completa** para a fórmula escolhida.

---

### **Item 5 — Reconhecedor Σ={a,b}: L_par_a e ab\***

**Objetivo:** Verificar se uma cadeia pertence a duas linguagens formais simples.  

**Funcionalidades:**
- **L_par_a:** cadeias com **número par de `'a'`**.
- **L = { w | w = ab* }:** cadeias que começam com `'a'` seguido de zero ou mais `'b'`.
- Retorna `"ACEITA"` ou `"REJEITA"` para a linguagem selecionada.

---

## ⚙️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Plataforma:** .NET 9  
- **Bibliotecas:** Apenas bibliotecas padrão do .NET (`System.Text.Json`)  
- **Dependências externas:** Nenhuma  

---

## 💻 Pré-requisitos

Para compilar e executar este projeto, você precisará do **SDK do .NET 9 (ou superior)**.

- [Download do .NET](https://dotnet.microsoft.com/en-us/download)

---

## 🚀 Como Executar

### 1. Clone ou baixe o projeto

``bash
git clone https://github.com/Hamewolf/Trabalho_AV1_Computacao.git
# Projeto Toolkit em C#

Este é um **aplicativo de console desenvolvido em C# (.NET 9)** que funciona como um **toolkit de ferramentas** para a disciplina de Computação Científica. O projeto consolida cinco módulos distintos, cada um abordando um conceito específico de **teoria da computação e lógica**, acessíveis através de um **menu interativo**.

---

## 📋 Módulos Incluídos

### **Item 1 — Verificador de Alfabeto e Cadeia em Σ={a,b}**

**Objetivo:** Verificar se um símbolo individual e uma cadeia completa pertencem ao alfabeto Σ={a,b}.  

**Funcionalidades:**
- Solicita um **símbolo único** e verifica se é `'a'` ou `'b'`.
- Solicita uma **cadeia de caracteres** e valida se todos os caracteres pertencem a Σ* (apenas `'a'` e `'b'`).
- Exibe mensagens claras indicando se o símbolo ou a cadeia são **válidos ou inválidos**.

---

### **Item 2 — Classificador T/I/N por JSON**

**Objetivo:** Ler itens de problemas embutidos em JSON e classificá-los como **Tratável (T)**, **Intratável (I)** ou **Não Computável (N)**.  

**Funcionalidades:**
- Carrega uma lista de problemas computacionais com suas classificações corretas a partir de uma string JSON embutida no código.
- Solicita ao usuário que classifique cada problema.
- Registra **acertos e erros** e exibe um **resumo de desempenho** ao final.

---

### **Item 3 — Programa de Decisão: “Termina com ‘b’?”**

**Objetivo:** Decidir se uma cadeia sobre Σ={a,b} termina com o símbolo `'b'`.  

**Funcionalidades:**
- Recebe uma cadeia sobre Σ={a,b}.
- Verifica de forma finita e garantida se termina com `'b'`.
- Trata o caso de cadeia vazia e retorna `"SIM"` ou `"NAO"`.

---

### **Item 4 — Avaliador Proposicional Básico**

**Objetivo:** Avaliar fórmulas proposicionais predeterminadas sobre as variáveis **P, Q e R**, com opção de gerar tabela-verdade.  

**Funcionalidades:**
- Permite ao usuário definir valores lógicos (**true/false**) para P, Q e R.
- Avalia fórmulas lógicas predefinidas:
  1. `(P ∧ Q) ∨ R`
  2. `(P → ¬Q)`
- Permite exibir a **tabela-verdade completa** para a fórmula escolhida.

---

### **Item 5 — Reconhecedor Σ={a,b}: L_par_a e ab\***

**Objetivo:** Verificar se uma cadeia pertence a duas linguagens formais simples.  

**Funcionalidades:**
- **L_par_a:** cadeias com **número par de `'a'`**.
- **L = { w | w = ab* }:** cadeias que começam com `'a'` seguido de zero ou mais `'b'`.
- Retorna `"ACEITA"` ou `"REJEITA"` para a linguagem selecionada.

---

## ⚙️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Plataforma:** .NET 9  
- **Bibliotecas:** Apenas bibliotecas padrão do .NET (`System.Text.Json`)  
- **Dependências externas:** Nenhuma  

---

## 💻 Pré-requisitos

Para compilar e executar este projeto, você precisará do **SDK do .NET 9 (ou superior)**.

- [Download do .NET](https://dotnet.microsoft.com/en-us/download)

---

##👨‍🏫 Grupo

- Kauan Vieira Xavier - 06004975

- João Marcellus Peçanha Rosa - 06003360

- Nícolas Eduardo Teixeira De Assis - 06004043

- Lucas Domingos da Silva Miranda - 06004981

- Márcio Josué Branco Carnevali - 06003553

- Mohamad Lobo Azevedo – 06003782

## 🚀 Como Executar
### 1. Clone ou baixe o projeto
```bash
git clone https://github.com/Hamewolf/Trabalho_AV1_Computacao.git

